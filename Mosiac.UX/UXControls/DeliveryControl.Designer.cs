namespace Mosiac.UX.UXControls
{
    partial class DeliveryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabControl tbDeliversControl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryControl));
            tbJobPicks = new System.Windows.Forms.TabPage();
            dgvDeliveries = new System.Windows.Forms.DataGridView();
            tbMyDeliveries = new System.Windows.Forms.TabPage();
            dgvMyDelieveries = new System.Windows.Forms.DataGridView();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            btnNewDellivery = new System.Windows.Forms.Button();
            lbJobList = new System.Windows.Forms.ListBox();
            btnSearch = new System.Windows.Forms.Button();
            txtJobSearch = new System.Windows.Forms.TextBox();
            dgvPickListItems = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            lbZip = new System.Windows.Forms.Label();
            lbState = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbAddress = new System.Windows.Forms.Label();
            lbAttention = new System.Windows.Forms.Label();
            lbDestinationName = new System.Windows.Forms.Label();
            btnSetDestination = new System.Windows.Forms.Button();
            btnViewReceipt = new System.Windows.Forms.Button();
            btnAttach = new System.Windows.Forms.Button();
            ckbDelivered = new System.Windows.Forms.CheckBox();
            cbkProcessed = new System.Windows.Forms.CheckBox();
            lbItemCount = new System.Windows.Forms.Label();
            lbPreparedBy = new System.Windows.Forms.Label();
            lbDateStamp = new System.Windows.Forms.Label();
            lbJobname = new System.Windows.Forms.Label();
            lbPickID = new System.Windows.Forms.Label();
            tsMain = new System.Windows.Forms.ToolStrip();
            tsSave = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsPrint = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsPrintLabels = new System.Windows.Forms.ToolStripButton();
            tbDeliversControl = new System.Windows.Forms.TabControl();
            tbDeliversControl.SuspendLayout();
            tbJobPicks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).BeginInit();
            tbMyDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyDelieveries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPickListItems).BeginInit();
            panel1.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tbDeliversControl
            // 
            tbDeliversControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbDeliversControl.Controls.Add(tbJobPicks);
            tbDeliversControl.Controls.Add(tbMyDeliveries);
            tbDeliversControl.Location = new System.Drawing.Point(6, 255);
            tbDeliversControl.Name = "tbDeliversControl";
            tbDeliversControl.SelectedIndex = 0;
            tbDeliversControl.Size = new System.Drawing.Size(313, 468);
            tbDeliversControl.TabIndex = 5;
            // 
            // tbJobPicks
            // 
            tbJobPicks.Controls.Add(dgvDeliveries);
            tbJobPicks.Location = new System.Drawing.Point(4, 24);
            tbJobPicks.Name = "tbJobPicks";
            tbJobPicks.Padding = new System.Windows.Forms.Padding(3);
            tbJobPicks.Size = new System.Drawing.Size(305, 440);
            tbJobPicks.TabIndex = 0;
            tbJobPicks.Text = "Job Deliveries";
            tbJobPicks.UseVisualStyleBackColor = true;
            // 
            // dgvDeliveries
            // 
            dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDeliveries.Location = new System.Drawing.Point(3, 3);
            dgvDeliveries.Name = "dgvDeliveries";
            dgvDeliveries.RowTemplate.Height = 25;
            dgvDeliveries.Size = new System.Drawing.Size(299, 434);
            dgvDeliveries.TabIndex = 4;
            dgvDeliveries.SelectionChanged += dgvDeliveries_SelectionChanged;
            // 
            // tbMyDeliveries
            // 
            tbMyDeliveries.Controls.Add(dgvMyDelieveries);
            tbMyDeliveries.Location = new System.Drawing.Point(4, 24);
            tbMyDeliveries.Name = "tbMyDeliveries";
            tbMyDeliveries.Padding = new System.Windows.Forms.Padding(3);
            tbMyDeliveries.Size = new System.Drawing.Size(305, 440);
            tbMyDeliveries.TabIndex = 1;
            tbMyDeliveries.Text = "My Deliveries";
            tbMyDeliveries.UseVisualStyleBackColor = true;
            // 
            // dgvMyDelieveries
            // 
            dgvMyDelieveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyDelieveries.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMyDelieveries.Location = new System.Drawing.Point(3, 3);
            dgvMyDelieveries.Name = "dgvMyDelieveries";
            dgvMyDelieveries.RowTemplate.Height = 25;
            dgvMyDelieveries.Size = new System.Drawing.Size(299, 434);
            dgvMyDelieveries.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(10, 10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(tbDeliversControl);
            splitContainer1.Panel1.Controls.Add(btnNewDellivery);
            splitContainer1.Panel1.Controls.Add(lbJobList);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(txtJobSearch);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvPickListItems);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(tsMain);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            splitContainer1.Size = new System.Drawing.Size(1178, 729);
            splitContainer1.SplitterDistance = 325;
            splitContainer1.TabIndex = 0;
            // 
            // btnNewDellivery
            // 
            btnNewDellivery.BackColor = System.Drawing.SystemColors.Highlight;
            btnNewDellivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewDellivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnNewDellivery.Image = Properties.Resources.baseline_get_app_black_24dp;
            btnNewDellivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNewDellivery.Location = new System.Drawing.Point(3, 213);
            btnNewDellivery.Name = "btnNewDellivery";
            btnNewDellivery.Size = new System.Drawing.Size(313, 30);
            btnNewDellivery.TabIndex = 0;
            btnNewDellivery.TabStop = false;
            btnNewDellivery.Text = "New Delivery Packing List";
            btnNewDellivery.UseVisualStyleBackColor = false;
            btnNewDellivery.Click += btnNewDellivery_Click;
            // 
            // lbJobList
            // 
            lbJobList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbJobList.FormattingEnabled = true;
            lbJobList.ItemHeight = 15;
            lbJobList.Location = new System.Drawing.Point(9, 38);
            lbJobList.Name = "lbJobList";
            lbJobList.Size = new System.Drawing.Size(307, 169);
            lbJobList.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(199, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(113, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtJobSearch
            // 
            txtJobSearch.Location = new System.Drawing.Point(9, 9);
            txtJobSearch.Name = "txtJobSearch";
            txtJobSearch.Size = new System.Drawing.Size(184, 23);
            txtJobSearch.TabIndex = 0;
            // 
            // dgvPickListItems
            // 
            dgvPickListItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvPickListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPickListItems.Location = new System.Drawing.Point(13, 213);
            dgvPickListItems.Name = "dgvPickListItems";
            dgvPickListItems.RowTemplate.Height = 25;
            dgvPickListItems.Size = new System.Drawing.Size(823, 504);
            dgvPickListItems.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(lbZip);
            panel1.Controls.Add(lbState);
            panel1.Controls.Add(lbCity);
            panel1.Controls.Add(lbAddress);
            panel1.Controls.Add(lbAttention);
            panel1.Controls.Add(lbDestinationName);
            panel1.Controls.Add(btnSetDestination);
            panel1.Controls.Add(btnViewReceipt);
            panel1.Controls.Add(btnAttach);
            panel1.Controls.Add(ckbDelivered);
            panel1.Controls.Add(cbkProcessed);
            panel1.Controls.Add(lbItemCount);
            panel1.Controls.Add(lbPreparedBy);
            panel1.Controls.Add(lbDateStamp);
            panel1.Controls.Add(lbJobname);
            panel1.Controls.Add(lbPickID);
            panel1.Location = new System.Drawing.Point(13, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(823, 169);
            panel1.TabIndex = 0;
            // 
            // lbZip
            // 
            lbZip.BackColor = System.Drawing.SystemColors.ControlLight;
            lbZip.Location = new System.Drawing.Point(334, 134);
            lbZip.Margin = new System.Windows.Forms.Padding(2);
            lbZip.Name = "lbZip";
            lbZip.Padding = new System.Windows.Forms.Padding(1);
            lbZip.Size = new System.Drawing.Size(79, 22);
            lbZip.TabIndex = 4;
            lbZip.Text = "Zip";
            lbZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbState
            // 
            lbState.BackColor = System.Drawing.SystemColors.ControlLight;
            lbState.Location = new System.Drawing.Point(304, 134);
            lbState.Margin = new System.Windows.Forms.Padding(2);
            lbState.Name = "lbState";
            lbState.Padding = new System.Windows.Forms.Padding(1);
            lbState.Size = new System.Drawing.Size(26, 22);
            lbState.TabIndex = 4;
            lbState.Text = "ST";
            lbState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCity
            // 
            lbCity.BackColor = System.Drawing.SystemColors.ControlLight;
            lbCity.Location = new System.Drawing.Point(146, 134);
            lbCity.Margin = new System.Windows.Forms.Padding(2);
            lbCity.Name = "lbCity";
            lbCity.Padding = new System.Windows.Forms.Padding(1);
            lbCity.Size = new System.Drawing.Size(153, 22);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            lbCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAddress
            // 
            lbAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            lbAddress.Location = new System.Drawing.Point(146, 108);
            lbAddress.Margin = new System.Windows.Forms.Padding(2);
            lbAddress.Name = "lbAddress";
            lbAddress.Padding = new System.Windows.Forms.Padding(1);
            lbAddress.Size = new System.Drawing.Size(267, 22);
            lbAddress.TabIndex = 4;
            lbAddress.Text = "Address";
            lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAttention
            // 
            lbAttention.BackColor = System.Drawing.SystemColors.ControlLight;
            lbAttention.Location = new System.Drawing.Point(417, 78);
            lbAttention.Margin = new System.Windows.Forms.Padding(2);
            lbAttention.Name = "lbAttention";
            lbAttention.Padding = new System.Windows.Forms.Padding(1);
            lbAttention.Size = new System.Drawing.Size(214, 26);
            lbAttention.TabIndex = 4;
            lbAttention.Text = "Attention";
            lbAttention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDestinationName
            // 
            lbDestinationName.BackColor = System.Drawing.SystemColors.ControlLight;
            lbDestinationName.Location = new System.Drawing.Point(146, 78);
            lbDestinationName.Margin = new System.Windows.Forms.Padding(2);
            lbDestinationName.Name = "lbDestinationName";
            lbDestinationName.Padding = new System.Windows.Forms.Padding(1);
            lbDestinationName.Size = new System.Drawing.Size(267, 26);
            lbDestinationName.TabIndex = 4;
            lbDestinationName.Text = "Destination Name";
            lbDestinationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetDestination
            // 
            btnSetDestination.BackColor = System.Drawing.SystemColors.ControlLight;
            btnSetDestination.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btnSetDestination.FlatAppearance.BorderSize = 2;
            btnSetDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetDestination.Location = new System.Drawing.Point(17, 79);
            btnSetDestination.Name = "btnSetDestination";
            btnSetDestination.Size = new System.Drawing.Size(111, 37);
            btnSetDestination.TabIndex = 3;
            btnSetDestination.Text = "Set Destination";
            btnSetDestination.UseVisualStyleBackColor = false;
            btnSetDestination.Click += btnSetDestination_Click;
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.Location = new System.Drawing.Point(700, 108);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new System.Drawing.Size(110, 24);
            btnViewReceipt.TabIndex = 3;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = true;
            // 
            // btnAttach
            // 
            btnAttach.Enabled = false;
            btnAttach.Location = new System.Drawing.Point(700, 78);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new System.Drawing.Size(110, 24);
            btnAttach.TabIndex = 3;
            btnAttach.Text = "Attach Receipt";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // ckbDelivered
            // 
            ckbDelivered.BackColor = System.Drawing.SystemColors.Highlight;
            ckbDelivered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            ckbDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ckbDelivered.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ckbDelivered.Location = new System.Drawing.Point(636, 10);
            ckbDelivered.Name = "ckbDelivered";
            ckbDelivered.Padding = new System.Windows.Forms.Padding(4, 4, 10, 4);
            ckbDelivered.Size = new System.Drawing.Size(174, 27);
            ckbDelivered.TabIndex = 2;
            ckbDelivered.Text = "Delivery Complete";
            ckbDelivered.UseVisualStyleBackColor = false;
            ckbDelivered.CheckedChanged += ckbDelivered_CheckedChanged;
            // 
            // cbkProcessed
            // 
            cbkProcessed.BackColor = System.Drawing.SystemColors.Highlight;
            cbkProcessed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cbkProcessed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbkProcessed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cbkProcessed.Location = new System.Drawing.Point(636, 41);
            cbkProcessed.Name = "cbkProcessed";
            cbkProcessed.Padding = new System.Windows.Forms.Padding(4, 4, 10, 4);
            cbkProcessed.Size = new System.Drawing.Size(174, 27);
            cbkProcessed.TabIndex = 2;
            cbkProcessed.Text = "Processed to Inventory";
            cbkProcessed.UseVisualStyleBackColor = false;
            cbkProcessed.CheckedChanged += cbkProcessed_CheckedChanged;
            // 
            // lbItemCount
            // 
            lbItemCount.BackColor = System.Drawing.SystemColors.Highlight;
            lbItemCount.ForeColor = System.Drawing.Color.White;
            lbItemCount.Location = new System.Drawing.Point(420, 41);
            lbItemCount.Margin = new System.Windows.Forms.Padding(2);
            lbItemCount.Name = "lbItemCount";
            lbItemCount.Size = new System.Drawing.Size(211, 27);
            lbItemCount.TabIndex = 1;
            lbItemCount.Text = "Item-Count";
            lbItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPreparedBy
            // 
            lbPreparedBy.BackColor = System.Drawing.SystemColors.Highlight;
            lbPreparedBy.ForeColor = System.Drawing.Color.White;
            lbPreparedBy.Location = new System.Drawing.Point(205, 10);
            lbPreparedBy.Margin = new System.Windows.Forms.Padding(2);
            lbPreparedBy.Name = "lbPreparedBy";
            lbPreparedBy.Size = new System.Drawing.Size(211, 27);
            lbPreparedBy.TabIndex = 1;
            lbPreparedBy.Text = "Prepared by";
            lbPreparedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateStamp
            // 
            lbDateStamp.BackColor = System.Drawing.SystemColors.Highlight;
            lbDateStamp.ForeColor = System.Drawing.Color.White;
            lbDateStamp.Location = new System.Drawing.Point(420, 10);
            lbDateStamp.Margin = new System.Windows.Forms.Padding(2);
            lbDateStamp.Name = "lbDateStamp";
            lbDateStamp.Size = new System.Drawing.Size(211, 27);
            lbDateStamp.TabIndex = 1;
            lbDateStamp.Text = "Date-Stamp";
            lbDateStamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJobname
            // 
            lbJobname.BackColor = System.Drawing.SystemColors.Highlight;
            lbJobname.ForeColor = System.Drawing.Color.White;
            lbJobname.Location = new System.Drawing.Point(17, 41);
            lbJobname.Margin = new System.Windows.Forms.Padding(2);
            lbJobname.Name = "lbJobname";
            lbJobname.Size = new System.Drawing.Size(399, 27);
            lbJobname.TabIndex = 1;
            lbJobname.Text = "Jobname";
            lbJobname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPickID
            // 
            lbPickID.BackColor = System.Drawing.SystemColors.Highlight;
            lbPickID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbPickID.ForeColor = System.Drawing.Color.White;
            lbPickID.Location = new System.Drawing.Point(17, 10);
            lbPickID.Margin = new System.Windows.Forms.Padding(2);
            lbPickID.Name = "lbPickID";
            lbPickID.Size = new System.Drawing.Size(184, 27);
            lbPickID.TabIndex = 1;
            lbPickID.Text = "List ID";
            lbPickID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsMain
            // 
            tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsSave, toolStripSeparator1, tsPrint, toolStripSeparator2, tsPrintLabels });
            tsMain.Location = new System.Drawing.Point(10, 10);
            tsMain.Name = "tsMain";
            tsMain.Size = new System.Drawing.Size(829, 25);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            tsMain.ItemClicked += tsMain_ItemClicked;
            // 
            // tsSave
            // 
            tsSave.BackColor = System.Drawing.SystemColors.Control;
            tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tsSave.Image = (System.Drawing.Image)resources.GetObject("tsSave.Image");
            tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSave.Name = "tsSave";
            tsSave.Size = new System.Drawing.Size(84, 22);
            tsSave.Text = "Save Changes";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsPrint
            // 
            tsPrint.BackColor = System.Drawing.SystemColors.Control;
            tsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tsPrint.Image = (System.Drawing.Image)resources.GetObject("tsPrint.Image");
            tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsPrint.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            tsPrint.Name = "tsPrint";
            tsPrint.Size = new System.Drawing.Size(51, 22);
            tsPrint.Text = "Print     ";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsPrintLabels
            // 
            tsPrintLabels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsPrintLabels.Image = (System.Drawing.Image)resources.GetObject("tsPrintLabels.Image");
            tsPrintLabels.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsPrintLabels.Name = "tsPrintLabels";
            tsPrintLabels.Size = new System.Drawing.Size(67, 22);
            tsPrintLabels.Text = "Print Label";
            tsPrintLabels.ToolTipText = "Print Labels";
            tsPrintLabels.Click += tsPrintLabels_Click;
            // 
            // DeliveryControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(splitContainer1);
            Name = "DeliveryControl";
            Padding = new System.Windows.Forms.Padding(10);
            Size = new System.Drawing.Size(1198, 749);
            tbDeliversControl.ResumeLayout(false);
            tbJobPicks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).EndInit();
            tbMyDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyDelieveries).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPickListItems).EndInit();
            panel1.ResumeLayout(false);
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbJobList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtJobSearch;
        private System.Windows.Forms.Button btnNewDellivery;
        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.DataGridView dgvPickListItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.Label lbPickID;
        private System.Windows.Forms.Label lbPreparedBy;
        private System.Windows.Forms.Label lbDateStamp;
        private System.Windows.Forms.Label lbJobname;
        private System.Windows.Forms.Label lbItemCount;
        private System.Windows.Forms.CheckBox cbkProcessed;
        private System.Windows.Forms.CheckBox ckbDelivered;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnViewReceipt;
        private System.Windows.Forms.Label lbZip;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDestinationName;
        private System.Windows.Forms.Button btnSetDestination;
        private System.Windows.Forms.Label lbAttention;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsPrintLabels;
        private System.Windows.Forms.TabPage tbJobPicks;
        private System.Windows.Forms.TabPage tbMyDeliveries;
        private System.Windows.Forms.DataGridView dgvMyDelieveries;
    }
}
