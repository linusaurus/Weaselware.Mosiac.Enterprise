using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Employee
    {
        public Employee()
        {
            OrderReciepts = new HashSet<OrderReciept>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int employeeID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public bool? IsPurchaser { get; set; }
        public string EmployeeEmail { get; set; }
        public bool? Show { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }

        public virtual ICollection<OrderReciept> OrderReciepts { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
