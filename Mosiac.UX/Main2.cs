
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using DataLayer.Entity;
using DataLayer.Data;
using Mosiac.UX.UXControls;

namespace Mosiac.UX
{
    public partial class Main2 : Form
    {
        MosaicContext _context;
        int _loggedOnUserID;
        readonly OrdersService _ordersService;
        public TabControl MainTabs { get; set; }

        public int LoggedOnUserID
        {
            get { return _loggedOnUserID; }
            set { _loggedOnUserID = value; }
        }

        //ctor --
        public  Main2(MosaicContext context)
        {
            
            InitializeComponent();
            _context = new MosaicContext();
            _ordersService = new OrdersService(_context);
            MainTabs = this.MainTabsControl;      
            OrderRecieptManager manager = new OrderRecieptManager();
            Mediator.GetInstance().OrderOpen += Main_OrderOpen;
            manager.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(manager);
            this.Text = "Mosiac - [Production] v" + Application.ProductVersion.ToString();
        }

        public void OpenAnOrder(int orderID)
        {
            TabPage page = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, orderID);
            MainTabsControl.TabPages.Add(page);
            MainTabsControl.SelectedTab = page;
        }

        private void Main_OrderOpen(object sender, OrderChangedArgs e)
        {
            MainTabsControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, e.Order.PurchaseOrderID));
        }

        public TabControl GetTabControl()
        {return this.MainTabs; }
            
       


    }
}
