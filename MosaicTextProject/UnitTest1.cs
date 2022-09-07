using NUnit.Framework;
using ServiceLayer;
using System.Linq;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using Microsoft.EntityFrameworkCore;
using DataLayer.Data;
using DataLayer.Entity;
using System;



namespace MosaicTextProject
{
    public class Tests
    {
        MosaicContext ctx;
        OrderReceiptRepository service;
        OrdersService ordersService;
        StockService stockService;

        [SetUp]
        public void Setup()
        {
            ctx = new MosaicContext("Data Source=dbserver;Initial Catalog=Mosaic;Integrated Security=True");
            service = new OrderReceiptRepository(ctx, "Richard", 8);
            ordersService  = new OrdersService(ctx);
            stockService = new StockService(ctx);
            
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
        public void Request_Order_Status()
        {
            PurchaseOrder po = ordersService.GetOrderByID(28004);
            OrderDetailDto dto = new OrderDetailDto();
            PurchaseOrderMapper mapper = new PurchaseOrderMapper();
            mapper.Map(po,dto);
            NotificationService.SendUpdateRequest("rich@designsynthesis.net", dto);
        }

        [Test]
        public  void Pull_PartID_From_Inventory()
        {
           
            decimal stockNow =  ctx.Inventory.AsNoTracking().Where(r => r.PartID == 1).Sum(i => i.InventoryAmount).GetValueOrDefault();
            stockService.PullPart("1", 1.0m, 1);
            decimal stockAfter = ctx.Inventory.AsNoTracking().Where(r => r.PartID == 1).Select(i => i.InventoryAmount).Sum().GetValueOrDefault();
            stockAfter += 1.0m;
            Assert.That(stockNow , Is.EqualTo(stockAfter).Within(0.0000000001));
        }

    }
}