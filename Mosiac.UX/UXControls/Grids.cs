﻿using System;
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

        public static void BuildPartSearchGrid(DataGridView dg)
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
            col_ID.DataPropertyName = "PartID";
            col_ID.Width = 55;

            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "Description";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Manufacturer Column --
            DataGridViewTextBoxColumn col_Manufacturer = new DataGridViewTextBoxColumn();
            col_Manufacturer.HeaderText = "Manufacturer";
            col_Manufacturer.DataPropertyName = "Manufacturer";
            col_Manufacturer.Width = 110;

            // Orders Column --
            DataGridViewTextBoxColumn col_Orders = new DataGridViewTextBoxColumn();
            col_Orders.HeaderText = "Orders";
            col_Orders.DataPropertyName = "Orders";
            col_Orders.Width = 70;

            dg.Columns.AddRange(col_ID, col_Description, col_Manufacturer, col_Orders);

        }

        public static void BuildPartResourcesGrid(DataGridView dg)
        {
            // Grid Width 430 --

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


            // ResourceID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "ResourceID";
            col_ID.Width = 55;

            // Resource Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "ResourceDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //FileSize Column --
            DataGridViewTextBoxColumn col_Manufacturer = new DataGridViewTextBoxColumn();
            col_Manufacturer.HeaderText = "FileSize";
            col_Manufacturer.DataPropertyName = "FileSize";
            col_Manufacturer.Width = 90;



            dg.Columns.AddRange(col_ID, col_Description, col_Manufacturer);
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
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dstyleDecimal.BackColor = Color.Cornsilk;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PartID Column -- 0
            DataGridViewTextBoxColumn col_OrderReceiptID = new DataGridViewTextBoxColumn();
            col_OrderReceiptID.HeaderText = "ID";
            col_OrderReceiptID.DataPropertyName = "OrderReceiptID";
            col_OrderReceiptID.Width = 55;

       
            // PartID Column -- 0
            DataGridViewTextBoxColumn col_OrderReceiptLineID = new DataGridViewTextBoxColumn();
            col_OrderReceiptLineID.HeaderText = "ID";
            col_OrderReceiptLineID.DataPropertyName = "OrderReceiptLineID";
            col_OrderReceiptLineID.Width = 55;


            // Description Column -- 1
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "Description";
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_Description.DefaultCellStyle = dstyleWrapText;

            // Units Of Measure Column -- 2
            DataGridViewTextBoxColumn col_UnitOfMeasureName = new DataGridViewTextBoxColumn();
            col_UnitOfMeasureName.HeaderText = "Units";
            col_UnitOfMeasureName.DataPropertyName = "UnitOfMeasureName";
            col_UnitOfMeasureName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_UnitOfMeasureName.Width = 60;

            // QntyOrdered Column -- 3
            DataGridViewTextBoxColumn col_QntyOrdered = new DataGridViewTextBoxColumn();
            col_QntyOrdered.HeaderText = "Qty-Ordered";
            col_QntyOrdered.DataPropertyName = "QntyOrdered";
            col_QntyOrdered.DefaultCellStyle = dstyleDecimal;
            col_QntyOrdered.ReadOnly = true;
            col_QntyOrdered.Width = 80;

            // OrderComplete Column -- 4
            DataGridViewCheckBoxColumn col_ReceivedComplete = new DataGridViewCheckBoxColumn();
            col_ReceivedComplete.HeaderText = "Complete";
            col_ReceivedComplete.DataPropertyName = "ItemsRecievedComplete";        
            col_ReceivedComplete.Width = 80;

            // QntyReceived Column --
            DataGridViewTextBoxColumn col_QntyRecieved = new DataGridViewTextBoxColumn();
            col_QntyRecieved.HeaderText = "Qty-Received";
            col_QntyRecieved.DataPropertyName = "QntyReceived";
            col_QntyRecieved.DefaultCellStyle = dstyleDecimal;
            col_QntyRecieved.Width = 80;

            // QntyBalance Column --
            DataGridViewTextBoxColumn col_QntyBalance = new DataGridViewTextBoxColumn();
            col_QntyBalance.HeaderText = "Qty-Balance";
            col_QntyBalance.DataPropertyName = "QntyBalance";
            col_QntyBalance.DefaultCellStyle = dstyleDecimal;
            col_QntyBalance.Width = 80;

            // QntyToInventory Column --
            DataGridViewTextBoxColumn col_QntyToInventory = new DataGridViewTextBoxColumn();
            col_QntyToInventory.HeaderText = "Qty-To-Inv";
            col_QntyToInventory.DataPropertyName = "QntyToInventory";
            col_QntyToInventory.DefaultCellStyle = dstyleDecimal;

            col_QntyToInventory.Width = 80;

            dg.Columns.AddRange(col_OrderReceiptID, col_OrderReceiptLineID,col_Description, col_UnitOfMeasureName, col_ReceivedComplete, col_QntyOrdered, 
                col_QntyRecieved, col_QntyBalance, col_QntyToInventory);
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
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // Receipt Date Column --
            DataGridViewTextBoxColumn col_Supplier = new DataGridViewTextBoxColumn();
            col_Supplier.HeaderText = "Supplier";
            col_Supplier.DataPropertyName = "Supplier";
            col_Supplier.Width = 120;
            col_Supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // EmployeeName Column --
            DataGridViewTextBoxColumn col_OrderDate = new DataGridViewTextBoxColumn();
            col_OrderDate.HeaderText = "Date";
            col_OrderDate.DataPropertyName = "OrderDate";
            col_OrderDate.Width = 90;


            dg.Columns.AddRange(col_ID, col_Supplier, col_OrderDate);

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
