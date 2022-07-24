namespace Mosiac.UX.UXControls
{
    partial class JobsControl
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
            this.spctnJobsManager = new System.Windows.Forms.SplitContainer();
            this.lbJobsList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtSearchJobs = new System.Windows.Forms.TextBox();
            this.txtJobOrderTotals = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.tabJobItems = new System.Windows.Forms.TabControl();
            this.tabJobOrders = new System.Windows.Forms.TabPage();
            this.dgvJobOrders = new System.Windows.Forms.DataGridView();
            this.tabJobOrderItems = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.spctnJobsManager)).BeginInit();
            this.spctnJobsManager.Panel1.SuspendLayout();
            this.spctnJobsManager.Panel2.SuspendLayout();
            this.spctnJobsManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabJobItems.SuspendLayout();
            this.tabJobOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // spctnJobsManager
            // 
            this.spctnJobsManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spctnJobsManager.Location = new System.Drawing.Point(6, 6);
            this.spctnJobsManager.Name = "spctnJobsManager";
            // 
            // spctnJobsManager.Panel1
            // 
            this.spctnJobsManager.Panel1.Controls.Add(this.lbJobsList);
            this.spctnJobsManager.Panel1.Controls.Add(this.panel1);
            this.spctnJobsManager.Panel1.Padding = new System.Windows.Forms.Padding(12);
            // 
            // spctnJobsManager.Panel2
            // 
            this.spctnJobsManager.Panel2.Controls.Add(this.txtJobOrderTotals);
            this.spctnJobsManager.Panel2.Controls.Add(this.btnNewOrder);
            this.spctnJobsManager.Panel2.Controls.Add(this.tabJobItems);
            this.spctnJobsManager.Panel2.Padding = new System.Windows.Forms.Padding(12, 60, 12, 9);
            this.spctnJobsManager.Size = new System.Drawing.Size(1097, 746);
            this.spctnJobsManager.SplitterDistance = 365;
            this.spctnJobsManager.TabIndex = 1;
            // 
            // lbJobsList
            // 
            this.lbJobsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbJobsList.FormattingEnabled = true;
            this.lbJobsList.ItemHeight = 15;
            this.lbJobsList.Location = new System.Drawing.Point(12, 87);
            this.lbJobsList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lbJobsList.Name = "lbJobsList";
            this.lbJobsList.Size = new System.Drawing.Size(341, 647);
            this.lbJobsList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.txtSearchJobs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(251, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(87, 24);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtSearchJobs
            // 
            this.txtSearchJobs.Location = new System.Drawing.Point(0, 13);
            this.txtSearchJobs.Name = "txtSearchJobs";
            this.txtSearchJobs.Size = new System.Drawing.Size(245, 23);
            this.txtSearchJobs.TabIndex = 0;
            // 
            // txtJobOrderTotals
            // 
            this.txtJobOrderTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobOrderTotals.Location = new System.Drawing.Point(598, 26);
            this.txtJobOrderTotals.Name = "txtJobOrderTotals";
            this.txtJobOrderTotals.Size = new System.Drawing.Size(111, 23);
            this.txtJobOrderTotals.TabIndex = 2;
            this.txtJobOrderTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(12, 24);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(107, 23);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "New Job Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // tabJobItems
            // 
            this.tabJobItems.Controls.Add(this.tabJobOrders);
            this.tabJobItems.Controls.Add(this.tabJobOrderItems);
            this.tabJobItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabJobItems.Location = new System.Drawing.Point(12, 60);
            this.tabJobItems.Name = "tabJobItems";
            this.tabJobItems.SelectedIndex = 0;
            this.tabJobItems.Size = new System.Drawing.Size(704, 677);
            this.tabJobItems.TabIndex = 0;
            // 
            // tabJobOrders
            // 
            this.tabJobOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabJobOrders.Controls.Add(this.dgvJobOrders);
            this.tabJobOrders.Location = new System.Drawing.Point(4, 24);
            this.tabJobOrders.Name = "tabJobOrders";
            this.tabJobOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobOrders.Size = new System.Drawing.Size(696, 649);
            this.tabJobOrders.TabIndex = 0;
            this.tabJobOrders.Text = "Job Orders";
            // 
            // dgvJobOrders
            // 
            this.dgvJobOrders.AllowUserToAddRows = false;
            this.dgvJobOrders.AllowUserToDeleteRows = false;
            this.dgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJobOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvJobOrders.Name = "dgvJobOrders";
            this.dgvJobOrders.ReadOnly = true;
            this.dgvJobOrders.RowTemplate.Height = 25;
            this.dgvJobOrders.Size = new System.Drawing.Size(690, 643);
            this.dgvJobOrders.TabIndex = 0;
            // 
            // tabJobOrderItems
            // 
            this.tabJobOrderItems.Location = new System.Drawing.Point(4, 24);
            this.tabJobOrderItems.Name = "tabJobOrderItems";
            this.tabJobOrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobOrderItems.Size = new System.Drawing.Size(696, 649);
            this.tabJobOrderItems.TabIndex = 1;
            this.tabJobOrderItems.Text = "tabPage2";
            this.tabJobOrderItems.UseVisualStyleBackColor = true;
            // 
            // JobsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spctnJobsManager);
            this.Name = "JobsControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1109, 758);
            this.spctnJobsManager.Panel1.ResumeLayout(false);
            this.spctnJobsManager.Panel2.ResumeLayout(false);
            this.spctnJobsManager.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spctnJobsManager)).EndInit();
            this.spctnJobsManager.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabJobItems.ResumeLayout(false);
            this.tabJobOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spctnJobsManager;
        private System.Windows.Forms.TabControl tabJobItems;
        private System.Windows.Forms.TabPage tabJobOrders;
        private System.Windows.Forms.TabPage tabJobOrderItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchJobs;
        private System.Windows.Forms.ListBox lbJobsList;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.DataGridView dgvJobOrders;
        private System.Windows.Forms.TextBox txtJobOrderTotals;
    }
}
