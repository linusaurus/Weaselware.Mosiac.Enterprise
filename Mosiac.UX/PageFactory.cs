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
            JobManagerPage,
            ManufacturersPage,
            StockBill,
            PartEditorPage,
            PartDetailEdit,
            PurchaseOrderPage,
            AssemblyManagerControl,
            RecieveOrderControl

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
                // Order Seach/Display Page
                case TabPageType.PurchaseOrdersPage:
                    //tab.Text = "Orders Manager";
                    //OrderManager po = new OrderManager(ctx);
                    //po.Dock = DockStyle.Fill;
                    //tab.Controls.Add(po);
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
                case TabPageType.ItemSearchPage:
                    //tab.Text = "Item Search";
                    //ItemSearchControl searchctr = new ItemSearchControl(ctx);
                    //searchctr.Dock = DockStyle.Fill;
                    //tab.Controls.Add(searchctr);
                    break;
                case TabPageType.JobManagerPage:
                     
                    TabPage jobTab = new TabPage("Job Manager");
                    JobManager jobControl = new JobManager(ctx);
                    jobControl.Dock = DockStyle.Fill;
                    jobTab.Controls.Add(jobControl);
                    return jobTab;
                    break;

                case TabPageType.OrderReceiptHistoryPage:
                    tab.Text = "Order Reciepts";
                    OrderReceiptHistoryPage orderHistoryControl = new OrderReceiptHistoryPage(ctx);
                    orderHistoryControl.Dock = DockStyle.Fill;
                    tab.Controls.Add(orderHistoryControl);
                    break;
                case TabPageType.StockBill:
                    //tab.Text = "Stock Bill";
                    //StockBillControl stockBillControl = new StockBillControl(ctx);
                    //stockBillControl.Dock = DockStyle.Fill;
                    //tab.Controls.Add(stockBillControl);
                    break;
                case TabPageType.AssemblyManagerControl:
                    //tab.Text = "Products";
                    //AssemblyManagerControl assemblyManagerControl = new AssemblyManagerControl(ctx);
                    //assemblyManagerControl.Dock = DockStyle.Fill;
                    //tab.Controls.Add(assemblyManagerControl);
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

                default:
                    break;
            }
            return tab;
        }
    }
}
