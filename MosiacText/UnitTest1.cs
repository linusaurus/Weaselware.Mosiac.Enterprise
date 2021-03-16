using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using System;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using ServiceLayer.Overloads;

namespace OrderReceipt_repo_Test
{
    [TestClass]
    public class OrderRecieptUnitTest
    {
        private MosaicContext _context;
        private OrderReceiptRepository _repository;
        


        [TestInitialize]
        public void TextInitialize()
        {
            DbContextOptions <MosaicContext> dbContextOptions = new DbContextOptionsBuilder<MosaicContext>()
                    .UseInMemoryDatabase("MosiacDB").Options;
                 _context = new MosaicContext(dbContextOptions);

            _repository = new OrderReceiptRepository(_context);
            Assert.IsNotNull(_repository);
        }

        [TestMethod]
        public void Add_OrderReceipt_Success()
        {
           var result =  _repository.GetOrderReceipts(9323);

            //Assert.IsTrue(orderReciept == result);
            //_context.Remove(result);
            //_context.SaveChanges();
        }
        
        [TestMethod]
        public void CreateUpdate_OrderReceiptDTO_Success()
        {
        //    OrderReceiptDto dto = new OrderReceiptDto
        //    {
        //        EmployeeId = 8,
        //        ReceiptDate = System.DateTime.Today,
        //        EmployeeName = "Richard",
        //        IsOrderComplete = true,
        //        PurchaseOrderID = 2000
        //    };
        //    // Generate and add 3 rows of items
        //    for (int i = 0; i < 3; i++)
        //    {
        //        dto.OrderReceiptLineItems.Add(new OrderRecieptLineItemDto
        //        {
        //            PartID = 1234,
        //            UnitPrice = 1.25m,
        //            Description = "Lineitem description",
        //            JobID = 2445,
        //            UiD = 1,
        //            QntyOrdered = 1.2m,
        //            QntyBalance = 0.0m,
        //            QntyReceived = 1.2m,
        //            Note = "Not an important",
        //            UnitOfMeasureName = "Each",
        //            Extended = 12.25m,
        //            ItemsRecievedComplete = true
                    
        //        });
        //    }

        //    _repository.UpdateOrCreate(dto);
        //    // return the recently added order receipt
        //    var result = _repository.Get(1);

        //    Assert.IsTrue(result.OrderReceiptID == 1);
        //    Assert.IsTrue(result.OrderReceiptItems.Count == 3);
        //    foreach (var Orderline in result.OrderReceiptItems)
        //    {
        //        Assert.IsTrue(Orderline.JobID == 2445);
        //        Assert.IsTrue(Orderline.OrderReceiptID == 1);
        //    }
        //    _context.Remove(result);
        //    _context.SaveChanges();
            

        }
    }
}
