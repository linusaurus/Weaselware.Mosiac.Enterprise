using NUnit.Framework;
using ServiceLayer;
using ServiceLayer.Models;
using DataLayer.Data;
using DataLayer.Entity;
using System;

namespace MosaicTextProject
{
    public class Tests
    {
        MosaicContext ctx;
        OrderReceiptRepository service;

        [SetUp]
        public void Setup()
        {
            ctx = new MosaicContext("Data Source=dbserver;Initial Catalog=Mosaic;Integrated Security=True");
            service = new OrderReceiptRepository(ctx, "Richard", 8);
            
        }

        [TearDown]
        public void TearDown()
        {
            ctx.Dispose();
        }

      
        [Test]
        public void Return_Stock_Tag()
        {
            var result = service.GetStockTag(1178);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.OrderReceiptLineID == 1178);

        }

        [Test]
        public void Make_XML_Output()
        {
            
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(currentReceiptItem.GetType());

  
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, currentReceiptItem);
        }
       
    }
}