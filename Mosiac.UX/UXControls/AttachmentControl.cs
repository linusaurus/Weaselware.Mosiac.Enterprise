using System;
using System.Windows.Forms;
using DataLayer.Entity;
using DataLayer.Data;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System.IO;
using System.Diagnostics;
using ServiceLayer;
using Mosiac.UX.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class AttachmentControl : UserControl
    {

        private OrderDetailDto orderDTO;
        private BindingSource bsAttachements = new BindingSource();
        private AttachmentDto selectedAttachment;
        private readonly DataLayer.Data.MosaicContext _ctx;

        public AttachmentControl(MosaicContext context)
        {
            InitializeComponent();
            _ctx = context;
            this.dgResources.AutoGenerateColumns = false;
            InitializeGrid();
            dgResources.SelectionChanged += DgResources_SelectionChanged;
        }

        public void Lock()
        {
            btnAddResource.Enabled = true;
            btnDeleteResource.Enabled = false;
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
            // Date Compact Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleDate.Format = "d";
            dstyleDate.NullValue = " ";
            dstyleDate.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;


            // AttachmentID Column --
            DataGridViewTextBoxColumn colAttachmentID = new DataGridViewTextBoxColumn();
            colAttachmentID.HeaderText = "ID";
            colAttachmentID.DataPropertyName = "AttachmentID";
            colAttachmentID.Width = 50;

            // AttachmentID Column --
            DataGridViewTextBoxColumn colCreator = new DataGridViewTextBoxColumn();
            colCreator.HeaderText = "Creator";
            colCreator.DataPropertyName = "Creator";
            colCreator.Width = 138;

            // Date Column --
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Date";
            colDate.DataPropertyName = "CreatedDate";
            colDate.Width = 75;
            colDate.DefaultCellStyle = dstyleDate;

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
            colSourceFile.Width = 95;

            // Filesize Column --
            DataGridViewTextBoxColumn colFileSize = new DataGridViewTextBoxColumn();
            colFileSize.HeaderText = "Size(KB)";
            colFileSize.DataPropertyName = "FileSize";
            colFileSize.Width = 95;

            dgResources.Columns.AddRange(colAttachmentID, colCreator, colDate, colDescription, colSourceFile, colFileSize);

        }

        private void dgResources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Add Attachment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddResource_Click(object sender, EventArgs e)
        {
            if (orderDTO != null)
            {
                CreateAttachmentForm frm = new CreateAttachmentForm(orderDTO.PurchaseOrderID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                   var result = frm.NewAttachment;
                   var att = _ctx.Attachment.Find(result.AttachmentID);
                    AttachmentMapper mapper = new ServiceLayer.Mappers.AttachmentMapper();
                    mapper.Map(att, result);
               
                    bsAttachements.Add(result);
                }


                
            }
        }

        private void btnOpenResource_Click(object sender, EventArgs e)
        {
            if (selectedAttachment != null)
            {
                FileOperations.GetAttachment(selectedAttachment.AttachmentID, Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgResources.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dgResources.DataSource, dgResources.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    selectedAttachment = (AttachmentDto)bm.Current;
                    if (selectedAttachment != null)
                    {
                        var deletableAttachment = _ctx.Attachment.Find(selectedAttachment.AttachmentID);
                        if (deletableAttachment != null)
                        {
                            if (MessageBox.Show("The attachment will be permantly deleted, you good?", "Delete Attachment",MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                _ctx.Remove(deletableAttachment);
                                _ctx.SaveChanges();
                                bsAttachements.RemoveCurrent();
                            }
                            
                        }
                    }
                   
                    
                }

            }



           
        }
    }
}
