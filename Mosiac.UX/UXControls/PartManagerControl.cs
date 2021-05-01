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
using ServiceLayer;
using ServiceLayer.Mappers;
using ServiceLayer.Models;


namespace Mosiac.UX.UXControls
{
    public partial class PartManagerControl : UserControl
    {
        private readonly MosaicContext _ctx;
        BindingSource BSpart = new BindingSource();
        PartDetailDTO partDTO = new PartDetailDTO();
        BindingSource bsResources = new BindingSource();
        private PartMapper partMapper = new PartMapper();
        PartDetailControl partControl;
        PartResourceControl resourceControl;
        
        PartsService _partService;
        int _selectedPartID;
        int _selectedManufacturer;
        bool UseManufacturer = false;
        Button btnSave;

        List<PartSearchDto> partsList = new List<PartSearchDto>();

        private bool isDirty;

        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        public PartManagerControl(MosaicContext context)
        {
            InitializeComponent();
            _ctx = context;
            _partService = new PartsService(_ctx);

            // The primary data hydration ------------------------
            var part = _partService.Find(1);
            // ---------------------------------------------------
            partMapper.Map(part, partDTO);
            ///TODO this create a part on startup and if you save it a null part
            BSpart.DataSource = partDTO;
            // Add the Part Control ---------------------
            partControl = new PartDetailControl();
            partControl.SetDatasource(BSpart);

            this.spcMain.Panel1.Controls.Add(partControl);
            partControl.Dock = DockStyle.Top;
            // Add the Resource Control ------------------

            resourceControl = new PartResourceControl();
            this.tabControl1.TabPages["tbResources"].Controls.Add(resourceControl);
            resourceControl.Dock = DockStyle.Fill;

            BuildPartsGrid(dgPartsSearch);
            // Cbo Manu-filter
            cboManuFilter.DisplayMember = "ManufacturerName";
            cboManuFilter.ValueMember = "ManuID";
            cboManuFilter.DataSource = _partService.GetManus();
            cboManuFilter.SelectedIndexChanged += CboManuFilter_SelectedIndexChanged;
            // -> Event Wiring ---
           
            // -> lbPartList.SelectedIndexChanged += LbPartList_SelectedIndexChanged;
            BSpart.ListChanged += BSpart_ListChanged;
            bsResources.ListChanged += BsResources_ListChanged;
            //dgPartsSearch.CellFormatting += DgPartsSearch_CellFormatting;
            dgPartsSearch.SelectionChanged += DgPartsSearch_SelectionChanged;

            partControl.OnPartSaved += PartControl_OnPartSaved;
            partControl.OnNewPart += PartControl_OnNewPart;
            partControl.OnPartDeleted += PartControl_OnPartDeleted;

            cboManuFilter.Visible = false;
            btnSave = partControl.btnSave;
        }

        private void DgPartsSearch_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPartsSearch.DataSource != null)
            {
                if (dgPartsSearch.RowCount > 0)
                {
                   
                    if (dgPartsSearch.CurrentRow != null)
                    {
                        _selectedPartID = (int)dgPartsSearch.CurrentRow.Cells[0].Value;
                        LoadPart(_selectedPartID);
                    }

                }

            }
        }

        private void DgPartsSearch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;

            // Cell 0 = PartID
            // Cell 1 = Description
            // Cell 2 = Manufacturer
            // Cell 3 = Orders

            foreach (DataGridViewRow row in dg.Rows)
            {                         
                if (Convert.ToInt32(row.Cells[3].Value) < 1) // Or your condition 
                { row.DefaultCellStyle.BackColor = Color.Cornsilk; }
           else
                {row.DefaultCellStyle.BackColor = Color.GhostWhite;}  
            }
        }

        private void PartControl_OnPartDeleted()
        {
            _partService.Delete(_selectedPartID);
        }

        private void PartControl_OnNewPart()
        {
            var part = _partService.New();
            partMapper.Map(part, partDTO);
            _partService.InsertOrUpdate(partDTO, Globals.CurrentUserName);
            LoadPart(partDTO.PartID);            
        }

        private void PartControl_OnPartSaved()
        {
            _partService.CreateOrUpdatePart(partDTO, "Richard");
            LoadPart(_selectedPartID);
            isDirty = false;
            ToogleButtonStyle(isDirty);
        }

        private void CboManuFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            _selectedManufacturer = ((ManuListDTO)cbo.SelectedItem).ManuID;
            dgPartsSearch.DataSource = _partService.GetManufacturerParts(_selectedManufacturer);
        }

        private void BSpart_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckForDirtyState(e);
        }

        private void BsResources_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckForDirtyState(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _partService.CreateOrUpdatePart(partDTO, "Richard");
            LoadPart(_selectedPartID);
            isDirty = false;
            ToogleButtonStyle(isDirty);
        }

        // Heavy Lifting a single part with resource(binary) and old style
        //----------------------------------------------------------------
        private void LoadPart(int id)
        {
            var part = _partService.Find(id);
            partMapper.Map(part, partDTO);
            BSpart.DataSource = partDTO;

            partControl.SetDatasource(BSpart);
            bsResources.DataSource = partDTO.Resources;
            resourceControl.SetDataSource(bsResources);
            isDirty = false;
            ToogleButtonStyle(isDirty);
        }
        //-----------------------------------------------------------------

        #region Dirty Checks  --
        private void CheckForDirtyState(ListChangedEventArgs e)
        {
                       
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
        }

        private void ToogleButtonStyle(bool dirtyState)
        {
            btnSave = partControl.btnSave;

            if (dirtyState == true)
            {
                btnSave.BackColor = System.Drawing.Color.Cornsilk;
                btnSave.FlatStyle = FlatStyle.Flat;
                btnSave.FlatAppearance.BorderColor = Color.Red;
                btnSave.FlatAppearance.BorderSize = 3;
            }

            else if (dirtyState == false)
            {
                btnSave.BackColor = Color.Gainsboro;
                btnSave.FlatAppearance.BorderColor = Color.AliceBlue;
                btnSave.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }


        #endregion

        private void txtPartSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            List<PartSearchDto> lst = new List<PartSearchDto>();
            //dgPartsSearch.DataSource = _partService.SearchPart(tb.Text,_selectedManufacturer);
            partsList = _partService.SearchPart(tb.Text, _selectedManufacturer);
            DataTable ListAsDataTable = BuildDataTable<PartSearchDto>(partsList);
            DataView dv = ListAsDataTable.DefaultView;
            dgPartsSearch.DataSource = dv;
        }
     
        private void cbxUseManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                cboManuFilter.Visible = true;
                UseManufacturer = true;            
            }
            else if (cb.Checked == false)
            {
                cboManuFilter.Visible = false;
                UseManufacturer = false;
                _selectedManufacturer = 0;
            }

        }

        private void txtPartIDSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            int id;
            if (int.TryParse(tb.Text, out id))
            {
                _selectedPartID = id;
                LoadPart(_selectedPartID);
            }
        }

        private void BuildPartsGrid(DataGridView dg)
        {


            dg.AutoGenerateColumns = false;
             //dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
             //dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
             dg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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
            DataGridViewTextBoxColumn colPartID = new DataGridViewTextBoxColumn();
            colPartID.HeaderText = "PartID";
            colPartID.DataPropertyName = "PartID";
            colPartID.Width = 55;

            // Description Column --
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "Description";
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.DefaultCellStyle = dstyleWrapText;
            
            // Manufacturer Column --
            DataGridViewTextBoxColumn colManu = new DataGridViewTextBoxColumn();
            colManu.HeaderText = "Manufacturer";
            colManu.DataPropertyName = "Manufacturer";
            colManu.Width = 150;

            // Orders Column --
            DataGridViewTextBoxColumn colOrders = new DataGridViewTextBoxColumn();
            colOrders.HeaderText = "Orders";
            colOrders.DataPropertyName = "Orders";
            colOrders.Width = 65;

            dg.Columns.AddRange(colPartID, colDescription, colManu, colOrders);

        }

        // <T> is the type of data in the list.
        // If you have a List<int>, for example, then call this as follows:
        // List<int> ListOfInt;
        // DataTable ListTable = BuildDataTable<int>(ListOfInt);
        public static DataTable BuildDataTable<T>(IList<T> lst)
        {
            //create DataTable Structure
            DataTable tbl = CreateTable<T>();
            Type entType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            //get the list item and add into the list
            foreach (T item in lst)
            {
                DataRow row = tbl.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                tbl.Rows.Add(row);
            }
            return tbl;
        }

        private static DataTable CreateTable<T>()
        {
            //T –> ClassName
            Type entType = typeof(T);
            //set the datatable name as class name
            DataTable tbl = new DataTable(entType.Name);
            //get the property list
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entType);
            foreach (PropertyDescriptor prop in properties)
            {
                //add property as column
                tbl.Columns.Add(prop.Name, prop.PropertyType);
            }
            return tbl;
        }


        private void tsbCollapse_Click(object sender, EventArgs e)
        {
            if (spcPartSplitContatiner.Panel2Collapsed == true)
            {
                spcPartSplitContatiner.Panel2Collapsed = false;
                tsbCollapse.Image = Mosiac.UX.Properties.Resources.baseline_push_pin_black_24dp;
            }
            else if (spcPartSplitContatiner.Panel2Collapsed == false)
            {
                spcPartSplitContatiner.Panel2Collapsed = true;
                tsbCollapse.Image = Mosiac.UX.Properties.Resources.round_keyboard_arrow_up_black_24dp;
            }          
        }

        private void rbRowColorNone_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "rbRowColorNone":
                    break;
                case "rbRowColorNeverOrdered":
                    break;
                case "rbRowColorNoInventory":
                    break;

                default:
                    break;
            }
        }
    }
}


