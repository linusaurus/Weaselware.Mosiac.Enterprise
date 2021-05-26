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
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;


namespace Mosiac.UX.UXControls
{
    public partial class OrderRecieptManager : UserControl
    {

        private readonly OrderReceiptRepository _orderReceiptRepository;
        private OrderReceiptDto _orderRecieptDto = new OrderReceiptDto();
        private OrderReceiptMapper _orMapper = new OrderReceiptMapper();
        private int _selectedOrderID;
        private BindingSource bsOrderReceiptItems = new BindingSource();

        public OrderRecieptManager()
        {
            InitializeComponent();
            Grids.BuildPendingOrdersGrid(dgPendingOrders);
            Grids.BuildOrderReceiptItemsGrid(dgOrderReceiptItems);
            _orderReceiptRepository = new OrderReceiptRepository(new MosaicContext());
            //----------------------------- Pending Grid ------------------------------------

            var orderReceipts = _orderReceiptRepository.PendingOrders();         
            this.dgPendingOrders.DataSource = orderReceipts;

            //------------------------------Event Wiring---------------------------------------
            dgPendingOrders.SelectionChanged += DgPendingOrders_SelectionChanged;
            dgPendingOrders.CellFormatting += DgPendingOrders_CellFormatting;

            bsOrderReceiptItems.ListChanged += BsOrderReceiptItems_ListChanged;
            dgOrderReceiptItems.CellClick += DgOrderReceiptItems_CellClick;
            dgOrderReceiptItems.CellContentClick += DgOrderReceiptItems_CellContentClick;
            dgOrderReceiptItems.CellValueChanged += DgOrderReceiptItems_CellValueChanged;
            dgOrderReceiptItems.CellMouseUp += DgOrderReceiptItems_CellMouseUp;
            dgOrderReceiptItems.CellFormatting += DgOrderReceiptItems_CellFormatting;

        }



        #region Grid-BindingSource Event Handlers ----------++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void DgPendingOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    DataGridViewRow row = dg.Rows[e.RowIndex];
                    PendingOrdersDto dat = (PendingOrdersDto)row.DataBoundItem;
                    if (dat.OrderState == 1 || dat.OrderState == 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.ReadOnly = true;
                    }
                    else if (dat.OrderState == 2)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        row.ReadOnly = true;
                    }
                    else if (dat.OrderState == 3)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        row.ReadOnly = true;
                    }

                }
            }
        }


        private void DgOrderReceiptItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            { dgOrderReceiptItems.EndEdit();               
            }
        }

        private void DgOrderReceiptItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    DataGridViewRow row = dg.Rows[e.RowIndex];
                    OrderRecieptLineItemDto dat = (OrderRecieptLineItemDto)row.DataBoundItem;
                    if (dat.ItemsRecievedComplete && dat.QntyToInventory > decimal.Zero)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.BackColor = Color.Gainsboro;
                        row.ReadOnly = true;
                    }
                }
            }
        }

        private void DgOrderReceiptItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    if (e.ColumnIndex == 4)
                    {
                        DataGridViewRow row = dg.CurrentRow;
                        OrderRecieptLineItemDto dat = (OrderRecieptLineItemDto)row.DataBoundItem;
                       // dat.ItemsRecievedComplete = true;
                        dgOrderReceiptItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    }
                }
            }
        }

        private void DgOrderReceiptItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {        
                if (dg.Rows.Count > 0)
                {
                    if (e.ColumnIndex == 4)
                    {                        
                        DataGridViewRow row = dg.CurrentRow;
                        BindingContext[dg.DataSource].EndCurrentEdit();                     
                        bsOrderReceiptItems.ResetBindings(true);
                    }              
                }
            }
        }

        private void DgOrderReceiptItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {  
                if (dg.Rows.Count > 0)
                {
                    if (e.ColumnIndex != 3)
                    {
                        DataGridViewRow row = dg.CurrentRow;
                        BindingContext[dg.DataSource].EndCurrentEdit();
                        dg.Refresh();
                    }
             
                }
            }
        }

        private void BsOrderReceiptItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e,this.btnSave);
        }

        private void DgPendingOrders_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    _selectedOrderID  = ((PendingOrdersDto)dg.CurrentRow.DataBoundItem).PurchaseOrderID;
                    if (((PendingOrdersDto)dg.CurrentRow.DataBoundItem).OrderState ==1)
                    {
                        btnReceiveOrder.Text = "Create Order Receipt";
                    }
                    else
                    {
                        btnReceiveOrder.Text = "Open Order Receipt";
                    }
                    
                }
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            int orID =  _orderReceiptRepository.UpdateOrCreate(_orderRecieptDto);
            _orderRecieptDto = _orderReceiptRepository.GetOrderReceipt(orID);
            BindOrderReceipt(_orderRecieptDto);
            Grids.ToogleButtonStyle(false, btnSave);
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            _orderRecieptDto = _orderReceiptRepository.ReceiveOrder(_selectedOrderID);
            BindOrderReceipt(_orderRecieptDto);
        }

 
        private void BindOrderReceipt(OrderReceiptDto dto)
        {

            bsOrderReceiptItems.DataSource = dto.OrderReceiptLineItems ?? null;
            dgOrderReceiptItems.DataSource = bsOrderReceiptItems.DataSource;

            txtPurchaseOrderID.DataBindings.Clear();
            txtPurchaseOrderID.DataBindings.Add("Text",dto, "PurchaseOrderID", true);

            txtOrderReceiptID.DataBindings.Clear();
            txtOrderReceiptID.DataBindings.Add("Text", dto, "OrderReceiptId", true);

            txtOrderReceiptDate.DataBindings.Clear();
            txtOrderReceiptDate.DataBindings.Add("Text", dto, "ReceiptDate", true);

            txtReceivedBy.DataBindings.Clear();
            txtReceivedBy.DataBindings.Add("Text", dto, "EmployeeName", true);

            ckbCompleted.DataBindings.Clear();
            ckbCompleted.DataBindings.Add("Checked", dto, "IsOrderComplete", true);
        }

        private int GetOrderState(OrderReceiptDto orderReceiptDto)
        {
            int resultState = 0;

            bool linesIncomplete =  orderReceiptDto.OrderReceiptLineItems.Any(r => r.ItemsRecievedComplete == false);
            // If any lineitems are not completet the make state as ReceivedIncomplete --

            if (linesIncomplete)
            { resultState = 3;}
            // the lines are all recieved so mark state as ReceivedComplete

            else if(!linesIncomplete)
            {resultState = 2;}

            return resultState;
        }

        private void OrderRecieptManager_Load(object sender, EventArgs e)
        {

        }
    }
}
