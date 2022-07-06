using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ServiceLayer.Models
{
    public class PickListDto : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private int pickListID;
        private int employeeID;
        private DateTime dateStamp;
        private string preparer;
        private int jobID;
        private string jobName;
        private int itemCount;
        private bool submitted;
        private bool delivered;
        private DateTime deliveryDate;

        public PickListDto()
        {
            PickListItems = new List<PickListItemDto>();
        }
        public int PickListID
        {
            get { return pickListID; }
            set { pickListID = value; OnPropertyChange(); }
        }
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; OnPropertyChange(); }
        }
        public DateTime DateStamp
        {
            get { return dateStamp; }
            set { dateStamp = value; OnPropertyChange(); }
        }
        public string Preparer
        {
            get { return preparer; }
            set { preparer = value; OnPropertyChange(); }
        }

        public int JobID
        {
            get { return jobID; }
            set { jobID = value; OnPropertyChange(); }
        }
        public string JobName
        {
            get { return jobName; }
            set { jobName = value; OnPropertyChange(); }
        }
        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; OnPropertyChange(); }
        }
        public bool Submitted
        {
            get { return submitted; }
            set { submitted = value; OnPropertyChange(); }
        }

        public bool Delivered
        {
            get { return delivered; }
            set { delivered = value; OnPropertyChange(); }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; OnPropertyChange(); }
        }

        public List<PickListItemDto> PickListItems { get; set; }



        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
