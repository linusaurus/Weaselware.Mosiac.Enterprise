using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DataLayer.Data;
using DataLayer.Entity;
using DataLayer.Data;
using ServiceLayer.Models;
using System.Windows.Forms;
using Mosiac.UX.UXControls;
using ServiceLayer;

namespace Mosiac.UX.Forms
{
    public partial class PartEditForm : Form
    {
        
        public  BindingSource bsPart = new BindingSource();
        private IEnumerable<ManuListDTO> manus;
        private IEnumerable<ManuListDTO> partManus;
        private PartsService partsService;
        private List<UnitOfMeasure> units;
        

        public PartEditForm(BindingSource source,MosaicContext context)
        {
            InitializeComponent();
            partsService = new PartsService(context);
            bsPart = source;
            BindPart(bsPart);

            units = partsService.Units();
            manus = partsService.GetManus();
            partManus = partsService.GetManus();

            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "UnitOfMeasureID";
            cbxUnit.DataSource = units;
            cbxUnit.ResetText();
            cbxUnit.SelectedIndex = -1;


            //cboManu.DataSource = manus;
            //cboManu.DisplayMember = "ManufacturerName";
            //cboManu.ValueMember = "ManuID";

            cboPartManu.DataSource = partManus;
            cboPartManu.DisplayMember = "ManufacturerName";
            cboPartManu.ValueMember = "ManuID";
            cboPartManu.ResetText();
            cboPartManu.SelectedIndex = -1;
            cboPartManu.Text = "Manufacturer";
            bsPart.ListChanged += BsPart_ListChanged;
        }

        private void BsPart_ListChanged(object sender, ListChangedEventArgs e)
        {
            Grids.CheckForDirtyState(e, this.btnSave);
        }

        private void PartEditForm_Load(object sender, EventArgs e)
        {

        }

        private void BindPart(BindingSource bs)
        {

            if (bs.Current.GetType() == typeof(PartDetailDTO))
            {

                txtPartID.DataBindings.Clear();
                cbxObsolete.DataBindings.Clear();
                cbxUnit.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                txtWaste.DataBindings.Clear();
                txtMarkUp.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtStockLevel.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtPartDescription.DataBindings.Clear();
                txtPartName.DataBindings.Clear();

                txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxObsolete.DataBindings.Add("Checked", bsPart, "Obsolete", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxUnit.DataBindings.Add("SelectedValue", bsPart, "UID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                //txtStockLevel.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtUnitPrice.DataBindings.Add("Text", bsPart, "UnitCost", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (bs.Current.GetType() == typeof(Part))
            {
                txtPartID.DataBindings.Clear();
                cbxObsolete.DataBindings.Clear();
                cbxUnit.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                txtWaste.DataBindings.Clear();
                txtMarkUp.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtStockLevel.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtPartDescription.DataBindings.Clear();
                txtPartName.DataBindings.Clear();
                cboPartManu.DataBindings.Clear();

                txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxObsolete.DataBindings.Add("Checked", bsPart, "ObsoluteFlag", true, DataSourceUpdateMode.OnPropertyChanged);
                cbxUnit.DataBindings.Add("SelectedValue", bsPart, "UnitOfMeasureID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
                txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
                txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                //txtStockLevel.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);
                txtUnitPrice.DataBindings.Add("Text", bsPart, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPartName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
                cboPartManu.DataBindings.Add("SelectedValue", bsPart, "ManuID", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddManu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
