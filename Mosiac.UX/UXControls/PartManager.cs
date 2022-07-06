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
using Mosiac.UX.Forms;
using System.ComponentModel;
using Neodynamic.SDK.Printing;
using System.Xml.Serialization;
using Mosiac.UX.Services;

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

        //IEnumerable<PartSearchDto> parts;
        PartMapper partMapper = new PartMapper();

        private bool ManuFilter = false;
     
        private BindingSource bsPart = new BindingSource();
        private BindingSource bsResource = new BindingSource();
       
        private IEnumerable<ManuListDTO> manus;
        private PartsService partsService;
        private ResourceService resourceService;

        List<PartFastSearchDto> partsList = new List<PartFastSearchDto>();
      

        DataTable ListAsDataTable;
        DataView dv;


        public PartManager(MosaicContext ctx)
        {
            InitializeComponent();

            _ctx = ctx;
            partsService = new PartsService(ctx);
            resourceService = new ResourceService(ctx);
            //-------------Build the Grids ---------------
            Grids.BuildPartSearchGrid(dgPartsSearch);
            Grids.BuildPartResourcesGrid(dgResources);
            Grids.BuildPartOrdersGrid(dgPartOrders);
            // -------------------------------------------
            manus = partsService.GetManus();

            cboManu.DataSource = manus;
            cboManu.DisplayMember = "ManufacturerName";
            cboManu.ValueMember = "ManuID";
            cboManu.SelectedIndex = 1;
            
            bsPart.ListChanged += BsPart_ListChanged;
            bsResource.ListChanged += BsResource_ListChanged;

        }

     
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))             
            {
                //Do custom stuff
                //true if key was processed by control, false otherwise
                if (txtPartIDLookup.Text.Length != 0)
                {
                    int id = int.Parse(txtPartIDLookup.Text);
                    OpenPartbyNumber(id);
                }
                else
                {
                    SearchParts();
                }

                return true;
            }
            else if (keyData == Keys.Escape) //clear the textboxes, null the dg source
            {
                txtSearch.Text = string.Empty;
                txtSecondTerm.Text = string.Empty;
                txtThirdTerm.Text = string.Empty;
                txtPartIDLookup.Text = string.Empty;
                dgPartsSearch.DataSource = null;
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
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
            txtPartIDLookup.Text = "";          
        }
       
        private async void SearchParts()
        {
            string searchMain = txtSearch.Text;
            string term = txtSecondTerm.Text;
            string term2 = txtThirdTerm.Text;

            string[] parms = { term, term2 };

            if (txtSearch.Text.Length > 1)
            {
                partsList = await partsService.SearchPartQueryAsync(searchMain, manuID, ManuFilter, parms);

                ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                dv = ListAsDataTable.DefaultView;
                dgPartsSearch.DataSource = dv;
            }
            else
            {

            }
        }

        private void SearchParts(int partID)
         {
            if (partID != default)
            {
                partsList = partsService.SearchPart(partID);
                ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                dv = ListAsDataTable.DefaultView;
                dgPartsSearch.DataSource = dv;
            }
     
        }

        private void BindResource(BindingSource bs)
        {
           
            txtSourceFile.DataBindings.Clear();
            txtSourceFile.DataBindings.Add("Text", bs, "filesource", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        /// <summary>
        /// this changes the selected part bindings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        var resources = _partBeingEdited.Resource.ToList();
                        var orders = partsService.GetPartOrders(_partBeingEdited.PartID);
                        dgPartOrders.DataSource = orders;
                        dgResources.DataSource = resources;
                    }
                }
            }
        }

        private void cboManu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           ComboBox cb = (ComboBox)sender;
            
            manuID =((ManuListDTO)cb?.SelectedItem).ManuID;
            partsList = partsService.GetManufacturerParts(manuID);
            ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
            dv = ListAsDataTable.DefaultView;
            dgPartsSearch.DataSource = dv;
        }

        /// <summary>
        /// Save the Active Part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, System.EventArgs e)
        {

            // _ctx.SaveChanges();
            partMapper.Map(_partBeingEdited, _selectedPart);

            partsService.CreateOrUpdatePart(_selectedPart,"Richard");
            Grids.ToogleButtonStyle(false, btnSave);
            dgPartsSearch.Enabled = true;
            _partBeingEdited = partsService.Find(_partBeingEdited.PartID);
            bsPart.DataSource = _partBeingEdited;
            OpenPartbyNumber(_selectedPart.PartID);

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
                    bsResource.DataSource = _partBeingEdited.Resource.ToList();
                    dgResources.DataSource = _partBeingEdited.Resource.ToList();
                }
            }
        }

        private void OpenResource(int resourceID)
        {
            Resource dto = _ctx.Resource.Find(resourceID);
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

        private void UpdateResourceFile(Resource resource)
        {
            if (_selectedResource != null )
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path += @"\ResourceCache\";
                path += resource.filesource;

                Resource getResource = _ctx.Resource.Where(r => r.ResourceID == resource.ResourceID).FirstOrDefault();

                // Check that the local file exist ---;
                if(File.Exists(path))
                {
                    getResource.ResourceFile = File.ReadAllBytes(path);
                    getResource.Lastmod = DateTime.Now;
                    
                    _ctx.SaveChanges();
                }
                else
                {
                    MessageBox.Show("File must exist in local cache before updating");
                }
               
         
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
        /// <summary>
        /// open part by Part ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPartIDLookup.Text);
            OpenPartbyNumber(id);
        }

        private void OpenPartbyNumber(int partid)
        {
            int partIDlookUp = partid;
            if (partIDlookUp != default)
            {
                _partBeingEdited = partsService.Find(partIDlookUp);
                if (_partBeingEdited != null)
                {

                    SearchParts(partIDlookUp);

                    
                    bsResource.DataSource = _partBeingEdited.Resource.ToList();
                    dgResources.DataSource = _partBeingEdited.Resource.ToList();
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
                var delResource = _ctx.Resource.Find(_selectedResource.ResourceID);
                _ctx.Resource.Remove(delResource);
                _ctx.SaveChanges();


                _partBeingEdited = partsService.Find(_partBeingEdited.PartID);
                if (_partBeingEdited != null)
                {
                    bsPart.DataSource = _partBeingEdited;                 
                    bsResource.DataSource = _partBeingEdited.Resource.ToList();
                    dgResources.DataSource = _partBeingEdited.Resource.ToList();
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
        private void newPart()
        {

            _partBeingEdited = partsService.New();
             bsPart.DataSource = _partBeingEdited;

            dgResources.DataSource = null;
            PartEditForm frm = new PartEditForm(bsPart, _ctx);
            frm.Text = "New Part";
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _partBeingEdited = (Part)frm.bsPart.DataSource;
                partMapper.Map(_partBeingEdited, _selectedPart);
                int id = partsService.InsertOrUpdate(_selectedPart, Mosiac.UX.Services.Globals.CurrentUserName);
                //int id = partsService.Find(_selectedPart.PartID).PartID;
               // _ctx.Entry(_partBeingEdited).State = EntityState.Added;
               // _ctx.SaveChanges();
                Grids.ToogleButtonStyle(false, btnSave);

                OpenPartbyNumber(id);
            }
            else if (result == DialogResult.Cancel)
            {
                Grids.ToogleButtonStyle(false, btnSave);
            }
           
           bsResource.DataSource = _partBeingEdited.Resource.ToList();
           dgResources.DataSource = _partBeingEdited.Resource.ToList();
        }

        private void lbResults_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FindAll()
        {
            partsList = partsService.ReturnAllParts();
            ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
            dv = ListAsDataTable.DefaultView;
            dgPartsSearch.DataSource = dv;
        }

        /// <summary>
        /// open the selected part in list --
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPartsSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

                        PartEditForm frm = new PartEditForm(bsPart,_ctx);
                        frm.Text = $"Editing Part = {_partBeingEdited.PartID.ToString()} ";
                        frm.StartPosition = FormStartPosition.CenterParent;
                        var result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                           // _partBeingEdited = (Part)bsPart.DataSource;
                            _ctx.SaveChanges();
                            Grids.ToogleButtonStyle(false, btnSave);

                        }
                        else if (result == DialogResult.Cancel)
                        {
                            bsPart.CancelEdit();
                            Grids.ToogleButtonStyle(false, btnSave);
                        }
                        var resources = _partBeingEdited.Resource.ToList();
                        dgResources.DataSource = resources;
                    }
                }
            }

        }

        private void btnOpenPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            var x = e.KeyChar;
        }

        private void dgResources_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_selectedResourceID != default)
            {
                string conn = Mosiac.UX.Properties.Settings.Default.MosiacConnection;
                FileOperations.GetResource(_selectedResourceID, Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            }

        }

        private void dgPartOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.CurrentRow != null)
                {
                    int poID = (int)dv.CurrentRow.Cells[0].Value;
                    Main main = (Main)Application.OpenForms["Main"];
                    main.OpenAnOrder(poID);
                }
            }
        }
        /// <summary>
        /// create a new part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPart_Click(object sender, EventArgs e)
        {
            newPart();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FindAll();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchParts();
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

        private void tsResources_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsbCollapsePanel":
                    splitContainer1.Panel2Collapsed = true;
                    break;
                
                default:
                    break;
            }
        }

        private void tsResources_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsbCollapsePanel":
                    if (splitContainer1.Panel2Collapsed == false)
                    {
                        splitContainer1.Panel2Collapsed = true;
                        e.ClickedItem.Image = Mosiac.UX.Properties.Resources.round_keyboard_arrow_up_black_24dp;
                    }
                    else if (splitContainer1.Panel2Collapsed==true)
                    {
                        splitContainer1.Panel2Collapsed = false;
                        e.ClickedItem.Image = Mosiac.UX.Properties.Resources.round_keyboard_arrow_down_black_24dp;
                    }
                    
                    break;

                default:
                    break;
            }
        }

        #region Label Printing
        // Print a part label to 2.25 x 1 .25 label Zebra 2824
        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            ThermalLabel tlabel;

            if (_partBeingEdited != null)
            {

                PartListDto partListDto = partsService.GetPartLabel(_partBeingEdited.PartID);
              
                tlabel = LabelEngine.GeneratePartLabel(partListDto);

                PrinterSettings XmlData;
                var fileName = Path.Combine(Environment.GetFolderPath(
                                Environment.SpecialFolder.ApplicationData), "Wml.xml");
                // if the settings file doesn't exist-re-create them
                if (!File.Exists(fileName))
                {
                    //Display Print Job dialog...           
                    PrintJobDialog frmPrintJob = new PrintJobDialog();
                    if (frmPrintJob.ShowDialog() == DialogResult.OK)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(PrinterSettings));
                        using (TextWriter writer = new StreamWriter(fileName))
                        {
                            serializer.Serialize(writer, frmPrintJob.PrinterSettings);
                        }
                    }
                }

                //Pull the settings from XML file --
                XmlSerializer deserializer = new XmlSerializer(typeof(PrinterSettings));
                TextReader reader = new StreamReader(fileName);
                object obj = deserializer.Deserialize(reader);
                XmlData = (PrinterSettings)obj;
                reader.Close();


               

                using (WindowsPrintJob pj = new WindowsPrintJob(XmlData))
                {


                            pj.Copies = 1; // set copies
                            pj.PrintOrientation = PrintOrientation.Portrait; //set orientation
                            pj.ThermalLabel = tlabel;
                            pj.PrintAsGraphic(tlabel);

                }
            }
            
        }

        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateResourceFile(_selectedResource);
        }
    }
}
