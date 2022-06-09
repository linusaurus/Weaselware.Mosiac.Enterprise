using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class InventoryDto : INotifyPropertyChanged
    {
        private int stockTransactionID;
        private int? orderReceiptID;
        private int? lineID;
        public int? partID;
        public int? jobID;
        public string location;
        public int? productID;
        public DateTime? dateStamp;
        public decimal? qntyOrdered;
        public string note;
        public string description;
        public int? unitOfMeasureID;
        public int? transActionType;
        public int? empID;
        public decimal? qntyReceived;
        public decimal? inventoryAmount;

        public int StockTransactionID 
        {
            get {return stockTransactionID; }
            set
            { 
                stockTransactionID = value;
                NotifyPropertyChanged();
            }
        }
        public int? OrderReceiptID 
        { 
            get { return orderReceiptID; }
            set 
            { 
                orderReceiptID = value;
                NotifyPropertyChanged();
            }
        }
        public int? LineID
        {
            get {return lineID; }

            set
            {
                lineID = value;
                NotifyPropertyChanged();
            }
        }
        public int? PartID
        {
            get {return partID; }
            set
            {
                partID = value;
                NotifyPropertyChanged();
            }
        }
        public int? JobID
        {
            get { return jobID; }
            set 
            { 
                jobID = value;
                NotifyPropertyChanged();
            }
        }
        public string Location 
        {
            get {return location; }
            set 
            { 
                location = value;
                NotifyPropertyChanged();
            }
        }
        public int? ProductID 
        { get 
            { 
                return productID;
            }
            set
            { 
                productID = value;
                NotifyPropertyChanged();
            } 
        }
        public DateTime? DateStamp 
        {
            get { return dateStamp; }
            set 
            {
                dateStamp = value;
                NotifyPropertyChanged();
            }
        }
        public decimal? QntyOrdered 
        {
            get { return qntyOrdered; }
            set 
            { 
                qntyOrdered = value;
                NotifyPropertyChanged();
            }
        }
        public string Note
        {
            get { return note; }
            set { note = value; NotifyPropertyChanged(); }
        }
        public string Description
        {
            get { return description; }
            set { description = value;NotifyPropertyChanged(); }
        }
        public int? UnitOfMeasureID 
        {
            get {return unitOfMeasureID; }
            set
            { 
                unitOfMeasureID = value;
                NotifyPropertyChanged();
            }
        }
        public int? TransActionType 
        {
            get {return transActionType; }
            set 
            { 
                transActionType = value;
                NotifyPropertyChanged();
            }
        }
        public int? EmpID 
        {
            get { return empID; }
            set 
            { 
                empID = value;
                NotifyPropertyChanged();
            }
        }
        public decimal? QntyReceived
        {
            get { return qntyReceived; }

            set { qntyReceived = value;NotifyPropertyChanged(); }
        }
        public decimal? InventoryAmount 
        {
            get { return inventoryAmount; }
            set
            {
                inventoryAmount = value;NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
