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


            StringWriter stringWriter = new StringWriter();




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
            msg.From = new MailAddress("alerts@designsynthesis.net", "Knoodle-Receiving");
            msg.Subject = string.Format("Order Number : {0} ", order.PurchaseOrderID.ToString());

            msg.Body = stringWriter.ToString();



            smtp.Send(msg);
        }

    }
}
