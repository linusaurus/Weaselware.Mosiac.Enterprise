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
using ServiceLayer;
using ServiceLayer.Services;
using System.Windows.Forms;

namespace Mosiac.UX.Forms
{
    public partial class AddDestinationForm : Form
    {
        private readonly MosaicContext _ctx;
        private StockService _stockService;
        private Destination _selectedDestination;

        public AddDestinationForm(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _stockService = new StockService(_ctx);

            lbDestinations.DisplayMember = "DestinationName";
            lbDestinations.ValueMember = "DestinationID";
            lbDestinations.SelectedValueChanged += LbDestinations_SelectedValueChanged;

        }

        public Destination SelectedDestination { get { return _selectedDestination; } set { _selectedDestination = value; } }

        private void LbDestinations_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if ((lb.DataSource != null) || (lb.SelectedItems.Count > 0))
            {
                _selectedDestination = (Destination)lb.SelectedItem;
                this.Text = _selectedDestination.DestinationName;
            }
            
        }

        private async void  SearchDestinations()
        {
            if (txtSearch.TextLength > 0)
            {
               var result = await _stockService.GetDestinationsAsync(txtSearch.Text);
               lbDestinations.DataSource = result;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchDestinations();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DestinationEditForm editForm = new DestinationEditForm(_ctx);
            if (editForm.ShowDialog()== DialogResult.OK)
            {
                txtSearch.Text = editForm.Destination.DestinationName.ToString();
                SearchDestinations();
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_selectedDestination != null)
            {
                Close();
            }
        }
    }
}
