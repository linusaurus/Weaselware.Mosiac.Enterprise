using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using ServiceLayer.Services;
using ServiceLayer;
using ServiceLayer.Models;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class JobsControl : UserControl
    {
        private readonly MosaicContext _ctx;
        private JobsService _jobService;
        public JobsControl(MosaicContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
            _jobService = new JobsService(_ctx);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Enter) || (keyData == Keys.Return))

            {
                if (txtSearchJobs.Text.Length > 0)
                {
                    lbJobsList.DisplayMember = "Jobname";
                    lbJobsList.DataSource = _jobService.GetJobs(txtSearchJobs.Text);
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
