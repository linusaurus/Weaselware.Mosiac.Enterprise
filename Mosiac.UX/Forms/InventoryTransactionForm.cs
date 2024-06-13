using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
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
    public partial class InventoryTransactionForm : Form
    {
        private readonly MosaicContext context;
        private Part _currentPart;
        private readonly InventoryService inventoryService;
        
        public InventoryTransactionForm(MosaicContext context)
        {
            InitializeComponent();
            this.context = context;
            inventoryService = new InventoryService(context);

        }
    }
}
