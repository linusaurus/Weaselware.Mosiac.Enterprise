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
using System.Threading.Tasks;

namespace Mosiac.UX.UXControls
{
    public partial class PartManager : UserControl
    {
        //private int partID;
        //private FileInfo fl;
        private string size = string.Empty;
        private readonly MosaicContext _ctx;
        private PartDetailDTO _selectedPart = new PartDetailDTO();
        private int manuID;
        private Part _partBeingEdited;
        private int _selectedResourceID;
        private Resource _selectedResource;
        //private int _currentTransactionsFilter = 1;
        private int _selectedPartID;
        private Location _selectedLocation;

        IEnumerable<PartTransactionListDto> _SelectedtransActions;
        PartMapper partMapper = new PartMapper();

        private bool ManuFilter = false;

        private BindingSource bsPart = new BindingSource();
        private BindingSource bsResource = new BindingSource();
        private BindingSource bsLocationParts = new BindingSource();
        private BindingSource bsLocation = new BindingSource();

        private IEnumerable<ManuListDTO> manus;
        private PartsService partsService;
        private ResourceService resourceService;
        private readonly InventoryService InventoryService;
        private readonly StockService _stockService;

        private string activeTab = "tabPartsManager";

        List<PartFastSearchDto> partsList = new List<PartFastSearchDto>();


        DataTable ListAsDataTable;
        DataView dv;


        public PartManager(MosaicContext ctx)
        {
            InitializeComponent();

            _ctx = ctx;
            partsService = new PartsService(ctx);
            resourceService = new ResourceService(ctx);
            InventoryService = new InventoryService(new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection));
            _stockService = new StockService(ctx);
            //-------------Build the Grids ---------------
            Grids.BuildPartSearchGrid(dgPartsSearch);
            Grids.BuildPartResourcesGrid(dgResources);
            Grids.BuildPartOrdersGrid(dgPartOrders);
            Grids.BuildStockPartsGrid(dgvStockParts);
            Grids.BuildPartsTransActionsGrid(dgTransactionsGrid);
            Grids.BuildLocationsGrid(dgLocations);
            Grids.BuildLocationPartsGrid(dgLocationParts);
            // -------------------------------------------
            manus = partsService.GetManus();

            cboManu.DataSource = manus;
            cboManu.DisplayMember = "ManufacturerName";
            cboManu.ValueMember = "ManuID";
            cboManu.SelectedIndex = -1;
            // Event Wiring ===========================================================================
            bsPart.ListChanged += BsPart_ListChanged;
            bsResource.ListChanged += BsResource_ListChanged;
            dgTransactionsGrid.CellContentDoubleClick += DgTransactionsGrid_CellContentDoubleClick;
            bsLocationParts.CurrentItemChanged += BsLocationParts_CurrentItemChanged;
            bsLocationParts.ListChanged += BsLocationParts_ListChanged;

            // ========================================================================================

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
            Grids.CheckForDirtyState(e, btnSave);
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

            switch (activeTab)
            {
                case "tabStockTransactions":
                    if (txtSearch.Text.Length > 1)
                    {
                        partsList = await partsService.SearchPartQueryAsync(searchMain, manuID, ManuFilter, parms);

                        ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                        dv = ListAsDataTable.DefaultView;
                        dgvStockParts.DataSource = dv;
                    }
                    else { }

                    break;

                case "tabPartsManager":
                    if (txtSearch.Text.Length > 1)
                    {
                        partsList = await partsService.SearchPartQueryAsync(searchMain, manuID, ManuFilter, parms);

                        ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                        dv = ListAsDataTable.DefaultView;
                        dgPartsSearch.DataSource = dv;
                    }
                    else { }

                    break;
                case "tabLocations":
                    dgLocations.DataSource = InventoryService.GetLocations();
                    break;

                default:
                    break;

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
                dgvStockParts.DataSource = dv;
            }

        }
        //TODO  bind details
        private void BindResource(BindingSource bs)
        {
            this.propertyGrid1.SelectedObject = bs.DataSource;
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
            if (cb.SelectedIndex != -1)
            {
                manuID = ((ManuListDTO)cb?.SelectedItem).ManuID;
                partsList = partsService.GetManufacturerParts(manuID);
                ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                dv = ListAsDataTable.DefaultView;
                dgPartsSearch.DataSource = dv;
            }

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

            partsService.CreateOrUpdatePart(_selectedPart, "Richard");
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
            if (_selectedResource != null)
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path += @"\ResourceCache\";
                path += resource.filesource;

                Resource getResource = _ctx.Resource.Where(r => r.ResourceID == resource.ResourceID).FirstOrDefault();

                // Check that the local file exist ---;
                if (File.Exists(path))
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

                        PartEditForm frm = new PartEditForm(bsPart, _ctx);
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
                    spcPartsManager.Panel2Collapsed = true;
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
                    if (spcPartsManager.Panel2Collapsed == false)
                    {
                        spcPartsManager.Panel2Collapsed = true;
                        e.ClickedItem.Image = Mosiac.UX.Properties.Resources.round_keyboard_arrow_up_black_24dp;
                    }
                    else if (spcPartsManager.Panel2Collapsed == true)
                    {
                        spcPartsManager.Panel2Collapsed = false;
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

        //----------------------------------Transactions Area---------------------------------------------
        #region Transactions Logic


        private void tabPartManager_SelectedIndexChanged(object sender, EventArgs e)
        {

            TabControl tb = (TabControl)sender;
            activeTab = tb.SelectedTab.Name;

            switch (tb.SelectedTab.Name)
            {
                case "tabStockTransactions":

                    SearchParts();
                    break;

                case "tabPartsManager":
                    SearchParts();
                    break;
                case "tabLocations":

                    tsbSaveLocationParts.BackColor = SystemColors.Window;
                    bsLocation.DataSource = InventoryService.GetLocations();
                    dgLocations.DataSource = bsLocation;

                    break;
                default:
                    break;
            }

        }


        #endregion



        private void dgvStockParts_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    if (dg.CurrentRow != null)
                    {
                        _selectedPartID = (int)dg.CurrentRow.Cells[0].Value;
                        dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);
                        decimal stockLevel = InventoryService.GetStockLevel(_selectedPartID);
                        txtStockLevel.Text = String.Format("{0:.##}", stockLevel);
                    }
                }
            }
        }

        private void tsTransactions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsbReceipts":
                    dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID, 1);
                    break;
                case "tsbAudits":
                    dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID, 4);
                    break;
                case "tsbPulls":
                    dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID, 3);
                    break;
                case "tsbAll":
                    dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);
                    break;
                case "tsbRemoveSelected":
                    dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);
                    break;
                default:
                    break;
            }
        }
        // Set Stock Level
        private void button1_Click_2(object sender, EventArgs e)
        {
            // Set the Stock Level  ----
            StockLevelAdjustmentForm frm = new StockLevelAdjustmentForm();
            frm.Text = String.Format("Set Stock Level # {0}", _selectedPartID.ToString());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                InventoryService.SetStockLevel(_selectedPartID, frm.Adjustment);
                dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);

            }


            txtStockLevel.Text = String.Format("{0:.##}", InventoryService.GetStockLevel(_selectedPartID));
        }

        private void dgTransactionsGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            DataGridViewRow row; ;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    if (dg.SelectedRows.Count > 0)
                    {
                        row = dg.SelectedRows[0];
                        _selectedPartID = (int)row.Cells[0].Value;
                    }

                }
            }
        }

        private void dgTransactionsGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //DataGridView dg = (DataGridView)sender;
            //// For any other operation except, StateChanged, do nothing
            //if (e.StateChanged != DataGridViewElementStates.Selected) return;


        }

        private void tsbRemoveSelected_Click(object sender, EventArgs e)
        {
            DataGridView dg = dgTransactionsGrid;
            List<Inventory> removeList = new List<Inventory>();

            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dg.SelectedRows)
                    {
                        removeList.Add(new Inventory() { StockTransactionID = (int)row.Cells[0].Value });
                    }
                }
            }
            _ctx.Inventory.RemoveRange(removeList);
            _ctx.SaveChanges();
            dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);
        }

        private void DgTransactionsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_selectedPartID > 0)
            {
                // open transaction for editing
            }
        }
        #region Locations Surface
        private void dgLocations_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = dgLocations;

            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    BindingManagerBase bm = dg.BindingContext[dg.DataSource, dg.DataMember];
                    _selectedLocation = (Location)bm.Current;
                    bsLocationParts.DataSource = InventoryService.GetLocationParts(_selectedLocation.LocationName);
                    dgLocationParts.DataSource = bsLocationParts;
                }
            }
        }


        private void tsLocationPartsToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStrip ts = (ToolStrip)sender;
            switch (e.ClickedItem.Name)
            {
                case "tsbSaveLocationParts":

                    tsbSaveLocationParts.BackColor = System.Drawing.Color.LightGray;
                    tsbSaveLocationParts.ForeColor = System.Drawing.Color.Black;
                    SaveChangesToLocationParts(bsLocationParts);

                    break;
                default:
                    break;
            }
        }

        private void BsLocationParts_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void BsLocationParts_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                tsbSaveLocationParts.BackColor = System.Drawing.Color.Bisque;
                tsbSaveLocationParts.ForeColor = System.Drawing.Color.DarkRed;

            }

        }

        private void SaveChangesToLocationParts(BindingSource bs)
        {
            List<Inventory> insertList = new List<Inventory>();
            if (bs.DataSource != null)
            {
                foreach (PartsLocationDto e in bs.List)
                {
                    Inventory n = new Inventory()
                    {
                        DateStamp = DateTime.Now,
                        PartID = e.PartID,
                        JobID = 1,
                        QntyOrdered = 0.0m,
                        QntyReceived = 0.0m,
                        Description = e.ItemDescription,
                        Location = e.Location,
                        EmpID = Globals.CurrentLoggedUserID,
                        InventoryAmount = e.StockOnHand,
                        TransActionType = 4

                    };
                    // add the new inventory item to the exportable list-->
                    insertList.Add(n);
                }
                //-->>
                InventoryService.UpdateLocationParts(insertList.ToList(), Globals.CurrentLoggedUserID);
            }
        }




        private void tsLocationMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStrip ts = (ToolStrip)sender;
            switch (e.ClickedItem.Name)
            {
                case "tsbNew":
                    bsLocation.DataSource = InventoryService.GetLocations();
                    txtAreaFilter.Text = "";
                    break;
                case "tsbEdit":
                    if (_selectedLocation != null)
                    {
                        LocationEditForm frm = new LocationEditForm(_selectedLocation);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            _ctx.Location.Update(frm.locationEdited);
                            _ctx.SaveChanges();
                            _selectedLocation = _ctx.Location.Find(_selectedLocation.LocationID);
                        }
                    }
                    break;
                case "tsbFilter":

                    if (txtAreaFilter.Text.Length > 0)
                    {
                        bsLocation.DataSource = InventoryService.GetAreaLocations(txtAreaFilter.Text);
                    }



                    break;
                default:
                    break;
            }
        }

        #endregion


        private void btnRollup_Click(object sender, EventArgs e)
        {
            if (_selectedPartID != default)
            {
                _stockService.PartRollup(_selectedPartID, Globals.CurrentLoggedUserID);
                dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);
            }

        }

        private void btnPullStock_Click(object sender, EventArgs e)
        {
            // Set the Stock Level  ----
            StockLevelAdjustmentForm frm = new StockLevelAdjustmentForm();
            frm.Text = String.Format("Pull Stock # {0}", _selectedPartID.ToString());
            
           
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _stockService.PullPart(_selectedPartID.ToString(),frm.Adjustment,Globals.CurrentLoggedUserID,1);
                dgTransactionsGrid.DataSource = InventoryService.GetPartTransactions(_selectedPartID);

            }


            txtStockLevel.Text = String.Format("{0:.##}", InventoryService.GetStockLevel(_selectedPartID));
        }
    }
}
