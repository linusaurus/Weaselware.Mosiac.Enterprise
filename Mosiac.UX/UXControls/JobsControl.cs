using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using ServiceLayer.Services;
using ServiceLayer;
using ServiceLayer.Models;
using DataLayer.Entity;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class JobsControl : UserControl
    {
        private readonly MosaicContext _ctx;
        //-----------------------------------
        private JobsService _jobService;
        private OrdersService _ordersService;
        private StockService _stockService;
        //-----------------------------------
        private Job _selectedJob;
        private int _selectedPurchaseOrderID;
        private int _selectedPickList;
        private string _lastJobSelected;

        private DateTimePicker dtp { get; set; }
        public JobsControl(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _jobService = new JobsService(_ctx);
            _ordersService = new OrdersService(_ctx);
            _stockService = new StockService(_ctx);

            if (Mosiac.UX.Properties.Settings.Default.LastJobSearched.Length > 0)
            {

            }

            Grids.BuildJobOrderDetailGrid(dgvJobOrders);
            Grids.BuildJobDeliveriesGrid(dgvJobDeliveries);

            lbJobsList.SelectedIndexChanged += LbJobsList_SelectedIndexChanged;
            dgvJobOrders.SelectionChanged += DgvJobOrders_SelectionChanged;
            dgvJobOrders.MouseDoubleClick += DgvJobOrders_MouseDoubleClick;
            // ------------------------------------------------------
           
            dgvJobDeliveries.CellValueChanged += DgvJobDeliveries_CellValueChanged;
            dgvJobDeliveries.CurrentCellDirtyStateChanged += DgvJobDeliveries_CurrentCellDirtyStateChanged;
            dgvJobDeliveries.CellClick += DgvJobDeliveries_CellClick;
            dgvJobDeliveries.SelectionChanged += DgvJobDeliveries_SelectionChanged;
        }

        private void DgvJobDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    _selectedPickList = ((PickListDto)dgv.CurrentRow.DataBoundItem).PickListID;
                }
            }
        }

        private void DgvJobDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            // determine if click was on our date column
            if (e.ColumnIndex == 5)
            {
                // initialize DateTimePicker
                DateTime val;
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                if (dgv.CurrentCell.ColumnIndex== 5)
                {
                    if (DateTime.TryParse(dgv.CurrentCell.Value.ToString(),out val))
                    {
                        if (val != DateTime.MinValue)
                        {
                            dtp.Value = DateTime.Parse(dgv.CurrentCell.Value.ToString());
                        }
                    }                  
                }
             

                // set size and location
                var rect = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(rect.Width, rect.Height);
                dtp.Location = new Point(rect.X, rect.Y);

                // attach events
                dtp.CloseUp += new EventHandler(dtp_CloseUp);
                dtp.TextChanged += new EventHandler(dtp_OnTextChange);

                dgv.Controls.Add(dtp);
            }
        }

        // on text change of dtp, assign back to cell
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            dgvJobDeliveries.CurrentCell.Value = dtp.Text.ToString();
            if (_selectedPickList != default )
            {
                var found = _ctx.PickList.Find(_selectedPickList);
                found.DeliveryDate = (DateTime)dgvJobDeliveries.CurrentCell.Value;
                _ctx.SaveChanges();

            }

        }

        // on close of cell, hide dtp
        void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

        private void DgvJobDeliveries_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (dgvJobDeliveries.IsCurrentCellDirty)
            {
                dgvJobDeliveries.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvJobDeliveries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
               
              
            }
        }

       

        private void DgvJobOrders_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgvJobOrders.DataSource != null)
            {
                if (dgvJobOrders.SelectedRows.Count > 0)
                {
                    int selectedrowindex = dgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];
                    _selectedPurchaseOrderID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                }
            }
        }

        private void DgvJobOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectedPurchaseOrderID != default)
            {
                Main main = (Main)Application.OpenForms["Main"];
                main.OpenAnOrder(_selectedPurchaseOrderID);
            }
        }

        private void LbJobsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.DataSource != null)
            {
                if (lb.SelectedItems.Count > 0)
                {
                    _selectedJob = (Job)lb.SelectedItems[0];
                    var jobOrders = _ordersService.JobOrders(_selectedJob.jobID);
                    DataTable dt = new DataTable();
                    dt = Grids.BuildDataTable(jobOrders);
                    dgvJobOrders.DataSource = dt.DefaultView;
                    // Return sum of JobOrder Totals-------------
                    var total = _ctx.PurchaseOrder.Where(i => i.JobID == _selectedJob.jobID).Sum(r => r.OrderTotal).GetValueOrDefault();
                    txtJobOrderTotals.Text = total.ToString("C");
                    // -------------------------------------------
                    var deliveries = _stockService.GetJobPicks(_selectedJob.jobID);
                    dgvJobDeliveries.DataSource = _stockService.GetJobPicks(_selectedJob.jobID);
                }
            }
           
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {
                if (txtSearchJobs.Text.Length > 0)
                {
                    lbJobsList.DisplayMember = "Jobname";
                    lbJobsList.ValueMember = "JobID";
                    lbJobsList.DataSource = _jobService.GetJobs(txtSearchJobs.Text);
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbJobsList.DisplayMember = "Jobname";
            lbJobsList.DataSource = _jobService.All();
        }

        private void CreateNewJobOrder()
        {
            //jobID = diag.JobNumber;
            //supplierID = diag.SupplierID;

           // var order = _ordersService.NewDefault(Globals.CurrentLoggedUserID, supplierID, jobID);
           // _ordersService.Add(order);
            // Purchase Order Page

            //TabPage orderPage = PageFactory.GetNewTabPage(_ctx, PageFactory.TabPageType.PurchaseOrderPage, order.PurchaseOrderID);

            //MainTabControl.TabPages.Add(orderPage);
            //MainTabControl.SelectTab(orderPage);
        }
    }
}
