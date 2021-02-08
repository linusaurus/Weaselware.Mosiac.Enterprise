using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using System;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using ServiceLayer.Overloads;

namespace MosiacText
{
    [TestClass]
    public class OrderRecieptUnitTest
    {
        private BadgerContext _context;
        private OrderReceiptRepository _repository;


        [TestInitialize]
        public void TextInitialize()
        {
            DbContextOptions <BadgerContext> dbContextOptions = new DbContextOptionsBuilder<BadgerContext>()
                    .UseInMemoryDatabase("MosiacDB").Options;
                 _context = new BadgerContext(dbContextOptions);

            _repository = new OrderReceiptRepository(_context);
            Assert.IsNotNull(_repository);
        }

        [TestMethod]
        public void Add_OrderReceipt_Success()
        {
            OrderReciept orderReciept = new OrderReciept
            {
                OrderNum = 6234,
                EmployeeID = 8,
                ReceiptDate = System.DateTime.Today,
                IsOrderComplete = true    
            };

            _repository.Add(orderReciept);
            _repository.SaveChanges();

            var result = _repository.Get(orderReciept.OrderReceiptID);

            Assert.IsTrue(orderReciept == result);
        }
        
        [TestMethod]
        public void CreateOrderReceiptDTO_Success()
        {
            OrderReceiptDto dto = new OrderReceiptDto
            {
                EmployeeId = 8,
                ReceiptDate = System.DateTime.Today,
                EmployeeName = "Richard",
                IsOrderComplete = true,
                PurchaseOrderID = 2000
            };
            // Generate and add 3 rows of items
            for (int i = 0; i < 3; i++)
            {
                dto.OrderReceiptLineItems.Add(new OrderRecieptLineItemDto
                {
                    PartID = 1234,
                    UnitPrice = 1.25m,
                    Description = "Lineitem description",
                    JobID = 2445,
                    UiD = 1,
                    QntyOrdered = 1.2m,
                    QntyBalance = 0.0m,
                    QntyReceived = 1.2m,
                    Note = "Not an important",
                    UnitOfMeasureName = "Each",
                    Extended = 12.25m,
                    ItemsRecievedComplete = true
                    
                });
            }

            _repository.UpdateOrCreate(dto);
            // return the recently added order receipt
            var result = _repository.Get(1);

            Assert.IsTrue(result.OrderReceiptID == 1);
            Assert.IsTrue(result.OrderReceiptItems.Count == 3);
            foreach (var Orderline in result.OrderReceiptItems)
            {
                Assert.IsTrue(Orderline.JobID == 2445);
                Assert.IsTrue(Orderline.OrderReceiptID == 1);
            }

            

        }

        [TestMethod]
        public void  Should_Retrun_OrderReceiptDTO()
        {
            OrderReceiptDto dto = new OrderReceiptDto();
            int id = 1;
            OrderReciept orderReceipt = _repository.Get(id);
            OrderReceiptMapper mapper = new OrderReceiptMapper();
            mapper.Map(orderReceipt, dto);
            Assert.IsNotNull(dto);
            Assert.IsTrue(dto.OrderReceiptId != default);
          

        }
    }
}
