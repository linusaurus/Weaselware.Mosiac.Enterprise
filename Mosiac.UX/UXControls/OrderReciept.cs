using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using ServiceLayer.Models;
using ServiceLayer;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class OrderReciept : UserControl
    {
        
        BindingSource bsOrderReceipt = new BindingSource();
        BindingSource bsItems = new BindingSource();
        internal OrderReceiptDto orderReceipt;
        public OrderReciept(OrderReceiptDto dto)
        {
            InitializeComponent();
            orderReceipt = dto;
            bsOrderReceipt.DataSource = dto;
            Grids.BuildOrderReceiptItemsGrid(dgReceiptItems);
            dgReceiptItems.ReadOnly = true;
            dgReceiptItems.BackgroundColor = Color.Gray;
            BindOrderReceipt(bsOrderReceipt);
        }

        private void BindOrderReceipt(BindingSource bs)
        {
       

            txtOrderRecieptID.DataBindings.Add("Text",bs,"OrderReceiptId");
            txtReceiptDate.DataBindings.Add("Text",bs,"ReceiptDate",true,DataSourceUpdateMode.Never,"","d");
            txtReceivedBy.DataBindings.Add("Text",bs, "EmployeeName");
            txtOrderDate.DataBindings.Add("Text",bs,"OrderDate",true,DataSourceUpdateMode.Never,"","d");
            txtPurchaseOrderID.DataBindings.Add("Text",bs,"PurchaseOrderID");

            

            dgReceiptItems.DataSource = orderReceipt.OrderReceiptLineItems;
          
        }
    }
}
