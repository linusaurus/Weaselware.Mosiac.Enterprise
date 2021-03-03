
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
using DataLayer.Data;
using Mosiac.UX.UXControls;

namespace Mosiac.UX
{
    public partial class Main : Form
    {
        public  Main(BadgerContext context)
        {
            InitializeComponent();
                            
            OrderRecieptManager manager = new OrderRecieptManager();
          
            manager.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(manager);
           
        }

    }
}
