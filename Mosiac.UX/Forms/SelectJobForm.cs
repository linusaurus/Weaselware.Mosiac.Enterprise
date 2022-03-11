using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.Entity;
using ServiceLayer;
using ServiceLayer.Models;

namespace Mosiac.UX.Forms
{
    public partial class SelectJobForm : Form
    {
        private readonly MosaicContext _ctx;
        private JobsService jobService;
        private Job _selectedJob;

        public Job SelectedJob { get => _selectedJob; set => _selectedJob = value; }

        public SelectJobForm(MosaicContext context)
        {
            InitializeComponent();
            _ctx = context;
            jobService = new JobsService(_ctx);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            lbJobsList.DataSource = jobService.GetJobs(tb.Text);
            lbJobsList.DisplayMember = "JobName";
            lbJobsList.ValueMember = "JobID";
        }

        private void lbJobsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lbJobsList.DataSource != null)
            {
                _selectedJob = (Job)lb.SelectedItem;
            }
        }
    }
}
