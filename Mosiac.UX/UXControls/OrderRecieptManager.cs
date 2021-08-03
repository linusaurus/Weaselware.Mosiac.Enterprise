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
        private readonly MosaicContext _context;
        private readonly OrderReceiptRepository _orderReceiptRepository;
        private readonly SuppliersService _suppliersService;
        private OrderReceiptDto _orderRecieptDto = new OrderReceiptDto();
        private OrderReceiptMapper _orMapper = new OrderReceiptMapper();
        private int _selectedOrderID;
        private BindingSource bsOrderReceiptItems = new BindingSource();
        private OrderRecieptLineItemDto _selectedOrderRecieptLineItemDto;
        private int _orderState = 0;
        
        public OrderRecieptManager(MosaicContext context)
        {
            InitializeComponent();
            _context = context;   
            Grids.BuildPendingOrdersGrid(dgPendingOrders);
            Grids.BuildOrderReceiptItemsGrid(dgOrderReceiptItems);
            _orderReceiptRepository = new OrderReceiptRepository(_context);
            _suppliersService = new SuppliersService(_context);

            lbSuppliers.DataSource = _suppliersService.SuppliersWithOpenOrders();
            lbSuppliers.DisplayMember ="SupplierName";
           
            //----------------------------- Pending Grid ------------------------------------

            var orderReceipts = _orderReceiptRepository.UnRecievedOrders(1);         
            this.dgPendingOrders.DataSource = orderReceipts;

            ///////////////////////Event Wiring///////////////////////////////////////////////
            ///
            dgPendingOrders.SelectionChanged += DgPendingOrders_SelectionChanged;
            dgPendingOrders.CellFormatting += DgPendingOrders_CellFormatting;

            bsOrderReceiptItems.ListChanged += BsOrderReceiptItems_ListChanged;
            dgOrderReceiptItems.CellClick += DgOrderReceiptItems_CellClick;
            dgOrderReceiptItems.CellContentClick += DgOrderReceiptItems_CellContentClick;
            dgOrderReceiptItems.CellValueChanged += DgOrderReceiptItems_CellValueChanged;
            dgOrderReceiptItems.CellMouseUp += DgOrderReceiptItems_CellMouseUp;
            dgOrderReceiptItems.CellFormatting += DgOrderReceiptItems_CellFormatting;
            dgOrderReceiptItems.SelectionChanged += DgOrderReceiptItems_SelectionChanged;
        }

        private void DgOrderReceiptItems_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                _selectedOrderRecieptLineItemDto =  (OrderRecieptLineItemDto) dv.CurrentRow.DataBoundItem;
                this.textBox1.DataBindings.Clear();
                this.textBox1.DataBindings.Add("Text", _selectedOrderRecieptLineItemDto, "Note", true, DataSourceUpdateMode.OnPropertyChanged);
            }
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
                        row.DefaultCellStyle.ForeColor = Color.Yellow;
                        row.DefaultCellStyle.BackColor = Color.Cornsilk;
                        row.ReadOnly = true;
                    }

                }
            }
        }


        private void DgOrderReceiptItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            { dgOrderReceiptItems.EndEdit();
                dgOrderReceiptItems.InvalidateRow(e.RowIndex);
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
                       
                        dgOrderReceiptItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        dg.InvalidateRow(dg.CurrentRow.Index);
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
                        dg.InvalidateRow(e.RowIndex);
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
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                orToolStrip.Items[0].BackColor = Color.Cornsilk;           
            }
            // Grids.CheckForDirtyState(e,this.btnSave);
            _orderState = _orderRecieptDto.OrderState;
            lborderstatus.Text = $"Order-Status = {UpdateReceiptStatus(_orderState)}";
        }

        private string UpdateReceiptStatus(int orderStatus)
        {
            string result = string.Empty;
            switch (orderStatus)
            {
                case 1:
                    result = "Pending";
                    break;
                case 2:
                    result = "Order Complete";
                    break;
                case 3:
                    result = "Incomplete";
                    break;
                default:
                    break;
            }

            return result;

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
                        tsbOrderReciept.Text = "Create Order Receipt";
                    }
                    else
                    {
                        tsbOrderReciept.Text = "Open Order Receipt";
                    }
                    
                }
            }
        }

        #endregion

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

        private void ToogleToolStripButton()
        {

        }
        private void orToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsSaveChanges":

                    int orID = _orderReceiptRepository.UpdateOrCreate(_orderRecieptDto);
                    _orderRecieptDto = _orderReceiptRepository.GetOrderReceipt(orID);
                    BindOrderReceipt(_orderRecieptDto);
                    orToolStrip.Items[0].BackColor = DefaultBackColor;

                    break;
                // -- Generate a new or open existing  PO for entering qnty and inventory value
                case "tsbOrderReciept":
                    _orderRecieptDto = _orderReceiptRepository.LoadOrderReciept(_selectedOrderID);
                    BindOrderReceipt(_orderRecieptDto);
                    

                    break;
                // -- process the order reciept view and push item to inventory
                // -- foreach line of the order receipt, mark if the line is complete
                // -- and push the qnty recieved to inventory line by line
                case "tsbProccessInventory":
                    // loop orderReceipt items, calculate status of line item, set inventory amount, and resolution
                    // of the lineitem, is less that qnty order is received the it
                    foreach (var line in _orderRecieptDto.OrderReceiptLineItems)
                    {
                        // init a new inventory object
                        Inventory inv = new Inventory();
                        inv.OrderReceiptID = line.OrderReceiptID;
                        inv.DateStamp = DateTime.Now;
                        inv.Description = line.Description;
                        inv.JobID =  line.PurchaseOrderID;
                        inv.EmpID = _orderRecieptDto.EmployeeId;   
                        inv.LineID = line.LineID;
                        inv.TransActionType = (int)TransActionTypeCode.Recieve;
                        inv.Note = line.Note;
                        inv.QntyOrdered = line.QntyOrdered;
                        inv.QntyReceived = line.QntyReceived;
                        if (!line.Pushed )
                        {
                            inv.InventoryAmount = line.QntyToInventory;
                            line.Pushed = true;
                        }
                       
                        
                        
                        _context.Inventories.Add(inv);

                    }
                    _context.SaveChanges();
                    break;

                case "tsbPrintReceipt":
                    break;

                case "tsbBarCode":
                    break;

                default:
                    break;
            }
        }

        private void orToolStrip_Click(object sender, EventArgs e)
        {

        }
        

        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.DataSource != null)
            {
                int supplierid = ((Supplier)lb.SelectedItem).SupplierID;
                // Filter the list of unReceived Items -->
                dgPendingOrders.DataSource = _orderReceiptRepository.UnRecievedOrders(1, supplierid);
            }

        }

        private void btnRejectLineItem_Click(object sender, EventArgs e)
        {
            _selectedOrderRecieptLineItemDto.QntyReceived = Decimal.Zero;
            _selectedOrderRecieptLineItemDto.Description =$"{_selectedOrderRecieptLineItemDto.Description}  [REJECTED]";
            _selectedOrderRecieptLineItemDto.ItemsRecievedComplete = false;
            _selectedOrderRecieptLineItemDto.QntyBalance = _selectedOrderRecieptLineItemDto.QntyOrdered;
            dgOrderReceiptItems.InvalidateRow(dgOrderReceiptItems.CurrentRow.Index);
        }
    }
}
