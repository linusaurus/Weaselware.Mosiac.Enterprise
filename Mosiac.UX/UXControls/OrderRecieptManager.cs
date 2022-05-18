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
using ServiceLayer.Enums;
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
        private OrderReceiptStates currentFilter = OrderReceiptStates.Unreceived;

        

        public OrderRecieptManager(MosaicContext context)
        {
            InitializeComponent();
            _context = context;
            Grids.BuildPendingOrdersGrid(dgPendingOrders);
            Grids.BuildOrderLineItemsGrid(dgOrderLineItems);
            _orderReceiptRepository = new OrderReceiptRepository(_context, Globals.CurrentUserName, Globals.CurrentLoggedUserID);
            ordersService = new OrdersService(_context);
            //EmployeeService employeeService = new EmployeeService(_context);

            _suppliersService = new SuppliersService(_context);
            
  

            //----------------------------- Pending Grid ------------------------------------

            LoadOrders(OrderReceiptStates.Unreceived);

            #region Events

            ///////////////////////Event Wiring///////////////////////////////////////////////
            ///
            dgPendingOrders.SelectionChanged += DgPendingOrders_SelectionChanged;
            dgPendingOrders.CellFormatting += DgPendingOrders_CellFormatting;
            orToolStrip.ItemClicked += orToolStrip_ItemClicked;

            #endregion

            tsbFilterCombo.SelectedIndex = 0;
        }

        private void LoadOrders(OrderReceiptStates state)
        {
            DataTable dt = new DataTable();
            dt = ServiceLayer.DataBuilders.BuildDataTable(_orderReceiptRepository.UnRecievedOrders(state));
            dgPendingOrders.DataSource = dt.DefaultView;
        }

        private void RefreshOrders()
        {

        }
        #region Grid-BindingSource Event Handlers ----------++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void DgPendingOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            DataRowView drv = (DataRowView) dg.Rows[e.RowIndex].DataBoundItem;

            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    //DataGridViewRow row = dg.Rows[e.RowIndex];
                    DataRow row = drv.Row;
                    DataGridViewRow r = dg.Rows[e.RowIndex];
                    //DateTime age = (DateTime)row["OrderDate"];
                    //System.TimeSpan diff = DateTime.Today.Subtract(age);


                    int dat =(int) row["OrderState"];
                    if (dat == 1 || dat == 2)
                    {
                        r.DefaultCellStyle.ForeColor = Color.Black;
                        r.DefaultCellStyle.BackColor = Color.White;
                        r.ReadOnly = true;
                    }
                    else if (dat == 2)
                    {
                        r.DefaultCellStyle.ForeColor = Color.Gray;
                        r.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        r.ReadOnly = true;
                    }
                    else if (dat == 3)
                    {
                        r.DefaultCellStyle.ForeColor = Color.Yellow;
                        r.DefaultCellStyle.BackColor = Color.Black;
                        r.ReadOnly = true;
                    }
                   

                }
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
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        //row.ReadOnly = true;
                    }
                }
            }
        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {
                // Find the Order to receive based on po entered
                if (tsSearchEntry.Text.Length > 0)
                {
                    int k = int.Parse(tsSearchEntry.Text);
                    
                    DataTable dt = new DataTable();
                    dt = ServiceLayer.DataBuilders.BuildDataTable(_orderReceiptRepository.FilterOrders(k));
                    dgPendingOrders.DataSource = dt.DefaultView;
                }

                return true;
            }
            if (keyData == Keys.Escape )

            {
                // Clear textbox and restore list
                tsSearchEntry.Clear();
                LoadOrders(currentFilter);
               

                return true;
            }
            else
            {
         
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

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
                    LoadOrders(currentFilter);
                    break;
  
                case "tsOpenOrder":

                    
                    Main main = (Main)Application.OpenForms["Main"];
                    main.OpenAnOrder(_selectedOrderID);
                    break;

                case "tsbShowLates":

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
                dgPendingOrders.DataSource = _orderReceiptRepository.UnRecievedOrders(currentFilter);
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

        private void tsbFilterCombo_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           ToolStripComboBox tsbFilterCombo = (ToolStripComboBox)sender;
           var selection = tsbFilterCombo.SelectedItem as string;
           if (selection != null)
            {
                switch (selection)
                {
                    case "Pending":
                        currentFilter = OrderReceiptStates.Unreceived;
                        LoadOrders(currentFilter);

                        break;
                    case "InComplete":
                        currentFilter = OrderReceiptStates.Partial;
                        LoadOrders(currentFilter);
                        break;

                    case "30 day":
                        currentFilter = OrderReceiptStates.Month;
                        LoadOrders(currentFilter);
                        break;

                    default:
                        break;
                }
            }
        
        }

        private void tscboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
           ToolStripComboBox cbo =  (ToolStripComboBox)sender;  
            string pick = cbo.SelectedItem.ToString();

        }
    }
}
