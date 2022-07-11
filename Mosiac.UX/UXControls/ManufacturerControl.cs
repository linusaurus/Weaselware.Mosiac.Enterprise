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
using ServiceLayer.Models;
using ServiceLayer.Services;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class ManufacturerControl : UserControl
    {
        private readonly MosaicContext _ctx;
        private PartsService _partService;
        private int _selectedManuID = 0;
        public ManufacturerControl(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _partService = new PartsService(_ctx);
            Grids.BuildPartSearchGrid(dgvManuParts);
            
        }

        private async void PartSearch()
        {
            string searchPart = txtPartSearchMain.Text;
            string term = txtTerm1.Text;
            string term2 = txtTerm2.Text;

            string[] parms = { term, term2 };

            if (txtPartSearchMain.Text.Length > 1)
            {
                var partsList = await _partService.SearchPartQueryAsync(searchPart, 1, false, parms);

                //ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                //dv = ListAsDataTable.DefaultView;
                //dgvPartsSearchResults.DataSource = dv;
            }
            else
            {

            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))
            {
                if (txtPartSearchMain.Text.Length == 0)
                {
                    SearchManus();
                }
                else if (txtPartSearchMain.Text.Length > 0)
                {
 
                    SearchParts();
                }
                
                return true;
            }
            else if (keyData == Keys.Escape) //clear the textboxes, null the dg source
            {
                txtPartSearchMain.Text = string.Empty;
                txtTerm1.Text = string.Empty;
                txtTerm2.Text = string.Empty;
                dgvManuParts.DataSource = null;
  
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private async void SearchParts()
        {
            string searchMain = txtPartSearchMain.Text;
            string term = txtTerm1.Text;
            string term2 = txtTerm2.Text;

            string[] parms = { term, term2 };

            if (txtPartSearchMain.Text.Length > 1)
            {
                var result = await _partService.SearchPartQueryAsync(searchMain, _selectedManuID, true, parms);

                DataTable dt = Grids.BuildDataTable<PartFastSearchDto>(result);
                DataView dv = dt.DefaultView;
                dgvManuParts.DataSource = dv;
            }
            else
            {

            }
        }

        private void LoadManuParts()
        {
            //var result = await _partService.SearchPartQueryAsync(searchMain, _selectedManuID, true, parms);
        }
        private void tsManufacturersToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchManus();
        }

        private void SearchManus()
        {
            var result = _partService.FindManufacturer(txtSearchManu.Text);
            lbManufacturers.DisplayMember = "ManufacturerName";
            lbManufacturers.DataSource = result;
        }

        private void lbManufacturers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbManufacturers.DataSource != null)
            {
                if (lbManufacturers.SelectedItems.Count > 0)
                {
                    _selectedManuID = ((ManuListDTO)lbManufacturers.SelectedItem).ManuID;

                }
            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ManuEditForm frm = new ManuEditForm(_ctx);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Manu manu = frm.Manu;
                txtSearchManu.Text = manu.Manufacturer.ToString();
                SearchManus();
            }
        }
    }
}
