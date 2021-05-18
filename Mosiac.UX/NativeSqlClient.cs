using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mosiac.UX
{
    public class NativeSqlClient
    {
        public enum DesiredAccess : uint
        {
            Read,
            Write,
            ReadWrite,
        }

        [DllImport("sqlncli11.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern SafeFileHandle OpenSqlFilestream(
          string path,
          uint access,
          uint options,
          byte[] txnToken,
          uint txnTokenLength,
          Sql64 allocationSize);

        [StructLayout(LayoutKind.Sequential)]
        private struct Sql64
        {
            public Int64 QuadPart;
            public Sql64(Int64 quadPart)
            {
                this.QuadPart = quadPart;
            }
        }

        public static SafeFileHandle GetSqlFilestreamHandle
         (string filePath, DesiredAccess access, byte[] txnToken)
        {
            SafeFileHandle handle = OpenSqlFilestream(
              filePath,
              (uint)access,
              0,
              txnToken,
              (uint)txnToken.Length,
              new Sql64(0));

            return handle;
        }
    }
}
