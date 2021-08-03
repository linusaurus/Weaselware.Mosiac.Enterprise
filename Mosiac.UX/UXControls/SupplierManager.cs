using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ServiceLayer;
using DataLayer.Data;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class SupplierManager : UserControl
    {
        private readonly MosaicContext _ctx;
        private SuppliersService _suppliersService;
        public SupplierManager(MosaicContext context)
        { 
            InitializeComponent();
            _ctx = context;
            _suppliersService = new SuppliersService(_ctx);

            SupplierSelector selector = new SupplierSelector(_suppliersService);
            selector.Dock = DockStyle.Fill;
            MainSplitContainer.Panel1.Controls.Add(selector);
            selector.OnSupplierSelected += Selector_OnSupplierSelected;
            Grids.BuildSupplierOrdersGrid(this.dataGridView1);
        }

        private void Selector_OnSupplierSelected(SupplierSelector.SelectedSUpplierEventArgs eventArgs)
        {
            int key = eventArgs.SelectedSupplierID;

            this.dataGridView1.DataSource = _suppliersService.GetSupplierOrders(key);
        }

        private void SupplierManager_Load(object sender, EventArgs e)
        {

        }

       
    }
}
