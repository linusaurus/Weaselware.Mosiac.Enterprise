using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entity;

namespace Mosiac.UX.Forms
{
    public partial class LocationEditForm : Form
    {
        public Location locationEdited;
        BindingSource bs = new BindingSource();
        
        public LocationEditForm(Location location)
        {
            InitializeComponent();
            locationEdited = location;
            bs.DataSource= locationEdited;
            bs.ListChanged += Bs_ListChanged;
        }

        private void Bs_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType== ListChangedType.ItemChanged)
            {
                btnOK.Enabled = true;
                btnOK.BackColor = Color.Cornsilk;
            } ;
        }

        private void LocationEditForm_Load(object sender, EventArgs e)
        {
            txtLocation.DataBindings.Add("Text", bs, "LocationName", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
