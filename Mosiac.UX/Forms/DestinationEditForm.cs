using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Entity;
using System.Windows.Forms;

namespace Mosiac.UX.Forms
{
    public partial class DestinationEditForm : Form
    {
        private readonly MosaicContext _ctx;
        private Destination _destination;
        public DestinationEditForm(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _destination = new Destination();
            Bind();
        }

        public Destination Destination { get => _destination; set => _destination = value; }

        private void Bind()
        {
            txtDestinationName.DataBindings.Add("Text", _destination, "DestinationName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAddress.DataBindings.Add("Text", _destination, "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCity.DataBindings.Add("Text", _destination, "City", true, DataSourceUpdateMode.OnPropertyChanged);
            txtState.DataBindings.Add("Text", _destination, "State", true, DataSourceUpdateMode.OnPropertyChanged);
            txtZip.DataBindings.Add("Text", _destination, "Zip", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _ctx.Destination.Add(_destination);
            _ctx.SaveChanges();
            Close();
        }
    }
}
