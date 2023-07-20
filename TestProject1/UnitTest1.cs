
using ServiceLayer;
using ServiceLayer.Models;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 0; i < 120; i++)
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
        }
    }
}