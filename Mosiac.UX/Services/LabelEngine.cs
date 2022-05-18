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

        public static ThermalLabel GenerateStockTag(int LineID)
        {


            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2, 1);
            tLabel.GapLength = 0.12;

            TextItem txtItem = new TextItem(0.1, 0.1, 1.75, 0.25, "STOCK TAG");
            txtItem.Font.Name = "ZPL Font 0";
            txtItem.Font.Size = 12;

            //Define a BarcodeItem object (Linear 1D)
            BarcodeItem bcItem = new BarcodeItem(0.1, .26, 1.5, 0.125, BarcodeSymbology.Code128, LineID.ToString());
            //Set bars height to .75inch
            bcItem.BarHeight = 0.25;
            //Set bars width to 0.0104inch
            bcItem.BarWidth = 0.75;

            //Define a BarcodeItem object (2D)
            BarcodeItem bcItem2D = new BarcodeItem(0.6, 1, 1, 1, BarcodeSymbology.QRCode, "Encoding Current Date: " + DateTime.Now.ToShortDateString());
            //Set symbol sizing
            bcItem2D.Sizing = BarcodeSizing.FitProportional;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(bcItem);
            tLabel.Items.Add(bcItem2D);

            return tLabel;


        }
    }
}
