using System;
using System.Windows.Forms;
using DataLayer.Entity;
using DataLayer.Data;
using ServiceLayer.Models;
using System.IO;
using System.Diagnostics;
using ServiceLayer;

namespace Mosiac.UX.UXControls
{
    public partial class AttachmentControl : UserControl
    {

        private OrderDetailDto orderDTO;
        private BindingSource bsAttachements = new BindingSource();
        private AttachmentDto selectedAttachment;

        public AttachmentControl()
        {
            InitializeComponent();
            this.dgResources.AutoGenerateColumns = false;
            InitializeGrid();
            dgResources.SelectionChanged += DgResources_SelectionChanged;
        }

        private void DgResources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgResources.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dgResources.DataSource, dgResources.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    selectedAttachment = (AttachmentDto)bm.Current;
                }

            }
        }

        public void SetDatasource(OrderDetailDto OrderDTO,BindingSource Source)
        {           
           
            bsAttachements = Source;
            orderDTO = OrderDTO;
            this.dgResources.DataSource = bsAttachements;
        }

        private void AttachmentControl_Load(object sender, EventArgs e)
        {

        }


        private void InitializeGrid()
        {
            dgResources.AutoGenerateColumns = false;
            dgResources.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgResources.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;


            // AttachmentID Column --
            DataGridViewTextBoxColumn colAttachmentID = new DataGridViewTextBoxColumn();
            colAttachmentID.HeaderText = "ID";
            colAttachmentID.DataPropertyName = "AttachmentID";
            colAttachmentID.Width = 75;

            // AttachmentID Column --
            DataGridViewTextBoxColumn colCreator = new DataGridViewTextBoxColumn();
            colCreator.HeaderText = "Creator";
            colCreator.DataPropertyName = "Creator";
            colCreator.Width = 115;

            // Date Column --
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Date";
            colDate.DataPropertyName = "CreatedDate";
            colDate.Width = 75;

            // Description Column --
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "AttachmentDescription";
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.DefaultCellStyle = dstyleWrapText;
            //colDescription.Width = 75;

            // Source File Column --
            DataGridViewTextBoxColumn colSourceFile = new DataGridViewTextBoxColumn();
            colSourceFile.HeaderText = "Source File";
            colSourceFile.DataPropertyName = "Src";
            colSourceFile.Width = 115;

            // Filesize Column --
            DataGridViewTextBoxColumn colFileSize = new DataGridViewTextBoxColumn();
            colFileSize.HeaderText = "File Size (KB)";
            colFileSize.DataPropertyName = "FileSize";
            colFileSize.Width = 125;

            dgResources.Columns.AddRange(colAttachmentID, colCreator, colDate, colDescription, colSourceFile, colFileSize);


        }

        private void dgResources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            AttachmentDto newAttachment = new AttachmentDto
            {
                OrderNum = orderDTO.PurchaseOrderID,
                AttachmentDescription = string.Empty,
                Src = string.Empty,
                //FileSource = new byte[],
                Ext = ".pdf",


            };

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(filePath);
                    newAttachment.Ext = fileInfo.Extension;
                    newAttachment.Src = fileInfo.Name.ToString();
                    newAttachment.FileSize = FileHelperService.GetSizeInMemory(fileInfo.Length);
                    newAttachment.creator = orderDTO.Purchaser;
                    newAttachment.CreatedDate = DateTime.Today;
                    //Read the bytes of the file into a byte array
                    newAttachment.FileSource = File.ReadAllBytes(filePath);
                }
            }

             bsAttachements.Add(newAttachment);
        }

        private void btnOpenResource_Click(object sender, EventArgs e)
        {
            if (selectedAttachment != null)
            {
                Attachment attachment;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path += @"\ResourceCache\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
               
                path += selectedAttachment.Src;
                using(MosaicContext ctx = new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection))
                { attachment = ctx.Attachments.Find(selectedAttachment.AttachmentID);
                }

                File.WriteAllBytes(path, attachment.Filesource);
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }
    }
}
