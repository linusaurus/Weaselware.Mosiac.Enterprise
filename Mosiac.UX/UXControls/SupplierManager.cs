using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ServiceLayer;
using DataLayer.Data;
using System.Linq;
using DataLayer.Entity;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Models;

namespace Mosiac.UX.UXControls
{
    public partial class SupplierManager : UserControl
    {
        private readonly MosaicContext _ctx;
        private SuppliersService _suppliersService;
        private OrdersService _ordersService;
        private List<SupplierOrdersListDto> supplierOrdersList;

        DataTable dataTable;
        DataView dv;

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
            Grids.BuildSupplierOrderItems(this.dgOrderLineItems);
        }

        private void Selector_OnSupplierSelected(SupplierSelector.SelectedSUpplierEventArgs eventArgs)
        {
            int key = eventArgs.SelectedSupplierID;
            supplierOrdersList = _suppliersService.GetSupplierOrders(key);
            dataTable = Grids.BuildDataTable<SupplierOrdersListDto>(supplierOrdersList);
            dv = dataTable.DefaultView;
            this.dataGridView1.DataSource = dv;

        }

        private void SupplierManager_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.Rows.Count > 0)
                {
                    //int po = ((SupplierOrdersListDto)dv.CurrentRow.DataBoundItem).OrderNumber;
                    int po = (int)dv.CurrentRow.Cells[0].Value;
                    var lineitems = _ctx.PurchaseLineItems.AsNoTracking().Where(p => p.PurchaseOrderID == po).ToList();
                    this.dgOrderLineItems.DataSource = lineitems;
                }
            }
        }
    }
}
