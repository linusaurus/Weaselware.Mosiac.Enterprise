using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dapper;
using DataLayer.Data;
using ServiceLayer;
using ServiceLayer.Models;
using Mosiac.UX.Forms;

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
            var ordersHistory = _service.ReceiptHistory();
            this.dataGridView1.DataSource = ordersHistory;
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
            switch (tscb.SelectedItem.ToString())
            {
                case "All":

                    break;
                case "Completed":
                    break;
                case "Not Complete":
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
            OrderReciept orderReciept = new OrderReciept(dto);
            viewerForm.Controls.Add(orderReciept);
            orderReciept.Dock = DockStyle.Fill;
            viewerForm.ShowDialog();
        }
    }
}
