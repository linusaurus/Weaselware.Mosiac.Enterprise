using Neodynamic.SDK.Printing;

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Mosiac.UX
{
    public class LabelEngine
    {

        public LabelEngine()
        {
            ThermalLabel.LicenseOwner = "Richard Young";
            ThermalLabel.LicenseKey = "MC4J7E7UM8BDLXA72PEWSJ84NR5FXRVBKPANLSYTCCGKKNMW9N6A";
        }

        public static void PrintPartLabel(int PartID)
        {
            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 4, 3);
            tLabel.GapLength = 0.2;

            //Define a TextItem object
            TextItem txtItem = new TextItem(0.2, 0.2, 2.5, 0.5, "Thermal Label Test");

            //Define a BarcodeItem object
            BarcodeItem bcItem = new BarcodeItem(0.2, 1, 2, 1, BarcodeSymbology.Code128, "ABC 12345");
            //Set bars height to .75inch
            bcItem.BarHeight = 0.75;
            //Set bars width to 0.0104inch
            bcItem.BarWidth = 0.0104;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(bcItem);

            //Create a WindowsPrintJob object
            using (WindowsPrintJob pj = new WindowsPrintJob())
            {
                //Create PrinterSettings object
                PrinterSettings myPrinter = new PrinterSettings();
                myPrinter.Communication.CommunicationType = CommunicationType.USB;
                myPrinter.Dpi = 203;
                myPrinter.ProgrammingLanguage = ProgrammingLanguage.ZPL;
                myPrinter.PrinterName = "Zebra  TLP2844-Z";

                //Set PrinterSettings to WindowsPrintJob
                pj.PrinterSettings = myPrinter;
                //Print ThermalLabel object...
                pj.Print(tLabel);
            }

        }

        private ThermalLabel GeneratePartLabel(int PartID)
        {


            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 4, 3);
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
    }
}
