using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;

namespace Mosiac.UX.UXControls
{
    public partial class MyOrdersControl : UserControl
    {
        private readonly OrdersService _ordersService;
        private readonly EmployeeService _employeeService;
        private readonly MosaicContext ctx;
        private int _employeeID;
        private int _selectedOrderId;
        private bool _showRecieved = false;

        public MyOrdersControl(MosaicContext context, int employeeID)
        {
            InitializeComponent();
            ctx = context;
            _employeeID = employeeID;
            _ordersService = new OrdersService(ctx);
            _employeeService = new EmployeeService(ctx);
            //---
            dgMyOrdersGrid.AutoGenerateColumns = false;
            //---
            dgMyOrdersGrid.CellFormatting += DgMyOrdersGrid_CellFormatting;
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
                    dgMyOrdersGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cornsilk;
                }
            }
        }

        private void MyOrdersControl_Load(object sender, EventArgs e)
        {

            cbJobName.DataSource = _employeeService.All();
            cbJobName.DisplayMember = "FullName";
            cbJobName.ValueMember = "EmployeeID";
            this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, _showRecieved);
            cbJobName.SelectedValue = _employeeID;
        }

        private void dgMyOrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView) sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    _selectedOrderId = ((OrderListDto)dg.CurrentRow.DataBoundItem).PurchaseOrderID;
                }
            }
        }

        private void dgMyOrdersGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectedOrderId != default)
            {
                Main2 main = (Main2)Application.OpenForms["Main"];
                main.OpenAnOrder(_selectedOrderId);
            }
        }

        private void ckbShowRecieved_CheckedChanged(object sender, EventArgs e)
        {
           CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            { _showRecieved = true; }

            else
            { _showRecieved = false; }

            this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, _showRecieved);
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
            }
        }

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
           int ordernumber;
           if (int.TryParse(txtOrderNumber.Text, out ordernumber))
           {
                Main2 main = (Main2)Application.OpenForms["Main"];
                main.OpenAnOrder(ordernumber);
           }
            

        }
    }
}
