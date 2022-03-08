using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mosiac.UX.Forms
{
    public partial class OrderReceiptViewerForm : Form
    {
        public OrderReceiptViewerForm()
        {
            InitializeComponent();
        }

        private void OrderReceiptViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void tsbClose_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                
                default:
                    break;
            }
        }
    }
}
