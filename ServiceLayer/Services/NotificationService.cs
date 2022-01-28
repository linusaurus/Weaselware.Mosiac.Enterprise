using System;
using System.Collections.Generic;

using ServiceLayer.Models;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace ServiceLayer { 
    public static class NotificationService 
    {
       

        public static void SendNotificaion(string toAddress, OrderReceiptDto order)
        {
            //EmployeeService _empService = new EmployeeService();

            StringWriter stringWriter = new StringWriter();

            StringBuilder sb = new StringBuilder();


            String userName = "designsynthesis.notifications@gmail.com";
            String password = "Kx09a32x";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password)
            };

            System.Net.Mail.MailMessage msg = new MailMessage("alerts@designsynthesis.net", toAddress);
            msg.IsBodyHtml = true;
            msg.From = new MailAddress("alerts@designsynthesis.net", "Mosiac-Receiving");
            msg.Subject = string.Format("Order Number : {0} ", order.PurchaseOrderID.ToString());

            sb.AppendLine($"Recieved by {order.EmployeeName.ToString()} at {order.ReceiptDate.ToShortDateString()}");
            sb.AppendLine();
            msg.Body = sb.ToString();

            msg.Body += "<table width='100%' style='border:Solid 1px Black;'>";

            foreach (var line in order.OrderReceiptLineItems)
            {
                msg.Body += "<tr>";
                msg.Body += "<td stlye='color:blue;'>" + line.Description + "</td>" + "<td stlye='color:blue;'>" + line.QntyOrdered + "</td>" + "<td stlye='color:blue;'>" + line.QntyToInventory + "</td>";
                msg.Body += "</tr>";
            }

            msg.Body += "</table>";



            smtp.Send(msg);
        }

       

      
    }
}
