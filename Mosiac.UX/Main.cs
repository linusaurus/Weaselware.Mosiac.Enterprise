using Microsoft.EntityFrameworkCore;
using DataLayer.Data;
using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System.Windows.Forms;
using Mosiac.UX.UXControls;
using Mosiac.UX.Properties;
using System.Reflection;
using SocketMobile.Capture;

namespace Mosiac.UX
{
    public partial class Main : Form
    {

        MosaicContext _context;
        int _loggedOnUserID;
        readonly OrdersService _ordersService;
        public TabControl MainTabs { get; set; }
        CaptureHelper mCapture;

        string appId = "windows: Designsynthesis.Mosiac.App";
        string developerId = "2c926d9e-0821-eb11-a813-000d3a33be69";
        string appKey = "MCwCFEJpEn5SjoP8LoeeCC0WNS9tCVOsAhRiU8TQRxWmP48X3MBdGH9Rbe2+Eg==";


        public int LoggedOnUserID
        {
            get { return _loggedOnUserID; }
            set { _loggedOnUserID = value; }
        }

        public Main()
        {
            InitializeComponent();

            // 3- instantiate and configure CaptureHelper
            mCapture = new CaptureHelper { ContextForEvents = WindowsFormsSynchronizationContext.Current };
            mCapture.DeviceArrival += mCapture_DeviceArrival;
            mCapture.DeviceRemoval += mCapture_DeviceRemoval;
            mCapture.DecodedData += mCapture_DecodedData;



            OpenScanner();

           

            // This should be the main contect wireup for everything else
            _context = new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            _ordersService = new OrdersService(_context);
            MainTabs = MainTabControl;
            Mediator.GetInstance().OrderOpen += Main_OrderOpen;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Mosaic - [Production] " + version;


        }
        #region Scanner Code
        private async void OpenScanner()
        {
            long Result = await mCapture.OpenAsync(appId, developerId, appKey);
            //if (!SktErrors.SKTSUCCESS(Result))
            //{
            //    toolStripTextBox1.Text = "Unable to connect to Socket Mobile Companion";
            //}
        }

        private void Capture_DecodedData(object sender, CaptureHelper.DecodedDataArgs e)
        {
            this.toolStripTextBox1.Text = e.DecodedData.DataToUTF8String; ;
        }
   

        private void Terminate(object sender, CaptureHelper.TerminateArgs e)
        {
            throw new NotImplementedException();
        }

   

        private void mCapture_DecodedData(object sender, CaptureHelper.DecodedDataArgs e)
        {
            throw new NotImplementedException();
        }

       

        private void mCapture_DeviceRemoval(object sender, CaptureHelper.DeviceArgs e)
        {
            throw new NotImplementedException();
        }

        private void mCapture_DeviceArrival(object sender, CaptureHelper.DeviceArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public TabControl GetTabControl()
        {
            return this.MainTabControl;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            closeImage = Properties.Resources._8kuxe;
            MainTabs.Padding = new System.Drawing.Point(26, 4);

            this.toolStripStatusLabel1.Text = "UserID=" + _loggedOnUserID.ToString();
            //_context = new MosaicContext();

            var emp = _context.Employees.Where(p => p.employeeID == LoggedOnUserID).FirstOrDefault();
            this.toolStripStatusLabel1.Text = "User= " + Globals.CurrentUserName;
            // Globals.CurrentUserName = emp.Firstname + " " + emp.Lastname;
            TabPage myOrdersTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.MyOrdersPage);
            myOrdersTab.Name = "myOrdersTab";
            MainTabControl.TabPages.Add(myOrdersTab);
        }

        //Region Global new tab generator --------------------

        public void OpenAnOrder(int orderID)
        {
            TabPage page = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, orderID);
            MainTabControl.TabPages.Add(page);
            MainTabControl.SelectedTab = page;
        }

        private void Main_OrderOpen(object sender, OrderChangedArgs e)
        {
            MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, e.Order.PurchaseOrderID));
        }

        private void MaintabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            if (tabControl.TabPages.Count > 0)
            {
                this.toolStripStatusLabel1.Text = tabControl.SelectedTab.Text;
                Mediator.GetInstance().OnTabChanged(tabControl, tabControl.SelectedTab);
            }

        }

        #region ToolBar Clicks
        private void tsSettingsButton_Click(object sender, EventArgs e)
        {

            //LabelService lbService = new LabelService();
            //lbService.SetPrintingOption();
        }

        private void tsScanBarCode_Click(object sender, EventArgs e)
        {

            TabPage searchPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.ItemSearchPage);

            MainTabControl.TabPages.Add(searchPage);
            MainTabControl.SelectedTab = searchPage;
        }

        #endregion

        private void tsbPullStockOrder_Click(object sender, EventArgs e)
        {

            TabPage stockBillPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.StockBill);

            MainTabControl.TabPages.Add(stockBillPage);
            MainTabControl.SelectedTab = stockBillPage;

        }

        private void CloseActiveTab()
        {
            TabPage tabpage = MainTabControl.SelectedTab;
            if (MainTabControl.TabPages.Count > 1)
            {
                // Need to determine is the page is Order, and is not Dirty
                if (tabpage.Name == "Order")
                {
                    if (((OrderEditSplitPanelControl)tabpage.Controls[0]).IsDirty == true)
                    {
                        DialogResult dlg = MessageBox.Show("Save changes?", "Question", MessageBoxButtons.YesNo);

                        if (dlg == DialogResult.Yes)
                        {
                            // -- UserCOntrol public save method ---
                            ((OrderEditSplitPanelControl)tabpage.Controls[0]).SaveChanges();
                            MainTabControl.TabPages.Remove(tabpage);
                        }
                        if (dlg == DialogResult.No)
                        { MainTabControl.TabPages.Remove(tabpage); }

                    }
                    else
                    { MainTabControl.TabPages.Remove(tabpage); }

                }
                else
                { MainTabControl.TabPages.Remove(tabpage); }
            }
        }

 

        private void mainToolStrip_MouseEnter(object sender, EventArgs e)
        {
            ToolStrip ts = ((ToolStrip)sender);
            ToolStripButton tsb = (ToolStripButton)ts.GetItemAt(395, 792);
        }

        private void tsbJobItems_OnClick(object sender, EventArgs e)
        {
            TabPage AssembliesTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.AssemblyManagerControl);
            MainTabControl.TabPages.Add(AssembliesTab);
            MainTabControl.SelectedTab = AssembliesTab;
        }

        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.MainTabs.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.MainTabs.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.MainTabs.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }

        private void MainTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.MainTabs.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.MainTabs.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (MainTabs.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    CloseActiveTab();
                }
            }
        }
        /// <summary>
        /// Main toolbar switcher code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsOrderButton":

                    var jobID = 0;
                    var supplierID = 0;

                    NewOrderDialog diag = new NewOrderDialog(_context);
                    if (diag.ShowDialog() == DialogResult.OK)
                    {
                        jobID = diag.JobNumber;
                        supplierID = diag.SupplierID;

                        var order = _ordersService.NewDefault(Globals.CurrentLoggedUserID, supplierID, jobID);
                        _ordersService.Add(order);
                        // Purchase Order Page

                        TabPage orderPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, order.PurchaseOrderID);
                        
                        MainTabControl.TabPages.Add(orderPage);
                        MainTabControl.SelectTab(orderPage);
                       // MainTabControl.TabPages.Add(PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PurchaseOrderPage, order.PurchaseOrderID));
                    }

                    break;
                /// My Orders -------+
                case "tsMyOrders":

                    TabPage myOrdersTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.MyOrdersPage);
                    myOrdersTab.Name = "myordersTab";

                    if (!MainTabControl.TabPages.ContainsKey("myordersTab"))
                    {
                        MainTabControl.TabPages.Add(myOrdersTab);
                        MainTabControl.SelectedTab = myOrdersTab;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("myordersTab"))
                        { MainTabControl.SelectTab("myordersTab"); }
                    }

                    break;
                case "tsSupplerOrders":

                    TabPage suppliersManager = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.SupplierOrdersPage);
                    suppliersManager.Name = "SupplierOrders";

                    if (!MainTabControl.TabPages.ContainsKey("SupplierOrders"))
                    {
                        MainTabControl.TabPages.Add(suppliersManager);
                        MainTabControl.SelectedTab = suppliersManager;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("SupplierOrders"))
                        { MainTabControl.SelectTab("SupplierOrders"); }
                    }
                    break;
                 //-------------------------------------------------------------------------------------------------------
                 // --------------------------Order Receipt Page ---------------------------------------------------------
                 //-------------------------------------------------------------------------------------------------------
                case "tsbReceiveOrder":

                    TabPage OrderReceiptTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.OrderRecieptPage);
                    OrderReceiptTab.Name = "OrderRecieptTab";
                    if (!MainTabControl.TabPages.ContainsKey("OrderRecieptTab"))
                    {
                        MainTabControl.TabPages.Add(OrderReceiptTab);
                        MainTabControl.SelectedTab = OrderReceiptTab;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("OrderReceiptTab"))
                        { MainTabControl.SelectTab("OrderReceiptTab"); }
                    }


                    break;
               // Display the Order Receipts Surface ----+|+

                case "tsbReceipts":
                    TabPage OrderReceiptHistoryTab = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.OrderReceiptHistoryPage);
                    OrderReceiptHistoryTab.Name = "OrderReceiptHistoryTab";

                    if (!MainTabControl.TabPages.ContainsKey("OrderReceiptHistoryTab"))
                    {
                        MainTabControl.TabPages.Add(OrderReceiptHistoryTab);
                        MainTabControl.SelectedTab = OrderReceiptHistoryTab;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("OrderReceiptTab"))
                        { MainTabControl.SelectTab("OrderReceiptHistoryTab"); }
                    }


                    break;

                 ///TODO  insert new part editor
                case "tsPartEditor":

                    TabPage partEditorPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.PartEditorPage); ;
                    partEditorPage.Name = "partEditorPage";

                    if (!MainTabControl.TabPages.ContainsKey("partEditorPage"))
                    {
                        MainTabControl.TabPages.Add(partEditorPage);
                        MainTabControl.SelectedTab = partEditorPage;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("partEditorPage"))
                        { MainTabControl.SelectTab("partEditorPage"); }
                    }

                    break;

                case "tsbJobOrders":

                    TabPage jobOrdersPage = PageFactory.GetNewTabPage(_context, PageFactory.TabPageType.JobManagerPage);

                    jobOrdersPage.Name = "JobOrderPage";
                    if (!MainTabControl.TabPages.ContainsKey("JobOrderPage"))
                    {
                        MainTabControl.TabPages.Add(jobOrdersPage);
                        MainTabControl.SelectedTab = jobOrdersPage;
                    }
                    else
                    {
                        if (MainTabControl.TabPages.ContainsKey("JobOrderPage"))
                        { MainTabControl.SelectTab("JobOrderPage"); }

                    }


                    break;
                default:
                    break;

            }
        }
    
}
}
