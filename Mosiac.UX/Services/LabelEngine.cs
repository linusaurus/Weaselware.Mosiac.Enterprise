using Neodynamic.SDK.Printing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ServiceLayer.Services;
using ServiceLayer.Models;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Data;

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
            txtItem.Font.Size = 9;
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
            TextItem txtItem = new TextItem(0.1, 0.1, 1.95, 0.125, txt1);
            txtItem.TextAlignment = TextAlignment.Center;
            txtItem.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            txtItem.Font.Size = 10;

            // Jobname --
            string txtJobName = $"Job : {dto.jobname}";
            TextItem txtJobInfo = new TextItem(0.1, 0.24, 1.95, 0.26, txtJobName);
            txtJobInfo.Sizing = TextSizing.ParagraphScaling;
            //txtJobInfo.Sizing = TextSizing.FontSizeScaling;
            txtJobInfo.BorderThickness = new FrameThickness(0.01);
            txtJobInfo.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            txtJobInfo.Font.Size = 12;

            // Description --
            string txtd = $" {dto.Description}";
            TextItem txtdesc = new TextItem(0.1, 0.31, 1.95, 0.38, txtd);
            //txtdesc.Sizing = TextSizing.ParagraphScaling;
            txtdesc.Sizing = TextSizing.FontSizeScaling;
            txtdesc.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontS;
            txtdesc.Font.Size = 6;

            // Qnty Recieved --
            string txt3 = $"Qnty : {dto.QuantityReceived} - {dto.ReceiptDate.ToShortDateString()}";
            TextItem txtDate = new TextItem(0.1, 0.54, 1.95, 0.60, txt3);
            //txtDate.Sizing = TextSizing.ParagraphScaling;
            txtDate.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            txtDate.Font.Size = 6;

            //Recieved By
            string txt4 = $"Recieved by : {dto.firstname}";
            TextItem txtReceiver = new TextItem(0.1, 0.65, 1.95, 0.24, txt4);
            txtReceiver.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontB;
            txtReceiver.Font.Size = 6;

            //Define a **BarcodeItem** object for encoding Code 39 symbology
            BarcodeItem bc1 = new BarcodeItem(0.25, 0.80, 1.5, .375, BarcodeSymbology.Codabar, dto.StockTransactionID.ToString());
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
            //tLabel.Items.Add(txtdesc);
     
            tLabel.Items.Add(txtDate);
            tLabel.Items.Add(txtReceiver);
            tLabel.Items.Add(bc1);

            return tLabel;

        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }

        public static ThermalLabel GeneratePackingListLabel(PackingListItemDto dto)
        {

            string xmlData = "";

            XmlSerializer serializer = new XmlSerializer(typeof(PackingListItemDto));

            ThermalLabel tLabel = new ThermalLabel();
            tLabel.LoadXmlTemplate(System.IO.File.ReadAllText("24StockLabel.tl"));

            using (var sw = new Utf8StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    serializer.Serialize(writer, dto);
                    xmlData = sw.ToString();
                }
            }
            StringReader xmlSR = new StringReader(xmlData);
            var ds = new DataSet();
            ds.ReadXml(xmlSR);
            tLabel.DataSource = ds;

            return tLabel;
        }

        public static ThermalLabel GenerateLargeStockTag(StockTagDto dto)
        {
       
            string xmlData = "";

            XmlSerializer serializer = new XmlSerializer(typeof(StockTagDto));
            
            ThermalLabel tLabel = new ThermalLabel();
            tLabel.LoadXmlTemplate(System.IO.File.ReadAllText("24StockLabel.tl"));

            using (var sw = new Utf8StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    serializer.Serialize(writer, dto);
                    xmlData = sw.ToString();
                }
            }
            StringReader xmlSR = new StringReader(xmlData);
            var ds = new DataSet();
            ds.ReadXml(xmlSR);
            tLabel.DataSource = ds;

            return tLabel;
        }

        public  string ToXML()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stringwriter, this);
                return stringwriter.ToString();
            }
        }

        public static StockTagDto LoadFromXMLString(string xmlText)
        {
            using (var stringReader = new System.IO.StringReader(xmlText))
            {
                var serializer = new XmlSerializer(typeof(StockTagDto));
                return serializer.Deserialize(stringReader) as StockTagDto;
            }
        }

        //public static PackingListItemDto LoadPacklistItemXMLString(string xmlText)
        //{
        //    using (var stringReader = new System.IO.StringReader(xmlText))
        //    {
        //        var serializer = new XmlSerializer(typeof(StockTagDto));
        //        return serializer.Deserialize(stringReader) as StockTagDto;
        //    }
        //}


    }
}
