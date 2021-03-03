using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.Data;
using System.Linq;
using DataLayer.Entity;
using SimpleInjector;
using ServiceLayer;
using System.Composition;

namespace Mosiac.UX.UXControls
{
    public partial class OrderRecieptManager : UserControl
    {


        private readonly OrderReceiptRepository _orderReceiptRepository;
        private BindingSource bsOrderReceipt = new BindingSource();

        public OrderRecieptManager()
        {
            InitializeComponent();
            OrderRecieptGrid oGrid = new OrderRecieptGrid();
            this.splitContainer1.Panel2.Controls.Add(oGrid);
            oGrid.Dock = DockStyle.Fill;
            _orderReceiptRepository =  new OrderReceiptRepository(new BadgerContext());

            var orderReceipts = _orderReceiptRepository.GetOrderReceipts(13608);
            bsOrderReceipt.DataSource = orderReceipts;
            oGrid.DataSource = orderReceipts;

            bsOrderReceipt.ListChanged += BsOrderReceipt_ListChanged;
            InitializeOrdersList();
            BindPendingOrdersList();



        }

        private void BsOrderReceipt_ListChanged(object sender, ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e, btnSave);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Grids.ToogleButtonStyle(false, btnSave);
        }

        private void BindPendingOrdersList()
        {
            var pendingOrders = _orderReceiptRepository.PendingOrders();
            foreach (var dto in pendingOrders)
            {
                ListViewItem lvi = new ListViewItem(dto.PurchaseOrderID.ToString());
                lvi.SubItems.Add(dto.JobName);
                lvi.SubItems.Add(dto.EmployeeName);
                lvi.SubItems.Add(dto.OrderDate.ToShortDateString());
                lvUnRecievedOrders.Items.Add(lvi);
            }

           
        }

        private void InitializeOrdersList()
        {
            lvUnRecievedOrders.View = View.Details;
            lvUnRecievedOrders.GridLines = true;
            lvUnRecievedOrders.FullRowSelect = true;

            // Attach Subitems to the ListView
            lvUnRecievedOrders.Columns.Add("ID", 90, HorizontalAlignment.Left);
            lvUnRecievedOrders.Columns.Add("Job", 120, HorizontalAlignment.Left);
            lvUnRecievedOrders.Columns.Add("Employee", 70, HorizontalAlignment.Left);
            lvUnRecievedOrders.Columns.Add("Date", 100, HorizontalAlignment.Right);
        }
    }
}
