using Neodynamic.SDK.Printing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ServiceLayer.Services;
using ServiceLayer.Models;


namespace Mosiac.UX.Services
{
    public class LabelEngine
    {

        public LabelEngine()
        {

        }


        // Creates a Part Label 2.25 x 1.25
        public static ThermalLabel GeneratePartLabel(PartListDto dto)
        {


            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2.25, 1.25);
            tLabel.GapLength = 0.12;
            // Label Header --
            string txt1 = $"PART  # {dto.PartID.ToString()}";
            TextItem txtItem = new TextItem(0.1, 0.1, 1.75, 0.25, txt1);
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 12;
            txtItem.Font.Bold = true;

            // Jobname --
            string txt2 = dto.Itemdescription;
            TextItem txtJobInfo = new TextItem(0.1, 0.26, 1.85, 0.30, txt2);
            txtJobInfo.Sizing = TextSizing.ParagraphScaling;
            //txtJobInfo.Sizing = TextSizing.FontSizeScaling;
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 6;

            // Qnty Recieved --
            string txt3 = $"SOURCE : {dto.Manufacturer}";
            TextItem txtDate = new TextItem(0.1, 0.62, 1.85, 0.22, txt3);
            //txtDate.Sizing = TextSizing.ParagraphScaling;
            txtDate.Font.Name = "ZPL Font 0";
            txtDate.Font.Size = 6;


            //Define a **BarcodeItem** object for encoding Code 39 symbology
            BarcodeItem bc1 = new BarcodeItem(0.25, 0.85, 1.5, .375, BarcodeSymbology.Code39, dto.PartID.ToString());
            bc1.AddChecksum = false;
            bc1.CodeAlignment = BarcodeTextAlignment.BelowCenter;
            bc1.BarWidth = 0.01;
            bc1.BarHeight = 0.5;
            bc1.QuietZone = new FrameThickness(0);
            bc1.BarcodeAlignment = BarcodeAlignment.MiddleCenter;
            bc1.Sizing = BarcodeSizing.FitProportional;
            bc1.Font.Size = 6;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(txtJobInfo);
            tLabel.Items.Add(txtDate);
            tLabel.Items.Add(bc1);

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
            //txtJobInfo.Sizing = TextSizing.ParagraphScaling;
            //txtJobInfo.Sizing = TextSizing.FontSizeScaling;
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 6;

            // Qnty Recieved --
            string txt3 = $"Qnty : {dto.QuantityReceived} - {dto.ReceiptDate.ToShortDateString()}";
            TextItem txtDate = new TextItem(0.1, 0.48, 1.75, 0.22, txt3);
            //txtDate.Sizing = TextSizing.ParagraphScaling;
            txtDate.Font.Name = "ZPL Font 0";
            txtDate.Font.Size = 7;

            //Recieved By
            string txt4 = $"Recieved by : {dto.firstname}";
            TextItem txtReceiver = new TextItem(0.1, 0.6, 1.75, 0.24, txt4);
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


            return tLabel;


        }
    }
}
