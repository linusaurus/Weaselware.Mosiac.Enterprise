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
            // Date Style
            DataGridViewCellStyle dstyleDate = new DataGridViewCellStyle();
            dstyleCurrency.Format = "d";
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
            col_Description.DataPropertyName = "ItemDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Manufacturer Column --
            DataGridViewTextBoxColumn col_Manufacturer = new DataGridViewTextBoxColumn();
            col_Manufacturer.HeaderText = "Manu-PartNumber";
            col_Manufacturer.DataPropertyName = "PartNumber";
            col_Manufacturer.Width = 200;
            // DateAdded Column --
            DataGridViewTextBoxColumn col_DateAdded = new DataGridViewTextBoxColumn();
            col_DateAdded.DefaultCellStyle = dstyleDate;
            col_DateAdded.HeaderText = "Date Added";
            col_DateAdded.DataPropertyName = "DateAdded";
            col_DateAdded.Width = 100;

            // Addedby Column --
            DataGridViewTextBoxColumn col_Addedby=  new DataGridViewTextBoxColumn();
            col_Addedby.HeaderText = "Added by";
            col_Addedby.DataPropertyName = "AddedBy";
            col_Addedby.Width = 140;


            dg.Columns.AddRange(col_ID, col_Description,col_DateAdded , col_Addedby, col_Manufacturer);

        }
        /// <summary>
        /// OrderRecipt Line Items
        /// </summary>
        /// <param name="dg"></param>
        internal static void BuildOrderLineItemsGrid(DataGridView dg)
        {
            dg.AutoGenerateColumns = false;

            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // LineID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "LineID";
            col_ID.Width = 55;

            //Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "description";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Unit Column --
            DataGridViewTextBoxColumn col_Unit = new DataGridViewTextBoxColumn();
            col_Unit.HeaderText = "Unit";
            col_Unit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Unit.DataPropertyName = "UnitOrderMeasureName";
            col_Unit.Width = 80;

            // Qnty Column --
            DataGridViewTextBoxColumn col_Qnty = new DataGridViewTextBoxColumn();
            col_Qnty.DefaultCellStyle = dstyleDecimal;
            col_Qnty.HeaderText = "Qnty";
            col_Qnty.DataPropertyName = "Quantity";
            col_Qnty.Width = 100;

            // Cost Column --
            DataGridViewTextBoxColumn col_Price = new DataGridViewTextBoxColumn();
            col_Price.DefaultCellStyle = dstyleDecimal;
            col_Price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col_Price.HeaderText = "Unit Cost";
            col_Price.DataPropertyName = "Price";
            col_Price.Width = 100;

            // Extended Column --
            DataGridViewTextBoxColumn col_Extended = new DataGridViewTextBoxColumn();
            col_Extended.DefaultCellStyle = dstyleDecimal;
            col_Extended.HeaderText = "Extension";
            col_Extended.DataPropertyName = "Extended";
            col_Extended.Width = 100;



            dg.Columns.AddRange(col_ID, col_Description, col_Unit, col_Qnty, col_Price, col_Extended);
        }

        public static void BuildJobOrdersGrid(DataGridView dg)
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
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // Receipt Description Column --
            DataGridViewTextBoxColumn col_Description = new DataGridViewTextBoxColumn();
            col_Description.HeaderText = "Description";
            col_Description.DataPropertyName = "ItemDescription";
            col_Description.Width = 120;
            col_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Manufacturer Column --
            DataGridViewTextBoxColumn col_Manufacturer = new DataGridViewTextBoxColumn();
            col_Manufacturer.HeaderText = "PartNum";
            col_Manufacturer.DataPropertyName = "PartNumber";
            col_Manufacturer.Width = 160;



            dg.Columns.AddRange(col_ID, col_Description, col_Manufacturer);

        }

        public static void BuildSupplierOrdersGrid(DataGridView dg)
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

            // PurchaseOrderID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "OrderNumber";
            col_ID.Width = 55;

            // Order Date Column --
            DataGridViewTextBoxColumn col_Date = new DataGridViewTextBoxColumn();
            col_Date.HeaderText = "Order Date";
            col_Date.DataPropertyName = "OrderDate";
            col_Date.DefaultCellStyle.Format = "d";
            col_Date.Width = 100;

            // Purchaser Column --
            DataGridViewTextBoxColumn col_purchaser = new DataGridViewTextBoxColumn();
            col_purchaser.HeaderText = "Purchaser";
            col_purchaser.DataPropertyName = "Purchaser";
            col_purchaser.Width = 160;

            // Jobname Column --
            DataGridViewTextBoxColumn col_Jobname = new DataGridViewTextBoxColumn();
            col_Jobname.HeaderText = "Job Name";
            col_Jobname.DataPropertyName = "JobName";
            col_Jobname.Width = 160;
            col_Jobname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // OrderTotal Column --
            DataGridViewTextBoxColumn col_orderTotal = new DataGridViewTextBoxColumn();
            col_orderTotal.HeaderText = "Order Total";
            col_orderTotal.DataPropertyName = "OrderTotal";
            col_orderTotal.Width = 100;
            col_orderTotal.DefaultCellStyle = dstyleCurrency;

            // Recieved COlumn --
            DataGridViewCheckBoxColumn col_received = new DataGridViewCheckBoxColumn();
            col_received.HeaderText = "Revd";
            col_received.DataPropertyName = "Received";
            col_received.Width = 75;


            dg.Columns.AddRange(col_ID, col_Date, col_purchaser, col_Jobname, col_orderTotal, col_received);

        }

        public static void BuildPartOrdersGrid(DataGridView dg)
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

            // PurchaseOrderID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "PurchaseOrderID";
            col_ID.Width = 55;

            // Order Date Column --
            DataGridViewTextBoxColumn col_Date = new DataGridViewTextBoxColumn();
            col_Date.HeaderText = "Order Date";
            col_Date.DataPropertyName = "OrderDate";
            col_Date.Width = 100;

            // Purchaser Column --
            DataGridViewTextBoxColumn col_purchaser = new DataGridViewTextBoxColumn();
            col_purchaser.HeaderText = "Supplier";
            col_purchaser.DataPropertyName = "SupplierName";
            col_purchaser.Width = 160;

            // Jobname Column --
            DataGridViewTextBoxColumn col_Jobname = new DataGridViewTextBoxColumn();
            col_Jobname.HeaderText = "Job Name";
            col_Jobname.DataPropertyName = "JobName";
            col_Jobname.Width = 160;
            col_Jobname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           

            dg.Columns.AddRange(col_ID, col_Date, col_purchaser, col_Jobname);

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
            DataGridViewTextBoxColumn col_filesize = new DataGridViewTextBoxColumn();
            col_filesize.HeaderText = "FileSize";
            col_filesize.DataPropertyName = "FileSize";
            col_filesize.Width = 90;

            //Create Colum--------
            DataGridViewTextBoxColumn col_Created = new DataGridViewTextBoxColumn();
            col_Created.HeaderText = "Created";
            col_Created.DataPropertyName = "CreationDate";
            col_Created.Width = 100;
            // Creator------------------------
            DataGridViewTextBoxColumn col_Createdby = new DataGridViewTextBoxColumn();
            col_Createdby.HeaderText = "Createdby";
            col_Createdby.DataPropertyName = "Createdby";
            col_Createdby.Width = 150;
            // LastMod------------------------
            DataGridViewTextBoxColumn col_LastMod = new DataGridViewTextBoxColumn();
            col_LastMod.HeaderText = "LastMod";
            col_LastMod.DataPropertyName = "LastMod";
            col_LastMod.Width = 90;


            dg.Columns.AddRange(col_ID, col_Description, col_filesize, col_Created,col_Createdby, col_LastMod);
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



       
            // OrderReceiptLineID Column -- 0
            DataGridViewTextBoxColumn col_OrderReceiptLineID = new DataGridViewTextBoxColumn();
            col_OrderReceiptLineID.HeaderText = "ID";
            col_OrderReceiptLineID.DataPropertyName = "OrderReceiptLineID";
            col_OrderReceiptLineID.Width = 55;

            // OrderReceiptLineID Column -- 0
            DataGridViewTextBoxColumn col_partID = new DataGridViewTextBoxColumn();
            col_partID.HeaderText = "PartID";
            col_partID.DataPropertyName = "PartID";
            col_partID.Width = 55;
            col_partID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

            dg.Columns.AddRange( col_OrderReceiptLineID, col_partID, col_Description, col_UnitOfMeasureName, col_ReceivedComplete, col_QntyOrdered, 
                col_QntyRecieved, col_QntyBalance, col_QntyToInventory);
        }
         //-xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
         // Pending Order Grid View
         //-xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        public static  void BuildPendingOrdersGrid(DataGridView dg)
        {

            dg.AutoGenerateColumns = false;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
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

            // JobNamee Column --
            DataGridViewTextBoxColumn col_JobName = new DataGridViewTextBoxColumn();
            col_JobName.HeaderText = "JobName";
            col_JobName.DataPropertyName = "JobName";
            col_JobName.Width = 160;
            col_JobName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Supplier Name Column --
            DataGridViewTextBoxColumn col_Supplier = new DataGridViewTextBoxColumn();
            col_Supplier.HeaderText = "Supplier";
            col_Supplier.DataPropertyName = "Supplier";
            col_Supplier.Width = 260;

            // Employee Name Column --
            DataGridViewTextBoxColumn col_Employee = new DataGridViewTextBoxColumn();
            col_Employee.HeaderText = "Purchaser";
            col_Employee.DataPropertyName = "EmployeeName";
            col_Employee.Width = 90;

            // Order Date Column --
            DataGridViewTextBoxColumn col_OrderDate = new DataGridViewTextBoxColumn();
            col_OrderDate.HeaderText = "Order Date";
            col_OrderDate.DataPropertyName = "OrderDate";
            col_OrderDate.Width = 90;


            dg.Columns.AddRange(col_ID, col_JobName,col_Supplier,  col_Employee, col_OrderDate);

        }

        public static void BuildSupplierOrderItems(DataGridView dg)
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

            // LineID Column --
            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.HeaderText = "ID";
            col_ID.DataPropertyName = "LineID";
            col_ID.Width = 55;

            // PartID Column --
            DataGridViewTextBoxColumn col_partid = new DataGridViewTextBoxColumn();
            col_partid.HeaderText = "ID";
            col_partid.DataPropertyName = "LineID";
            col_partid.Width = 55;


            // Description Column --
            DataGridViewTextBoxColumn col_description = new DataGridViewTextBoxColumn();
            col_description.HeaderText = "Description";
            col_description.DataPropertyName = "Description";
            col_description.Width = 120;
            col_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // UnitCost Column --
            DataGridViewTextBoxColumn col_unitCost = new DataGridViewTextBoxColumn();
            col_unitCost.HeaderText = "UnitCost";
            col_unitCost.DataPropertyName = "UnitCost";
            col_unitCost.Width = 90;

            // Qnty Column --
            DataGridViewTextBoxColumn col_qnty = new DataGridViewTextBoxColumn();
            col_qnty.HeaderText = "Qnty";
            col_qnty.DataPropertyName = "Qnty";
            col_qnty.Width = 90;

            // extended Column --
            DataGridViewTextBoxColumn col_extended = new DataGridViewTextBoxColumn();
            col_extended.HeaderText = "Extension";
            col_extended.DataPropertyName = "Extended";
            col_extended.Width = 90;


            dg.Columns.AddRange(col_ID, col_partid,col_description, col_unitCost, col_qnty, col_extended);
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
