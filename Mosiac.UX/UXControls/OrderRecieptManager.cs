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
using Mosiac.UX.Services;
using static System.Windows.Forms.AxHost;

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
            _orderReceiptRepository = new OrderReceiptRepository(_context, Mosiac.UX.Services.Globals.CurrentUserName, Mosiac.UX.Services.Globals.CurrentLoggedUserID);
            ordersService = new OrdersService(_context);
            //EmployeeService employeeService = new EmployeeService(_context);
            _suppliersService = new SuppliersService(_context);

            //----------------------------- Pending Grid ------------------------------------

            LoadOrders(OrderReceiptStates.Unreceived);
            LoadReceiptSuppliers();

            #region Events

            ///////////////////////Event Wiring///////////////////////////////////////////////
            ///
            dgPendingOrders.SelectionChanged += DgPendingOrders_SelectionChanged;
            dgPendingOrders.CellFormatting += DgPendingOrders_CellFormatting;
            orToolStrip.ItemClicked += orToolStrip_ItemClicked;

            #endregion

            tsbFilter.SelectedIndex = 0;
        }
        /// <summary>
        /// this Populates the order to recevie list -->>
        /// </summary>
        /// <param name="state"></param>
        private void LoadOrders(OrderReceiptStates state)
        {
            DataTable dt = new DataTable();
            dt = ServiceLayer.DataBuilders.BuildDataTable(_orderReceiptRepository.UnRecievedOrders(state));
            // table = dt.AsEnumerable().Where(row => row.Field<String>("Supplier").Contains("Aba")).CopyToDataTable();
            DataView dv = new DataView(dt);
            dgPendingOrders.DataSource = dv;
        }

        private void RefreshOrders()
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {
                int ordernumber;
                if (int.TryParse(tsSearchEntry.Text, out ordernumber))
                {
                    if ( ordernumber != default)
                    {
                        _orderRecieptDto = _orderReceiptRepository.LoadOrderReciept(ordernumber);

                        OrderRecieptForm frm = new OrderRecieptForm(ordernumber, _context);
                        frm.Width = 1200;
                        frm.Height = 600;
                        frm.Text = $"Recieve Order :{ordernumber.ToString()}";
                        frm.StartPosition = FormStartPosition.CenterScreen;

                        frm.ShowDialog();
                        //Reload changed Orders list --
                        LoadOrders(currentFilter);
                    }

                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #region Grid-BindingSource Event Handlers ----------++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void DgPendingOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            DataRowView drv = (DataRowView)dg.Rows[e.RowIndex].DataBoundItem;

            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    DataRow row = drv.Row;
                    DataGridViewRow r = dg.Rows[e.RowIndex];

                    int dat = (int)row["OrderState"];
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
                    }
                }
            }
        }

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

        private void LoadReceiptSuppliers()
        {
            var sups = _suppliersService.SuppliersWithOpenOrders();
            foreach (var sup in sups)
            {
                tsComboSupplier.Items.Add(sup.SupplierName);
            }
        }



        private void PopulateOrderItems(int selectedOrderID)
        {
            var lineItems = ordersService.GetLineItems(_selectedOrderID);
            dgOrderLineItems.DataSource = lineItems;
        }

        private void ToogleToolStripButton()
        {

        }
        private void orToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                // Receive the Order- retrieve Order ReceiptDTO
                case "tsbOrderReciept":

                    _orderRecieptDto = _orderReceiptRepository.LoadOrderReciept(_selectedOrderID);

                    OrderRecieptForm frm = new OrderRecieptForm(_selectedOrderID, _context);
                    frm.Width = 1200;
                    frm.Height = 600;
                    frm.Text = $"Recieve Order :{_selectedOrderID.ToString()}";
                    frm.StartPosition = FormStartPosition.CenterScreen;

                    frm.ShowDialog();
                    //Reload changed Orders list --
                    LoadOrders(currentFilter);
                    break;

                case "tsOpenOrder":


                    Main main = (Main)Application.OpenForms["Main"];
                    main.OpenAnOrder(_selectedOrderID);
                    break;

                case "tsPrintSettings":
                    PrintJobDialog diaglog = new PrintJobDialog();
                    diaglog.ShowDialog();

                    break;

                case "tsbShowLates":

                    break;

                case "tsbPrintReceipt":
                    break;
                case "tsRequestStatus":
                    //if (_selectedOrderID != default)
                    //{
                    //    PurchaseOrder po = ordersService.GetOrderByID(_selectedOrderID);
                    //    OrderDetailDto dto = new OrderDetailDto();
                    //    PurchaseOrderMapper mapper = new PurchaseOrderMapper();
                    //    mapper.Map(po, dto);
                    //    Employee emp = _context.Employee.Find(dto.EmployeeID);
                    //    string emailAdress = emp.EmployeeEmail.ToString();
                    //    NotificationService.SendUpdateRequest(emailAdress, dto);
                    //}
                    break;
                case "tscboPickSupplier":


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
            _selectedOrderRecieptLineItemDto.Description = $"{_selectedOrderRecieptLineItemDto.Description}  [REJECTED]";
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
            ToolStripComboBox cbo = (ToolStripComboBox)sender;
            string pick = cbo.SelectedItem.ToString();

        }



        private void tsComboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = tsComboSupplier.SelectedItem as string;
            DataTable dt = new DataTable();
            DataTable table;
            dt = ServiceLayer.DataBuilders.BuildDataTable(_orderReceiptRepository.UnRecievedOrders(OrderReceiptStates.Unreceived));
            try
            {

                if (dt.AsEnumerable().Where(row => row.Field<String>("Supplier").Contains(result)).Count() > 0)
                {
                    table = dt.AsEnumerable().Where(row => row.Field<String>("Supplier").Contains(result)).CopyToDataTable();
                    DataView dv = new DataView(table);
                    dgPendingOrders.DataSource = dv;
                }
                else
                {
                    MessageBox.Show("Supplier has no existing Orders", "Search Result Error");
                }

            }
            catch (Exception)
            {

                throw;
            }



        }

     
    }
}
