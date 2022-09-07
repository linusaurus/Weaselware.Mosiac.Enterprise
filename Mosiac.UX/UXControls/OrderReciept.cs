using System;
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

namespace Mosiac.UX.UXControls
{
    public partial class OrderReciept : UserControl
    {
        
        BindingSource bsOrderReceipt = new BindingSource();
        BindingSource bsItems = new BindingSource();
        internal OrderReceiptDto orderReceipt;
        OrderReceiptRepository orderReceiptRepository;
        internal OrderRecieptLineItemDto currentReceiptItem;
        readonly MosaicContext mosaicContext;
        BindingSource bsInventory = new BindingSource();

        public OrderReciept(OrderReceiptDto dto, MosaicContext context)
        {
            InitializeComponent();

            ThermalLabel.LicenseOwner = "Richard Young-Ultimate Edition-Developer License";
            ThermalLabel.LicenseKey = "RALJ9V89HNTFJMHZWRMH6MFP82AXAXDTX3ZXUESKXRFLXAZ346GQ";

            mosaicContext = context;
            orderReceiptRepository = new OrderReceiptRepository(context, Globals.CurrentUserName,Globals.CurrentLoggedUserID );
            dgReceiptItems.CellFormatting += DgReceiptItems_CellFormatting;

            orderReceipt = dto;
            bsOrderReceipt.DataSource = dto;
            Grids.BuildOrderReceiptItemsGrid(dgReceiptItems);
            dgReceiptItems.ReadOnly = true;
            dgReceiptItems.BackgroundColor = System.Drawing.Color.Gray;
            BindOrderReceipt(bsOrderReceipt);
            bsInventory.CurrentItemChanged += BsInventory_CurrentItemChanged;
        }

        private void BsInventory_CurrentItemChanged(object sender, EventArgs e)
        {
            var c = e;
            btnOK.BackColor = System.Drawing.Color.Bisque;
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
       

            txtOrderRecieptID.DataBindings.Add("Text",bs,"OrderReceiptId");
            txtReceiptDate.DataBindings.Add("Text",bs,"ReceiptDate",true,DataSourceUpdateMode.Never,"","d");
            txtReceivedBy.DataBindings.Add("Text",bs, "EmployeeName");
            txtOrderDate.DataBindings.Add("Text",bs,"OrderDate",true,DataSourceUpdateMode.Never,"","d");
            txtPurchaseOrderID.DataBindings.Add("Text",bs,"PurchaseOrderID");

            

            dgReceiptItems.DataSource = orderReceipt.OrderReceiptLineItems;
          
        }

        private void BindInventory(BindingSource bs)
        {
            // Clear the binding and data
            txtTransactionID.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            txtDateStamp.DataBindings.Clear();
            txtQntyRecieved.DataBindings.Clear();
            txtInventoryAmount.DataBindings.Clear();
            // Bind the datasource
            if (bs.Current != null)
            {
                txtTransactionID.DataBindings.Add("Text", bs, "StockTransactionID");
                txtDescription.DataBindings.Add("Text", bs, "Description");
                txtDateStamp.DataBindings.Add("Text", bs, "DateStamp", true, DataSourceUpdateMode.OnPropertyChanged, "", "d");
                txtQntyRecieved.DataBindings.Add("Text", bs, "QntyReceived");
                txtInventoryAmount.DataBindings.Add("Text", bs, "InventoryAmount", true, DataSourceUpdateMode.OnPropertyChanged);
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
                    var inventory = mosaicContext.Inventory.Where(k => k.LineID == currentReceiptItem.LineID).FirstOrDefault();
                    //InventoryDto inventoryDto = orderReceiptRepository.GetInventoryItem(lineID);
                    bsInventory.DataSource = inventory;
                    BindInventory(bsInventory);    
                }
            }
        }

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
    }

}