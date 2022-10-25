using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Data;
using ServiceLayer.Services;
using ServiceLayer.Models;
using ServiceLayer;

namespace Mosiac.UX.UXControls
{
    public partial class InventoryTransactionsControl : UserControl
    {
        readonly MosaicContext _ctx;
        InventoryService _inventoryService;
        public InventoryTransactionsControl(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _inventoryService = new InventoryService(_ctx);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtPartNo.Text.Length > 0)
            {
                int pid = int.Parse( txtPartNo.Text);
                var trans = await _inventoryService.GetPartTransactions(pid);
                this.dataGridView1.DataSource = trans;
            }
        }
    }
}
