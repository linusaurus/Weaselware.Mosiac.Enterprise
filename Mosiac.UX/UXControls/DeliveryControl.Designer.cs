﻿namespace Mosiac.UX.UXControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryControl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNewDellivery = new System.Windows.Forms.Button();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.lbJobList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtJobSearch = new System.Windows.Forms.TextBox();
            this.dgvPickListItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbItemCount = new System.Windows.Forms.Label();
            this.lbPreparedBy = new System.Windows.Forms.Label();
            this.lbDateStamp = new System.Windows.Forms.Label();
            this.lbJobname = new System.Windows.Forms.Label();
            this.lbPickID = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickListItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.btnNewDellivery);
            this.splitContainer1.Panel1.Controls.Add(this.dgvDeliveries);
            this.splitContainer1.Panel1.Controls.Add(this.lbJobList);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtJobSearch);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPickListItems);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.tsMain);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 726);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNewDellivery
            // 
            this.btnNewDellivery.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewDellivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDellivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewDellivery.Image = global::Mosiac.UX.Properties.Resources.baseline_get_app_black_24dp;
            this.btnNewDellivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDellivery.Location = new System.Drawing.Point(3, 213);
            this.btnNewDellivery.Name = "btnNewDellivery";
            this.btnNewDellivery.Size = new System.Drawing.Size(313, 30);
            this.btnNewDellivery.TabIndex = 0;
            this.btnNewDellivery.Text = "New Delivery Packing List";
            this.btnNewDellivery.UseVisualStyleBackColor = false;
            this.btnNewDellivery.Click += new System.EventHandler(this.btnNewDellivery_Click);
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Location = new System.Drawing.Point(9, 252);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.RowTemplate.Height = 25;
            this.dgvDeliveries.Size = new System.Drawing.Size(307, 462);
            this.dgvDeliveries.TabIndex = 4;
            this.dgvDeliveries.SelectionChanged += new System.EventHandler(this.dgvDeliveries_SelectionChanged);
            // 
            // lbJobList
            // 
            this.lbJobList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJobList.FormattingEnabled = true;
            this.lbJobList.ItemHeight = 15;
            this.lbJobList.Location = new System.Drawing.Point(9, 38);
            this.lbJobList.Name = "lbJobList";
            this.lbJobList.Size = new System.Drawing.Size(307, 169);
            this.lbJobList.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtJobSearch
            // 
            this.txtJobSearch.Location = new System.Drawing.Point(9, 9);
            this.txtJobSearch.Name = "txtJobSearch";
            this.txtJobSearch.Size = new System.Drawing.Size(184, 23);
            this.txtJobSearch.TabIndex = 0;
            // 
            // dgvPickListItems
            // 
            this.dgvPickListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPickListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPickListItems.Location = new System.Drawing.Point(13, 161);
            this.dgvPickListItems.Name = "dgvPickListItems";
            this.dgvPickListItems.RowTemplate.Height = 25;
            this.dgvPickListItems.Size = new System.Drawing.Size(831, 553);
            this.dgvPickListItems.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbItemCount);
            this.panel1.Controls.Add(this.lbPreparedBy);
            this.panel1.Controls.Add(this.lbDateStamp);
            this.panel1.Controls.Add(this.lbJobname);
            this.panel1.Controls.Add(this.lbPickID);
            this.panel1.Location = new System.Drawing.Point(13, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 117);
            this.panel1.TabIndex = 0;
            // 
            // lbItemCount
            // 
            this.lbItemCount.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbItemCount.ForeColor = System.Drawing.Color.White;
            this.lbItemCount.Location = new System.Drawing.Point(17, 41);
            this.lbItemCount.Margin = new System.Windows.Forms.Padding(2);
            this.lbItemCount.Name = "lbItemCount";
            this.lbItemCount.Size = new System.Drawing.Size(144, 27);
            this.lbItemCount.TabIndex = 1;
            this.lbItemCount.Text = "label1";
            this.lbItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPreparedBy
            // 
            this.lbPreparedBy.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbPreparedBy.ForeColor = System.Drawing.Color.White;
            this.lbPreparedBy.Location = new System.Drawing.Point(602, 41);
            this.lbPreparedBy.Margin = new System.Windows.Forms.Padding(2);
            this.lbPreparedBy.Name = "lbPreparedBy";
            this.lbPreparedBy.Size = new System.Drawing.Size(211, 27);
            this.lbPreparedBy.TabIndex = 1;
            this.lbPreparedBy.Text = "label1";
            this.lbPreparedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateStamp
            // 
            this.lbDateStamp.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbDateStamp.ForeColor = System.Drawing.Color.White;
            this.lbDateStamp.Location = new System.Drawing.Point(602, 10);
            this.lbDateStamp.Margin = new System.Windows.Forms.Padding(2);
            this.lbDateStamp.Name = "lbDateStamp";
            this.lbDateStamp.Size = new System.Drawing.Size(211, 27);
            this.lbDateStamp.TabIndex = 1;
            this.lbDateStamp.Text = "label1";
            this.lbDateStamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJobname
            // 
            this.lbJobname.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbJobname.ForeColor = System.Drawing.Color.White;
            this.lbJobname.Location = new System.Drawing.Point(165, 10);
            this.lbJobname.Margin = new System.Windows.Forms.Padding(2);
            this.lbJobname.Name = "lbJobname";
            this.lbJobname.Size = new System.Drawing.Size(433, 27);
            this.lbJobname.TabIndex = 1;
            this.lbJobname.Text = "List ID";
            this.lbJobname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPickID
            // 
            this.lbPickID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbPickID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPickID.ForeColor = System.Drawing.Color.White;
            this.lbPickID.Location = new System.Drawing.Point(17, 10);
            this.lbPickID.Margin = new System.Windows.Forms.Padding(2);
            this.lbPickID.Name = "lbPickID";
            this.lbPickID.Size = new System.Drawing.Size(144, 27);
            this.lbPickID.TabIndex = 1;
            this.lbPickID.Text = "List ID";
            this.lbPickID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSave,
            this.toolStripSeparator1,
            this.tsPrint});
            this.tsMain.Location = new System.Drawing.Point(10, 10);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(837, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            this.tsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMain_ItemClicked);
            // 
            // tsSave
            // 
            this.tsSave.BackColor = System.Drawing.SystemColors.Control;
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(84, 22);
            this.tsSave.Text = "Save Changes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsPrint
            // 
            this.tsPrint.BackColor = System.Drawing.SystemColors.Control;
            this.tsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsPrint.Image")));
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(54, 22);
            this.tsPrint.Text = "Print      ";
            // 
            // DeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Name = "DeliveryControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1206, 746);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickListItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

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
    }
}