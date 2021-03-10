using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class PendingOrdersGrid : DataGridView
    {
        public PendingOrdersGrid()
        {
            InitializeComponent();
            InitializeGrid(this);
        }

        private void InitializeGrid(DataGridView dg)
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
                col_ID.DataPropertyName = "PurchaserOrderID";
                col_ID.Width = 65;

                // Receipt Date Column --
                DataGridViewTextBoxColumn col_OrderDate = new DataGridViewTextBoxColumn();
                col_OrderDate.HeaderText = "Date";
                col_OrderDate.DataPropertyName = "OrderDate";
                col_OrderDate.Width = 95;

            // EmployeeName Column --
                DataGridViewTextBoxColumn col_Supplier = new DataGridViewTextBoxColumn();
                col_Supplier .HeaderText = "Supplier";
                col_Supplier .DataPropertyName = "Supplier";
                col_Supplier .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col_Supplier.DefaultCellStyle = dstyleWrapText;


                dg.Columns.AddRange(col_ID, col_Supplier, col_OrderDate);
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
