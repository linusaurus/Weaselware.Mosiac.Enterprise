using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ServiceLayer;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class SupplierSelector : UserControl
    {
        private SuppliersService _service;
        private int _selectedSupplierID;
        public delegate void  SupplierSelectedHandler(SelectedSUpplierEventArgs eventArgs);
        public event SupplierSelectedHandler OnSupplierSelected;

        

        public class SelectedSUpplierEventArgs : EventArgs
        {
            public int SelectedSupplierID { get; set; }
        }
        
        public SupplierSelector(SuppliersService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void SetdataSource(SuppliersService supplierService)
        {
            _service = supplierService;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            lbSuppliersList.DisplayMember = "SupplierName";
            lbSuppliersList.ValueMember = "SupplierID";
            lbSuppliersList.DataSource = _service.Find(tb.Text);

        }

        private void SupplierSelector_Load(object sender, EventArgs e)
        {

        }

        private void lbSuppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSuppliersList.DataSource != null)
            {
                if (lbSuppliersList.SelectedItems.Count > 0)
                {
                    _selectedSupplierID = (int)lbSuppliersList.SelectedValue;
                    OnSupplierSelected(new SelectedSUpplierEventArgs {SelectedSupplierID = _selectedSupplierID});
                }
            }
         
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}
