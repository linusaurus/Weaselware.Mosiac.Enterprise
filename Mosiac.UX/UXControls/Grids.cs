using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public class Grids
    {
        private static bool isDirty;

        public static bool IsDirty
        {
            get { return isDirty; }
            set 
            {
                isDirty = value;
                
            }
        }
        public static void BuildOrderReceiptItemsGrid(DataGridView dg)
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

            // PartID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "OrderReceiptID";
            col_ID.Width = 55;

            // Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Employee";
            col_Description.DataPropertyName = "EmployeeName";
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_Description.DefaultCellStyle = dstyleWrapText;

            // Manufacturer Column --
            DataGridViewTextBoxColumn colManu = new DataGridViewTextBoxColumn();
            colManu.HeaderText = "Manufacturer";
            colManu.DataPropertyName = "Manufacturer";
            colManu.Width = 150;

            // Orders Column --
            DataGridViewTextBoxColumn colOrders = new DataGridViewTextBoxColumn();
            colOrders.HeaderText = "Orders";
            colOrders.DataPropertyName = "Orders";
            colOrders.Width = 65;

            dg.Columns.AddRange(col_ID, col_Description, colManu, colOrders);

        }

        public static  void BuildPendingOrdersGrid(DataGridView dg)
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
            col_ID.DataPropertyName = "OrderReceiptLineID";
            col_ID.Width = 55;

            // Receipt Date Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "Description";
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_Description.DefaultCellStyle = dstyleWrapText;

            // EmployeeName Column --
            DataGridViewTextBoxColumn col_PartID = new DataGridViewTextBoxColumn();
            col_PartID.HeaderText = "Supplier";
            col_PartID.DataPropertyName = "Supplier";
            col_PartID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_PartID.DefaultCellStyle = dstyleWrapText;


            dg.Columns.AddRange(col_ID,  col_Description, col_PartID);

        }


        public static void CheckForDirtyState(ListChangedEventArgs e, Button btn)
        {

            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                btn.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, btn);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                btn.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, btn);
            }
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                btn.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty, btn);
            }
        }

       

        public static void ToogleButtonStyle(bool dirtyState, Button btn)
        {
            

            if (dirtyState == true)
            {
                btn.BackColor = System.Drawing.Color.Cornsilk;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Red;
                btn.FlatAppearance.BorderSize = 3;
            }

            else if (dirtyState == false)
            {
                btn.BackColor = Color.Gainsboro;
                btn.FlatAppearance.BorderColor = Color.AliceBlue;
                btn.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }

        // <T> is the type of data in the list.
        // If you have a List<int>, for example, then call this as follows:
        // List<int> ListOfInt;
        // DataTable ListTable = BuildDataTable<int>(ListOfInt);
        public static DataTable BuildDataTable<T>(IList<T> lst)
        {
            //create DataTable Structure
            DataTable tbl = CreateTable<T>();
            Type entType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            //get the list item and add into the list
            foreach (T item in lst)
            {
                DataRow row = tbl.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                tbl.Rows.Add(row);
            }
            return tbl;
        }

        private static DataTable CreateTable<T>()
        {
            //T –> ClassName
            Type entType = typeof(T);
            //set the datatable name as class name
            DataTable tbl = new DataTable(entType.Name);
            //get the property list
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            foreach (PropertyDescriptor prop in properties)
            {
                //add property as column
                tbl.Columns.Add(prop.Name, prop.PropertyType);
            }
            return tbl;
        }
    }
}
