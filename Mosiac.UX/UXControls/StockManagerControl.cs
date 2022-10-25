using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer.Models;
using ServiceLayer.Services;
using DataLayer.Data;
using ServiceLayer;

namespace Mosiac.UX.UXControls
{
    public partial class StockManagerControl : UserControl
    {
        readonly MosaicContext _ctx;
        StockService _stockService;
        
        public StockManagerControl(MosaicContext context)
        {
            InitializeComponent();
            _ctx = context;
            _stockService = new StockService(_ctx);
            Grids.BuildLineItemSearchGrid(dataGridView1);
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
               int po = ((LineItemSearchDto)dataGridView1.CurrentRow.DataBoundItem).purchaseOrderID;
                Main main = (Main)Application.OpenForms["Main"];
                main.OpenAnOrder(po);
            }           
        }

        private async void FindLineItems()
        {
            String[] terms = new string[2];
            terms[0] = txtSearchTwo.Text;
            terms[1] = txtSearchthree.Text;
            this.dataGridView1.DataSource = await _stockService.SearchLineItemAsync(txtSearchOne.Text,terms);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsSearchLineItems":
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindLineItems();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {
                FindLineItems();
                return true;
            }
            else if ((keyData == Keys.Escape))
            {
                ClearSearch();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void ClearSearch()
        {
            txtSearchOne.Text = String.Empty;
            txtSearchTwo.Text = String.Empty;
            txtSearchthree.Text = String.Empty;
            this.dataGridView1.DataSource = null;
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsSearchLineItems":
                    tsSearchLineItems.BackColor = Color.Bisque;
                    tsTransactions.BackColor = Color.Gainsboro;
                    //-- set the control surface --
                    break;

                case "tsTransactions":

                    tsTransactions.BackColor = Color.Bisque;
                    tsSearchLineItems.BackColor = Color.Gainsboro;

                    splitContainer1.Panel2.Controls.Clear();
                    InventoryTransactionsControl control = new InventoryTransactionsControl(_ctx);
                    control.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(control);
                    break;

                default:
                    break;
            }
        }
    }
}
