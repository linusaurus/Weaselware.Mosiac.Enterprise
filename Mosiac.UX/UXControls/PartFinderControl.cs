using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using ServiceLayer;
using ServiceLayer.Overloads;


namespace Mosiac.UX.UXControls
{
    public partial class PartFinderControl : UserControl
    {
        private  MosaicContext _ctx;
        PartsService partsService;
        OrdersService _ordersService;
        SearchOptions _searchOptions = SearchOptions.Contains;
        private Part _selectedPart;
        String currentPartSearch;
        BindingSource bsPart = new BindingSource();
        private  List<SupplierLineItemDto> 
            supplierLineItems = new List<SupplierLineItemDto>();
        
        #region Events

        // Standard Part --------------+
        public class PartAddedArgs : System.EventArgs
        {
            public Part selectPart { get; set; }

        }
        public delegate void AddPartHandler(object sender, PartAddedArgs e);
        public event AddPartHandler OnPartAdded;


        // JobPart  ----------------------------
        public class JobPartAddedArgs : System.EventArgs
        {
            public LineItemDto jobLineItem { get; set; }
        }

        public delegate void AddJobPartHandler(object sender, JobPartAddedArgs e);
        public event AddJobPartHandler OnJobPartAdded;


        // Supplier-Part  ----------------------------
        public class SupplierPartAddedArgs : System.EventArgs
        {
            public LineItemDto jobLineItem { get; set; }
        }
        
        #endregion

        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; }

        public PartFinderControl()
        {
            InitializeComponent();
            BuildSupplierPartGrid();
        }


        public void LoadDatasource(MosaicContext context, int supplierID)
        {
            _ctx = context;
            partsService = new PartsService(_ctx);
            _ordersService = new OrdersService(_ctx);
            dgvPartsSearchResults.AutoGenerateColumns = false;
            dgSupplierParts.AutoGenerateColumns = false;
            //This init the EF query-strangely its needed 
            Part blow = partsService.Find(1);
            supplierLineItems = _ordersService.GetSupplierLineItems(supplierID);
            dgSupplierParts.DataSource = supplierLineItems;
            dgSupplierParts.CellContentClick += DgSupplierParts_CellContentClick;
        }

        public PartFinderControl(MosaicContext context,int supplierID)
        {
            InitializeComponent();         
        }

        private void DgSupplierParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {               
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                SupplierLineItemDto _selectedSupplierLineItem = (SupplierLineItemDto)dg.CurrentRow.DataBoundItem;
                if (_selectedSupplierLineItem != null)
                {
                    var order = _ordersService.GetOrderByID(_selectedSupplierLineItem.OrderNum);
                    //--Open a Purchase Order Page for the order---
                    Mediator.GetInstance().OnOrderOpened(this, order);
                }


            }
               
 
        }

        private void PartFinderControl_Load(object sender, EventArgs e)
        {

        }

        private void tbSearchParts_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                currentPartSearch = tb.Text;
                SearchParts(currentPartSearch);
            }
        }

        private void SearchParts(string search)
        {
            var parts = partsService.SearchParts(search, _searchOptions);
            this.dgvPartsSearchResults.DataSource = parts;
        }
        #region Search Options

        private void rbStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            _searchOptions = SearchOptions.StartsWith;
            SearchParts(currentPartSearch);
        }

        private void rbContains_CheckedChanged(object sender, EventArgs e)
        {
            _searchOptions = SearchOptions.Contains;
            SearchParts(currentPartSearch);
        }

        #endregion

        private void tbSearchParts_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        private void dgvPartsSearchResults_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                if (dgv.Rows.Count > 0)
                {_selectedPart = (Part)dgv.CurrentRow.DataBoundItem; } 
            }           
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (OnPartAdded != null)
            {
               
                     if (_selectedPart != null)
                    {OnPartAdded(this, new PartAddedArgs { selectPart = _selectedPart }); } 
                    
                
            }
        }

        private void btnAddJobPart_Click(object sender, EventArgs e)
        {
            if (OnJobPartAdded != null)
            {
                if (OnJobPartAdded != null)
                { OnJobPartAdded(this, new JobPartAddedArgs { jobLineItem = new LineItemDto { Description = "JobPart" } }); }
            }
        }

        private void btnNewPart_Click(object sender, EventArgs e)
        {
            if (OnJobPartAdded != null)
            {
                if (OnJobPartAdded != null)
                { OnJobPartAdded(this, new JobPartAddedArgs { jobLineItem = new LineItemDto { Description = "JobPart" } }); }
            }
        }

        private void BuildSupplierPartGrid()
        {
            dgSupplierParts.AutoGenerateColumns = false;
            dgSupplierParts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // PartID Column --
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ID";
            colID.DataPropertyName = "PartID";
            colID.Width = 75;

            // Qnty ----------
            DataGridViewTextBoxColumn colQnty = new DataGridViewTextBoxColumn();
            colQnty.Width = 75;
            colQnty.HeaderText = "Qnty";
            colQnty.DataPropertyName = "Qnty";
            colQnty.DefaultCellStyle = dstyleDecimal;

            // Description Column --
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.DefaultCellStyle = dstyleWrapText;
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "Description";
            colDescription.Width = 450;
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Order No. ----------
            DataGridViewLinkColumn colOrderNum = new DataGridViewLinkColumn();
            colOrderNum.Width = 85;
            colOrderNum.HeaderText = "Order No#";
            colOrderNum.DataPropertyName = "OrderNum";

            //colUnit.DataSource = _partService.Units();
            dgSupplierParts.Columns.AddRange(colID, colQnty, colDescription, colOrderNum);
        }
    }
}
