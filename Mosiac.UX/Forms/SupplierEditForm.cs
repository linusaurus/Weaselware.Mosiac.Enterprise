using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Models;
using ServiceLayer;
using System.Windows.Forms;

namespace Mosiac.UX.Forms
{
    public partial class SupplierEditForm : Form
    {
        private readonly MosaicContext ctx;
        private BindingSource bsSupplier = new BindingSource();
        private SuppliersService _supplierService;
        public Supplier _supplierToEdit { get; set; }

        public SupplierEditForm(SuppliersService suppliersService, int supplierID)
        {
            InitializeComponent();
            _supplierService = suppliersService;

            if (supplierID == default)
            {
                _supplierToEdit = new Supplier();
            }
            else
            {
                _supplierToEdit = _supplierService.Find(supplierID);
            }
            
        
            BindText();

        }
        public SupplierEditForm(int supplierID, MosaicContext context)
        {
            InitializeComponent();
            ctx = context;
            _supplierService = new SuppliersService(ctx);
            if (supplierID != 0)
            {
                _supplierToEdit = _supplierService.Find(supplierID);
                this.Text = $"Edit - {_supplierToEdit.SupplierName}";
            }
            else
            {
                _supplierToEdit = new Supplier();
            }
            
            BindText();

        }

        private void BindText()
        {
            txtSupplierName.DataBindings.Clear();
            txtSupplierName.DataBindings.Add("Text", _supplierToEdit, "SupplierName", true, DataSourceUpdateMode.OnPropertyChanged);

            txtSupplierID.DataBindings.Clear();
            txtSupplierID.DataBindings.Add("Text", _supplierToEdit, "SupplierID", true, DataSourceUpdateMode.OnPropertyChanged);

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", _supplierToEdit, "Address1", true, DataSourceUpdateMode.OnPropertyChanged);

            txtAddress2.DataBindings.Clear();
            txtAddress2.DataBindings.Add("Text", _supplierToEdit, "Address2", true, DataSourceUpdateMode.OnPropertyChanged);

            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", _supplierToEdit, "City", true, DataSourceUpdateMode.OnPropertyChanged);

            txtState.DataBindings.Clear();
            txtState.DataBindings.Add("Text", _supplierToEdit, "State", true, DataSourceUpdateMode.OnPropertyChanged);

            txtZip.DataBindings.Clear();
            txtZip.DataBindings.Add("Text", _supplierToEdit, "Zip", true, DataSourceUpdateMode.OnPropertyChanged);

            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", _supplierToEdit, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);

            txtFax.DataBindings.Clear();
           txtFax.DataBindings.Add("Text", _supplierToEdit, "Fax", true, DataSourceUpdateMode.OnPropertyChanged);

            txtTaxRate.DataBindings.Clear();
            txtTaxRate.DataBindings.Add("Text", _supplierToEdit, "TaxRate", true, DataSourceUpdateMode.OnPropertyChanged, "0.08");

            txtAccountNumber.DataBindings.Clear();
            txtAccountNumber.DataBindings.Add("Text", _supplierToEdit, "AccountNumber", true, DataSourceUpdateMode.OnPropertyChanged);

        }

      

        private void SupplierEditForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _supplierService.InsertOrUpdate(_supplierToEdit);
            _supplierService.Save();
        }
    }
}
