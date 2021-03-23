using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;
using ServiceLayer.Mappers;
using System.Windows.Forms;


namespace Mosiac.UX.UXControls
{
    public partial class OrderFeeControl : UserControl
    {
        
        
        BindingSource bsOrderFees = new BindingSource();
        OrderFeeDto _selectedFee;
        OrderDetailDto orderDTO;


        public delegate void OrderFeeAddedEventHandler(object sender, OrderFeeChangedEventArgs e);
        public delegate void OrderFeeRemovedEventHandler(object sender, OrderFeeChangedEventArgs e);

        public class OrderFeeChangedEventArgs : EventArgs
        {
            public string FeeName { get; set; }
        }

        public event OrderFeeAddedEventHandler OnOrderFeeAdded;
        public event OrderFeeRemovedEventHandler OnOrderFeeRemoved;
        
        

       private void BuildGrid()
       {
           

            dgOrderFees.AutoGenerateColumns = false;
            dgOrderFees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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


            // ID Column --
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ID";
            colID.DataPropertyName = "OrderFeeID";
            colID.Width = 75;


            // Description Column --
            DataGridViewTextBoxColumn colFeeName = new DataGridViewTextBoxColumn();
            colFeeName.DefaultCellStyle = dstyleWrapText;
            colFeeName.HeaderText = "Description";
            colFeeName.DataPropertyName = "FeeName";
            colFeeName.Width = 450;
            colFeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Qnty ----------
            DataGridViewTextBoxColumn colQnty = new DataGridViewTextBoxColumn();
            colQnty.Width = 75;
            colQnty.HeaderText = "Qnty";
            colQnty.DataPropertyName = "Qnty";
            colQnty.DefaultCellStyle = dstyleDecimal;


            // UnitCost ----------
            DataGridViewTextBoxColumn colCost = new DataGridViewTextBoxColumn();
            colCost.Width = 60;
            colCost.HeaderText = "Cost";
            colCost.DataPropertyName = "Cost";
            colCost.DefaultCellStyle = dstyleCurrency;

          
            // Extended ----------
            DataGridViewTextBoxColumn colExtended = new DataGridViewTextBoxColumn();

            colExtended.Width = 60;
            colExtended.HeaderText = "Extension";
            colExtended.DataPropertyName = "Extension";
            colExtended.DefaultCellStyle = dstyleCurrency;
            
            //colUnit.DataSource = _partService.Units();
            dgOrderFees.Columns.AddRange(colID, colFeeName, colQnty, colCost, colExtended);

        }

        public OrderFeeControl()
        {
            InitializeComponent();
            BuildGrid();
            dgOrderFees.SelectionChanged += DgOrderFees_SelectionChanged;
        }

        private void DgOrderFees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOrderFees.DataSource != null)
            {
                BindingManagerBase bm = BindingContext[dgOrderFees.DataSource, dgOrderFees.DataMember];
                if (bm.Count > 0 && bm.Current != null)
                {
                    _selectedFee = (OrderFeeDto)bm.Current;
                }
            }
        }

        public void SetDataSource(OrderDetailDto OrderDTO,BindingSource BSorderFees)
        {

            orderDTO = OrderDTO;
            bsOrderFees = BSorderFees;
            dgOrderFees.DataSource = bsOrderFees;
        }

        private void OrderFeeControl_Load(object sender, EventArgs e)
        {
           
        }

        #region Actions and Events

        private void btnAddOrderFee_Click(object sender, EventArgs e)
        {
            if (OnOrderFeeAdded != null)
            {
                OnOrderFeeAdded(sender, new OrderFeeChangedEventArgs { FeeName = "New Fee Added" });
            }

            bsOrderFees.Add(new OrderFeeDto { FeeName = "New Fee" });
         
        }

        private void btnRemoveFee_Click(object sender, EventArgs e)
        {
            if (OnOrderFeeRemoved != null)
            {
                    OnOrderFeeRemoved(this, new OrderFeeChangedEventArgs { FeeName = "Fee Removed" });
            }
            bsOrderFees.Remove(_selectedFee);
            bsOrderFees.EndEdit();
        }

        #endregion
    }
}
