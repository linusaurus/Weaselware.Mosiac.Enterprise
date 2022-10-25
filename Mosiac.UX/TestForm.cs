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
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer.Services;
using Mosiac.UX.UXControls;

namespace Mosiac.UX
{
    public partial class TestForm : Form
    {
        private readonly MosaicContext ctx;
 
        ServiceLayer.ProductService _productService;
        JobsService _jobService;
        PartsService partsService;

        Job _selectedJob;
        // This is the primary active object -----------------------------
        JobListDto _SelectedJobDTO;
        ProductDto _selectedProductDto = new ProductDto();
        SubAssemblyDTO _selectedSubAssemblyDTO = new SubAssemblyDTO();

        bool _loading = true;
        public static int _counter = 1;
        private List<ProductDto> _products;
        ProductMapper productMapper = new ProductMapper();
        JobMapper jobMapper = new JobMapper();

        BindingSource bsProducts = new BindingSource();
        BindingSource bsSubassemlies = new BindingSource();

       

        public TestForm()
        {
            InitializeComponent();
            ctx = new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection);
            ProductsControl ctr = new ProductsControl(ctx);
            ctr.Dock = DockStyle.Fill;
            this.Controls.Add(ctr);

        }
    }
}
