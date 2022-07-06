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
            this.txtSearchJobs = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJobOrders = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.spctnJobsManager)).BeginInit();
            this.spctnJobsManager.Panel1.SuspendLayout();
            this.spctnJobsManager.Panel2.SuspendLayout();
            this.spctnJobsManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.spctnJobsManager.Panel2.Controls.Add(this.tabControl1);
            this.spctnJobsManager.Panel2.Padding = new System.Windows.Forms.Padding(12, 36, 12, 12);
            this.spctnJobsManager.Size = new System.Drawing.Size(1097, 746);
            this.spctnJobsManager.SplitterDistance = 365;
            this.spctnJobsManager.TabIndex = 1;
            // 
            // lbJobsList
            // 
            this.lbJobsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbJobsList.FormattingEnabled = true;
            this.lbJobsList.ItemHeight = 15;
            this.lbJobsList.Location = new System.Drawing.Point(12, 61);
            this.lbJobsList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lbJobsList.Name = "lbJobsList";
            this.lbJobsList.Size = new System.Drawing.Size(341, 673);
            this.lbJobsList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchJobs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 49);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchJobs
            // 
            this.txtSearchJobs.Location = new System.Drawing.Point(0, 13);
            this.txtSearchJobs.Name = "txtSearchJobs";
            this.txtSearchJobs.Size = new System.Drawing.Size(245, 23);
            this.txtSearchJobs.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJobOrders);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 698);
            this.tabControl1.TabIndex = 0;
            // 
            // tabJobOrders
            // 
            this.tabJobOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabJobOrders.Location = new System.Drawing.Point(4, 24);
            this.tabJobOrders.Name = "tabJobOrders";
            this.tabJobOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobOrders.Size = new System.Drawing.Size(696, 670);
            this.tabJobOrders.TabIndex = 0;
            this.tabJobOrders.Text = "Job Orders";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.spctnJobsManager)).EndInit();
            this.spctnJobsManager.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spctnJobsManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJobOrders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchJobs;
        private System.Windows.Forms.ListBox lbJobsList;
    }
}
