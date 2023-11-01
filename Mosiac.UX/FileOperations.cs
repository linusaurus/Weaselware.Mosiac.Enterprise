using System;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32.SafeHandles;
using Boxed.Mapping;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using DataLayer.Entity;
using System.Windows.Markup;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Mosiac.UX
{
    public class FileOperations
    {
       //---private static string ConnStr = "Data Source=RICHARD-PC;database = Mosaic; Integrated Security = True;Trust Server Certificate=true";
       //---this is the right shared connection string for both Filestream and normal access, Filestream level must be set to 2
        private static string ConnStr = Mosiac.UX.Properties.Settings.Default.MosiacConnection;
        
        private static string cn = ConnStr.Substring(0, 68);
        private static void OpenResource(string path)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            };
            using (var proc = Process.Start(psi)) { }


        }

        private static void FolderExist()
        {
           
            string Localpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Localpath += @"\ResourceCache\";
            if(Directory.Exists(Localpath))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(Localpath);
            }

            
        }

        public static void OpenCacheFolder()
        {
            FolderExist();
            string Localpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Localpath += @"\ResourceCache\";
            OpenResource(Localpath);
        }

        public static void ClearCacheFolder()
        {
            FolderExist();
            string Localpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Localpath += @"\ResourceCache\";            
            string[] files = Directory.GetFiles(Path.GetDirectoryName(Localpath));
            foreach (string file in files)
            {
                File.Delete(file);
            }
        }

        public static void GetResource(int resourceId, string conString)
        {
            
            const string SelectTSql = @"
            SELECT
                filesource,
                ResourceFile.PathName(),
                GET_FILESTREAM_TRANSACTION_CONTEXT()
                FROM Resource
                WHERE ResourceID = @resourceID";

            string fileName;         
            string serverPath;
            byte[] serverTxn;
            // set the location for the file to be loaded to local cache
            string Localpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(cn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(SelectTSql, conn))
                    {
                        cmd.Parameters.Add("@resourceID", SqlDbType.Int).Value = resourceId;
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            fileName = rdr.GetSqlString(0).Value;
                            serverPath = rdr.GetSqlString(1).Value;
                            serverTxn = rdr.GetSqlBinary(2).Value;
                            rdr.Close();
                            Localpath += @"\ResourceCache\";
                            Localpath += fileName;
                        }
                    }

                    byte[] t = LoadResourceFile(serverPath, serverTxn);
                    File.WriteAllBytes(Localpath, t);
                    OpenResource(Localpath);
                }
                ts.Complete();
               
            }
          
        }
        /// <summary>
        /// Retrieves binary object for Filestream and opens
        /// with appropriate application local
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="txnToken"></param>
        /// <returns></returns>
        private static byte[] LoadResourceFile(string filePath, byte[] txnToken)
        {
           
            using (SqlFileStream sfs =
              new SqlFileStream(filePath, txnToken, FileAccess.Read))
            {
                byte[] buffer = new byte[sfs.Length];
                int bytesRead;

                while ((bytesRead = sfs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    sfs.Read(buffer, 0, bytesRead);
                    sfs.Flush();
                }
                sfs.Close();
                return buffer;
            }
           
        }

        public static void InsertPartResource(int partID, string resourcedDesc,string filesize, FileInfo filename)
        {
            int resourceID = 0;
            const string InsertCmd = "Resource_INSERT";

             //"INSERT INTO Resource(PartID, ResourceDescription,filesource)" +
             //" VALUES(@PartID, @Description, @filesource)";

            using (SqlConnection conn = new SqlConnection(cn))
            {
                conn.Open();

                using (SqlTransaction txn = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand(InsertCmd, conn, txn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@partID", SqlDbType.Int).Value = partID;
                        cmd.Parameters.Add("@resourcedescription", SqlDbType.VarChar).Value = resourcedDesc;
                        cmd.Parameters.Add("@filename", SqlDbType.VarChar).Value = filename.Name;
                        cmd.Parameters.Add("@filesize", SqlDbType.VarChar).Value = filesize;
                        
                        SqlParameter param = new SqlParameter("@resourceId", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(param);
                        

                        cmd.ExecuteNonQuery();
                        resourceID = (int)cmd.Parameters["@resourceId"].Value;
                    }

                    SaveResourceFile(resourceID, filename.FullName, txn);
                    txn.Commit();
                }

                conn.Close();
            }
        }

        public static void SaveResourceFile(int resourceId, string filename, SqlTransaction txn)
        {
            const int BlockSize = 1024 * 512;
            FileStream source = new FileStream(filename, FileMode.Open, FileAccess.Read);
            SafeFileHandle handle = GetOutputFileHandle(resourceId, txn);
            using (FileStream dest = new FileStream(handle, FileAccess.Write))
            {
                byte[] buffer = new byte[BlockSize];
                int bytesRead;
                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    dest.Write(buffer, 0, bytesRead);
                }
                dest.Close();
            }
            source.Close();
        }

        private static SafeFileHandle GetOutputFileHandle(int resourceId, SqlTransaction txn)
        {
            const string GetOutputFileInfoCmd =
              "SELECT GET_FILESTREAM_TRANSACTION_CONTEXT(), ResourceFile.PathName()" +
              " FROM Resource" +
              " WHERE ResourceId = @resourceId";

            SqlCommand cmd = new SqlCommand(GetOutputFileInfoCmd, txn.Connection, txn);
            cmd.Parameters.Add("@resourceID", SqlDbType.Int).Value = resourceId;

            string filePath;
            byte[] txnToken;

            using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow))
            {
                rdr.Read();
                txnToken = rdr.GetSqlBinary(0).Value;
                filePath = rdr.GetSqlString(1).Value;
                rdr.Close();
            }

            SafeFileHandle handle = 
                NativeSqlClient.GetSqlFilestreamHandle (filePath, NativeSqlClient.DesiredAccess.ReadWrite, txnToken);

            return handle;
        }
        #region AttachmentFunctions

        public static void GetAttachment(int attachmentId, string conString)
        {

            const string SelectTSql = @"
            SELECT
                src,
                BLOBData.PathName(),
                GET_FILESTREAM_TRANSACTION_CONTEXT()
                FROM Attachment
                WHERE AttachmentID = @attachmentID";

            string fileName;
            string serverPath;
            byte[] serverTxn;
            // set the location for the file to be loaded to local cache
            string Localpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(cn))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(SelectTSql, conn))
                    {
                        cmd.Parameters.Add("@attachmentID", SqlDbType.Int).Value = attachmentId;
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            fileName = rdr.GetSqlString(0).Value;
                            serverPath = rdr.GetSqlString(1).Value;
                            serverTxn = rdr.GetSqlBinary(2).Value;
                            rdr.Close();
                            Localpath += @"\ResourceCache\";
                            Localpath += fileName;
                        }
                    }

                    byte[] t = LoadResourceFile(serverPath, serverTxn);
                    File.WriteAllBytes(Localpath, t);
                    OpenResource(Localpath);
                }
                ts.Complete();
            }

        }

        private static SafeFileHandle GetAttachmentFileHandle(int attachmentId, SqlTransaction txn)
        {
            const string GetOutputFileInfoCmd =
              "SELECT GET_FILESTREAM_TRANSACTION_CONTEXT(), BLOBData.PathName()" +
              " FROM Attachment" +
              " WHERE AttachmentID = @attachmentId";

            SqlCommand cmd = new SqlCommand(GetOutputFileInfoCmd, txn.Connection, txn);
            cmd.Parameters.Add("@attachmentId", SqlDbType.Int).Value = attachmentId;

            string filePath;
            byte[] txnToken;

            using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow))
            {
                rdr.Read();
                txnToken = rdr.GetSqlBinary(0).Value;
                filePath = rdr.GetSqlString(1).Value;
                rdr.Close();
            }

            SafeFileHandle handle =
                NativeSqlClient.GetSqlFilestreamHandle(filePath, NativeSqlClient.DesiredAccess.ReadWrite, txnToken);

            return handle;
        }
        public static void SaveAttachmentFile(int attachmentId, string filename, SqlTransaction txn)
        {
            const int BlockSize = 1024 * 512;
            FileStream source = new FileStream(filename, FileMode.Open, FileAccess.Read);
            SafeFileHandle handle = GetAttachmentFileHandle(attachmentId, txn);
            using (FileStream dest = new FileStream(handle, FileAccess.Write))
            {
                byte[] buffer = new byte[BlockSize];
                int bytesRead;
                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    dest.Write(buffer, 0, bytesRead);
                }
                dest.Close();
            }
            source.Close();
        }

    

        public static int InsertOrderAttachment(int purchaseOrderID, string attachmentDescription, string filesize, FileInfo filename)
        {
            int attachmentID = 0;
            const string InsertCmd = "Attachment_Insert";

           

            using (SqlConnection conn = new SqlConnection(cn))
            {
                conn.Open();

                using (SqlTransaction txn = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand(InsertCmd, conn, txn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@purchaseOrderID", SqlDbType.Int).Value = purchaseOrderID;
                        cmd.Parameters.Add("@attachmentdescription", SqlDbType.VarChar).Value = attachmentDescription;
                        cmd.Parameters.Add("@filename", SqlDbType.VarChar).Value = filename.Name;
                        cmd.Parameters.Add("@filesize", SqlDbType.VarChar).Value = filesize;

                        SqlParameter param = new SqlParameter("@attachmentId", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(param);


                        cmd.ExecuteNonQuery();
                        attachmentID = (int)cmd.Parameters["@attachmentId"].Value;
                    }

                    SaveAttachmentFile(attachmentID, filename.FullName, txn);
                    txn.Commit();
                }

                conn.Close();
            }

            return attachmentID;
        }
        #endregion
    }
}
