using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class OrderRecieptGrid : System.Windows.Forms.DataGridView
    {
        public OrderRecieptGrid()
        {
            InitializeComponent();
            Build(this);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void Build(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // OrderReceiptID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "OrderReceiptID";
            col_ID.Width = 55;

            // EmployeeName Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Employee";
            col_Description.DataPropertyName = "EmployeeName";
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_Description.DefaultCellStyle = dstyleWrapText;

            // PurchaseOrderID Column --
            DataGridViewTextBoxColumn col_PO = new DataGridViewTextBoxColumn();
            col_PO.HeaderText = "PO#";
            col_PO.DataPropertyName = "PurchaseOrderID";
            col_PO.Width = 90;

            // IsComplete Column --

            DataGridViewCheckBoxColumn col_IsComplete = new DataGridViewCheckBoxColumn();
            col_IsComplete.HeaderText = "Complete";
            col_IsComplete.DataPropertyName = "IsOrderComplete";
            col_IsComplete.Width = 90;

            // Receipt Date Column --
            DataGridViewTextBoxColumn colOrders = new DataGridViewTextBoxColumn();
            colOrders.HeaderText = "Date";
            colOrders.DataPropertyName = "ReceiptDate";
            colOrders.Width = 95;

            dg.Columns.AddRange(col_ID, col_Description, col_PO, col_IsComplete, colOrders);
        }
    }
}
