using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System;
using System.Diagnostics;
using System.Drawing;
using Mosiac.UX;
using Mosiac.UX.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class PartManager : UserControl
    {
        private int partID;
        private FileInfo fl;
        private string size = string.Empty;
        private readonly MosaicContext _ctx;
        private PartDetailDTO _selectedPart = new PartDetailDTO();
        private int manuID;
        private Part _partBeingEdited;
        private int _selectedResourceID;
        private Resource _selectedResource;

        IEnumerable<PartSearchDto> parts;
        PartMapper partMapper = new PartMapper();

        private bool ManuFilter = false;
        int startTime, endTime;

        private BindingSource bsPart = new BindingSource();
        private BindingSource bsResource = new BindingSource();

        private List<UnitOfMeasure> units;
       
        private IEnumerable<ManuListDTO> manus;
        private IEnumerable<ManuListDTO> partManus;
        private PartsService partsService;
        private ResourceService resourceService;

        List<PartSearchDto> partsList = new List<PartSearchDto>();
        

        DataTable ListAsDataTable;
        DataView dv;


        public PartManager(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            partsService = new PartsService(ctx);
            resourceService = new ResourceService(ctx);
            Grids.BuildPartSearchGrid(dgPartsSearch);
            Grids.BuildPartResourcesGrid(dgResources);

            units = partsService.Units();
            manus = partsService.GetManus();
            partManus = partsService.GetManus();

            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "UnitOfMeasureID";
            cbxUnit.DataSource = units;
            cbxUnit.ResetText();
            cbxUnit.SelectedIndex = -1;


            cboManu.DataSource = manus;
            cboManu.DisplayMember = "ManufacturerName";
            cboManu.ValueMember = "ManuID";

            cboPartManu.DataSource = partManus;
            cboPartManu.DisplayMember = "ManufacturerName";
            cboPartManu.ValueMember = "ManuID";
            cboPartManu.ResetText();
            cboPartManu.SelectedIndex = -1;
            cboPartManu.Text = "Manufacturer";
            
            bsPart.ListChanged += BsPart_ListChanged;
            bsResource.ListChanged += BsResource_ListChanged;

        }

        private void BsResource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e, btnSave);
        }

        private void BsPart_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e,btnSave);          
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            SearchParts();
        }

        private void SearchParts()
        {
            if (txtSearch.Text.Length > 2)
            {
                
                startTime = System.DateTime.Now.Millisecond;
                partsList = partsService.SearchPart(txtSearch.Text, manuID,ManuFilter);
                ListAsDataTable = Grids.BuildDataTable<PartSearchDto>(partsList);
                dv = ListAsDataTable.DefaultView;
                endTime = System.DateTime.Now.Millisecond;
                lbResults.Text = $"Returned {ListAsDataTable.Rows.Count} Items, Milliseconds = {(endTime - startTime).ToString()} ";

                dgPartsSearch.DataSource = dv;
            }
        }

        private void BindPart(BindingSource bs)
        {

            if (bs.Current.GetType() == typeof(PartDetailDTO))
            {
          
                txtPartID.DataBindings.Clear();
                cbxObsolete.DataBindings.Clear();
                cbxUnit.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                txtWaste.DataBindings.Clear();
                txtMarkUp.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtStockLevel.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtPartDescription.DataBindings.Clear();
                txtPartName.DataBindings.Clear();

                txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxObsolete.DataBindings.Add("Checked", bsPart, "Obsolete", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxUnit.DataBindings.Add("SelectedValue", bsPart, "UID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                //txtStockLevel.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtUnitPrice.DataBindings.Add("Text", bsPart, "UnitCost", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (bs.Current.GetType() == typeof(Part))
            {
                txtPartID.DataBindings.Clear();
                cbxObsolete.DataBindings.Clear();
                cbxUnit.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                txtWaste.DataBindings.Clear();
                txtMarkUp.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtStockLevel.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtPartDescription.DataBindings.Clear();
                txtPartName.DataBindings.Clear();
                cboPartManu.DataBindings.Clear();

                txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxObsolete.DataBindings.Add("Checked", bsPart, "ObsoluteFlag", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxUnit.DataBindings.Add("SelectedValue", bsPart, "UnitOfMeasureID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                //txtStockLevel.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtUnitPrice.DataBindings.Add("Text", bsPart, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
                cboPartManu.DataBindings.Add("SelectedValue", bsPart, "ManuID", true, DataSourceUpdateMode.OnPropertyChanged);
            }
                    

        }

        private void BindResource(BindingSource bs)
        {
            txtResourceCreateDate.DataBindings.Clear();
            txtResourceCreator.DataBindings.Clear();
            txtSourceFile.DataBindings.Clear();

            txtResourceCreator.DataBindings.Add("Text", bs, "Createdby", true, DataSourceUpdateMode.OnPropertyChanged);
            txtResourceCreateDate.DataBindings.Add("Text", bs, "CreationDate", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSourceFile.DataBindings.Add("Text", bs, "filesource", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void dgAttachments_SelectionChanged(object sender, System.EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    if (dg.CurrentRow != null)
                    {
                        int i = (int)dg.CurrentRow.Cells[0].Value;
                        _partBeingEdited = partsService.Find(i);
                                 
                        bsPart.DataSource = _partBeingEdited;
                    
                        BindPart(bsPart);
                        var resources = _partBeingEdited.Resources.ToList();
                        dgResources.DataSource = resources;
                    }                  
                }
            }
        }

        private void cboManu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            manuID = (int)cboManu.SelectedValue;

            startTime = System.DateTime.Now.Millisecond;
            
            partsList = partsService.GetManufacturerParts(manuID);
            ListAsDataTable = Grids.BuildDataTable<PartSearchDto>(partsList);
            dv = ListAsDataTable.DefaultView;
            endTime = System.DateTime.Now.Millisecond;
            lbResults.Text = $"Returned {ListAsDataTable.Rows.Count} Items, Milliseconds = {(endTime - startTime).ToString()} ";

            dgPartsSearch.DataSource = dv;
        }

        /// <summary>
        /// Save the Active Part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e)
        {
           
            _ctx.SaveChanges();
            // ---  partsService.CreateOrUpdatePart(_selectedPart,"Richard");
            Grids.ToogleButtonStyle(false, btnSave);
            dgPartsSearch.Enabled = true;
            _partBeingEdited = partsService.Find(_partBeingEdited.PartID);
            bsPart.DataSource = _partBeingEdited;
            BindPart(bsPart);
          
        }

        private void gpbResource_Enter(object sender, System.EventArgs e)
        {

        }
        //---------------------------------------------------------
        // the big kahuna, get this to work and you can move on
        // to better things, a long time coming.
        //---------------------------------------------------------
        private void btnNewResource_Click(object sender, System.EventArgs e)
        {            
            if (_partBeingEdited != null || _partBeingEdited.PartID != default)
            {
                CreateResourceForm frm = new CreateResourceForm(_partBeingEdited.PartID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var resrc = frm.NewResource;                    
                }

                // -- Refresh the Resource list---;
                _partBeingEdited = partsService.Find(_partBeingEdited.PartID);
                if (_partBeingEdited != null)
                {
                    bsPart.DataSource = _partBeingEdited;
                    BindPart(bsPart);
                    bsResource.DataSource = _partBeingEdited.Resources.ToList();
                    dgResources.DataSource = _partBeingEdited.Resources.ToList();
                }
            }
        }

        private void OpenResource(int resourceID)
        {
            Resource dto = _ctx.Resources.Find(resourceID);
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\ResourceCache\";
            path += dto.filesource;
            File.WriteAllBytes(path, dto.ResourceFile);
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            };
            using (var proc = Process.Start(psi)) { }
        }

        private void btnOpenResource_Click(object sender, EventArgs e)
        {
            if (_selectedResourceID != default)
            {
                string conn = Mosiac.UX.Properties.Settings.Default.MosiacConnection;
                FileOperations.GetResource(_selectedResourceID, Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            }
        }

        private void dgResources_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    if (dg.CurrentRow != null)
                    {
                        _selectedResourceID = (int)dg.CurrentRow.Cells[0].Value;
                        _selectedResource = (Resource)dg.CurrentRow.DataBoundItem;
                        bsResource.DataSource = _selectedResource;
                        BindResource(bsResource);
                    }                
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int partIDlookUp = int.Parse(txtPartIDLookup.Text);
            if (partIDlookUp != default)
            {
                _partBeingEdited = partsService.Find(partIDlookUp);
                if (_partBeingEdited != null)
                {
                   
                    bsPart.DataSource = _partBeingEdited;
                    BindPart(bsPart);
                    bsResource.DataSource = _partBeingEdited.Resources.ToList();
                    dgResources.DataSource = _partBeingEdited.Resources.ToList();
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(String.Format("Part Number {0} does not exist",
                                                    partIDlookUp),
                                                    "Part Lookup", buttons);
                }
            }
        }
        /// <summary>
        /// Delete a Resource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteResource_Click(object sender, EventArgs e)
        {
            if (_selectedResource != null)
            {
                var delResource = _ctx.Resources.Find(_selectedResource.ResourceID);
                _ctx.Resources.Remove(delResource);
                _ctx.SaveChanges();


                _partBeingEdited = partsService.Find(_partBeingEdited.PartID);
                if (_partBeingEdited != null)
                {
                    bsPart.DataSource = _partBeingEdited;
                    BindPart(bsPart);
                    bsResource.DataSource = _partBeingEdited.Resources.ToList();
                    dgResources.DataSource = _partBeingEdited.Resources.ToList();
                }

            }
        }

        private void AddNewManufacturer(object sender, EventArgs e)
        {
            if (_partBeingEdited != null)
            {
                ManuEditForm frm = new ManuEditForm(_ctx);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnOpenCache_Click(object sender, EventArgs e)
        {
            FileOperations.OpenCacheFolder();
        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            FileOperations.ClearCacheFolder();
        }
        /// <summary>
        /// New Part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

            _partBeingEdited = partsService.New();
             bsPart.DataSource = _partBeingEdited;

            dgResources.DataSource = null;

            txtResourceCreateDate.DataBindings.Clear();
            txtResourceCreator.DataBindings.Clear();
            txtSourceFile.DataBindings.Clear();

            txtResourceCreateDate.Text = string.Empty;
            txtResourceCreator.Text = string.Empty;
            txtSourceFile.Text = string.Empty;

            bsResource.DataSource = _partBeingEdited.Resources.ToList();
             dgResources.DataSource = _partBeingEdited.Resources.ToList();
             txtPartDescription.PlaceholderText = "Enter a new part Description";
             bsPart.DataSource = _partBeingEdited;
            _ctx.Entry(_partBeingEdited).State = EntityState.Added;
            BindPart(bsPart);
            dgPartsSearch.Enabled = false;
        }

        private void lbResults_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            startTime = System.DateTime.Now.Millisecond;
            partsList = partsService.ReturnAllParts();
            ListAsDataTable = Grids.BuildDataTable<PartSearchDto>(partsList);
            dv = ListAsDataTable.DefaultView;
            endTime = System.DateTime.Now.Millisecond;
            lbResults.Text = $"Returned {ListAsDataTable.Rows.Count} Items, Milliseconds = {(endTime - startTime).ToString()} ";

            dgPartsSearch.DataSource = dv;
        }

        private void ckbUseManufacturer_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox cbx = (CheckBox)sender;
            if (cbx.Checked)
            {
                cboManu.Enabled = true;
                txtSearch.Clear();
                ManuFilter = true;
                cboManu.Refresh();
                SearchParts();
            }
            else
            {
                cboManu.Enabled = false;
                ManuFilter = false;
                cboManu.SelectedIndex = 0;
                cboManu.Refresh();
                SearchParts();
            }
        }
    }
}
