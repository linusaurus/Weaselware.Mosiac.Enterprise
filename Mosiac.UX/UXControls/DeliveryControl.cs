﻿using System;
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
using Mosiac.UX.Forms;

namespace Mosiac.UX.UXControls
{
    public partial class DeliveryControl : UserControl
    {
        private int pickID;
        private PickListDto activePickList; //= new PickListDto();
        private PickListDto selectedPickList;
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
            // Init the two servicess
            _stockService = new StockService(_ctx);
            _jobService = new JobsService(_ctx);

            // Constuct the two grids
            Grids.BuildPlistGrid(dgvDeliveries);
            Grids.BuildScannedPartGrid(dgvPickListItems);
     
            lbJobList.SelectedIndexChanged += LbJobList_SelectedIndexChanged;
            bsPickItems.ListChanged += BsPickItems_ListChanged;
            bsPicks.ListChanged += BsPicks_ListChanged;
            bsPickItems.AddingNew += BsPickItems_AddingNew;

            // Reload last job selected --
            if (Mosiac.UX.Properties.Settings.Default.LastJobSearched.Length > 0)
            {
                string lastJobSearch = Mosiac.UX.Properties.Settings.Default.LastJobSearched;
                txtJobSearch.Text = lastJobSearch;
                LoadJobsList();
            }
  
        }

       
        private void BsPicks_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged |
                e.ListChangedType == ListChangedType.ItemDeleted |
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                tsSave.BackColor = Color.Cornsilk;
            }
        }

        private void BsPickItems_AddingNew(object sender, AddingNewEventArgs e)
        {
          PickListItemDto newItem = new PickListItemDto 
          {
              Qnty = 1.0m,
              PartID = 0,
          } ;

          e.NewObject = newItem;
        }

        private void BsPickItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged |
                e.ListChangedType == ListChangedType.ItemDeleted | 
                e.ListChangedType== ListChangedType.ItemAdded)
            {
                tsSave.BackColor = Color.Cornsilk;
            }
        }

        private void BindListHeader(PickListDto selected)
        {

            ckbDelivered.DataBindings.Clear();
            cbkProcessed.DataBindings.Clear();
            //-----------------------------------
            lbPickID.Text = $"List # {selected.PickListID.ToString()}";
            lbJobname.Text = $"Job : {selected.JobName}";
            lbDateStamp.Text = $"Date : {selected.DateStamp.ToLongDateString()}";
            lbPreparedBy.Text = $"Prepared By : {selected.Preparer}";
            lbItemCount.Text = $"Items : {selected.ItemCount.ToString()}";
            //---------------------------------------
            ckbDelivered.DataBindings.Add("Checked",selected,"Delivered",true,DataSourceUpdateMode.OnPropertyChanged);
            cbkProcessed.DataBindings.Add("Checked",selected,"Submitted",true,DataSourceUpdateMode.OnPropertyChanged);         
        }

       

        private void LbJobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbJobList.DataSource != null)
            {
                if (lbJobList.Items.Count > 0)
                {
                    dgvPickListItems.DataSource = null;
                    _selectedJobDto = (JobListDto)lbJobList.SelectedItem;
                    var picks = _stockService.GetJobPicks(_selectedJobDto.JobID);                 
                    dgvDeliveries.DataSource = picks;                
                }
                else
                {
                    _selectedJobDto = null;
                    dgvDeliveries.DataSource = null;
                }
            }
        }
        /// <summary>
        /// Here where the money is ------
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.DataSource != null)
            {
                if (dg.SelectedRows.Count > 0)
                {
                    selectedPickList = ((PickListDto)dg.CurrentRow.DataBoundItem);
                    activePickList = _stockService.GetPicklist(selectedPickList.PickListID);
                    BindListHeader(activePickList);
                    bsPicks.DataSource = activePickList;
                    bsPickItems.DataSource = activePickList;
                    bsPickItems.DataMember = "PickListItems";
                    
                    dgvPickListItems.DataSource = bsPickItems;
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
                    
                    // this is updating the stale Picklist object
                    bsPicks.EndEdit();
                    bsPickItems.EndEdit();
                    var result = await  _stockService.CreateOrUpdate(activePickList);
                    activePickList = result;
                    bsPicks.DataSource = activePickList;
                    bsPickItems.DataSource = bsPicks;
                    bsPickItems.DataMember = "PickListItems";
                  
                    Grids.ToogleToolStripButtonStyle(false, tsSave);

                    break;
                case "tsPrint":

                    FastReport.Report report = new FastReport.Report();
                    report.Load($"{Application.StartupPath}PLIST.frx");
                    // Setting the parameter is not taking --
                    report.SetParameterValue("ID", selectedPickList.PickListID);
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

        private void cbkProcessed_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                selectedPickList.Submitted = true;

            }
            else
            {
                selectedPickList.Submitted = false;
            }
        }

        private void ckbDelivered_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                selectedPickList.Delivered = true;

            }
            else
            {
                selectedPickList.Delivered = false;
            }
        }
        /// <summary>
        /// Attach a file to the Plist --
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttach_Click(object sender, EventArgs e)
        {
            //if (activePickList != null)
            //{
            //    CreateAttachmentForm frm = new CreateAttachmentForm(orderDTO.PurchaseOrderID);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        var result = frm.NewAttachment;
            //        var att = _ctx.Attachment.Find(result.AttachmentID);
            //        AttachmentMapper mapper = new ServiceLayer.Mappers.AttachmentMapper();
            //        mapper.Map(att, result);

            //       // bsAttachements.Add(result);
            //    }



            //}
        }
        // Open the Destination Finder/Editor and return destination
        private void btnSetDestination_Click(object sender, EventArgs e)
        {
            AddDestinationForm frm = new AddDestinationForm(_ctx);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
