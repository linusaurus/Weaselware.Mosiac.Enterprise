using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class DeliveryControl : UserControl
    {
        private int pickID;
        private PickListDto activePickList = new PickListDto();
        JobListDto _selectedJobDto;
        private readonly MosaicContext _ctx;
        private StockService _stockService;
        private JobsService _jobService;
        string lastJobSearch = string.Empty;

        // BindingSource ------

        BindingSource bsPicks = new BindingSource();
        BindingSource bsPickItems = new BindingSource();

        PickListMapper mapper = new PickListMapper();

        public DeliveryControl(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;

            _stockService = new StockService(_ctx);
            _jobService = new JobsService(_ctx);
            Grids.BuildPlistGrid(dgvDeliveries);
            Grids.BuildScannedPartGrid(dgvPickListItems);
     
            lbJobList.SelectedIndexChanged += LbJobList_SelectedIndexChanged;
            bsPickItems.ListChanged += BsPickItems_ListChanged;
            bsPickItems.AddingNew += BsPickItems_AddingNew;
            if (Mosiac.UX.Properties.Settings.Default.LastJobSearched.Length > 0)
            {
                string lastJobSearch = Mosiac.UX.Properties.Settings.Default.LastJobSearched;
                txtJobSearch.Text = lastJobSearch;
                LoadJobsList();
            }
            
        }

        private void BsPickItems_AddingNew(object sender, AddingNewEventArgs e)
        {
          PickListItemDto newItem = new PickListItemDto { Qnty = 1.0m}  ;
            e.NewObject = newItem;
        }

        private void BsPickItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                tsSave.BackColor = Color.Cornsilk;
            }
        }

        private void BindListHeader(PickListDto selectedList)
        {
            
            lbPickID.Text = $"List # {selectedList.PickListID.ToString()}";
            lbJobname.Text = $"Job : {selectedList.JobName}";
            lbDateStamp.Text = $"Date : {selectedList.DateStamp.ToLongDateString()}";
            lbPreparedBy.Text = $"Prepared By : {selectedList.Preparer}";
            lbItemCount.Text = $"Items : {selectedList.ItemCount.ToString()}";
        }

       

        private void LbJobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbJobList.DataSource != null)
            {
                if (lbJobList.Items.Count > 0)
                {
                    _selectedJobDto = (JobListDto)lbJobList.SelectedItem;
                    var picks = _stockService.GetJobPicks(_selectedJobDto.JobID);
                    bsPicks.DataSource = picks;
                    //bsPickItems.DataSource = picks;
                    //bsPickItems.DataMember = "PickListItems";
                    dgvDeliveries.DataSource = bsPicks;
                    
                }
                else
                {
                    _selectedJobDto = null;
                    dgvDeliveries.DataSource = null;
                }
            }
        }

        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))
            {
                LoadJobsList();
                Mosiac.UX.Properties.Settings.Default.LastJobSearched = txtJobSearch.Text;
                Mosiac.UX.Properties.Settings.Default.Save();
                return true;
            }
            else if (keyData == Keys.Escape) //clear the textboxes, null the dg source
            {
                txtJobSearch.Text = string.Empty;
                txtJobSearch.Focus();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private async void LoadJobsList()
        {
            if (txtJobSearch.Text.Length > 0)
            {
                var listJobs = await _jobService.Search(txtJobSearch.Text);
                lbJobList.DisplayMember = "JobName";
                lbJobList.ValueMember = "JobID";
                lbJobList.DataSource = listJobs;
            }
        }
        /// <summary>
        /// Main toolbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsSave":

                    activePickList =  await  _stockService.CreateOrUpdate(activePickList);
                    bsPickItems.DataSource = activePickList.PickListItems;
                    Grids.ToogleToolStripButtonStyle(false, tsSave);
                    break;
                case "tsPrint":

                    FastReport.Report report = new FastReport.Report();
                    report.Load($"{Application.StartupPath}PLIST.frx");
                    // Setting the parameter is not taking --
                    report.SetParameterValue("ID", activePickList.PickListID);
                    report.Show();
                    break;

                default:
                    break;
            }
        }

        private void btnNewDellivery_Click(object sender, EventArgs e)
        {
            AddNewPicklist();
        }

        private async void AddNewPicklist()
        {
            if (_selectedJobDto != null)
            {
                if (_selectedJobDto.JobID != default)
                {
                    Job job = await _jobService.FindAsync(_selectedJobDto.JobID);
                    PickList newPickList = new PickList
                    {
                        JobID = _selectedJobDto.JobID,
                        EmployeeID = Mosiac.UX.Services.Globals.CurrentLoggedUserID,
                        DateStamp = DateTime.Today,
                        Job = job
                    };
                    PickListDto dto = new PickListDto();

                    _ctx.PickList.Add(newPickList);
                    await _ctx.SaveChangesAsync();
                    mapper.Map(newPickList, activePickList);

                    bsPicks.Add(activePickList);
                    int nRowIndex = dgvDeliveries.Rows.Count - 1;

                    dgvDeliveries.ClearSelection();
                    dgvDeliveries.Rows[nRowIndex].Selected = true;
                    dgvPickListItems.DataSource = activePickList.PickListItems;
                }
            }
        }

        private void dgvDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.SelectedRows.Count > 0)
                {
                   activePickList = (PickListDto)dg.CurrentRow.DataBoundItem;
                   BindListHeader(activePickList);
                   bsPickItems.DataSource = activePickList.PickListItems;
                   dgvPickListItems.DataSource = bsPickItems;
                    bsPickItems.AddNew();
                  
                }  
            }
        }
    }
}
