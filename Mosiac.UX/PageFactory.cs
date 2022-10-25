using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mosiac.UX.UXControls;
using Mosiac.UX.Services;

namespace Mosiac.UX
{
    public class PageFactory
    {
        public enum TabPageType
        {
            SupplierOrdersPage,
            PurchaseOrdersPage,
            MyOrdersPage,
            OrderRecieptPage,
            OrderReceiptHistoryPage,
            ItemSearchPage,
            RecieptManagerPage,
            LabelEditorPage,
            JobsManagerPage,
            JobItemsPage,
            DeliveryPage,
            ManufacturersPage,
            StockBill,
            PartEditorPage,
            PartDetailEdit,
            PurchaseOrderPage,
            AssemblyManagerControl,
            RecieveOrderControl,
            StockManagerPage
        }
        
        public static TabPage GetNewTabPage(MosaicContext ctx,TabPageType pageType,int key = 0)
        {
            TabPage tab = new TabPage();

            switch (pageType)
            {
                case TabPageType.SupplierOrdersPage:
                    {
                        tab.Text = "Supplier Orders";                    
                        SupplierManager ctr = new SupplierManager(ctx);
                        tab.Controls.Add(ctr);
                        ctr.Dock = DockStyle.Fill;
                    }
                    break;
               
                case TabPageType.MyOrdersPage:
                    tab.Text = "Order";
                    tab.Name = "myOrdersPage";
                    MyOrdersControl myOrdersPage = new MyOrdersControl(ctx, Mosiac.UX.Services.Globals.CurrentLoggedUserID);
                    myOrdersPage.Dock = DockStyle.Fill;
                    tab.Controls.Add(myOrdersPage);
                    break;
                case TabPageType.OrderRecieptPage:
                    tab.Text = "Recieve Order";
                    OrderRecieptManager orderctr = new OrderRecieptManager(new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection));
                    orderctr.Dock = DockStyle.Fill;
                    tab.Controls.Add(orderctr);
                    break;
               
                case TabPageType.JobsManagerPage:
                     
                    TabPage jobsTab = new TabPage("Job Manager");
                    JobsControl jobsControl = new JobsControl(ctx);
                    jobsControl.Dock = DockStyle.Fill;
                    jobsTab.Controls.Add(jobsControl);
                    return jobsTab;
                    break;

                case TabPageType.OrderReceiptHistoryPage:
                    tab.Text = "Order Reciepts";
                    OrderReceiptHistoryPage orderHistoryControl = new OrderReceiptHistoryPage(ctx);
                    orderHistoryControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(orderHistoryControl);
                    break;
               
                case TabPageType.PartEditorPage:
                    tab.Text = "Part Editor";
                    //PartEditor partEditorControl = new PartEditor(ctx);
                    PartManager partEditorControl = new PartManager(ctx);
                    partEditorControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(partEditorControl);
                    break;     

                // Open Part for Detailed Editing w/ resource --
                case TabPageType.ManufacturersPage:
                    
                        tab.Text = "Manufacturers";
                        tab.Name = "Manufacturers";
                        ManufacturerControl manufacturerControl = new ManufacturerControl(ctx);
                        manufacturerControl.Dock = DockStyle.Fill;
                        tab.Controls.Add(manufacturerControl);
                    
                    break;
                // Delivery List Page -------------------------
                case TabPageType.DeliveryPage:

                    tab.Text = "Deliveries";
                    tab.Name = "Deliveries";
                    DeliveryControl delivery = new DeliveryControl(ctx);
                    delivery.Dock = DockStyle.Fill;
                    tab.Controls.Add(delivery);
                    return tab;

                    break;
                case TabPageType.PurchaseOrderPage:
                    {                        
                        tab.Text = $"Purchase Order :{key}";
                        tab.Name = "Order";
                        //// OrderEditControl ctr = new OrderEditControl();
                        OrderEditSplitPanelControl ctr = new OrderEditSplitPanelControl();
                        ctr.SetDataSource(ctx,key);
                        //// ctr.LoadByID(key);
                        ctr.Dock = DockStyle.Fill;
                        tab.Controls.Add(ctr);                
                    }
                    break;
                //-----------------------------------------------------------------------+
                // Stock Managers Page --------------------------------------------------+
                //-----------------------------------------------------------------------+
                case TabPageType.StockManagerPage:
                    {
                        tab.Text = $"Stock Manager";
                        tab.Name = "StockManager";
                        StockManagerControl ctr = new StockManagerControl(ctx);                        
                        ctr.Dock = DockStyle.Fill;
                        tab.Controls.Add(ctr);
                    }
                    break;
                default:
                    break;
            }
            return tab;
        }
    }
}
