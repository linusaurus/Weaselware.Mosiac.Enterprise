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

namespace Mosiac.UX.UXControls
{
    public partial class ProductsControl : UserControl
    {
        private readonly MosaicContext _context;
        ServiceLayer.ProductService _productService;
        JobsService _jobService;
        PartsService partsService;

        Job _selectedJob;
        // This is the primary active object -----------------------------
        JobListDto _SelectedJobDTO;
        ProductDto _selectedProductDto = new ProductDto();
        SubAssemblyDTO _selectedSubAssemblyDTO = new SubAssemblyDTO();

        public ProductsControl(MosaicContext context)
        {
            InitializeComponent();
            _context = context;
            _jobService = new JobsService(_context);
            cboSelectJob.Items.Clear();
            cboSelectJob.DataSource = _jobService.Recent();
            cboSelectJob.DisplayMember = "JobName";
        }
    }
}
