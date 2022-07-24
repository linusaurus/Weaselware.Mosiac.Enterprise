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
        //-----------------------------------
        private Job _selectedJob;
        private int _selectedPurchaseOrderID;
        public JobsControl(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _jobService = new JobsService(_ctx);
            _ordersService = new OrdersService(_ctx);
            Grids.BuildJobOrderDetailGrid(dgvJobOrders);

            lbJobsList.SelectedIndexChanged += LbJobsList_SelectedIndexChanged;
            dgvJobOrders.SelectionChanged += DgvJobOrders_SelectionChanged;
            dgvJobOrders.MouseDoubleClick += DgvJobOrders_MouseDoubleClick;
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
