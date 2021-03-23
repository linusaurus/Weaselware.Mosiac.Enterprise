
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
    public partial class Main : Form
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
        public  Main(MosaicContext context)
        {
            
            InitializeComponent();
            MainTabs = this.MainTabsControl;      
            OrderRecieptManager manager = new OrderRecieptManager();
          
            manager.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(manager);
           
        }

        public TabControl GetTabControl()
        {
            return this.MainTabs;
        }


    }
}
