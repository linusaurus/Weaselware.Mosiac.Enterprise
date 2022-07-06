using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class PickListItemDto : INotifyPropertyChanged
    {

        private int pickListItemID;
        private int pickListID;
        private string description;
        private int? productID;
        private int? subAssemblyID;
        private int? partID;
        private decimal? qnty;
        private string? unit;
        private bool? onboard;
        private bool? delivered;
        private int? stockTransActionID;

        public event PropertyChangedEventHandler? PropertyChanged;

        public PickListItemDto()
        {
            description = String.Empty;
            onboard = false;
            delivered = false;
        }
        public int PickListItemID 
        {
            get { return pickListItemID; }
            set { pickListItemID = value; OnPropertyChange(); } 
        }
        public int PickListID
        {
            get { return pickListID; }
            set { pickListID = value; OnPropertyChange(); }
        }
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChange();}
        }
        public int? ProductID 
        {
            get { return productID; }
            set { productID = value; OnPropertyChange(); }
        }
        public int? SubAssemblyID 
        {
            get { return subAssemblyID; }
            set { subAssemblyID = value; OnPropertyChange(); }
        }
        public int? PartID
        {
            get { return partID; }
            set { partID = value; OnPropertyChange(); } 
        }
        public decimal? Qnty
        {
            get { return qnty; }
            set { qnty = value; OnPropertyChange(); }
        }
        public string? Unit
        {
            get { return unit; }
            set{unit = value; OnPropertyChange(); }
        }
        public bool? Onboard 
        {
            get { return onboard; }
            set { onboard = value; OnPropertyChange(); }
        }
        public bool? Delivered 
        {
            get { return delivered; }
            set { delivered = value; OnPropertyChange(); }
        }
        public int? StockTransActionID 
        {
            get { return stockTransActionID; }
            set { stockTransActionID = value; OnPropertyChange(); }
        }

        protected void OnPropertyChange([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
