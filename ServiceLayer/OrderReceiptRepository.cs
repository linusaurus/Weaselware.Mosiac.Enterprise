using DataLayer.Entity;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace ServiceLayer
{
    public class OrderReceiptRepository : IOrderReceiptRepository
    {
        private readonly BadgerContext _ctx;

        public OrderReceiptRepository()
        {
            _ctx = new BadgerContext();
        }

        public IEnumerable<OrderReciept> Find(Expression<Func<OrderReciept, bool>> predicate)
        {
            return _ctx.OrderReciepts.Where(predicate);
        }

        public OrderReciept Get(int id)
        {
            return _ctx.OrderReciepts.Find(id);
        }
    }
}
