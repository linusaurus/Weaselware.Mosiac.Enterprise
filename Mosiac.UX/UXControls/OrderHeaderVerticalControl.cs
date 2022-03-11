using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using ServiceLayer.Mappers;
using ServiceLayer.Models;
using Mosiac.UX;
using Mosiac.UX.Forms;
using DataLayer.Data;

namespace Mosiac.UX.UXControls
{ 
    /// <summary>
    /// Control for suppliers and order totals
    /// </summary>
    public partial class OrderHeaderVerticalControl : UserControl
    {
        
        private BindingSource bsorder = new BindingSource();
        private Boolean locked = false;

        public bool Locked { get => locked; set => locked = value; }

        //-----------------------------------------------------
        public event EventHandler  OnSaveHandler;
        public event EventHandler OnPrintHandler;
        public event EventHandler OnOrderCanceledHandler;
        //-----------------------------------------------------
        public delegate void SupplierChangedEventHandler(object sender, SupplierChangeArgs args);
        public event SupplierChangedEventHandler OnChangeSupplierHandler;

        public delegate void   OnJobChangedEventHandlerHandler(object sender, JobChangedArgs args);
        public event OnJobChangedEventHandlerHandler OnJobChangedHandler;

       

        public class SupplierChangeArgs : EventArgs
        {
            public SupplierChangeArgs(int supplierID)
            {
                SupplierID = supplierID;
            }

            public int SupplierID { get; set; }
        }

        public class JobChangedArgs : EventArgs
        {
            public JobChangedArgs(int jobID)
            {
                JobID = jobID;
            }

            public int JobID { get; set; }
        }


        protected virtual void OnSave(EventArgs e)
        {
            if (OnSaveHandler != null)
            {OnSaveHandler(this, e);}
        }

        protected virtual void OnPrint(EventArgs e)
        {
            if (OnPrintHandler != null)
            {
                OnPrintHandler(this, e);
            }
        }

        protected virtual void OnCancel(EventArgs e)
        {
            if (OnOrderCanceledHandler != null)
            {
                OnOrderCanceledHandler(this, e);
            }
        }

        protected virtual void OnSupplierChanged(SupplierChangeArgs e)
        {
            if (OnChangeSupplierHandler != null)
            {
                OnChangeSupplierHandler(this, e);
            }
        }


        public OrderHeaderVerticalControl()
        {
            InitializeComponent();

        }

        public void LoadDataSource(BindingSource BSorder)
        {
            bsorder = BSorder;
            Bind();
        }

       
        
        private void Bind()
        {
            // Order Number -------------------------------------------------------
            txtOrderNumber.DataBindings.Clear();
            txtOrderNumber.DataBindings.Add("Text", bsorder, "PurchaseOrderID", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Name -------------------------------------------------------
            txtSupplierName.DataBindings.Clear();
            txtSupplierName.DataBindings.Add("Text", bsorder, "SupplierName", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Address -------------------------------------------------------
            txtSupplierAddress.DataBindings.Clear();
            txtSupplierAddress.DataBindings.Add("Text", bsorder, "SupplierAddress", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier City -------------------------------------------------------
            txtCity.DataBindings.Clear();
            txtCity.DataBindings.Add("Text", bsorder, "SupplierCity", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier State -------------------------------------------------------
            txtState.DataBindings.Clear();
            txtState.DataBindings.Add("Text", bsorder, "SupplierState", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Zip -------------------------------------------------------
            txtZip.DataBindings.Clear();
            txtZip.DataBindings.Add("Text", bsorder, "SupplierZip", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Phone -------------------------------------------------------
            mtxtPhone.DataBindings.Clear();
            mtxtPhone.DataBindings.Add("Text", bsorder, "SupplierPhone", true, DataSourceUpdateMode.OnPropertyChanged);
            // Supplier Fax -------------------------------------------------------
            mtxtFax.DataBindings.Clear();
            mtxtFax.DataBindings.Add("Text", bsorder, "SupplierFax", true, DataSourceUpdateMode.OnPropertyChanged);
            // Purchaser -------------------------------------------------------
            txtPurchaser.DataBindings.Clear();
            txtPurchaser.DataBindings.Add("Text", bsorder, "Purchaser", true, DataSourceUpdateMode.OnPropertyChanged);
            // Order Date -------------------------------------------------------
            txtOrderDate.DataBindings.Clear();
            txtOrderDate.DataBindings.Add("Text", bsorder, "OrderDate", true, DataSourceUpdateMode.OnPropertyChanged);
            // Order Total -------------------------------------------------------
            txtOrderTotal.DataBindings.Clear();
            txtOrderTotal.DataBindings.Add("Text", bsorder, "OrderTotal", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // SubTotal
            txtSubTotal.DataBindings.Clear();
            txtSubTotal.DataBindings.Add("Text", bsorder, "SubTotal", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Tax -------------------------------------------------------
            txtTax.DataBindings.Clear();
            txtTax.DataBindings.Add("Text", bsorder, "Tax", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Memo ---------------------------------------------------------------------------------------------
            txtMemo.DataBindings.Clear();
            txtMemo.DataBindings.Add("Text", bsorder, "Memo", true, DataSourceUpdateMode.OnPropertyChanged);
            // Rep
            txtAttention.DataBindings.Clear();
            txtAttention.DataBindings.Add("Text", bsorder, "SalesRep", true, DataSourceUpdateMode.OnPropertyChanged);
            // Taxable
            cbTaxable.DataBindings.Clear();
            cbTaxable.DataBindings.Add("Checked", bsorder, "Taxable", true, DataSourceUpdateMode.OnPropertyChanged);
            // Shipping and Fees
            txtOtherFees.DataBindings.Clear();
            txtOtherFees.DataBindings.Add("Text", bsorder, "ShippingCost", true, DataSourceUpdateMode.OnPropertyChanged, 0.0, "C");
            // Jobname --
            txtJobName.DataBindings.Clear();
            txtJobName.DataBindings.Add("Text", bsorder, "JobName", true, DataSourceUpdateMode.OnPropertyChanged);
            // Taxrate
            txtTaxRate.DataBindings.Clear();
            txtTaxRate.DataBindings.Add("Text", bsorder, "TaxRate", true, DataSourceUpdateMode.OnPropertyChanged,0.0,"P");
            // Account Number --
            txtAccountNumber.DataBindings.Clear();
            txtAccountNumber.DataBindings.Add("Text", bsorder, "AccountNumber", true, DataSourceUpdateMode.OnPropertyChanged);
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSaveHandler(this,e);
            // if the return value is true
            btnSave.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OnPrintHandler(this, e);
        }

        private void OrderHeaderVerticalControl_Load(object sender, EventArgs e)
        {

        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            int supplierID = ((OrderDetailDto)bsorder.DataSource).SupplierID;
            
            Forms.SupplierEditForm frm = new Forms.SupplierEditForm(supplierID, new DataLayer.Data.MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection));
            if (frm.ShowDialog() == DialogResult.OK)
            {               
                ((OrderDetailDto)bsorder.DataSource).SupplierName = frm._supplierToEdit.SupplierName;
                ((OrderDetailDto)bsorder.DataSource).SupplierAddress = frm._supplierToEdit.Address1;
                ((OrderDetailDto)bsorder.DataSource).SupplierCity = frm._supplierToEdit.City;
                ((OrderDetailDto)bsorder.DataSource).SupplierState = frm._supplierToEdit.State;
                ((OrderDetailDto)bsorder.DataSource).SupplierZip = frm._supplierToEdit.Zip;
                ((OrderDetailDto)bsorder.DataSource).SupplierPhone = frm._supplierToEdit.Phone;
                ((OrderDetailDto)bsorder.DataSource).SupplierFax = frm._supplierToEdit.Fax;
                ((OrderDetailDto)bsorder.DataSource).AccountNumber = frm._supplierToEdit.AccountNumber;
                ((OrderDetailDto)bsorder.DataSource).TaxRate = frm._supplierToEdit.TaxRate.GetValueOrDefault();
            }

        }

        private void btnChangeSupplier_Click(object sender, EventArgs e)
        {
            // Show dialog and retrieve SUpplier ID to pass into the event
            FindSupplierForm frm = new FindSupplierForm();          
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SupplierChangeArgs ars = new SupplierChangeArgs(frm.SelectedSupplier.SupplierID);
                OnSupplierChanged(ars);
            }
 
        }

        private void gbCOst_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cancel To Order and put in locked state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            OnOrderCanceledHandler(this, e);
        }
        /// <summary>
        /// Change to current Job for the PurchaseOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJobChange_Click(object sender, EventArgs e)
        {
            using (var ctx = new MosaicContext(Mosiac.UX.Properties.Settings.Default.MosiacConnection))
            {
                SelectJobForm frm = new SelectJobForm(ctx);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            
            
           
        }
    }
}
