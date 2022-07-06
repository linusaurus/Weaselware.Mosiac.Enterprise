using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Data;
using ServiceLayer;
using ServiceLayer.Services;
using ServiceLayer.Models;
using Mosiac.UX.Forms;
using Mosiac.UX.Services;

namespace Mosiac.UX.UXControls
{
    public partial class OrderReceiptHistoryPage : UserControl
    {
        private readonly MosaicContext _ctx;
        private OrderReceiptRepository _service;
        private int _selectedOrderReceiptID;
        private int _selectedPurchaseOrderID;
        public OrderReceiptHistoryPage(MosaicContext context)
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.MouseDoubleClick += DataGridView1_MouseDoubleClick;
            Grids.BuildReceiptsHistoryGrid(dataGridView1);
            _ctx = context;
            _service = new OrderReceiptRepository(_ctx, Globals.CurrentUserName, Globals.CurrentLoggedUserID);

            tscboFilter.SelectedIndex = 1;
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenReceipt();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.Rows.Count > 0)
                {
                    _selectedOrderReceiptID = ((OrderReceiptHistoryDto)dv.CurrentRow.DataBoundItem).OrderReceiptID;
                    _selectedPurchaseOrderID= ((OrderReceiptHistoryDto)dv.CurrentRow.DataBoundItem).PurchaseOrderID;
                }

            }
          
        }



        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==7)
            {
                if (e.Value.ToString() == "ReceivedIncomplete")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cornsilk;
                }
            };
        }

        /// <summary>
        /// Filter the list of Order Receipts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            List<OrderReceiptHistoryDto> ordersHistory = new List<OrderReceiptHistoryDto>();

            switch (tscb.SelectedItem.ToString())
            {
                case "All":
                    ordersHistory = _service.ReceiptHistory(1);
                    this.dataGridView1.DataSource = ordersHistory;
                    tsRecordsReturned.Text = $" Records Returned {ordersHistory.Count.ToString()}";
                    break;
                case "Completed":

                   ordersHistory = _service.ReceiptHistory(2);
                   
                    this.dataGridView1.DataSource = ordersHistory.OrderByDescending(e => e.PurchaseOrderID).ToList();
                    tsRecordsReturned.Text = $" Records Returned {ordersHistory.Count.ToString()}";
                    break;
                case "Not Complete":

                    ordersHistory = _service.ReceiptHistory(3);
                    this.dataGridView1.DataSource = ordersHistory;
                    tsRecordsReturned.Text = $" Records Returned {ordersHistory.Count.ToString()}";
                    break;

                default:
                    break;

                   
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Name)
            {
                case "tsbViewReceipt":
                    OpenReceipt();
                    break;
                case "tsbOpenOrder":
                    if (_selectedOrderReceiptID != default)
                    {
                        Main main = (Main)Application.OpenForms["Main"];
                        main.OpenAnOrder(_selectedPurchaseOrderID);
                    }
                    break;
                default:
                    break;
            }
        }

        private void OpenReceipt()
        {
            OrderReceiptDto dto = _service.LoadOrderReciept(_selectedPurchaseOrderID);
            OrderReceiptViewerForm viewerForm = new OrderReceiptViewerForm();
            
            viewerForm.Text = $"Order Receipt - PO # {dto.PurchaseOrderID.ToString()}";
            OrderReciept orderReciept = new OrderReciept(dto,_ctx);
            viewerForm.Controls.Add(orderReciept);
            orderReciept.Dock = DockStyle.Fill;
            viewerForm.ShowDialog();
        }

        private void toolStripSplitButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            List<OrderReceiptHistoryDto> ordersHistory = new List<OrderReceiptHistoryDto>();
            switch (e.ClickedItem.Name)
            {
                case "tsSortByOrderDate":

                    ordersHistory = _service.ReceiptHistory(2);
                    this.dataGridView1.DataSource = ordersHistory.OrderByDescending(e => e.ReceivedOn).ToList();
                    tsRecordsReturned.Text = $" Records Returned {ordersHistory.Count.ToString()}";
                    break;
                case "tsSortByPurchaseOrderID":

                    ordersHistory = _service.ReceiptHistory(2);
                    this.dataGridView1.DataSource = ordersHistory.OrderByDescending(e => e.PurchaseOrderID).ToList();
                    tsRecordsReturned.Text = $" Records Returned {ordersHistory.Count.ToString()}";
                    break;

                default:
                    break;
            }
        }
    }
}
