
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
using DataLayer.Entity;
using Mosiac.UX.UXControls;

namespace Mosiac.UX
{
    public partial class Main : Form
    {
        IOrderReceiptRepository orderReceiptRepository;
        public  Main(IOrderReceiptRepository orderReceiptRepository)
        {
            InitializeComponent();
            this.orderReceiptRepository = orderReceiptRepository;

            var orders = orderReceiptRepository.Find(p => p.OrderNum == 5000);
            OrderRecieptManager manager = new OrderRecieptManager(this.orderReceiptRepository);
            manager.Dock = DockStyle.Fill;
          
            Controls.Add(manager);
        }

    }
}
