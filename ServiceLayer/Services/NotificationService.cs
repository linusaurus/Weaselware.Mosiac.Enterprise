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
            String password = "adnskqtevqvwaohs";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password)
            };

            try
            {
                System.Net.Mail.MailMessage msg = new MailMessage("alerts@designsynthesis.net", toAddress);
                msg.IsBodyHtml = true;
                msg.From = new MailAddress("alerts@designsynthesis.net", "Mosiac-Receiving");
                msg.Subject = string.Format("Order Number : {0} ", order.PurchaseOrderID.ToString());

                sb.AppendLine($"Recieved by {order.EmployeeName.ToString()} at {DateTime.Now.DayOfWeek}, {DateTime.Today.ToShortDateString()}, {DateTime.Now.ToShortTimeString()}");
                sb.AppendLine();
                msg.Body = sb.ToString();

                msg.Body += "<table width='100%' style='background-color: #EDE8E3'>";
                msg.Body += "<th>Description</th>";
                msg.Body += "<th>Qnty Ordered</th>";
                msg.Body += "<th>Qnty Received</th>";

                foreach (var line in order.OrderReceiptLineItems)
                {
                    msg.Body += "<tr>";
                    msg.Body += "<td style=size= '8';>" + line.Description + "</td>" + "<td style='color:blue;'>" + line.QntyOrdered + "</td>" + "<td style='color:blue;'>" + line.QntyToInventory + "</td>";
                    msg.Body += "</tr>";
                }

                msg.Body += "</table>";



                smtp.Send(msg);

            }
            catch (Exception)
            {

              // Do Nothing;

            }
           


        }

       

      
    }
}
