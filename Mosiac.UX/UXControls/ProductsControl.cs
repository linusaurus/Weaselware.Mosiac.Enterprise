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
using Motorola.Snapi.Commands;

using ServiceLayer;
using ServiceLayer.Models;
using Mosiac.UX.UIActions;

namespace Mosiac.UX.UXControls
{
    public partial class ProductsControl : UserControl
    {
        private readonly MosaicContext _context;
        private readonly ProductService _productService;
        private readonly JobsService _jobService;
        private readonly PartsService _partsService;
        private readonly BindingSource _productBindingSource = new BindingSource();
        private readonly BindingSource _subassemblyBindingSource = new BindingSource();

        private Job _selectedJob = null!; // Marked as readonly to fix IDE0044  
        private JobListDto _SelectedJobDTO = null!;
        private ProductDto _selectedProductDto = new(); // Removed readonly to allow assignment  
        private readonly SubAssemblyDTO _selectedSubAssemblyDTO = new();

        public ProductsControl(MosaicContext context)
        {
            InitializeComponent();
            _context = context;
            _jobService = new JobsService(_context);
            _productService = new ProductService(_context);
            _partsService = new PartsService(_context);
            if (Mosiac.UX.Properties.Settings.Default.ActiveJob != 0)
            {
                var products = _productService.GetProducts(Mosiac.UX.Properties.Settings.Default.ActiveJob);
                _selectedJob = _context.Job.Find(Mosiac.UX.Properties.Settings.Default.ActiveJob);
                _productBindingSource.DataSource = products;
                //Bind the data source to the DataGridView
           
                dgProductsAssemblies.DataSource = _productBindingSource;
                _productBindingSource.ListChanged += _productBindingSource_ListChanged;

                _subassemblyBindingSource.DataSource = _productBindingSource;
                _subassemblyBindingSource.DataMember = "SubAssembly";

                dgProductSubAssemblies.DataSource = _subassemblyBindingSource;
                _subassemblyBindingSource.ListChanged += _subassemblyBindingSource_ListChanged;

                tslActiveJob.Text = _selectedJob.jobname; // Assign the selected product to the field
                spcMain.Panel1Collapsed = true;

            }
            // cboSelectJob.Items.Clear();
            // cboSelectJob.DataSource = _jobService.Recent();
            // cboSelectJob.DisplayMember = "JobName";
        }

        private void _subassemblyBindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            if (e.ListChangedType == ListChangedType.ItemChanged)
            { UIactions.CheckForDirtyState(e, this.tsbSaveProducts); }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                { UIactions.CheckForDirtyState(e, this.tsbSaveProducts); }
            }
        }

        private void _productBindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            if (e.ListChangedType == ListChangedType.ItemChanged)
            { UIactions.CheckForDirtyState(e, this.tsbSaveProducts); }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                { UIactions.CheckForDirtyState(e, this.tsbSaveProducts); }
            }

        }

        private void cboSelectJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            var job = cboSelectJob.SelectedItem as JobListDto;
            if (job != null)
            {
                _SelectedJobDTO = job;
                var products = _productService.GetProducts(job.JobID);
                dgProductsAssemblies.DataSource = products;
            }
        }

        private void dgProductsAssemblies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductsAssemblies.CurrentRow != null)
            {
                var product = dgProductsAssemblies.CurrentRow.DataBoundItem as ProductDto;
                if (product != null)
                {
                    _selectedProductDto = product; // Now allowed since readonly was removed  
                   // dgProductSubAssemblies.DataSource = null; // Clear the sub-assemblies data source before loading new data
                    spcMain.Panel1Collapsed = true;
                    // var subAssemblies = _productService.GetSubAssemblies(product.ProductID);
                    // dgSubAssembly.DataSource = subAssemblies;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (!spcMain.Panel1Collapsed)
            {


                if ((keyData == Keys.Enter) || (keyData == Keys.Return))
                {
                    // Do custom stuff  
                    // true if key was processed by control, false otherwise  
                    if (txtJobSearch.Text.Length != 0)
                    {
                        // Use the search term directly instead of assigning it unnecessarily  
                        // Example: Pass txtJobSearch.Text directly to a method or logic  
                        PerformSearch(txtJobSearch.Text);
                    }
                    else
                    {
                        // SearchParts();  
                    }

                    return true;
                }
                else if (keyData == Keys.Escape) // clear the textboxes, null the dg source  
                {
                    txtJobSearch.Text = string.Empty;

                    return true;
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        // Example method to demonstrate usage of the search term  
        private async Task PerformSearch(string searchTerm)
        {

            var result = await _jobService.Search(searchTerm);
            dgJobSearchResults.DataSource = result;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            spcMain.Panel1Collapsed = !spcMain.Panel1Collapsed;
            if (spcMain.Panel1Collapsed)
            {
                toolStripButton1.Text = "Show Search";
            }
            else
            {
                toolStripButton1.Text = "Hide Search";
            }
        }

        private void dgJobSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgJobSearchResults.CurrentRow != null)
            {
                var job = dgJobSearchResults.CurrentRow.DataBoundItem as JobListDto;
                if (job != null)
                {
                    tslActiveJob.Text = job.JobName; // Assign the selected product to the field
                    Mosiac.UX.Properties.Settings.Default.ActiveJob = job.JobID;
                    Mosiac.UX.Properties.Settings.Default.Save();
                    var result = _productService.GetJobUnits(job.JobID);
                    dgProductsAssemblies.DataSource = result;
                    tslActiveJob.Text = job.JobName; // Assign the selected product to the field

                    // Uncomment the following lines if you want to load sub-assemblies for the selected product
                    // var subAssemblies = _productService.GetSubAssemblies(product.ProductID);
                    // dgSubAssembly.DataSource = subAssemblies;
                }
            }

        }

        private void dgProductsAssemblies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductsAssemblies.CurrentRow != null)
            {
                var product = dgProductsAssemblies.CurrentRow.DataBoundItem as Product;
                if (product != null)
                {
                    ///tslActiveJob.Text = product.UnitName; // Assign the selected product to the field
                   // var subAssemblies = _productService.GetSubAssemblies(product.ProductID);
                   // dgProductSubAssemblies.DataSource = subAssemblies;
                }
            }
        }

        private void tsbSaveProducts_Click(object sender, EventArgs e)
        {
            // Ensure that the CheckForDirtyState method is called with a non-null argument
            var listChangedEventArgs = new ListChangedEventArgs(ListChangedType.Reset, -1);
            UIActions.UIactions.ToogleButtonStyle(false,tsbSaveProducts );
        }
    }
}
