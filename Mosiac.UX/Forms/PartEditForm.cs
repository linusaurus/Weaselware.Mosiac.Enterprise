using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Linq;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
//-----------------------------------
using Motorola.Snapi;
using Motorola.Snapi.Constants.Enums;
using Motorola.Snapi.EventArguments;
//-----------------------------------
using ServiceLayer.Models;
using System.Windows.Forms;
using Mosiac.UX.UXControls;
using ServiceLayer;

namespace Mosiac.UX.Forms
{
    public partial class PartEditForm : Form
    {

        public BindingSource bsPart = new BindingSource();
        private IEnumerable<ManuListDTO> manus;
        private IEnumerable<ManuListDTO> partManus;
        private PartsService partsService;
        private InventoryService _inventoryService;
        private List<UnitOfMeasure> units;
        private readonly MosaicContext _ctx;
        private decimal _stockLevel;
        private string _lastScanned;

        public PartEditForm(BindingSource source, MosaicContext context)
        {
            InitializeComponent();
            _ctx = context;
            partsService = new PartsService(_ctx);
            _inventoryService = new InventoryService(_ctx);
            bsPart = source;
            BindPart(bsPart);

            units = partsService.Units();
            manus = partsService.GetManus();
            partManus = partsService.GetManus();

            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "UnitOfMeasureID";
            cbxUnit.DataSource = units;
            cbxUnit.ResetText();
            cbxUnit.SelectedIndex = -1;

            LoadManus();
            LoadLocations();
            bsPart.ListChanged += BsPart_ListChanged;
        }

        private void LoadManus()
        {
            cboPartManu.DataSource = partManus;
            cboPartManu.DisplayMember = "ManufacturerName";
            cboPartManu.ValueMember = "ManuID";
            cboPartManu.ResetText();
            cboPartManu.SelectedIndex = -1;
            cboPartManu.Text = "Manufacturer";
        }

        private void LoadLocations()
        {
            cboLocations.DataSource = _inventoryService.GetLocations();
            cboLocations.DisplayMember = "LocationName";
            cboLocations.ValueMember = "LocationID";


        }

        private void BsPart_ListChanged(object sender, ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e, this.btnSave);
        }

        private void PartEditForm_Load(object sender, EventArgs e)
        {
            // _ctx.Inventories.

        }

        private void BindPart(BindingSource bs)
        {

            if (bs.Current.GetType() == typeof(PartDetailDTO))
            {

                txtPartID.DataBindings.Clear();
                cbxObsolete.DataBindings.Clear();
                cbxUnit.DataBindings.Clear();
                //txtLocation.DataBindings.Clear();
                txtWaste.DataBindings.Clear();
                txtMarkUp.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtStockLevel.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtPartDescription.DataBindings.Clear();
                txtPartName.DataBindings.Clear();
                txtPartNum.DataBindings.Clear();
                cboLocations.DataBindings.Clear();


                txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxObsolete.DataBindings.Add("Checked", bsPart, "Obsolete", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxUnit.DataBindings.Add("SelectedValue", bsPart, "UID", true, DataSourceUpdateMode.OnPropertyChanged);
                cboLocations.DataBindings.Add("SelectedValue", bsPart, "LocationID", true, DataSourceUpdateMode.OnPropertyChanged);
                //txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStockLevel.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtUnitPrice.DataBindings.Add("Text", bsPart, "UnitCost", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (bs.Current.GetType() == typeof(Part))
            {
                if (((Part)bs.Current).PartID != 0)
                {
                    _stockLevel = _ctx.Inventory.Where(c => c.PartID == ((Part)bsPart.DataSource).PartID).Sum(i => i.InventoryAmount).GetValueOrDefault();
                }

                txtPartID.DataBindings.Clear();
                cbxObsolete.DataBindings.Clear();
                cbxUnit.DataBindings.Clear();
                cboLocations.DataBindings.Clear();
                //txtLocation.DataBindings.Clear();
                txtWaste.DataBindings.Clear();
                txtMarkUp.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtPartNum.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtPartDescription.DataBindings.Clear();
                txtPartName.DataBindings.Clear();
                cboPartManu.DataBindings.Clear();
                txtSKU.DataBindings.Clear();
                txtNotes.DataBindings.Clear();

                txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxObsolete.DataBindings.Add("Checked", bsPart, "ObsoluteFlag", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxUnit.DataBindings.Add("SelectedValue", bsPart, "UnitOfMeasureID", true, DataSourceUpdateMode.OnPropertyChanged);
                cboLocations.DataBindings.Add("SelectedValue", bsPart, "LocationID", true, DataSourceUpdateMode.OnPropertyChanged);
                //txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStockLevel.Text = _stockLevel.ToString();
                txtPartNum.DataBindings.Add("Text", bsPart, "PartNum", true, DataSourceUpdateMode.OnPropertyChanged);
                txtUnitPrice.DataBindings.Add("Text", bsPart, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSKU.DataBindings.Add("Text", bsPart, "SKU", true, DataSourceUpdateMode.OnPropertyChanged);
                cboPartManu.DataBindings.Add("SelectedValue", bsPart, "ManuID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtNotes.DataBindings.Add("Text", bsPart, "Notes", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(Disposing);
        }

        private void btnAddManu_Click(object sender, EventArgs e)
        {
            if (bsPart.DataSource != null)
            {
                ManuEditForm frm = new ManuEditForm(_ctx);
                frm.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Save the Manufactoer and return new ID -->
                    //Retrive the updated list of Manufacturers
                    partManus = partsService.GetManus();
                    // Load the Combobox with new list
                    LoadManus();
                    // Set the selected value to the newly created manufacturer
                    this.cboPartManu.SelectedValue = frm.Manu.ManuID;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLinkToUPC_Click(object sender, EventArgs e)
        {
            BarcodeScannerManager.Instance.Open();

            BarcodeScannerManager.Instance.RegisterForEvents(
               EventType.Barcode,
               EventType.Pnp,
               EventType.Image,
               EventType.Other,
               EventType.Rmd
               );

            //The events you are currently registered to will be listed in RegisteredEvents.
            if (BarcodeScannerManager.Instance.RegisteredEvents.Contains(EventType.Image))
            { };

            BarcodeScannerManager.Instance.DataReceived += Instance_DataReceived;

            txtSKU.BackColor = Color.Cornsilk;
        }

        private void Instance_DataReceived(object sender, BarcodeScanEventArgs e)
        {
            _lastScanned = e.Data;
            //Invoke(new Action(() => ((Part)bsPart.DataSource).SKU = _lastScanned));
            //Invoke(new Action(() => txtSKU.Text = _lastScanned));
            if (IsHandleCreated)
            {
                BeginInvoke(new Action(() => txtSKU.Text = _lastScanned));
                return;
            }
            else
            {

            }

        }
    }
}
