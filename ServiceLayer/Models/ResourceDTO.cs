using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ServiceLayer.Models
{
    public class ResourceDto : INotifyPropertyChanged
    {
        
        // private fields ------------------------------------
        private int resourceID;
        private int partID;
        private string resourceDescription;
        private string createdBy;
        private DateTime creationDate;
        private byte[] payLoad;
        private string fileSource;
        private string fileSize;
        private DateTime lastmod;

        // ---------------------------------------------------
        public int ResourceID 
        {
            get { return resourceID; }
            set
            {
                resourceID = value  ;
                OnPropertyChange();
            }
        }
        public int PartID
        {
            get {return partID; }
            set
            {
                partID = value  ;
                OnPropertyChange();
            } 
        }
        public string ResourceDescription
        {
            get {return resourceDescription; }
            set
            {
                resourceDescription = value;
                OnPropertyChange();
            }
        }
        public string Createdby
        {
            get {return createdBy; }
            set
            {
               createdBy = value ;
                OnPropertyChange();
            } 
        }
        public DateTime CreationDate { get; set; }
        public byte[] Payload 
        {
            get {return payLoad; }
            set
            {
               payLoad = value ;
               OnPropertyChange();
            } 
        }
        public string Filesource
        {
            get {return fileSource; }
            set
            {
                fileSource = value;
                OnPropertyChange();
            }
        }
        public string Filesize
        {
            get {return fileSize; }
            set
            {
                fileSize = value;
                OnPropertyChange();
            }
        }
        public DateTime Lastmod 
        {
            get {return lastmod; }
            set
            {
                lastmod = value;
                OnPropertyChange();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
