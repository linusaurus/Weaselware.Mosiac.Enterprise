
using System.Drawing;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    partial class JobManager
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
            splcJobMain = new SplitContainer();
            dgJobOrders = new DataGridView();
            splcJobProducts = new SplitContainer();
            dgProducts = new DataGridView();
            tbTabs = new TabControl();
            tbSubAssemblies = new TabPage();
            dgSubAssemblies = new DataGridView();
            tbProductDocuments = new TabPage();
            dgProductDocuments = new DataGridView();
            groupBox1 = new GroupBox();
            cboJobs = new ComboBox();
            Job = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splcJobMain).BeginInit();
            splcJobMain.Panel1.SuspendLayout();
            splcJobMain.Panel2.SuspendLayout();
            splcJobMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgJobOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splcJobProducts).BeginInit();
            splcJobProducts.Panel1.SuspendLayout();
            splcJobProducts.Panel2.SuspendLayout();
            splcJobProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            tbTabs.SuspendLayout();
            tbSubAssemblies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSubAssemblies).BeginInit();
            tbProductDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductDocuments).BeginInit();
            Job.SuspendLayout();
            SuspendLayout();
            // 
            // splcJobMain
            // 
            splcJobMain.Cursor = Cursors.VSplit;
            splcJobMain.Dock = DockStyle.Fill;
            splcJobMain.Location = new Point(10, 120);
            splcJobMain.Name = "splcJobMain";
            // 
            // splcJobMain.Panel1
            // 
            splcJobMain.Panel1.Controls.Add(dgJobOrders);
            splcJobMain.Panel1.Padding = new Padding(6);
            // 
            // splcJobMain.Panel2
            // 
            splcJobMain.Panel2.Controls.Add(splcJobProducts);
            splcJobMain.Size = new Size(1189, 598);
            splcJobMain.SplitterDistance = 394;
            splcJobMain.TabIndex = 0;
            // 
            // dgJobOrders
            // 
            dgJobOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJobOrders.Dock = DockStyle.Fill;
            dgJobOrders.Location = new Point(6, 6);
            dgJobOrders.Name = "dgJobOrders";
            dgJobOrders.Size = new Size(382, 586);
            dgJobOrders.TabIndex = 0;
            // 
            // splcJobProducts
            // 
            splcJobProducts.Cursor = Cursors.HSplit;
            splcJobProducts.Dock = DockStyle.Fill;
            splcJobProducts.Location = new Point(0, 0);
            splcJobProducts.Name = "splcJobProducts";
            splcJobProducts.Orientation = Orientation.Horizontal;
            // 
            // splcJobProducts.Panel1
            // 
            splcJobProducts.Panel1.Controls.Add(dgProducts);
            // 
            // splcJobProducts.Panel2
            // 
            splcJobProducts.Panel2.Controls.Add(tbTabs);
            splcJobProducts.Size = new Size(791, 598);
            splcJobProducts.SplitterDistance = 193;
            splcJobProducts.TabIndex = 0;
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.Location = new Point(0, 0);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(791, 193);
            dgProducts.TabIndex = 0;
            // 
            // tbTabs
            // 
            tbTabs.Controls.Add(tbSubAssemblies);
            tbTabs.Controls.Add(tbProductDocuments);
            tbTabs.Dock = DockStyle.Fill;
            tbTabs.Location = new Point(0, 0);
            tbTabs.Name = "tbTabs";
            tbTabs.SelectedIndex = 0;
            tbTabs.Size = new Size(791, 401);
            tbTabs.TabIndex = 1;
            // 
            // tbSubAssemblies
            // 
            tbSubAssemblies.Controls.Add(dgSubAssemblies);
            tbSubAssemblies.Location = new Point(4, 24);
            tbSubAssemblies.Name = "tbSubAssemblies";
            tbSubAssemblies.Padding = new Padding(3);
            tbSubAssemblies.Size = new Size(783, 373);
            tbSubAssemblies.TabIndex = 0;
            tbSubAssemblies.Text = "SubAssemblies";
            tbSubAssemblies.UseVisualStyleBackColor = true;
            // 
            // dgSubAssemblies
            // 
            dgSubAssemblies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSubAssemblies.Dock = DockStyle.Fill;
            dgSubAssemblies.Location = new Point(3, 3);
            dgSubAssemblies.Name = "dgSubAssemblies";
            dgSubAssemblies.Size = new Size(777, 367);
            dgSubAssemblies.TabIndex = 0;
            // 
            // tbProductDocuments
            // 
            tbProductDocuments.Controls.Add(dgProductDocuments);
            tbProductDocuments.Location = new Point(4, 24);
            tbProductDocuments.Name = "tbProductDocuments";
            tbProductDocuments.Padding = new Padding(3);
            tbProductDocuments.Size = new Size(693, 304);
            tbProductDocuments.TabIndex = 1;
            tbProductDocuments.Text = "Documents";
            tbProductDocuments.UseVisualStyleBackColor = true;
            // 
            // dgProductDocuments
            // 
            dgProductDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductDocuments.Dock = DockStyle.Fill;
            dgProductDocuments.Location = new Point(3, 3);
            dgProductDocuments.Name = "dgProductDocuments";
            dgProductDocuments.Size = new Size(687, 298);
            dgProductDocuments.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Location = new Point(364, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // cboJobs
            // 
            cboJobs.FormattingEnabled = true;
            cboJobs.Location = new Point(6, 22);
            cboJobs.Name = "cboJobs";
            cboJobs.Size = new Size(320, 23);
            cboJobs.TabIndex = 0;
            cboJobs.SelectedIndexChanged += cboJobs_SelectedIndexChanged;
            // 
            // Job
            // 
            Job.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Job.Controls.Add(cboJobs);
            Job.Location = new Point(10, 14);
            Job.Name = "Job";
            Job.Size = new Size(483, 100);
            Job.TabIndex = 2;
            Job.TabStop = false;
            Job.Text = "Job";
            // 
            // JobManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Job);
            Controls.Add(groupBox1);
            Controls.Add(splcJobMain);
            Name = "JobManager";
            Padding = new Padding(10, 120, 10, 10);
            Size = new Size(1209, 728);
            splcJobMain.Panel1.ResumeLayout(false);
            splcJobMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splcJobMain).EndInit();
            splcJobMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgJobOrders).EndInit();
            splcJobProducts.Panel1.ResumeLayout(false);
            splcJobProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splcJobProducts).EndInit();
            splcJobProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            tbTabs.ResumeLayout(false);
            tbSubAssemblies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSubAssemblies).EndInit();
            tbProductDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductDocuments).EndInit();
            Job.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splcJobMain;
        private System.Windows.Forms.SplitContainer splcJobProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboJobs;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.DataGridView dgSubAssemblies;
        private System.Windows.Forms.DataGridView dgJobOrders;
        private System.Windows.Forms.TabControl tbTabs;
        private System.Windows.Forms.TabPage tbSubAssemblies;
        private System.Windows.Forms.TabPage tbProductDocuments;
        private System.Windows.Forms.DataGridView dgProductDocuments;
        private System.Windows.Forms.GroupBox Job;
    }
}
