using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosiac.UX.Forms
{
    public partial class StockLevelAdjustmentForm : Form
    {

        public decimal Adjustment = decimal.Zero;
        
        public StockLevelAdjustmentForm()
        {
            InitializeComponent();
            txtAdjustment.Text = "0.00";
           
        }

        private void StockLevelAdjustmentForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtAdjustment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAdjustment_TextChanged(object sender, EventArgs e)
        {
            Adjustment = Convert.ToDecimal(txtAdjustment.Text);
        }
    }
}
