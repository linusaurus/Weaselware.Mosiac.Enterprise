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
        private OrderReceiptRepository _orderReceiptService;
        private List<SupplierOrdersListDto> supplierOrdersList;
       
        DataTable dataTable;
        DataView dv;

        public SupplierManager(MosaicContext context)
        { 
            InitializeComponent();
            closeImage = Properties.Resources._8kuxe;
            tbcOrderReciepts.Padding = new System.Drawing.Point(26, 4);
            _ctx = context;
            _suppliersService = new SuppliersService(_ctx);
            _orderReceiptService = new OrderReceiptRepository(_ctx, Globals.CurrentUserName, Globals.CurrentLoggedUserID);
            SupplierSelector selector = new SupplierSelector(_suppliersService);
            selector.Dock = DockStyle.Fill;
            MainSplitContainer.Panel1.Controls.Add(selector);
            tbcOrderReciepts.DrawItem += TbcOrderReciepts_DrawItem;
            tbcOrderReciepts.MouseClick += TbcOrderReciepts_MouseClick;
            selector.OnSupplierSelected += Selector_OnSupplierSelected;
            Grids.BuildSupplierOrdersGrid(this.dgSupplierOrders);
            Grids.BuildSupplierOrderItems(this.dgOrderLineItems);
        }

        private void TbcOrderReciepts_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tbcOrderReciepts.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tbcOrderReciepts.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tbcOrderReciepts.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    CloseActiveTab();
                }
            }
        }

        private void TbcOrderReciepts_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.tbcOrderReciepts.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tbcOrderReciepts.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.tbcOrderReciepts.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }

        private void Selector_OnSupplierSelected(SupplierSelector.SelectedSUpplierEventArgs eventArgs)
        {
            int key = eventArgs.SelectedSupplierID;
            supplierOrdersList = _suppliersService.GetSupplierOrders(key);
            dataTable = Grids.BuildDataTable<SupplierOrdersListDto>(supplierOrdersList);
            dv = dataTable.DefaultView;
            this.dgSupplierOrders.DataSource = dv;
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

        private void dgOrderLineItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSupplierOrders_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            if (dv.DataSource != null)
            {
                if (dv.Rows.Count > 0)
                {
                    //int po = ((SupplierOrdersListDto)dv.CurrentRow.DataBoundItem).OrderNumber;
                    int po = (int)dv.CurrentRow.Cells[0].Value;
                    bool recieved = (bool)dv.CurrentRow.Cells[5].Value;
                    if (recieved)
                    {
                        var recpt = _orderReceiptService.LoadOrderReciept(po);
                        OrderReciept orderReciept = new OrderReciept(recpt);
                        TabPage receiptTab = new TabPage(String.Format("Order Receipt - {0}", recpt.OrderReceiptId.ToString()));
                        receiptTab.Controls.Add(orderReciept);
                        orderReciept.Dock = DockStyle.Fill;
                        tbcOrderReciepts.TabPages.Add(receiptTab);
                        tbcOrderReciepts.SelectedTab = receiptTab;
                    }

                }
            }
        }

        private void CloseActiveTab()
        {
            TabPage tabpage = tbcOrderReciepts.SelectedTab;
            if (tbcOrderReciepts.TabPages.Count > 1)
            {
                // Need to determine is the page is Order, and is not Dirty
                if (tabpage.Name != "OrdersPage")
                {                   
                     tbcOrderReciepts.TabPages.Remove(tabpage); 
                }
              
            }
        }

    }
}
