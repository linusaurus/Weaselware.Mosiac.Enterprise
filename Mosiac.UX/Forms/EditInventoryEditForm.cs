using DataLayer.Data;
using DataLayer.Entity;

using ServiceLayer;
using ServiceLayer.Models;

using System.ComponentModel;
using System.Globalization;


namespace Mosiac.UX.Forms
{
    public partial class EditInventoryEditForm : Form
    {
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Inventory InventoryEdit { get; set; }

        public EditInventoryEditForm(Inventory inventory)
        {
            InitializeComponent();
            InventoryEdit = inventory;
            BindInventoryFields(inventory);
            txtDescription.DataBindings.Add("Text", inventory, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTransactionID.DataBindings.Add("Text", inventory, "StockTransactionID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLineId.DataBindings.Add("Text", inventory, "LineID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPartID.DataBindings.Add("Text", inventory, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDate.DataBindings.Add("Text", inventory, "DateStamp", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNote.DataBindings.Add("Text", inventory, "Note", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEmployee.DataBindings.Add("Text", inventory, "Emp.firstname", true, DataSourceUpdateMode.OnPropertyChanged);
            txtUnitOfMeasure.DataBindings.Add("Text", inventory, "UnitOfMeasure.UnitName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocation.DataBindings.Add("Text", inventory, "LocationNavigation.LocationName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTransactionType.DataBindings.Add("Text", inventory, "TransActionTypeNavigation.TransactionTypeName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtInventoryAmount.DataBindings.Add("Text", inventory, "InventoryAmount", true, DataSourceUpdateMode.OnPropertyChanged,"d");


        }

        private void BindInventoryFields(Inventory i)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            // Replace the problematic line with the following:
           

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
