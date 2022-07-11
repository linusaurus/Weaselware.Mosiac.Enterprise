using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;

namespace Mosiac.UX
{
    public partial class ManuEditForm : Form
    {

        private Manu _manu ;
        private readonly MosaicContext _ctx;



        public Manu Manu
        {
            get { return _manu; }
            set { _manu = value; }
        }

        public ManuEditForm(MosaicContext ctx)
        {
            InitializeComponent();
            _manu = new Manu();
            BindManu();
            _ctx = ctx;
        }
        public ManuEditForm(MosaicContext ctx, Manu manuToEdit)
        {
            InitializeComponent();
            _manu = manuToEdit;
            BindManu();
            _ctx = ctx;
        }

        private void BindManu()
        {
            txtName.DataBindings.Add("Text", _manu, "Manufacturer",true,DataSourceUpdateMode.OnPropertyChanged);
            txtULR.DataBindings.Add("Text", _manu, "WebAddress", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {      
            _ctx.Manu.Add(_manu);
            _ctx.SaveChanges();
            // This is not strickly necessary but confirms creation of new manufactorer
            _manu = _ctx.Manu.Find(_manu.ManuID);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtName.Text;
        }
    }
}
