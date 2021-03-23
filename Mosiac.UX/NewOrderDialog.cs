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
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;

namespace Mosiac.UX
{
    public partial class NewOrderDialog : Form
    {
        private readonly MosaicContext _context;
        private readonly JobsService _jobService;
        private readonly SuppliersService _supplierService;
        
        public NewOrderDialog(MosaicContext context)
        {
            InitializeComponent();
            _context = context;
            _jobService = new JobsService(_context);
            _supplierService = new SuppliersService(context);
            tbSupplier.Validated += TbSupplier_Validated;
            tbJobSelection.Validated += TbJobSelection_Validated;

            AutoCompleteStringCollection jobNames = new AutoCompleteStringCollection();
            foreach (var item in _jobService.All())
            {
                jobNames.Add(item.JobName);
            }
            this.tbJobSelection.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.tbJobSelection.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbJobSelection.AutoCompleteCustomSource = jobNames;

            AutoCompleteStringCollection supplierNames = new AutoCompleteStringCollection();
            foreach (var item in _supplierService.GetAll())
            {
                supplierNames.Add(item.SupplierName);
            }
            this.tbSupplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.tbSupplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSupplier.AutoCompleteCustomSource = supplierNames;
            CheckState();

        }

        private void CheckState()
        {
         
            if (JobNumber > 0 && SupplierID > 0)
            { btnGo.Enabled = true;}
            else
            {  btnGo.Enabled = false; }
                 
        }

        private void TbJobSelection_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            var result =_jobService.GetJobs(tb.Text);
            if (result != null || result.Count > 0)
            {
                JobNumber = result[0].jobID;
            }
            CheckState();
        }

        private void TbSupplier_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            var result = _supplierService.Find(tb.Text);
            if (result != null || result.Count > 0)
            {
                SupplierID = result[0].SupplierID;
                CheckState();
            }
            CheckState();
        }

        private void NewOrderDialog_Load(object sender, EventArgs e)
        {
            tbJobSelection.Focus();
            this.ActiveControl = tbJobSelection;
        }

        public int JobNumber { get; set; }
        public int SupplierID { get; set; }


    }
}
