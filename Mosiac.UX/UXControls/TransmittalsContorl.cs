using DataLayer.Data;
using ServiceLayer;
using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class TransmittalsContorl : UserControl
    {
        readonly MosaicContext _ctx;
        JobsService jobsService;
        JobListDto selectedjobListDto;
        public TransmittalsContorl(MosaicContext ctx)
        {
            jobsService = new JobsService(ctx);

            InitializeComponent();
            lbJobsList.DataSource = jobsService.Recent().ToList();
            lbJobsList.DisplayMember = "JobName";
            // Events Wiring ----------------------------------
            lbJobsList.MouseDoubleClick += LbJobsList_MouseDoubleClick;
        }

        private void LbJobsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          Transmittal trns = new Transmittal();
          trns.Controls.Add(new Label { Text=selectedjobListDto.JobName});
          splitContainer1.Panel2.Controls.Add(trns);
        }

        private void lbJobsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedjobListDto = (JobListDto)lbJobsList.SelectedItem ;
        }
    }
}
