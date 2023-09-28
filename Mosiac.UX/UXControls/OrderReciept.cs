﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml.Serialization;
using ServiceLayer.Models;
using ServiceLayer;
using ServiceLayer.Services;
using DataLayer.Data;
using System.Windows.Forms;
using SkiaSharp;
using Neodynamic.SDK.Printing;
using System.IO;
using Mosiac.UX.Services;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entity;

namespace Mosiac.UX.UXControls
{
    public partial class OrderReciept : UserControl
    {

        BindingSource bsOrderReceipt = new BindingSource();
        BindingSource bsItems = new BindingSource();
        BindingSource bsInventory = new BindingSource();
        //-------------------------------------------------
        internal OrderReceiptDto orderReceipt;
        OrderReceiptRepository orderReceiptRepository;
        InventoryService inventoryService;
        PartsService partsService;
        internal OrderRecieptLineItemDto currentReceiptItem;
        readonly MosaicContext mosaicContext;
        //--selectedInvneotryItem ----
        Inventory _currentInventory;
        InventoryWrapper inventoryWrapper;



        public OrderReciept(OrderReceiptDto dto, MosaicContext context)
        {
            InitializeComponent();


            mosaicContext = context;
            orderReceiptRepository = new OrderReceiptRepository(context, Globals.CurrentUserName, Globals.CurrentLoggedUserID);
            inventoryService = new InventoryService(mosaicContext);
            partsService = new PartsService(mosaicContext);
            dgReceiptItems.CellFormatting += DgReceiptItems_CellFormatting;

            orderReceipt = dto;
            bsOrderReceipt.DataSource = dto;
            Grids.BuildOrderReceiptItemsGrid(dgReceiptItems);
            //dgReceiptItems.ReadOnly = true;
            dgReceiptItems.BackgroundColor = System.Drawing.Color.Gray;
            BindOrderReceipt(bsOrderReceipt);
            // ------------------------------------------------
            bsInventory.ListChanged += BsInventory_ListChanged;

            cbxInventoryLocation.DataSource = inventoryService.GetLocations();
            cbxInventoryLocation.DisplayMember = "LocationName";
            cbxInventoryLocation.ValueMember = "LocationID";

            LoadPrinterSelections();
        }

        private void BsInventory_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                btnOK.BackColor = System.Drawing.Color.Bisque;
            }
        }


        private void DgReceiptItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "IsOrderComplete")
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
                dgv.Rows[e.RowIndex].ReadOnly = true;
            }
        }

        private void BindOrderReceipt(BindingSource bs)
        {
            txtOrderRecieptID.DataBindings.Add("Text", bs, "OrderReceiptId");
            txtReceiptDate.DataBindings.Add("Text", bs, "ReceiptDate", true, DataSourceUpdateMode.Never, "", "d");
            txtReceivedBy.DataBindings.Add("Text", bs, "EmployeeName");
            txtOrderDate.DataBindings.Add("Text", bs, "OrderDate", true, DataSourceUpdateMode.Never, "", "d");
            txtPurchaseOrderID.DataBindings.Add("Text", bs, "PurchaseOrderID");
            lbPO.Text = $" PO : {((OrderReceiptDto)bsOrderReceipt.DataSource).PurchaseOrderID.ToString()} ";

            bsItems.DataSource = orderReceipt.OrderReceiptLineItems;
            dgReceiptItems.DataSource = bsItems;
        }

        private void BindInventory(BindingSource bs)
        {
            // Clear the binding and data
            txtTransactionID.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            txtDateStamp.DataBindings.Clear();
            txtQntyRecieved.DataBindings.Clear();
            txtInventoryAmount.DataBindings.Clear();
            txtIventoryNote.DataBindings.Clear();
            cbxInventoryLocation.DataBindings.Clear();

            // Bind the datasource
            if (bs.Current != null)
            {
                txtTransactionID.DataBindings.Add("Text", bs, "StockTransactionID");
                txtDescription.DataBindings.Add("Text", bs, "Description");
                txtDateStamp.DataBindings.Add("Text", bs, "DateStamp", true, DataSourceUpdateMode.OnPropertyChanged, "", "d");
                txtQntyRecieved.DataBindings.Add("Text", bs, "QntyReceived");
                txtInventoryAmount.DataBindings.Add("Text", bs, "InventoryAmount", true, DataSourceUpdateMode.OnPropertyChanged);
                txtIventoryNote.DataBindings.Add("Text", bs, "Note", true, DataSourceUpdateMode.OnPropertyChanged);

            }

        }

        private void dgReceiptItems_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            if (dvg.DataSource != null)
            {
                if (dvg.Rows.Count > 0)
                {
                    currentReceiptItem = (OrderRecieptLineItemDto)dvg.CurrentRow.DataBoundItem;
                    // Return the inventory transaction for the Reciept item --
                    _currentInventory = mosaicContext.Inventory.Where(k => k.LineID == currentReceiptItem.LineID).FirstOrDefault();
                    inventoryWrapper = new InventoryWrapper(_currentInventory);
                    if (_currentInventory.LocationID != null)
                    {
                        //int index = cbxInventoryLocation.FindString(_currentInventory.LocationNavigation.LocationName.ToString());
                        //cbxInventoryLocation.SelectedIndex = index;
                    }
                    cbxInventoryLocation.DataBindings.Clear();
                    cbxInventoryLocation.DataBindings.Add("SelectedValue", _currentInventory, "LocationID", true, DataSourceUpdateMode.OnPropertyChanged);
                    //_currentInventory.LocationID = null;

                    bsInventory.DataSource = inventoryWrapper;
                    BindInventory(bsInventory);
                }
            }
        }
        /// <summary>
        /// Print the stock label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PrinterSettings PrinterXmlData;
            var fileName = Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.ApplicationData), "GK420t.xml");
            // if the settings file doesn't exist-re-create them
            if (!File.Exists(fileName))
            {
                //Display Print Job dialog...           
                PrintJobDialog frmPrintJob = new PrintJobDialog();
                if (frmPrintJob.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(PrinterSettings));
                    using (TextWriter writer = new StreamWriter(fileName))
                    {
                        serializer.Serialize(writer, frmPrintJob.PrinterSettings);
                    }
                }
            }

            //Pull the settings from XML file --
            XmlSerializer deserializer = new XmlSerializer(typeof(PrinterSettings));
            TextReader reader = new StreamReader(fileName);
            object obj = deserializer.Deserialize(reader);
            PrinterXmlData = (PrinterSettings)obj;
            reader.Close();

            using (WindowsPrintJob pj = new WindowsPrintJob(PrinterXmlData))
            {

                foreach (DataGridViewRow row in dgReceiptItems.SelectedRows)
                {
                    OrderRecieptLineItemDto rowItem = (OrderRecieptLineItemDto)row.DataBoundItem;
                    if (rowItem != null)
                    {
                        StockTagDto ts = orderReceiptRepository.GetStockTag(rowItem.OrderReceiptLineID);

                        ThermalLabel tLabel = LabelEngine.GenerateLargeStockTag(ts);

                        pj.Copies = 1; // set copies
                        pj.PrintOrientation = PrintOrientation.Portrait; //set orientation
                        pj.ThermalLabel = tLabel;
                        pj.PrintAsGraphic(tLabel);
                    }

                }

            }

        }



        private void txtMultiplier_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int multi;
            if (tb.Text.Length > 0)
            {
                if (int.TryParse(tb.Text, out multi))
                {
                    ((InventoryWrapper)bsInventory.Current).InventoryAmount = ((InventoryWrapper)bsInventory.Current).QntyReceived * multi;
                    bsInventory.ResetBindings(true);
                    //BindInventory(bsInventory);
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mosaicContext.Inventory.Update(_currentInventory);

            btnOK.BackColor = System.Drawing.Color.WhiteSmoke;

            var lineItems = bsItems.List;
            foreach (OrderRecieptLineItemDto item in lineItems)
            {
                var it = mosaicContext.OrderReceiptItems.Find(item.OrderReceiptLineID);
                it.Note = item.Note;
                it.Extended = item.Extended;
                it.QuantityOrdered = item.QntyOrdered;
                it.QuantityReceived = item.QntyReceived;
                it.InventoryAmount = item.QntyToInventory;
                it.Balance = item.QntyBalance;
                it.Description = item.Description;

                mosaicContext.OrderReceiptItems.Update(it);

            }

            mosaicContext.SaveChanges();
        }

        private void LoadPrinterSelections()
        {
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] fileNames = Directory.GetFiles(folderpath);
            List<String> trimmed = new List<string>();
            foreach (string file in fileNames)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                trimmed.Add(name);
            }

            tsPrinterChoice.Items.AddRange(trimmed.ToArray());
        }
        private void tsClearPrinterSettings_Click(object sender, EventArgs e)
        {
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string path = Path.Combine(folderpath, "GK420t.xml");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inv = _currentInventory;
            int receiptID = _currentInventory.OrderReceiptID.GetValueOrDefault();
            int poID = mosaicContext.OrderReciept.Find(receiptID).PurchaseOrderID.GetValueOrDefault();
            DataLayer.Entity.OrderReciept recp = mosaicContext.OrderReciept.Find(receiptID);
            if (recp != null)
            {

                mosaicContext.Remove(recp);
                mosaicContext.RemoveRange(recp.OrderReceiptItems);
                PurchaseOrder po = mosaicContext.PurchaseOrder.Find(poID);
                po.OrderReciept = null;
                po.RecievedDate = null;
                po.OrderState = 1;
                po.Recieved = false;
                List<Inventory> inventroy = mosaicContext.Inventory.Where(m => m.OrderReceiptID == receiptID).ToList();
                if (inventroy != null)
                {
                    mosaicContext.RemoveRange(inventroy);
                }

            }

            mosaicContext.SaveChanges();

        }

        private void cbxInventoryLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (_currentInventory != null) { _currentInventory.LocationID = ((Location)cb.SelectedItem).LocationID; }
            mosaicContext.SaveChanges();
        }
    }

}