using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neodynamic.SDK.Printing;
using Neodynamic.SDK;



namespace Mosiac.UX {
    
    
    public class LabelService {

        public LabelService() {
            ThermalLabel.LicenseOwner = "Richard Young-Standard Edition-Developer License";
            ThermalLabel.LicenseKey = "MC4J7E7UM8BDLXA72PEWSJ84NR5FXRVBKPANLSYTCCGKKNMW9N6A";
        }

        public ThermalLabel GenerateInventoryDetailLabel(string LineID, string jobname, string orderNumber,string receiver, string revDate)
        {
            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2, 1);
            tLabel.GapLength = 0.2;

            //Define a TextItem object
            TextItem txtItem = new TextItem(0.1, 0.10, 1.75, 0.125, "Job = " + jobname);
            txtItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontA;
            txtItem.Font.Unit = FontUnit.Point;
            txtItem.Font.Size = 7;
            txtItem.TextAlignment = TextAlignment.Left;

            TextItem txt2Item = new TextItem(0.1, 0.20, 1.75, 0.125, "Recv Date:  " +  revDate );
            txt2Item.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontA;
            txt2Item.Font.Unit = FontUnit.Point;
            txt2Item.Font.Bold = true;
            txt2Item.Font.Size = 7;
            txt2Item.TextAlignment = TextAlignment.Left;

            TextItem txt3Item = new TextItem(0.1, 0.3, 1.75, 0.125, "Order Number:   " + orderNumber );
            txt3Item.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontA;
            txt3Item.Font.Unit = FontUnit.Point;
            txt3Item.Font.Size = 7;
            txt3Item.TextAlignment = TextAlignment.Left;

            TextItem txt4Item = new TextItem(0.1, 0.4, 1.75, 0.125, "Recieved By:  " + receiver);
            txt4Item.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontA;
            txt4Item.Font.Unit = FontUnit.Point;
            txt4Item.Font.Size = 7;
            txt4Item.TextAlignment = TextAlignment.Left;

            //Define a BarcodeItem object
            BarcodeItem bcItem = new BarcodeItem(0.1, 0.53, 1.75, 0.45, BarcodeSymbology.Code39, LineID);
            bcItem.AddChecksum = false;
            bcItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontS;
            bcItem.Font.Unit = FontUnit.Point;
            bcItem.Font.Size = 7;
            bcItem.CodabarStopChar = CodabarStartStopChar.A;

            //Set bars height to .75inch
            bcItem.BarHeight = 0.325;
            //Set bars width to 0.0104inch
            bcItem.BarWidth = 0.0104;
            bcItem.BarcodeAlignment = BarcodeAlignment.MiddleCenter;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(bcItem);
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(txt2Item);
            tLabel.Items.Add(txt3Item);
            tLabel.Items.Add(txt4Item);

            return tLabel;
        }

        public ThermalLabel GenerateInventoryLabel(string LineID, string jobname, string revDate) {
            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2, 1);
            tLabel.GapLength = 0.2;

            //Define a TextItem object
            TextItem txtItem = new TextItem(0.1, 0.19, 1.75, 0.125, "Job= " + jobname);
            txtItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            txtItem.Font.Unit = FontUnit.Point;
            txtItem.Font.Size = 7;
            txtItem.TextAlignment = TextAlignment.Left;

            TextItem txt2Item = new TextItem(0.1, 0.300, 1.75, 0.125, "Recv Date:" + revDate + "---");
            txt2Item.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            txt2Item.Font.Unit = FontUnit.Point;
            txt2Item.Font.Size = 7;
            txt2Item.TextAlignment = TextAlignment.Left;

            //Define a BarcodeItem object
            BarcodeItem bcItem = new BarcodeItem(0.1, 0.45, 1.75, 0.375, BarcodeSymbology.Code39, LineID);
            bcItem.AddChecksum = false;
            bcItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            bcItem.Font.Unit = FontUnit.Point;
            bcItem.Font.Size = 7;
            bcItem.CodabarStopChar = CodabarStartStopChar.A;

            //Set bars height to .75inch
            bcItem.BarHeight = 0.375;
            //Set bars width to 0.0104inch
            bcItem.BarWidth = 0.0104;
            bcItem.BarcodeAlignment = BarcodeAlignment.MiddleCenter;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(bcItem);
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(txt2Item);


            return tLabel;
        }

        public ThermalLabel GeneratePartLabel(string PartID, string partDescription)
        {
            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 2, 1);
            
            tLabel.GapLength = 0.2;

            //Define a TextItem object
            TextItem txtItem = new TextItem(0.1, 0.25, 1.75, 0.25, "PN | " + PartID);
            txtItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            //txtItem.RotationAngle = 90;
            txtItem.Font.Unit = FontUnit.Point;
            txtItem.Font.Size = 10;
            txtItem.TextAlignment = TextAlignment.Center;

            //Define a TextItem object
            TextItem txt2 = new TextItem(0.03, 0.15, 1.9, 0.125, "DESIGN SYNTHESIS");
            txt2.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontS;
            //txt2.RotationAngle = 90;
            txt2.Font.Unit = FontUnit.Point;
            txt2.Font.Size = 4;
            txt2.TextAlignment = TextAlignment.Center;

            //A simple vertical line
            LineShapeItem l3 = new LineShapeItem(1.85, 0.1, 0.01, 0.870);
            l3.StrokeThickness = 0.05;
            l3.Orientation = LineOrientation.Vertical;

            //A simple vertical line
            LineShapeItem l2 = new LineShapeItem(0.105, 0.1, 0.01, 0.870);
            l2.StrokeThickness = 0.05;
            l2.Orientation = LineOrientation.Vertical;



            //Define a BarcodeItem object

            BarcodeItem bcItem = new BarcodeItem(0.5, 0.4, 1.0, 0.5, BarcodeSymbology.Code39, PartID);
            bcItem.AddChecksum = false;
            bcItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontS;
            
            bcItem.Font.Unit = FontUnit.Point;
            
            bcItem.Font.Size = 4;
            bcItem.CodabarStopChar = CodabarStartStopChar.A;
            bcItem.BarHeight = 0.375;
            bcItem.BarWidth = 0.0104;
            bcItem.BarcodeAlignment = BarcodeAlignment.MiddleCenter;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(bcItem);
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(txt2);
            tLabel.Items.Add(l3);
            tLabel.Items.Add(l2);



            return tLabel;
        }

        public void PrintLabel(ThermalLabel label) {
            using (PrintJob pj = new PrintJob(Properties.Settings.Default.PrinterSetting))
            {
                pj.PrinterSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL;
                pj.ThermalLabel = label; // set the ThermalLabel object
                pj.PrinterSettings.Dpi = 203;
                // pj.Copies = 2;
                //pj.Print(); // print the ThermalLabel object  

               pj.ExportToImage(label, @"c:\temp\myLabel.jpg", new ImageSettings(ImageFormat.Jpeg), 300);
            }
        }

        public void PrintLabel(ThermalLabel label,int Qnty)
        {
            using (PrintJob pj = new PrintJob(Properties.Settings.Default.PrinterSetting))
            {
                //pj.PrinterSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL;
                pj.ThermalLabel = label; // set the ThermalLabel object
                pj.PrinterSettings.Dpi = 203;
                pj.Copies = Qnty;
                pj.Print(); // print the ThermalLabel object  
               // pj.ExportToImage(label, @"c:\temp\myLabel.jpg", new ImageSettings(ImageFormat.Jpeg), 300);
            }
        }

        public void SetPrintingOption() {

            //PrintJobDialog printJobDialog = new PrintJobDialog();
            //printJobDialog.ShowDialog();
            //if (printJobDialog.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //   Properties.Settings.Default.PrinterSetting = printJobDialog.PrinterSettings;
            //    Properties.Settings.Default.Save();
            //}
             
            
        }


    }
}
