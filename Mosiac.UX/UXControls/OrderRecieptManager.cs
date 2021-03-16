using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.Data;
using System.Linq;
using DataLayer.Entity;
using SimpleInjector;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System.Composition;

namespace Mosiac.UX.UXControls
{
    public partial class OrderRecieptManager : UserControl
    {


        private readonly OrderReceiptRepository _orderReceiptRepository;
        private OrderReceiptDto _orderRecieptDto = new OrderReceiptDto();
        private OrderReceiptMapper _orMapper = new OrderReceiptMapper();
        private int _selectedOrderID;
        private BindingSource bsOrderReceiptItems = new BindingSource();

        


        public OrderRecieptManager()
        {
            InitializeComponent();
            Grids.BuildPendingOrdersGrid(dgPendingOrders);
            Grids.BuildOrderReceiptItemsGrid(dgOrderReceiptItems);
            _orderReceiptRepository = new OrderReceiptRepository(new MosaicContext());
            //----------------------------- Pending Grid ------------------------------------
            var orderReceipts = _orderReceiptRepository.PendingOrders();
          
            this.dgPendingOrders.DataSource = orderReceipts;
            //------------------------------Event Wiring---------------------------------------
            dgPendingOrders.SelectionChanged += DgPendingOrders_SelectionChanged;
            bsOrderReceiptItems.ListChanged += BsOrderReceiptItems_ListChanged;
        }

        private void BsOrderReceiptItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e,this.btnSave);
        }

        private void DgPendingOrders_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    _selectedOrderID  = ((PendingOrdersDto)dg.CurrentRow.DataBoundItem).PurchaseOrderID;
                    this.label1.Text = $"Purchase Order {_selectedOrderID}"; 
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int orID =  _orderReceiptRepository.UpdateOrCreate(_orderRecieptDto);
            _orderRecieptDto = _orderReceiptRepository.GetOrderReceipt(orID);

            BindOrderReciptDTO(_orderRecieptDto);
            Grids.ToogleButtonStyle(false, btnSave);
           // _orderRecieptDto = _orderReceiptRepository.GetOrderReceipt(_orderRecieptDto.OrderReceiptId);

        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            _orderRecieptDto = _orderReceiptRepository.ReceiveOrder(_selectedOrderID);
            BindOrderReciptDTO(_orderRecieptDto);
        }

        private void BindOrderReciptDTO(OrderReceiptDto dto)
        {
            bsOrderReceiptItems.DataSource = dto.OrderReceiptLineItems ?? null;
            dgOrderReceiptItems.DataSource = bsOrderReceiptItems.DataSource;

        }
    }
}
