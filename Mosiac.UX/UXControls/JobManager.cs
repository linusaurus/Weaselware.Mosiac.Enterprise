using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;
using System.Windows.Forms;
using System.Linq;

namespace Mosiac.UX.UXControls
{
    public partial class JobManager : UserControl
    {
        private readonly MosaicContext _ctx;
        private JobsService  _jobService;
        private List<JobListDto> jobsList;

        Job _selectedJob;

        //Default Constructor --
        public JobManager()
        {
            InitializeComponent();
        }

        public JobManager(MosaicContext context)
        {
            InitializeComponent();
            _ctx = context;
            _jobService = new JobsService(_ctx);

            cboJobs.DataSource = _jobService.Recent();
            cboJobs.DisplayMember = "JobName";
            cboJobs.ValueMember = "JobID";
           // Grids.
        }

        private void cboJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            if (cbx.DataSource != null)
            {
                if (cbx.Items.Count > 0)
                {
                    _selectedJob = _jobService.Find((int)cbx.SelectedValue);
                    dgJobOrders.DataSource = _selectedJob.PurchaseOrders.ToList();
                }
            }
        }

        private void BindJobDetails()
        {

        }
    }
}
