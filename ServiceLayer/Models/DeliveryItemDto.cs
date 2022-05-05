using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using DataLayer.Entity;

namespace ServiceLayer.Models
{
    public class DeliveryItemDto : INotifyPropertyChanged
    {
        private int deliveryID;
        private int deliveryItemID;
        private int subAssemblyID;
        private string description;
        private int productID;
        private int partID;
        private decimal qnty;
        private bool onBoard;
        private bool delivered;

        public event PropertyChangedEventHandler PropertyChanged;

        public int DeliveryID
        {
            get { return deliveryID; }
            set { deliveryID = value; OnPropertyChange(); }
        }

        public int DeliveryItemID
        {
            get { return deliveryItemID; }
            set { deliveryItemID = value;OnPropertyChange(); }
        }

        public int SubAssemblyID
        {
            get { return subAssemblyID; }
            set
            { 
                subAssemblyID = value; 
                OnPropertyChange();
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChange(); }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; OnPropertyChange(); }
        }

        public int PartID
        {
            get { return partID; }
            set { partID = value;OnPropertyChange(); }
        }

        public decimal Qnty
        {
            get { return qnty; }
            set { qnty = value;OnPropertyChange(); }
        }


        public bool OnBoard
        {
            get { return onBoard; }
            set 
            { 
              onBoard = value; 
              OnPropertyChange();
            }
        }

        public bool Delivered
        {
            get { return delivered; }
            set { delivered = value;OnPropertyChange(); }
        }

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
