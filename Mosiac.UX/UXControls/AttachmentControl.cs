using System;
using System.Windows.Forms;
using DataLayer.Entity;
using DataLayer.Data;
using ServiceLayer.Models;
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
                }

                //// -- Refresh the Resource list---;
                //_partBeingEdited = partsService.Find(_partBeingEdited.PartID);
                //if (_partBeingEdited != null)
                //{
                //    bsPart.DataSource = _partBeingEdited;
                //    BindPart(bsPart);
                //    bsResource.DataSource = _partBeingEdited.Resources.ToList();
                //    dgResources.DataSource = _partBeingEdited.Resources.ToList();
                //}
            }
        }

        private void btnOpenResource_Click(object sender, EventArgs e)
        {
            if (selectedAttachment != null)
            {
                FileOperations.GetAttachment(selectedAttachment.AttachmentID, Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            }
        }
    }
}
