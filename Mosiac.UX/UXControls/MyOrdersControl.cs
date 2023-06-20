using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;

namespace Mosiac.UX.UXControls
{
    public partial class MyOrdersControl : UserControl
    {
        private readonly OrdersService _ordersService;
        private readonly EmployeeService _employeeService;
        private readonly MosaicContext ctx;
        private PurchaseOrderToOrderReceiptMapper orderMapper;
        private int _employeeID;
        private int _selectedOrderId;
        private bool _showRecieved;

        public MyOrdersControl(MosaicContext context, int employeeID)
        {
            InitializeComponent();
            ctx = context;
            _employeeID = employeeID;
            _ordersService = new OrdersService(ctx);
            _employeeService = new EmployeeService(ctx);
            orderMapper = new PurchaseOrderToOrderReceiptMapper();
            //---
            dgMyOrdersGrid.AutoGenerateColumns = false;
            //---
            dgMyOrdersGrid.CellFormatting += DgMyOrdersGrid_CellFormatting;
            dgMyOrdersGrid.CellContentClick += DgMyOrdersGrid_CellContentClick;
            dgMyOrdersGrid.CellValueChanged += DgMyOrdersGrid_CellValueChanged;
        }

        private void DgMyOrdersGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMyOrdersGrid.DataSource != null)
            {
                if (e.ColumnIndex == 5 && e.RowIndex != -1)  // It the Recieved checkbox
                {

                    if (dgMyOrdersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                    {
                        int po = _selectedOrderId;
                        //---- Recieve the order
                        ctx.Database.ExecuteSqlRaw("dbo.sproc_recieved_order {0}, {1}", po, _employeeID);
                        this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, false);
                        // Push the lineitem into inventory
                        ctx.Database.ExecuteSqlRaw("dbo.pushlines {0} , {1}", po, _employeeID);
                        var order = _ordersService.GetOrderByID(_selectedOrderId);
                        OrderReceiptDto dto = new OrderReceiptDto();
                        orderMapper.Map(order, dto);

                        var emp = _employeeService.Find(order.EmployeeID.GetValueOrDefault());
                        emp.EmployeeEmail.ToString();
                        NotificationService.SendNotificaion(emp.EmployeeEmail.ToString(), dto);

                    }

                }
            }

        }

        private void DgMyOrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dgMyOrdersGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {
                int ordernumber;
                if (int.TryParse(txtOrderNumber.Text, out ordernumber))
                {
                    if (_ordersService.GetOrderByID(ordernumber) != null)
                    {
                        Main main = (Main)Application.OpenForms["Main"];
                        main.OpenAnOrder(ordernumber);
                    }

                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void DgMyOrdersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Compare the column to the column you want to format
            if (this.dgMyOrdersGrid.Columns[e.ColumnIndex].Name == "colRecieved")
            {
                //get the IChessitem you are currently binding, using the index of the current row to access the datasource
                OrderListDto item = (OrderListDto)dgMyOrdersGrid.Rows[e.RowIndex].DataBoundItem;
                //check the condition
                if (item.Recieved == true)
                {
                    dgMyOrdersGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PeachPuff;
                }
            }
        }

        private void MyOrdersControl_Load(object sender, EventArgs e)
        {
            cbJobName.DataSource = _employeeService.Active();
            cbJobName.DisplayMember = "FullName";
            cbJobName.ValueMember = "EmployeeID";
            this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, _showRecieved);
            cbJobName.SelectedValue = _employeeID;
        }

        private void dgMyOrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    _selectedOrderId = ((OrderListDto)dg.CurrentRow.DataBoundItem).PurchaseOrderID;
                }
            }
        }
        /// <summary>
        /// Open the selected Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgMyOrdersGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectedOrderId != default)
            {
                Main main = (Main)Application.OpenForms["Main"];
                main.OpenAnOrder(_selectedOrderId);
            }
        }



        private void cbJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.DataSource != null)
            {
                if (cb.SelectedIndex > 0)
                {
                    _employeeID = (int)cb.SelectedValue;
                    this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, _showRecieved);
                }
                else
                {
                    this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(81, _showRecieved);
                }


            }
        }

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            int ordernumber;
            if (int.TryParse(txtOrderNumber.Text, out ordernumber))
            {
                if (_ordersService.GetOrderByID(ordernumber) != null)
                {
                    Main main = (Main)Application.OpenForms["Main"];
                    main.OpenAnOrder(ordernumber);
                }
            }


        }
        // Show all Employee even prior employees
        private void ckbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                cbJobName.DataSource = _employeeService.All();

            }
            else if (!cb.Checked)
            {
                cbJobName.DataSource = _employeeService.Active();
            }
        }

        private void ckbShowRecieved_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, _showRecieved);
        }
        // Show order both recieved and pending for Active Users
        private void cbxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                _showRecieved = false;
                this.dgMyOrdersGrid.DataSource = _ordersService.GetAllMyOrdersList(_employeeID);
            }
            else if (!cb.Checked)
            {
                this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, false);

            }
        }

        private void cbxShowReturned_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.dgMyOrdersGrid.DataSource = _ordersService.GetReturnedOrders(_employeeID);
            }


        }
        // View Filters --------------------------------------------------------------------
        #region View Filters
        private void rbShowReceived_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked) { this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, true); }
        }

        private void rbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked) { this.dgMyOrdersGrid.DataSource = _ordersService.GetAllMyOrdersList(_employeeID); }
        }

        private void rbShowReturned_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked) { this.dgMyOrdersGrid.DataSource = _ordersService.GetReturnedOrders(_employeeID); }
        }

        private void rbOutStanding_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked) { this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, false); }
        }
        #endregion
    }
}
