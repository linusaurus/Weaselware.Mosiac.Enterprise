using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ServiceLayer.Models
{
    public class OrderReceiptDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public int OrderReceiptId { get; set; }
        public bool IsOrderComplete { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int PurchaseOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReceiptDate { get; set; }
        public virtual List<OrderRecieptLineItemDto> OrderReceiptLineItems { get; set; } =  new List<OrderRecieptLineItemDto>();

        public int OrderState
        {
            get
            {
                if( OrderReceiptLineItems.All(c => c.QntyOrdered == c.QntyReceived))
                {
                    return 2;
                }
                else if(OrderReceiptLineItems.Any(c => c.QntyOrdered > c.QntyReceived))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}

