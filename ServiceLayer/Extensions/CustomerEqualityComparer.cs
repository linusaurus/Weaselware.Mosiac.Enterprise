using DataLayer.Entity;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ServiceLayer.Overloads
{

    public class OrderRecieptComparer : EqualityComparer<OrderReciept>
    {

        public override bool Equals(OrderReciept x, OrderReciept y)
        {
            return x.OrderReceiptID == y.OrderReceiptID
                && x.PurchaseOrderID == y.PurchaseOrderID;
        }

        public override int GetHashCode([DisallowNull] OrderReciept obj)
        {
            int randomNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(int.MaxValue / 2);
            return (obj.OrderReceiptID + obj.PurchaseOrderID + randomNumber).GetHashCode();
        }


       
    }



}