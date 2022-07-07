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
        private PickListDto activePickList;
        JobListDto _selectedJobDto;
        private readonly MosaicContext _ctx;
        private StockService _stockService;
        private JobsService _jobService;
        
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
     
            lbJobList.SelectedIndexChanged += LbJobList_SelectedIndexChanged;

        }

        private void LbJobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbJobList.DataSource != null)
            {
                if (lbJobList.Items.Count > 0)
                {
                    _selectedJobDto = (JobListDto)lbJobList.SelectedItem;
                    var picks = _stockService.JobPicks(_selectedJobDto.JobID);
                    bsPicks.DataSource = picks;
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
        private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
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
                    mapper.Map(newPickList, dto);

                    bsPicks.Add(dto);
                    int nRowIndex = dgvDeliveries.Rows.Count - 1;

                    dgvDeliveries.ClearSelection();
                    dgvDeliveries.Rows[nRowIndex].Selected = true;

                }
            }
        }
    }
}
