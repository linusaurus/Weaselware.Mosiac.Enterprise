using DataLayer.Data;
using DataLayer.Entity;
using System;
using System.Windows.Forms;
using ServiceLayer;

namespace Mosiac.UX
{
    public partial class SupplierEditForm : Form
    {
        private readonly MosaicContext ctx;
       
        private SuppliersService _supplierService;
        public Supplier _supplierToEdit { get; set; }

        public SupplierEditForm()
        {

        }
        public SupplierEditForm(int supplierID, MosaicContext context)
        {
            InitializeComponent();
            ctx = context;
            _supplierService = new SuppliersService(ctx);
            _supplierToEdit = _supplierService.Find(supplierID);
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

            mtxtPhone.DataBindings.Clear();
            mtxtPhone.DataBindings.Add("Text", _supplierToEdit, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);

            mtxFax.DataBindings.Clear();
            mtxFax.DataBindings.Add("Text", _supplierToEdit, "Fax", true, DataSourceUpdateMode.OnPropertyChanged);

            txtTaxRate.DataBindings.Clear();
            txtTaxRate.DataBindings.Add("Text", _supplierToEdit, "TaxRate", true, DataSourceUpdateMode.OnPropertyChanged,"P");

            txtAccountNumber.DataBindings.Clear();
            txtAccountNumber.DataBindings.Add("Text", _supplierToEdit, "AccountNumber", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _supplierService.Save();
        }

        private void SupplierEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
