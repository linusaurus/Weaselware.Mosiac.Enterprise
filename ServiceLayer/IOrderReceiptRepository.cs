using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Models;

namespace ServiceLayer
{
    public interface IOrderReceiptRepository : IRepository<OrderReciept>
    {
        IEnumerable<OrderReciept> GetOrderReciepts(int supplierId);
        IEnumerable<OrderReciept> GetPurchaseOrderReceipts(int purchaseOrderId);

        OrderReceiptDto UpdateOrCreate(OrderReceiptDto dto);
        
    }
}
