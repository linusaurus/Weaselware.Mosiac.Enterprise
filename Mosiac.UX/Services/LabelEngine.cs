using Neodynamic.SDK.Printing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ServiceLayer.Services;
using ServiceLayer.Models;


namespace Mosiac.UX
{
    public class LabelEngine
    {

        public LabelEngine()
        {
            
        }

       

        public static ThermalLabel GeneratePartLabel(int PartID)
        {

            
            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2, 1);
            tLabel.GapLength = 0.2;

            TextItem txtItem = new TextItem(0.2, 0.2, 2.5, 0.5, "Thermal Label Test");
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 12;

            //Define a BarcodeItem object (Linear 1D)
            BarcodeItem bcItem = new BarcodeItem(0.2, 1, 2, 2, BarcodeSymbology.Code128, "ABC123");
            //Set bars height to .75inch
            bcItem.BarHeight = 0.75;
            //Set bars width to 0.0104inch
            bcItem.BarWidth = 0.0104;

            //Define a BarcodeItem object (2D)
            BarcodeItem bcItem2D = new BarcodeItem(2.5, 1, 1, 1, BarcodeSymbology.QRCode, "Encoding Current Date: " + DateTime.Now.ToShortDateString());
            //Set symbol sizing
            bcItem2D.Sizing = BarcodeSizing.FitProportional;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(bcItem);
            tLabel.Items.Add(bcItem2D);

            return tLabel;


        }

        public static ThermalLabel GenerateStockTag(StockTagDto dto)
        {


            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2.25, 1.25);
            tLabel.GapLength = 0.12;
            // Line 1 --
            string txt1 = $"STOCK TAG # {dto.StockTransactionID.ToString()}";
            TextItem txtItem = new TextItem(0.1, 0.1, 1.75, 0.25, txt1);
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 8;

            // Jobname --
            string txt2 = $"Job : {dto.jobname}";
            TextItem txtJobInfo = new TextItem(0.1, 0.24, 1.75, 0.30, txt2);
            txtJobInfo.Sizing = TextSizing.ParagraphScaling;
            txtJobInfo.Sizing = TextSizing.FontSizeScaling;
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 6;

            // Qnty Recieved --
            string txt3 = $"Qnty : {dto.QuantityReceived} - {dto.ReceiptDate.ToShortDateString()}";
            TextItem txtDate = new TextItem(0.1, 0.4, 1.75, 0.22, txt3);
            //txtDate.Sizing = TextSizing.ParagraphScaling;
            txtDate.Font.Name = "ZPL Font 0";
            txtDate.Font.Size = 7;

            //Recieved By
            string txt4 = $"Recieved by : {dto.firstname}";
            TextItem txtReceiver = new TextItem(0.1, 0.5, 1.75, 0.24, txt4);         
            txtReceiver.Font.Name = "ZPL Font 0";
            txtReceiver.Font.Size = 7;

            //Define a **BarcodeItem** object for encoding Code 39 symbology
            BarcodeItem bc1 = new BarcodeItem(0.25, 0.85, 1.5, .375, BarcodeSymbology.Code39, dto.StockTransactionID.ToString());
            bc1.AddChecksum = false;
            bc1.CodeAlignment = BarcodeTextAlignment.BelowCenter;
            bc1.BarWidth = 0.01;
            bc1.BarHeight = 0.5;
            bc1.QuietZone = new FrameThickness(0);
            bc1.BarcodeAlignment = BarcodeAlignment.MiddleCenter;
            bc1.Sizing = BarcodeSizing.FitProportional;
            bc1.Font.Size = 5;
    
            //Add items to ThermalLabel object...
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(txtJobInfo);
            tLabel.Items.Add(txtDate);
            tLabel.Items.Add(txtReceiver);
            tLabel.Items.Add(bc1);
            //tLabel.Items.Add(bcItem2D);

            return tLabel;


        }
    }
}
