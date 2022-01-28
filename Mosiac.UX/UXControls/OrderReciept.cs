using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ServiceLayer.Models;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class OrderReciept : UserControl
    {
        OrderReceiptDto orderDetailDto;
        public OrderReciept(OrderReceiptDto dto)
        {
            InitializeComponent();
            orderDetailDto = dto;
            Grids.BuildOrderReceiptItemsGrid(dgReceiptItems);
            BindOrderReceipt(dto);
        }

        private void BindOrderReceipt(OrderReceiptDto dto)
        {
            this.txtOrderRecieptID.Text = dto.OrderReceiptId.ToString();
            txtReceiptDate.Text = dto.ReceiptDate.ToShortDateString();
            txtReceivedBy.Text = dto.EmployeeName;
            txtOrderDate.Text = DateTime.Today.ToShortDateString();
            txtPurchaseOrderID.Text = dto.PurchaseOrderID.ToString();

            dgReceiptItems.DataSource = dto.OrderReceiptLineItems;
        }
    }
}
