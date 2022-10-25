using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class LineItemSearchDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int lineID;
        public int purchaseOrderID;
        public DateTime orderDate;
        public string jobName;
        public string supplierName;
        public int PartID;
        public string UnitOfMeasureName;
        public decimal quantity;
        public string description;
        public decimal Extended;

        public int LineID
        { 
            get { return lineID; }
            set { lineID = value; }
        }

        public int PurchaseOrderID
        {
            get { return purchaseOrderID; }
            set { purchaseOrderID = value; }
        }
         public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public string Description
        {
            get { return description; }
            set{ description = value;}
        }

        public string JobName
        {
            get { return jobName; }
            set { jobName = value; }

        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
