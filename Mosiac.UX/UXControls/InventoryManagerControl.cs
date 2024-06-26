using DataLayer.Data;
using DataLayer.Entity;
using Mosiac.UX.Forms;
using ServiceLayer;
using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class InventoryManagerControl : UserControl
    {
        Part currentPart;
        public BindingSource bsPart = new BindingSource();
        JobsService jobsService;
        InventoryService inventoryService;
        PartsService partsService;
        private IEnumerable<ManuListDTO> manus;
        private IEnumerable<ManuListDTO> partManus;
        private IEnumerable<JobListDto> jobs;
        private List<UnitOfMeasure> units;
        private decimal _stockLevel;

        private readonly MosaicContext _ctx;

        public InventoryManagerControl(MosaicContext mosiacContext)
        {
            InitializeComponent();
            _ctx = mosiacContext;
            inventoryService = new InventoryService(mosiacContext);
            partsService = new PartsService(mosiacContext);
            jobsService = new JobsService(mosiacContext);
            LoadManus();
            LoadLocations();
            bsPart.ListChanged += BsPart_ListChanged;
        }

        public void SetPart(int partID)
        {
            currentPart = partsService.Find(partID);
            bsPart.DataSource = currentPart;

            units = partsService.Units();
            manus = partsService.GetManus();
            partManus = partsService.GetManus();

            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "UnitOfMeasureID";
            cbxUnit.DataSource = units;
            cbxUnit.ResetText();
            cbxUnit.SelectedIndex = -1;


            BindPart(bsPart);
        }

        private void BsPart_ListChanged(object sender, ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e, this.btnSave);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int partID = 0;

            if (int.TryParse(txtSearchPart.Text, out partID))
            {
                var transActions = inventoryService.GetPartTransactions(partID);
                this.dataGridView1.DataSource = transActions;
                SetPart(partID);
            }

        }

        private void LoadJobs()
        {
            jobs = jobsService.All();

            cboCheckOutJobs.DataSource = jobs;
            cboCheckOutJobs.DisplayMember = "Jobname";
            cboCheckOutJobs.ValueMember = "JobID";
            cboCheckOutJobs.ResetText();
            cboCheckOutJobs.SelectedIndex = -1;
            cboPartManu.Text = "Jobs";
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
            cboLocations.DataSource = inventoryService.GetLocations();
            cboLocations.DisplayMember = "LocationName";
            cboLocations.ValueMember = "LocationID";


        }

        private void BindPart(BindingSource bs)
        {
            if (bs.DataSource == null)
            { return; }
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

            }
        }

        private void btnSetStockLevel_Click(object sender, EventArgs e)
        {
            StockLevelAdjustmentForm frm = new StockLevelAdjustmentForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                inventoryService.SetStockLevel(currentPart.PartID, frm.Adjustment);
                var transActions = inventoryService.GetPartTransactions(currentPart.PartID);
                this.dataGridView1.DataSource = transActions;
                this.txtStockLevel.Text = inventoryService.GetStockLevel(currentPart.PartID).ToString();

            }
        }

        private void btnPullStock_Click(object sender, EventArgs e)
        {
            StockLevelAdjustmentForm frm = new StockLevelAdjustmentForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transActions = inventoryService.GetPartTransactions(currentPart.PartID);
                List<int> list = new List<int>();
                foreach (var item in transActions)
                {
                    list.Add(item.PartID);
                }
                inventoryService.RemoveTransactions(list);
            }
        }


        private void btnRollUp_Click(object sender, EventArgs e)
        {
            var transActions = inventoryService.GetPartTransactions(currentPart.PartID);
            List<int> list = new List<int>();
            foreach (var item in transActions)
            {
                list.Add(item.StockTransactionId);
            }

            inventoryService.RemoveTransactions(list);
            inventoryService.RollUp(currentPart.PartID);

            this.dataGridView1.DataSource = inventoryService.GetPartTransactions(currentPart.PartID);
            this.txtStockLevel.Text = inventoryService.GetStockLevel(currentPart.PartID).ToString();
        }

        private void btnLoadLineItem_Click(object sender, EventArgs e)
        {
            int labelLineID;

            if (int.TryParse(txtLineItemEntry.Text, out labelLineID))
            {
                Inventory inventory = _ctx.Inventory.Include(u => u.UnitOfMeasure).Include(j => j.Job).Include(o => o.GetOrderReciept)
                    .Where(l => l.LineID == labelLineID).FirstOrDefault();
                if (inventory != null)
                {
                    LoadLineItem(inventory);
                }
            }


        }

        private void LoadLineItem(Inventory inventory)
        {
            int orderRecieptId = inventory.OrderReceiptID.GetValueOrDefault();

            if (orderRecieptId != default)
            {
                var order = _ctx.OrderReciept.Include(p => p.PurchaseOrder).ThenInclude(j => j.Job)
                    .Where(c => c.OrderReceiptID == inventory.OrderReceiptID.GetValueOrDefault()).FirstOrDefault();
                txtjJobName.Text = order.PurchaseOrder.Job.jobname;
                txtjOrderDate.Text = order.PurchaseOrder.OrderDate.GetValueOrDefault().ToShortDateString();
                txtjJobID.Text = order.PurchaseOrder.JobID.GetValueOrDefault().ToString();
                txtjDescription.Text = inventory.Description;
                txtjUnitOfMeasure.Text = inventory.UnitOfMeasure.UnitName;
                txt2CheckOutUnits.Text = inventory.UnitOfMeasure.UnitName;
                txt2StockReceived.Text = inventory.QntyReceived.GetValueOrDefault().ToString();

            }



        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            int partID = 0;

            if (int.TryParse(txtSearchPart.Text, out partID))
            {
                var transActions = inventoryService.GetPartTransactions(partID);
                this.dataGridView1.DataSource = transActions;
                SetPart(partID);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TabPage tabPage = ((TabControl)sender).SelectedTab;
            if (tabPage != null)
            {
                if (tabPage.Name == "tbCheckOuts")
                {
                    this.btnSetStockLevel.Enabled = false;
                    this.btnPullStock.Enabled = false;
                    this.btnRollUp.Enabled = false;
                    LoadJobs();
                }
                else if (tabPage.Name == "tbPartsInventory")
                {
                    this.btnSetStockLevel.Enabled = true;
                    this.btnPullStock.Enabled = true;
                    this.btnRollUp.Enabled = true;
                }


            }
        }
  
        ////TODO  check out part logic

        private void btnCheckout_Click(object sender, EventArgs e)
        {
          var line =   inventoryService.FindLineItem(56982);
        }
    }
}
