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
        private readonly OrdersService ordersService;
        private readonly SuppliersService _suppliersService;
        private OrderReceiptDto _orderRecieptDto = new OrderReceiptDto();
        private OrderReceiptMapper _orMapper = new OrderReceiptMapper();
        private int _selectedOrderID;
        private BindingSource bsOrderReceiptItems = new BindingSource();
        private OrderRecieptLineItemDto _selectedOrderRecieptLineItemDto;
     

        public OrderRecieptManager(MosaicContext context)
        {
            InitializeComponent();
            _context = context;
            Grids.BuildPendingOrdersGrid(dgPendingOrders);
            Grids.BuildOrderLineItemsGrid(dgOrderLineItems);
            _orderReceiptRepository = new OrderReceiptRepository(_context, Globals.CurrentUserName, Globals.CurrentLoggedUserID);
            ordersService = new OrdersService(_context);
            _suppliersService = new SuppliersService(_context);


            //----------------------------- Pending Grid ------------------------------------

            LoadOrders();

            #region Events

            ///////////////////////Event Wiring///////////////////////////////////////////////
            ///
            dgPendingOrders.SelectionChanged += DgPendingOrders_SelectionChanged;
            dgPendingOrders.CellFormatting += DgPendingOrders_CellFormatting;
            orToolStrip.ItemClicked += orToolStrip_ItemClicked;
            //bsOrderReceiptItems.ListChanged += BsOrderReceiptItems_ListChanged;
            //dgOrderReceiptItems.CellClick += DgOrderReceiptItems_CellClick;
            //dgOrderReceiptItems.CellContentClick += DgOrderReceiptItems_CellContentClick;
            //dgOrderReceiptItems.CellValueChanged += DgOrderReceiptItems_CellValueChanged;
            //dgOrderReceiptItems.CellMouseUp += DgOrderReceiptItems_CellMouseUp;
            //dgOrderReceiptItems.CellFormatting += DgOrderReceiptItems_CellFormatting;

            #endregion

        }

        private void LoadOrders()
        {
            DataTable dt = new DataTable();
            dt = ServiceLayer.DataBuilders.BuildDataTable(_orderReceiptRepository.UnRecievedOrders());
            dgPendingOrders.DataSource = dt.DefaultView;
        }

        private void RefreshOrders()
        {

        }
        #region Grid-BindingSource Event Handlers ----------++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void DgPendingOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DataGridView dg = (DataGridView)sender;
            //if (dg.DataSource != null)
            //{
            //    if (dg.Rows.Count > 0)
            //    {
            //        DataGridViewRow row = dg.Rows[e.RowIndex];
            //        PendingOrdersDto dat = (PendingOrdersDto)row.DataBoundItem;
            //        if (dat.OrderState == 1 || dat.OrderState == 2)
            //        {
            //            row.DefaultCellStyle.ForeColor = Color.Black;
            //            row.DefaultCellStyle.BackColor = Color.White;
            //            row.ReadOnly = true;
            //        }
            //        else if (dat.OrderState == 2)
            //        {
            //            row.DefaultCellStyle.ForeColor = Color.Gray;
            //            row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            //            row.ReadOnly = true;
            //        }
            //        else if (dat.OrderState == 3)
            //        {
            //            row.DefaultCellStyle.ForeColor = Color.Yellow;
            //            row.DefaultCellStyle.BackColor = Color.Black;
            //            row.ReadOnly = true;
            //        }

            //    }
            //}
        }


        //private void DgOrderReceiptItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.ColumnIndex == 8 && e.RowIndex != -1)
        //    { dgOrderReceiptItems.EndEdit();
        //        dgOrderReceiptItems.InvalidateRow(e.RowIndex);
        //    }
        //}

        //private void DgOrderReceiptItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    DataGridView dg = (DataGridView)sender;
        //    if (dg.DataSource != null)
        //    {
        //        if (dg.Rows.Count > 0)
        //        {
        //            DataGridViewRow row = dg.Rows[e.RowIndex];
        //            OrderRecieptLineItemDto dat = (OrderRecieptLineItemDto)row.DataBoundItem;
        //            if (dat.ItemsRecievedComplete && dat.QntyToInventory > decimal.Zero)
        //            {
        //                row.DefaultCellStyle.ForeColor = Color.White;
        //                row.DefaultCellStyle.BackColor = Color.LightGray;
        //                //row.ReadOnly = true;
        //            }
        //        }
        //    }
        //}

        //private void DgOrderReceiptItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridView dg = (DataGridView)sender;
        //    if (dg.DataSource != null)
        //    {
        //        if (dg.Rows.Count > 0)
        //        {
        //            if (e.ColumnIndex == 4)
        //            {
        //                DataGridViewRow row = dg.CurrentRow;
        //                OrderRecieptLineItemDto dat = (OrderRecieptLineItemDto)row.DataBoundItem;

        //                dgOrderReceiptItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //                dg.InvalidateRow(dg.CurrentRow.Index);
        //            }
        //        }
        //    }
        //}

        //private void DgOrderReceiptItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridView dg = (DataGridView)sender;
        //    if (dg.DataSource != null)
        //    {        
        //        if (dg.Rows.Count > 0)
        //        {
        //            if (e.ColumnIndex == 4)
        //            {                        
        //                DataGridViewRow row = dg.CurrentRow;
        //                BindingContext[dg.DataSource].EndCurrentEdit();                     
        //                bsOrderReceiptItems.ResetBindings(true);
        //                dg.InvalidateRow(e.RowIndex);
        //            }              
        //        }
        //    }
        //}

        //private void DgOrderReceiptItems_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridView dg = (DataGridView)sender;
        //    if (dg.DataSource != null)
        //    {  
        //        if (dg.Rows.Count > 0)
        //        {
        //            if (e.ColumnIndex != 3)
        //            {
        //                DataGridViewRow row = dg.CurrentRow;
        //                BindingContext[dg.DataSource].EndCurrentEdit();
        //                dg.Refresh();
        //            }

        //        }
        //    }
        //}

        //private void BsOrderReceiptItems_ListChanged(object sender, ListChangedEventArgs e)
        //{
        //    if (e.ListChangedType == ListChangedType.ItemChanged)
        //    {
        //        orToolStrip.Items[3].BackColor = Color.Cornsilk;           
        //    }
        //    // Grids.CheckForDirtyState(e,this.btnSave);
        //    _orderState = _orderRecieptDto.OrderState;
        //    lborderstatus.Text = $"Order-Status = {UpdateReceiptStatus(_orderState)}";
        //}

        //private string UpdateReceiptStatus(int orderStatus)
        //{
        //    string result = string.Empty;
        //    switch (orderStatus)
        //    {
        //        case 1:
        //            result = "Pending";
        //            break;
        //        case 2:
        //            result = "Order Complete";
        //            break;
        //        case 3:
        //            result = "Incomplete";
        //            break;
        //        default:
        //            break;
        //    }

        //    return result;

        //}

        //private void ButtonSwitcher(int btnState)
        //{
        //    for (int i = 0; i < 6; i++)
        //    { 
        //        orToolStrip.Items[i].BackColor = DefaultBackColor;

        //    }
        //    //-------------------------------------------------------++
        //    switch (btnState)
        //    {
        //        case  0: // Ready for Recieving
        //            orToolStrip.Items[0].BackColor = Color.Cornsilk; // Open receipt button only
        //            orToolStrip.Items[1].Visible = false;
        //            orToolStrip.Items[2].Visible = false;
        //            orToolStrip.Items[3].Visible = false;
        //            orToolStrip.Items[4].Visible = false;
        //            orToolStrip.Items[5].Visible = false;
        //            break;
        //        case 1: // In Receiving Mode
        //            orToolStrip.Items[0].Visible = false;
        //            orToolStrip.Items[1].BackColor = Color.Cornsilk;
        //            orToolStrip.Items[1].Visible = true;
        //            orToolStrip.Items[2].Visible = true;
        //            orToolStrip.Items[3].Visible = true;
        //            orToolStrip.Items[4].Visible = false;
        //            orToolStrip.Items[5].Visible = false;
        //            break;
        //        case 2:
        //            break;
        //        case 3:
        //            break;
        //        default:
        //            break;
        //    }

        //}

        //private int GetOrderState(OrderReceiptDto orderReceiptDto)
        //{
        //    //int resultState = 0;

        //    //bool linesIncomplete =  orderReceiptDto.OrderReceiptLineItems.Any(r => r.ItemsRecievedComplete == false);
        //    //// If any lineitems are not completet the make state as ReceivedIncomplete --

        //    //if (linesIncomplete)
        //    //{ resultState = 3;}
        //    //// the lines are all recieved so mark state as ReceivedComplete

        //    //else if(!linesIncomplete)
        //    //{resultState = 2;}

        //    //return resultState;
        //}

        #endregion

        private void DgPendingOrders_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    if (dg.CurrentRow != null)
                    {
                        _selectedOrderID = (int)dg.CurrentRow.Cells[0].Value;
                        PopulateOrderItems(_selectedOrderID);
                    }
   
                }
            }
        }

        private void PopulateOrderItems(int selectedOrderID)
        {
            var lineItems  = ordersService.GetLineItems(_selectedOrderID);
            dgOrderLineItems.DataSource = lineItems;
        }

        private void ToogleToolStripButton()
        {

        }
        private void orToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {

                case "tsbOrderReciept":

                    _orderRecieptDto = _orderReceiptRepository.LoadOrderReciept(_selectedOrderID);


                    OrderRecieptForm frm = new OrderRecieptForm(_selectedOrderID, _context);
                    frm.Width = 1200;
                    frm.Height = 600;
                    frm.Text = $"Recieve Order :{ _selectedOrderID.ToString()}";
                    frm.StartPosition = FormStartPosition.CenterScreen;
                   
                    frm.ShowDialog();
                    //Reload changed Orders list --
                    LoadOrders();
                    break;
  
                case "tsOpenOrder":

                    
                    Main main = (Main)Application.OpenForms["Main"];
                    main.OpenAnOrder(_selectedOrderID);
                    break;

                case "tsbPrintReceipt":
                    break;

                default:
                    break;
            }
        }

        private void orToolStrip_Click(object sender, EventArgs e)
        {

        }
        
        // Select POs from the selected Suppliers ------------------++
        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.DataSource != null)
            {
                int supplierid = ((Supplier)lb.SelectedItem).SupplierID;
                // Filter the list of unReceived Items -->
                dgPendingOrders.DataSource = _orderReceiptRepository.UnRecievedOrders();
            }

        }

        private void btnRejectLineItem_Click(object sender, EventArgs e)
        {
            _selectedOrderRecieptLineItemDto.QntyReceived = Decimal.Zero;
            _selectedOrderRecieptLineItemDto.Description =$"{_selectedOrderRecieptLineItemDto.Description}  [REJECTED]";
            _selectedOrderRecieptLineItemDto.ItemsRecievedComplete = false;
            _selectedOrderRecieptLineItemDto.QntyBalance = _selectedOrderRecieptLineItemDto.QntyOrdered;
        
        }

        private void tsSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void spcMainContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderRecieptManager_Load(object sender, EventArgs e)
        {

        }

       
    }
}
