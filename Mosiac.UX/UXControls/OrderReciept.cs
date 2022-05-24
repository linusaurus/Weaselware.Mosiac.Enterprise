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
using Mosiac.UX;
using System.Windows.Forms;
using SkiaSharp;
using Neodynamic.SDK.Printing;
using System.IO;

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

        private void BindInventory()
        {

        }

        private void dgReceiptItems_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            if (dvg.DataSource != null)
            {
                if (dvg.Rows.Count > 0)
                {
                    BindingManagerBase bm = dvg.BindingContext[orderReceipt, "OrderReceiptLineItems"];
                    currentReceiptItem = (OrderRecieptLineItemDto)bm.Current;
                    
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PrinterSettings XmlData;

            // if the settings file doesn't exist-re-create them
            if (!File.Exists(@"C:\Wml.xml"))
            {
                //Display Print Job dialog...           
                PrintJobDialog frmPrintJob = new PrintJobDialog();
                if (frmPrintJob.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(PrinterSettings));
                    using (TextWriter writer = new StreamWriter(@"C:\Wml.xml"))
                    {
                        serializer.Serialize(writer, frmPrintJob.PrinterSettings);
                    }
                }
            }
      
            //Pull the settings from XML file --
            XmlSerializer deserializer = new XmlSerializer(typeof(PrinterSettings));
            TextReader reader = new StreamReader(@"C:\Wml.xml");
            object obj = deserializer.Deserialize(reader);
            XmlData = (PrinterSettings)obj;
            reader.Close();
            

            List<OrderRecieptLineItemDto> labelItems = new List<OrderRecieptLineItemDto>();

            using (WindowsPrintJob pj = new WindowsPrintJob(XmlData))
            {

                foreach (DataGridViewRow row in dgReceiptItems.SelectedRows)
                {
                    OrderRecieptLineItemDto rowItem = (OrderRecieptLineItemDto)row.DataBoundItem;
                    if (rowItem != null)
                    {
                        StockTagDto ts = orderReceiptRepository.GetStockTag(rowItem.OrderReceiptLineID);
                        ThermalLabel tLabel = LabelEngine.GenerateStockTag(ts);
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