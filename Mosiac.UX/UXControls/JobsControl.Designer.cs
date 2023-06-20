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
            spctnJobsManager = new System.Windows.Forms.SplitContainer();
            lbJobsList = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            btnShowAll = new System.Windows.Forms.Button();
            txtSearchJobs = new System.Windows.Forms.TextBox();
            txtJobOrderTotals = new System.Windows.Forms.TextBox();
            btnNewOrder = new System.Windows.Forms.Button();
            tabJobDelivery = new System.Windows.Forms.TabControl();
            tabJobOrders = new System.Windows.Forms.TabPage();
            dgvJobOrders = new System.Windows.Forms.DataGridView();
            tabDeliveries = new System.Windows.Forms.TabPage();
            dgvJobDeliveries = new System.Windows.Forms.DataGridView();
            tabJobItems = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)spctnJobsManager).BeginInit();
            spctnJobsManager.Panel1.SuspendLayout();
            spctnJobsManager.Panel2.SuspendLayout();
            spctnJobsManager.SuspendLayout();
            panel1.SuspendLayout();
            tabJobDelivery.SuspendLayout();
            tabJobOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobOrders).BeginInit();
            tabDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobDeliveries).BeginInit();
            SuspendLayout();
            // 
            // spctnJobsManager
            // 
            spctnJobsManager.Dock = System.Windows.Forms.DockStyle.Fill;
            spctnJobsManager.Location = new System.Drawing.Point(6, 6);
            spctnJobsManager.Name = "spctnJobsManager";
            // 
            // spctnJobsManager.Panel1
            // 
            spctnJobsManager.Panel1.Controls.Add(lbJobsList);
            spctnJobsManager.Panel1.Controls.Add(panel1);
            spctnJobsManager.Panel1.Padding = new System.Windows.Forms.Padding(12);
            // 
            // spctnJobsManager.Panel2
            // 
            spctnJobsManager.Panel2.Controls.Add(txtJobOrderTotals);
            spctnJobsManager.Panel2.Controls.Add(btnNewOrder);
            spctnJobsManager.Panel2.Controls.Add(tabJobDelivery);
            spctnJobsManager.Panel2.Padding = new System.Windows.Forms.Padding(12, 60, 12, 9);
            spctnJobsManager.Size = new System.Drawing.Size(1185, 615);
            spctnJobsManager.SplitterDistance = 394;
            spctnJobsManager.TabIndex = 1;
            // 
            // lbJobsList
            // 
            lbJobsList.Dock = System.Windows.Forms.DockStyle.Fill;
            lbJobsList.FormattingEnabled = true;
            lbJobsList.ItemHeight = 15;
            lbJobsList.Location = new System.Drawing.Point(12, 87);
            lbJobsList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            lbJobsList.Name = "lbJobsList";
            lbJobsList.Size = new System.Drawing.Size(370, 516);
            lbJobsList.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowAll);
            panel1.Controls.Add(txtSearchJobs);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(370, 75);
            panel1.TabIndex = 0;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new System.Drawing.Point(264, 12);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(87, 24);
            btnShowAll.TabIndex = 1;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtSearchJobs
            // 
            txtSearchJobs.Location = new System.Drawing.Point(11, 13);
            txtSearchJobs.Name = "txtSearchJobs";
            txtSearchJobs.Size = new System.Drawing.Size(245, 23);
            txtSearchJobs.TabIndex = 0;
            // 
            // txtJobOrderTotals
            // 
            txtJobOrderTotals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtJobOrderTotals.Location = new System.Drawing.Point(657, 26);
            txtJobOrderTotals.Name = "txtJobOrderTotals";
            txtJobOrderTotals.Size = new System.Drawing.Size(111, 23);
            txtJobOrderTotals.TabIndex = 2;
            txtJobOrderTotals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new System.Drawing.Point(12, 24);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new System.Drawing.Size(107, 23);
            btnNewOrder.TabIndex = 1;
            btnNewOrder.Text = "New Job Order";
            btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // tabJobDelivery
            // 
            tabJobDelivery.Controls.Add(tabJobOrders);
            tabJobDelivery.Controls.Add(tabDeliveries);
            tabJobDelivery.Controls.Add(tabJobItems);
            tabJobDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            tabJobDelivery.Location = new System.Drawing.Point(12, 60);
            tabJobDelivery.Name = "tabJobDelivery";
            tabJobDelivery.SelectedIndex = 0;
            tabJobDelivery.Size = new System.Drawing.Size(763, 546);
            tabJobDelivery.TabIndex = 0;
            tabJobDelivery.SelectedIndexChanged += tabJobDelivery_SelectedIndexChanged;
            // 
            // tabJobOrders
            // 
            tabJobOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            tabJobOrders.Controls.Add(dgvJobOrders);
            tabJobOrders.Location = new System.Drawing.Point(4, 24);
            tabJobOrders.Name = "tabJobOrders";
            tabJobOrders.Padding = new System.Windows.Forms.Padding(3);
            tabJobOrders.Size = new System.Drawing.Size(755, 518);
            tabJobOrders.TabIndex = 0;
            tabJobOrders.Text = "Job Orders";
            // 
            // dgvJobOrders
            // 
            dgvJobOrders.AllowUserToAddRows = false;
            dgvJobOrders.AllowUserToDeleteRows = false;
            dgvJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvJobOrders.Location = new System.Drawing.Point(3, 3);
            dgvJobOrders.Name = "dgvJobOrders";
            dgvJobOrders.ReadOnly = true;
            dgvJobOrders.RowTemplate.Height = 25;
            dgvJobOrders.Size = new System.Drawing.Size(749, 512);
            dgvJobOrders.TabIndex = 0;
            // 
            // tabDeliveries
            // 
            tabDeliveries.Controls.Add(dgvJobDeliveries);
            tabDeliveries.Location = new System.Drawing.Point(4, 24);
            tabDeliveries.Name = "tabDeliveries";
            tabDeliveries.Padding = new System.Windows.Forms.Padding(3);
            tabDeliveries.Size = new System.Drawing.Size(755, 518);
            tabDeliveries.TabIndex = 1;
            tabDeliveries.Text = "Job Deliveries";
            tabDeliveries.UseVisualStyleBackColor = true;
            // 
            // dgvJobDeliveries
            // 
            dgvJobDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvJobDeliveries.Location = new System.Drawing.Point(3, 3);
            dgvJobDeliveries.Name = "dgvJobDeliveries";
            dgvJobDeliveries.RowTemplate.Height = 25;
            dgvJobDeliveries.Size = new System.Drawing.Size(749, 512);
            dgvJobDeliveries.TabIndex = 0;
            // 
            // tabJobItems
            // 
            tabJobItems.Location = new System.Drawing.Point(4, 24);
            tabJobItems.Name = "tabJobItems";
            tabJobItems.Padding = new System.Windows.Forms.Padding(3);
            tabJobItems.Size = new System.Drawing.Size(755, 518);
            tabJobItems.TabIndex = 2;
            tabJobItems.Text = "Job Items";
            tabJobItems.UseVisualStyleBackColor = true;
            // 
            // JobsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(spctnJobsManager);
            Name = "JobsControl";
            Padding = new System.Windows.Forms.Padding(6);
            Size = new System.Drawing.Size(1197, 627);
            spctnJobsManager.Panel1.ResumeLayout(false);
            spctnJobsManager.Panel2.ResumeLayout(false);
            spctnJobsManager.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spctnJobsManager).EndInit();
            spctnJobsManager.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabJobDelivery.ResumeLayout(false);
            tabJobOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobOrders).EndInit();
            tabDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobDeliveries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer spctnJobsManager;
        private System.Windows.Forms.TabControl tabJobDelivery;
        private System.Windows.Forms.TabPage tabJobOrders;
        private System.Windows.Forms.TabPage tabJobOrderItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchJobs;
        private System.Windows.Forms.ListBox lbJobsList;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.DataGridView dgvJobOrders;
        private System.Windows.Forms.TextBox txtJobOrderTotals;
        private System.Windows.Forms.DataGridView dgvJobDeliveries;
        private System.Windows.Forms.TabPage tabJobItems;
        private System.Windows.Forms.TabPage tabDeliveries;
    }
}
