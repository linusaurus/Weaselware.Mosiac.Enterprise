using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ServiceLayer.Models
{
    public class LineItemDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       

        private int lineID;
        private int purchaseOrderID;
        private int jobID;
        private int partID;
        private int uid;
        private string unitOfMeasureName;
        private decimal quantity;
        private string description;
        private decimal price;
        private decimal extended;
        private string partNum;


        /// <summary>
        /// LineID
        /// </summary>
        public int LineID 
        {
            get { return lineID; }
            set
            {
                lineID = value;
                OnPropertyChange();
            }
        }
        public string UnitOrderMeasureName
        {
            get { return unitOfMeasureName; }
            set
            {
                unitOfMeasureName = value;
                OnPropertyChange();
            }
        }
        /// <summary>
        /// PurchaseOrderID
        /// </summary>
        public int PurchaseOrderID 
        {
            get { return purchaseOrderID; }
            set
            {
                purchaseOrderID = value;
                OnPropertyChange();

            } 
        }
        /// <summary>
        /// JobID
        /// </summary>
        public int JobID
        {
            get { return jobID; }
            set
            {
                jobID = value;
                OnPropertyChange();
            }
        }
        /// <summary>
        /// PartID
        /// </summary>
        public int PartID 
        {
            get { return partID; }
            set
            { 
               partID = value ;
               OnPropertyChange();
            }
        }

        public string PartNum
        {
            get { return partNum; }
            set { partNum = value; OnPropertyChange(); }
        }
        /// <summary>
        /// UiD
        /// </summary>
        public int UiD
        {
            get { return uid; }
            set
            {
                uid = value;
                OnPropertyChange();
            } 
        }
        /// <summary>
        /// Quantity
        /// </summary>
        public decimal Quantity 
        {
            get { return quantity; }
            set
            {
                quantity= value ;
                extended = price * quantity;
                OnPropertyChange();

                
            }
        }
        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChange();
               
            }
        }
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                extended = price * quantity;
                OnPropertyChange();
                
            }
        }
        /// <summary>
        /// Extended
        /// </summary>
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
