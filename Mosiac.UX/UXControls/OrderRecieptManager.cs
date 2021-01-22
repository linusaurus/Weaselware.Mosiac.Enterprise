using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using SimpleInjector;
using ServiceLayer;
using System.Composition;

namespace Mosiac.UX.UXControls
{
    public partial class OrderRecieptManager : UserControl
    {


        private readonly IOrderReceiptRepository _orderReceiptRepository;

        public OrderRecieptManager(IOrderReceiptRepository orderReceiptRepository)
        {
            InitializeComponent();
            _orderReceiptRepository = orderReceiptRepository;
    

        }
    }
}
