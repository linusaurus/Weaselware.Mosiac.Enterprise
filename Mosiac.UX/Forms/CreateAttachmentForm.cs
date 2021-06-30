using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ServiceLayer.Models;
using System.Text;
using System.Windows.Forms;
using ServiceLayer;
using System.IO;
using Mosiac.UX.UXControls;

namespace Mosiac.UX.Forms
{
    public partial class CreateAttachmentForm : Form
    {
        private AttachmentDto newAttachmentDto = new AttachmentDto();
        BindingSource bsAttachment = new BindingSource();
        FileInfo info;

        // Error Providers --->
        private ErrorProvider DescriptionErrorProvider;
       // private ErrorProvider sourceFileErrorProvider;

        public CreateAttachmentForm(int purchaseOrderID)
        {
            InitializeComponent();
            bsAttachment.DataSource = newAttachmentDto;
            newAttachmentDto.PurchaseOrderID = purchaseOrderID;
            this.Text = $"Add Document #Order: {newAttachmentDto.PurchaseOrderID}";
            
            BindAttachment(bsAttachment);
            bsAttachment.ListChanged += BsAttachment_ListChanged;
        }

        public AttachmentDto NewAttachment
        {
            get { return newAttachmentDto; }
        }

        private void BsAttachment_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                btnSave.Enabled = true;
            }
        }

        private void CreateAttachmentForm_Load(object sender, EventArgs e)
        {

        }

        private void BindAttachment(BindingSource bs)
        {
            txtAttachmentDescription.DataBindings.Clear();
            txtSourceFile.DataBindings.Clear();
            txtFileSize.DataBindings.Clear();

            txtAttachmentDescription.DataBindings.Add("Text", bs, "AttachmentDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSourceFile.DataBindings.Add("Text", bs, "src", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFileSize.DataBindings.Add("Text", bs, "FileSize", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (newAttachmentDto.IsValid())
            {
               int k =  FileOperations.InsertOrderAttachment(newAttachmentDto.PurchaseOrderID,
                    newAttachmentDto.AttachmentDescription, newAttachmentDto.FileSize, info);
                newAttachmentDto.AttachmentID = k;
                
            }
            else
            {
            }
        }

        // Create and set the ErrorProvider for each data entry control.
        private void SetValidation()
        {

            DescriptionErrorProvider = new System.Windows.Forms.ErrorProvider();
            DescriptionErrorProvider.SetIconAlignment(this.txtAttachmentDescription, ErrorIconAlignment.MiddleRight);
            DescriptionErrorProvider.SetIconPadding(this.txtAttachmentDescription, 2);
            DescriptionErrorProvider.BlinkRate = 1000;
            DescriptionErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

        }

        // Functions to verify data.
        private bool IsDescriptionValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (txtAttachmentDescription.Text.Length > 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Close();
        }

        /// <summary>
        /// Browser for File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            info = FileDialogHelpers.GetFile();
            if (info != null)
            {
                newAttachmentDto.FileSize = FileHelperService.GetSizeInMemory(info.Length);
                newAttachmentDto.Src = info.Name;
            }
            else
            {
                return;
            }
        }
    }
}
