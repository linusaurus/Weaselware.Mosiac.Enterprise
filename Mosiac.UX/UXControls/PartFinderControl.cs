﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ServiceLayer.Models;
using ServiceLayer;
using System.Data;
using Mosiac.UX.Forms;

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

        DataTable ListAsDataTable;
        DataView dv;

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

        public void Lock()
        {
            this.btnAddJobPart.Enabled = false;
            this.btnAddToOrder.Enabled = false;
            this.dgSupplierParts.Enabled = false;
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

        private async void PartSearch()
        {
            string searchMain = tbSearchParts.Text;
            string term = txtTerm2.Text;
            string term2 = txtTerm3.Text;

            string[] parms = { term, term2 };

            if (tbSearchParts.Text.Length > 1)
            {
                var partsList = await partsService.SearchPartQueryAsync(searchMain, 1, false, parms);

                ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(partsList);
                dv = ListAsDataTable.DefaultView;
                dgvPartsSearchResults.DataSource = dv;
            }
            else
            {

            }
        }

        private void tbSearchParts_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //if (tb.Text.Length > 0)
            //{
            //    currentPartSearch = tb.Text;
            //    SearchParts(currentPartSearch);
            //}
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))
            {   
                PartSearch();
                return true;
            }
            else if (keyData == Keys.Escape) //clear the textboxes, null the dg source
            {
                tbSearchParts.Text = string.Empty;
                txtTerm2.Text = string.Empty;
                txtTerm3.Text = string.Empty;
                dgvPartsSearchResults.DataSource = null;
                tbSearchParts.Focus();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void SearchParts(string search)
        {
           
            
            var parts = partsService.SearchParts(search, _searchOptions);
            ListAsDataTable = Grids.BuildDataTable<PartFastSearchDto>(parts);
            dv = ListAsDataTable.DefaultView;
            this.dgvPartsSearchResults.DataSource = dv;
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
                {
                    if (dgv.CurrentRow != null)
                    {
                    int partNumber = (int)dgv.CurrentRow.Cells[0].Value;
                    _selectedPart = partsService.Find(partNumber); 
                    }
                    
                } 
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

        private void dgvPartsSearchResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                if (dgv.Rows.Count > 0)
                {
                    if (dgv.CurrentRow != null)
                    {
                        int partID = (int)dgv.CurrentRow.Cells[0].Value;
                       Part _partBeingEdited = partsService.Find(partID);
                        BindingSource bsPart = new BindingSource();
                        bsPart.DataSource = _partBeingEdited;

                        PartEditForm frm = new PartEditForm(bsPart, _ctx);
                        frm.Text = $"Editing Part = {_partBeingEdited.PartID.ToString()} ";
                        frm.StartPosition = FormStartPosition.CenterParent;
                        var result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _partBeingEdited = (Part)bsPart.DataSource;
                            // _ctx.SaveChanges();

                            //LineItemDto lineitem = (LineItemDto)bsLineitems.Current;
                            //// change the lineitem text
                            //lineitem.Description = _partBeingEdited.ItemDescription;
                            //lineitem.Price = _partBeingEdited.Cost.GetValueOrDefault();

                        }
                        else if (result == DialogResult.Cancel)
                        {
                            bsPart.CancelEdit();

                        }

                    }

                }
            }
        }

        private void dgvPartsSearchResults_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.DataSource != null)
            {
                if (dgv.Rows.Count > 0)
                {
                    if (dgv.CurrentRow != null)
                    {
                        int partID = (int)dgv.CurrentRow.Cells[0].Value;
                        Part _partBeingEdited = partsService.Find(partID);
                        BindingSource bsPart = new BindingSource();
                        bsPart.DataSource = _partBeingEdited;

                        PartEditForm frm = new PartEditForm(bsPart, _ctx);
                        frm.Text = $"Editing Part = {_partBeingEdited.PartID.ToString()} ";
                        frm.StartPosition = FormStartPosition.CenterParent;
                        var result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _partBeingEdited = (Part)bsPart.DataSource;
                          
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            bsPart.CancelEdit();

                        }

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            if (! String.IsNullOrEmpty (txtPartNumber.Text) )
            {
                if (int.TryParse(txtPartNumber.Text,out result))
                {
                   _selectedPart = _ctx.Parts.AsNoTracking().Where(p => p.PartID == result).FirstOrDefault();
                    if (OnPartAdded != null)
                    {
                        if (_selectedPart != null)
                        { OnPartAdded(this, new PartAddedArgs { selectPart = _selectedPart }); }

                    }

                }


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PartSearch();
        }
    }
}
