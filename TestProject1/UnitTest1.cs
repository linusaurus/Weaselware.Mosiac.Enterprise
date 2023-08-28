
using ServiceLayer;
using ServiceLayer.Models;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string Conn = "Data Source=dbserver;Initial Catalog=Mosaic;Integrated Security=True;Trust Server Certificate=true";
        
        [TestMethod]
        public void TestMethod1()
        {
                    
            OrderReceiptDto orderReceiptDto = new OrderReceiptDto();
            //orderReceiptDto.OrderState = 2;
            orderReceiptDto.PurchaseOrderID = 1;
            orderReceiptDto.OrderReceiptId = 2334;
            orderReceiptDto.EmployeeId = 8;
            orderReceiptDto.EmployeeName = "sirous@designsynthesis.net";
            orderReceiptDto.JobName = "Email olympics!";         
            NotificationService.SendNotificaion("sirous@designsynthesis.net", orderReceiptDto);
            
        }

        [TestMethod]
        public void TestMethod2() 
        {
            InventoryService service = new InventoryService(new DataLayer.Data.MosaicContext(Conn));
            var result = service.GetLocationParts(1);
            Assert.IsNotNull(result);
           
        }
    }
}