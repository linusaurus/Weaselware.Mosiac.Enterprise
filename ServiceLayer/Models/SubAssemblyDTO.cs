using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using DataLayer.Data;
using DataLayer.Entity;


namespace ServiceLayer.Models
{
    public class SubAssemblyDTO : INotifyPropertyChanged
    {

        private int _productID { get; set; }
        private int _subAssemblyID { get; set; }
        private string _subAssemblyName { get; set; }
        private string _makeFile { get; set; }
        private decimal? _w { get; set; }
        private decimal? _h { get; set; }
        private decimal? _d { get; set; }

        private int? _glassPartID { get; set; }
        private int? _cPD_id { get; set; }


        public int? GlassPartID
        {
            get { return _glassPartID; }
            set
            {
                _glassPartID = value;
                OnPropertyChange();
            }
        }

        public int? CPD_ID
        {
            get { return _cPD_id; }
            set
            {
                _cPD_id = value;
                OnPropertyChange();
            }
        }

        // ProductionDate
        public int ProductID
        {
            get { return _productID; }
            set
            {
                _productID = value;
                OnPropertyChange();
            }
        }

        // SUbAssemblyID
        public int SubAssemblyID
        {
            get { return _subAssemblyID; }
            set
            {
                _subAssemblyID = value;
                OnPropertyChange();
            }
        }

        // SubAssemblyName
        public string SubAssemblyName
        {
            get { return _subAssemblyName; }
            set
            {
                _subAssemblyName = value;
                OnPropertyChange();
            }
        }

        // MakeFile
        public string MakeFile
        {
            get { return _makeFile; }
            set
            {
                _makeFile = value;
                OnPropertyChange();
            }
        }

        // W
        public decimal? W
        {
            get { return _w; }
            set
            {
                _w = value;
                OnPropertyChange();
            }
        }

        // H
        public decimal? H
        {
            get { return _h; }
            set
            {
                _h = value;
                OnPropertyChange();
            }
        }
        // D
        public decimal? D
        {
            get { return _d; }
            set
            {
                _d = value;
                OnPropertyChange();
            }
        }

        public List<Part> Parts { get; set; }





        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
