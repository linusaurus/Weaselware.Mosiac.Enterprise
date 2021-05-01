using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System.IO;
using System.Diagnostics;
using Mosiac.UX.UXControls;

namespace Mosiac.UX.UXControls
{
    public partial class PartResourceControl : UserControl
    {
        private BindingSource _bsPartResources = new BindingSource();
        private ResourceDto _selectedResource;
        
        public PartResourceControl()
        {
            InitializeComponent();
            
            BuildGrid(dgResources);
            toolStrip1.ItemClicked += ToolStrip1_ItemClicked;
            dgResources.SelectionChanged += DgResources_SelectionChanged;
        }

        private void DgResources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgResources.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dgResources.DataSource, dgResources.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    _selectedResource = (ResourceDto)bm.Current;
                }
            }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessStartInfo psi;

            switch (e.ClickedItem.Name)
            {
                case "tsbAddResource":
                    FileInfo info = FileDialogHelpers.GetFile();

                    ResourceDto dto = new ResourceDto();
                    dto.PartID = 1;
                    dto.ResourceDescription = "New Resource Added...";
                    dto.Filesource = info.Name;
                    dto.Createdby = "Richard";
                    dto.CreationDate = DateTime.Today;
                    dto.Payload = File.ReadAllBytes(info.FullName);
                    dto.Filesize = FileHelperService.GetSizeInMemory(dto.Payload.Length);
                    _bsPartResources.Add(dto);

                    break;
                case "tsbOpenResource":

                    if (_selectedResource != null)
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        path += @"\ResourceCache\";
                        path += _selectedResource.Filesource;
                        File.WriteAllBytes(path, _selectedResource.Payload);
                        psi = new ProcessStartInfo
                        {
                            FileName = path,
                            UseShellExecute = true,
                            Verb = "open"

                        };
                        using (var proc = Process.Start(psi)) { }
                    }

                    break;
                case "tsbOpenLocalFolder":

                    string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    folderpath += @"\ResourceCache\";

                    psi = new ProcessStartInfo
                    {
                        FileName = folderpath,
                        UseShellExecute = true,
                        Verb = "open"

                    };
                    using (var proc = Process.Start(psi)) { }

                    break;
                case "tsbUpdateFromLocal":

                    if (_selectedResource != null)
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        path += @"\ResourceCache\";
                        path += _selectedResource.Filesource;

                        if (File.Exists(path))
                        {
                            _selectedResource.Payload = File.ReadAllBytes(path);
                            _selectedResource.Lastmod = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Local copy doesn't exist, please open the resource to create local copy",
                                "Local Resource Missing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    break;
                case "tsbClearCache":
                    string cachepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    cachepath += @"\ResourceCache\";

                    Array.ForEach(Directory.GetFiles(cachepath),
                                    delegate (string path) { File.Delete(path); });
                   
                    break;
                default:
                    break;
            }
        }

        private void BuildGrid(DataGridView dv)
        {

            dv.AutoGenerateColumns = false;
           // dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

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

            dv.AutoGenerateColumns = false;

            // AttachmentID Column --
            DataGridViewTextBoxColumn colResourceID = new DataGridViewTextBoxColumn();
            colResourceID.HeaderText = "ID";
            colResourceID.DataPropertyName = "ResourceID";
            colResourceID.Width = 55;

            // AttachmentID Column --
            DataGridViewTextBoxColumn colCreator = new DataGridViewTextBoxColumn();
            colCreator.HeaderText = "Creator";
            colCreator.DataPropertyName = "Createdby";
            colCreator.Width = 75;

            // Date Column --
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Date";
            colDate.DataPropertyName = "CreationDate";
            colDate.Width = 75;

            // Description Column --
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "ResourceDescription";
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.DefaultCellStyle = dstyleWrapText;
 
            //colDescription.Width = 75;

            // Source File Column --
            DataGridViewTextBoxColumn colSourceFile = new DataGridViewTextBoxColumn();
            colSourceFile.HeaderText = "Source File";
            colSourceFile.DataPropertyName = "Filesource";
            colSourceFile.ReadOnly = true;
            colSourceFile.Width = 115;

            // Filesize Column --
            DataGridViewTextBoxColumn colFileSize = new DataGridViewTextBoxColumn();
            colFileSize.HeaderText = "File Size (KB)";
            colFileSize.DataPropertyName = "Filesize";
            colSourceFile.ReadOnly = true;
            colFileSize.Width = 115;

            dv.Columns.AddRange(colResourceID, colCreator, colDate, colDescription, colSourceFile, colFileSize);

        }

        public void SetDataSource(BindingSource bsPartResource)
        {
            _bsPartResources = bsPartResource;
            dgResources.DataSource = _bsPartResources;
        }

       
    }
}
