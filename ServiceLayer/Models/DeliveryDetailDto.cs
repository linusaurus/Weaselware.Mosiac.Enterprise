using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace ServiceLayer.Models
{
    public class DeliveryDetailDto : INotifyPropertyChanged
    {
        private int deliveryID;
        private DateTime deliveryDate;
        private int jobID;
        private int employeeID;
        private int itemCount;
        private int jobSiteID;
        private List<DeliveryItemDto> deliveryItems = new List<DeliveryItemDto>();

        public event PropertyChangedEventHandler PropertyChanged;

        public List<DeliveryItemDto> DeliveryItem
        {
            get { return deliveryItems; }
            set
            {
                deliveryItems = value;
                OnPropertyChange();
            }
        }
            
        public int DeliveryID
        {
            get { return deliveryID; }
            set 
            {
                deliveryID = value;
                OnPropertyChange();
            }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set
            {
                deliveryDate = value;
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
        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                OnPropertyChange();
            }
        }

        public int ItemCount
        {
            get { return itemCount; }
            set
            {
                itemCount = value;
                OnPropertyChange();
            }
        }
        public int JobSiteID
        {
            get { return jobSiteID; }
            set
            {
                jobSiteID = value;
                OnPropertyChange();
            }
        }
         
        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
      
    }
}
