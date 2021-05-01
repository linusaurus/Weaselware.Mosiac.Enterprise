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
using ServiceLayer.Models;
using ServiceLayer.Mappers;


namespace Mosiac.UX.UXControls
{
    public partial class PartDetailControl : UserControl
    {
        private PartDetailDTO _part = new PartDetailDTO();
        private BindingSource bsPart = new BindingSource();
        private MosaicContext ctx;
        private PartsService partService;


      

        public event SavePart OnPartSaved;
        public delegate void SavePart();

        public event NewPart OnNewPart;
        public delegate void NewPart();

        public event DeletePart OnPartDeleted;
        public delegate void DeletePart();


        public PartDetailControl()
        {
            InitializeComponent();
            ctx = new MosaicContext();
            partService = new PartsService(ctx);
        }

      

        public void SetDatasource(BindingSource source)
        {
            BindPart(source);
        }

        private void BindPart(BindingSource bsPart)
        {
            // Clear the bindings ---
            this.txtPartID.DataBindings.Clear();
            this.txtDescription.DataBindings.Clear();
            this.txtItemName.DataBindings.Clear();
            this.txtUnitCost.DataBindings.Clear();
            this.txtWaste.DataBindings.Clear();
            this.txtWeight.DataBindings.Clear();
            this.txtMarkUp.DataBindings.Clear();
            this.txtAddedBy.DataBindings.Clear();
            this.txtDateAdded.DataBindings.Clear();
            this.txtLocation.DataBindings.Clear();
            this.txtModifiedDate.DataBindings.Clear();
            this.cbxCardTrack.DataBindings.Clear();
            this.cbxObsolete.DataBindings.Clear();
            this.txtSku.DataBindings.Clear();
            this.cboManufacturer.DataBindings.Clear();
            this.cboUnitOfMeasure.DataBindings.Clear();
            this.txtPartNumber.DataBindings.Clear();

            this.txtPartID.DataBindings.Add("Text", bsPart, "PartID", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtItemName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtUnitCost.DataBindings.Add("Text", bsPart, "UnitCost", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtMarkUp.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtAddedBy.DataBindings.Add("Text", bsPart, "AddedBy", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtDateAdded.DataBindings.Add("Text", bsPart, "DateAdded", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtModifiedDate.DataBindings.Add("Text", bsPart, "ModifiedDate", true, DataSourceUpdateMode.OnPropertyChanged, String.Empty, "d");

            this.txtSku.DataBindings.Add("Text", bsPart, "Sku", true, DataSourceUpdateMode.OnPropertyChanged);

            this.txtPartNumber.DataBindings.Add("Text", bsPart, "PartNum", true, DataSourceUpdateMode.OnPropertyChanged);

            this.cbxCardTrack.DataBindings.Add("Checked", bsPart, "CarbTrack", true, DataSourceUpdateMode.OnPropertyChanged);
            this.cbxObsolete.DataBindings.Add("Checked", bsPart, "Obsolete", true, DataSourceUpdateMode.OnPropertyChanged);

            cboManufacturer.DataSource = partService.GetManus();
            cboManufacturer.DisplayMember = "Manufacturer";
            cboManufacturer.ValueMember = "ManuID";
            cboManufacturer.DataBindings.Add("SelectedValue", bsPart, "ManuID", true, DataSourceUpdateMode.OnPropertyChanged);

            cboUnitOfMeasure.DataSource = partService.Units();
            cboUnitOfMeasure.DisplayMember = "UnitName";
            cboUnitOfMeasure.ValueMember = "UnitOfMeasureID";
            cboUnitOfMeasure.DataBindings.Add("SelectedValue", bsPart, "UID", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void PartDetailControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnPartSaved?.Invoke();
        }

        private void btnNewPart_Click(object sender, EventArgs e)
        {
            OnNewPart?.Invoke();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            OnPartDeleted?.Invoke();
        }

        private void btnAddManu_Click(object sender, EventArgs e)
        {
            ManuEditForm frm = new ManuEditForm(ctx);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cboManufacturer.DataSource = partService.GetManus();
                cboManufacturer.SelectedValue = frm.Manu.ManuID;
            }
        }
    }
}
