using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Mosiac.UX.UXControls;
using ServiceLayer.Models;
using ServiceLayer;

namespace Mosiac.UX.Forms
{
    public partial class CreateResourceForm : Form
    {
        private ResourceDto resourseDto = new ResourceDto();
        BindingSource bsResource = new BindingSource();
        FileInfo info;

        //private System.Windows.Forms.ErrorProvider ageErrorProvider;
        private System.Windows.Forms.ErrorProvider DescriptionErrorProvider;
       // private System.Windows.Forms.ErrorProvider favoriteColorErrorProvider;

        public CreateResourceForm(int partID)
        {
            InitializeComponent();
            resourseDto.PartID = partID;
            bsResource.DataSource = resourseDto;
            bsResource.ListChanged += BsResource_ListChanged;
            BindResource(bsResource);
            SetValidation();
            txtResourceDescription.Validating += TxtResourceDescription_Validating;
        }

        private void TxtResourceDescription_Validating(object sender, CancelEventArgs e)
        {
            if (IsDescriptionValid())
            {
                // Clear the error, if any, in the error provider.
                DescriptionErrorProvider.SetError(this.txtResourceDescription, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                DescriptionErrorProvider.SetError(this.txtResourceDescription, "Description is required.");
            }
        }

        private void BsResource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        public ResourceDto NewResource
        {
            get { return resourseDto; }
        }

        private void BindResource(BindingSource bs)
        {
            txtResourceDescription.DataBindings.Clear();
            txtSourceFile.DataBindings.Clear();
            txtFileSize.DataBindings.Clear();

            txtResourceDescription.DataBindings.Add("Text", bs, "ResourceDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSourceFile.DataBindings.Add("Text", bs, "FileSource", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFileSize.DataBindings.Add("Text", bs, "Filesize", true, DataSourceUpdateMode.OnPropertyChanged);

        }
        /// <summary>
        /// Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (resourseDto.IsValid())
            {
                FileOperations.InsertPhoto(resourseDto.PartID, resourseDto.ResourceDescription, resourseDto.Filesize, info);
            }
            else
            {
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            info = FileDialogHelpers.GetFile();
            resourseDto.Filesize = FileHelperService.GetSizeInMemory(info.Length);
            resourseDto.Filesource = info.Name;


        }

      

        // Create and set the ErrorProvider for each data entry control.
        private void SetValidation()
        {

            DescriptionErrorProvider = new System.Windows.Forms.ErrorProvider();
            DescriptionErrorProvider.SetIconAlignment(this.txtResourceDescription, ErrorIconAlignment.MiddleRight);
            DescriptionErrorProvider.SetIconPadding(this.txtResourceDescription, 2);
            DescriptionErrorProvider.BlinkRate = 1000;
            DescriptionErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            //ageErrorProvider = new System.Windows.Forms.ErrorProvider();
            //ageErrorProvider.SetIconAlignment(this.ageUpDownPicker, ErrorIconAlignment.MiddleRight);
            //ageErrorProvider.SetIconPadding(this.ageUpDownPicker, 2);
            //ageErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;

            //favoriteColorErrorProvider = new System.Windows.Forms.ErrorProvider();
            //favoriteColorErrorProvider.SetIconAlignment(this.favoriteColorComboBox, ErrorIconAlignment.MiddleRight);
            //favoriteColorErrorProvider.SetIconPadding(this.favoriteColorComboBox, 2);
            //favoriteColorErrorProvider.BlinkRate = 1000;
            //favoriteColorErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }

        // Functions to verify data.
        private bool IsDescriptionValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (txtResourceDescription.Text.Length > 0);
        }

        private void CreateResourceForm_Activated(object sender, EventArgs e)
        {
            txtResourceDescription.Focus();
        }
    }
}
