using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServiceLayer;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using DataLayer.Data;
using DataLayer.Entity;

namespace Mosiac.UX
{
    public partial class OrderRecieptForm : Form
    {

        private OrderReceiptDto receiptDto;
        private PurchaseOrder order;
        private int purchaseOrderID;    
        private readonly MosaicContext _ctx;
        private readonly OrderReceiptRepository orderReceiptRepository;
        private readonly OrdersService ordersService;
        private BindingSource bsOrderReceipt = new BindingSource();
        private BindingSource bsItems = new BindingSource();


        public OrderRecieptForm(int OrderID,MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            UXControls.Grids.BuildOrderReceiptItemsGrid(dgOrderReceiptItemGrid);
            dgOrderReceiptItemGrid.AllowUserToAddRows = false;
            purchaseOrderID = OrderID;
            receiptDto = new OrderReceiptDto();

            ordersService = new OrdersService(_ctx);
            orderReceiptRepository = new OrderReceiptRepository(_ctx, Globals.CurrentUserName, Globals.CurrentLoggedUserID);
            receiptDto = orderReceiptRepository.LoadOrderReciept(purchaseOrderID);
            bsOrderReceipt.DataSource = receiptDto;
            //dgOrderReceiptItemGrid.DataSource = receiptDto.OrderReceiptLineItems;
            bsItems.DataSource = bsOrderReceipt;
            bsItems.DataMember = "OrderReceiptLineItems";
            dgOrderReceiptItemGrid.DataSource = bsItems;
            bsOrderReceipt.ListChanged += BsOrderReceipt_ListChanged;
            bsItems.ListChanged += BsItems_ListChanged;
           

        }

        private void BsItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            tsSubmit.BackColor = Color.Cornsilk; 
        }

        private void BsOrderReceipt_ListChanged(object sender, ListChangedEventArgs e)
        {
            
        }

        private void OrderRecieptForm_Load(object sender, EventArgs e)
        {

        }

        private void tsOrderReceipts_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsSubmit":
                    Application.UseWaitCursor = true;
                    orderReceiptRepository.UpdateOrCreate(receiptDto);
                    Application.UseWaitCursor = false;

                    this.Close();
                    break;
                case "tsCancel":
                    this.Close();
                    break;
                case "tsPrintLabels":
                    NotificationService.SendNotificaion("rich@designsynthesis.net", receiptDto);
                    break;
                default:
                    break;
            }
        }

        private void dgOrderReceiptItemGrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void tsBottomToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsCollapse":
                    if (!splitContainer1.Panel2Collapsed)
                    {
                        splitContainer1.Panel2Collapsed = true;
                        tsCollapse.Image = Mosiac.UX.Properties.Resources.round_keyboard_arrow_up_black_24dp;
                    }
                    else if (splitContainer1.Panel2Collapsed)
                    {
                        splitContainer1.Panel2Collapsed = false;
                        tsCollapse.Image = Mosiac.UX.Properties.Resources.round_keyboard_arrow_down_black_24dp;
                    }
                   
                    break;
              
                default:
                    break;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
