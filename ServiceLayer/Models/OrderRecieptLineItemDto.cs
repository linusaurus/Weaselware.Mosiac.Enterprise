using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ServiceLayer.Models
{
    public  class OrderRecieptLineItemDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int orderRecieptLineID;
        private int orderRecieptID;
        private int lineID;
        private int stockTransactionID;
        private int purchaseOrderID;
        private int jobID;
        private int partID;
        private bool itemReceivedComplete;
        //----
        private int uid;
        private string unitOfMeasureName;
        private decimal unitToQuantityRatio;
        //----

        private decimal qntyOrdered;
        private decimal qntyRecieved;
        private decimal qntyBalance;

        private string description;
        private decimal unitPrice;
        private decimal extended;
        private string note;

        public int StockTransaction
        {
            get { return stockTransactionID; }
            set
            {
                stockTransactionID = value;
                OnPropertyChange();
            }
        }

        public decimal UnitToQuantityRatio
        {
            get { return unitToQuantityRatio; }
            set
            {
                unitToQuantityRatio = value;
            
                OnPropertyChange();
            }
        }

        public string Note
        {
            get { return note; }
            set
            {
                note = value;
                OnPropertyChange();
            }
        }

        public int OrderReceiptLineID
        {
            get { return orderRecieptLineID; }
            set
            {
                orderRecieptLineID = value;
                OnPropertyChange();
            }
        }
        public int OrderReceiptID
        {
            get { return orderRecieptID; }
            set
            {
                orderRecieptID = value;
                OnPropertyChange();
            }
        }
        public int LineID
        {
            get { return lineID; }
            set
            {
                lineID = value;
                OnPropertyChange();
            }
        }
        public int PurchaseOrderID
        {
            get { return purchaseOrderID; }
            set
            {
                purchaseOrderID = value;
                OnPropertyChange();
            }
        }
        public int JobID
        {
            get { return jobID; }
            set
            {
                jobID = value;
                OnPropertyChange();
            }
        }
        public int UiD
        {
            get { return uid; }
            set
            {
                uid = value;
                OnPropertyChange();
            }
        }
        public int PartID
        {
            get { return partID; }
            set
            {
                partID = value;
                OnPropertyChange();
            }
        }
        public string UnitOfMeasureName
        {
            get { return unitOfMeasureName; }
            set
            {
                unitOfMeasureName = value;
                OnPropertyChange();
            }
        }
        public decimal QntyOrdered
        {
            get { return qntyOrdered; }
            set
            {
                qntyOrdered = value;
                OnPropertyChange();
            }
        }

        public decimal QntyReceived
        {
            get { return qntyRecieved; }
            set
            {
                qntyRecieved = value;
                qntyBalance = qntyOrdered - qntyRecieved;
                if (qntyBalance == default)
                {
                    itemReceivedComplete = true;
                }
                OnPropertyChange();
            }
        }

        public decimal QntyBalance
        {
            get { return qntyBalance; }
            set
            {
                qntyBalance = value;
                OnPropertyChange();
            }
        }

        public bool ItemsRecievedComplete
        {
            get { return itemReceivedComplete; }
            set
            {
                itemReceivedComplete = value;
                if (itemReceivedComplete)
                {
                    QntyReceived = QntyOrdered; 
                } else
                {
                    QntyReceived = decimal.Zero;
                }
                OnPropertyChange();
            }
        }


        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChange();
            }
        }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                unitPrice = value;
                OnPropertyChange();
            }
        }
        public decimal Extended
        {
            get { return extended; }
            set
            {
                extended = value;
                OnPropertyChange();
            }
        }

       
       


        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
