using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DataLayer.Data;
using ServiceLayer.Models;
using ServiceLayer;
using System.Windows.Forms;
using Mosiac.UX.Forms;

namespace Mosiac.UX
{
    public partial class FindSupplierForm : Form
    {
        private readonly MosaicContext _ctx;
        private List<SupplierLineItemDto> suppliers;
        private SuppliersService _supplierService;
        private SuppliersListDto _selectedSupplier;


        public FindSupplierForm()
        {
            InitializeComponent();
            lbSuppliers.MouseDoubleClick += LbSuppliers_MouseDoubleClick;
            _ctx = new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            _supplierService = new SuppliersService(_ctx);
            lbSuppliers.DisplayMember = "SupplierName";
            lbSuppliers.ValueMember = "SupplierID";
        }

        private void LbSuppliers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            _selectedSupplier = (SuppliersListDto)lb.SelectedItem;
            _ctx.Dispose();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tsFindSupplier_TextChanged(object sender, EventArgs e)
        {
         
           ToolStripTextBox tb = (ToolStripTextBox)sender;
            var result = _supplierService.Search(tb.Text.ToString());
        
            lbSuppliers.DataSource = result;

        }

        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            _selectedSupplier = (SuppliersListDto)lb.SelectedItem;
        }

        

        public  SuppliersListDto SelectedSupplier
        {
            get { return _selectedSupplier; }          
        }

        private void Select_Click(object sender, EventArgs e)
        {
            _ctx.Dispose();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FindSupplierForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tsbNewSupplier_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupplierEditForm frm = new SupplierEditForm(default, _ctx);
            frm.Text = "New Supplier";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _selectedSupplier = new SuppliersListDto
                { SupplierID = frm._supplierToEdit.SupplierID ,
                  SupplierName = frm._supplierToEdit.SupplierName
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
