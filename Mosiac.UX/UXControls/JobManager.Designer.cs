
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
            this.splcJobMain = new System.Windows.Forms.SplitContainer();
            this.dgJobOrders = new System.Windows.Forms.DataGridView();
            this.splcJobProducts = new System.Windows.Forms.SplitContainer();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.tbTabs = new System.Windows.Forms.TabControl();
            this.tbSubAssemblies = new System.Windows.Forms.TabPage();
            this.dgSubAssemblies = new System.Windows.Forms.DataGridView();
            this.tbProductDocuments = new System.Windows.Forms.TabPage();
            this.dgProductDocuments = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboJobs = new System.Windows.Forms.ComboBox();
            this.Job = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splcJobMain)).BeginInit();
            this.splcJobMain.Panel1.SuspendLayout();
            this.splcJobMain.Panel2.SuspendLayout();
            this.splcJobMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splcJobProducts)).BeginInit();
            this.splcJobProducts.Panel1.SuspendLayout();
            this.splcJobProducts.Panel2.SuspendLayout();
            this.splcJobProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.tbTabs.SuspendLayout();
            this.tbSubAssemblies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubAssemblies)).BeginInit();
            this.tbProductDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductDocuments)).BeginInit();
            this.Job.SuspendLayout();
            this.SuspendLayout();
            // 
            // splcJobMain
            // 
            this.splcJobMain.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splcJobMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcJobMain.Location = new System.Drawing.Point(10, 120);
            this.splcJobMain.Name = "splcJobMain";
            // 
            // splcJobMain.Panel1
            // 
            this.splcJobMain.Panel1.Controls.Add(this.dgJobOrders);
            this.splcJobMain.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splcJobMain.Panel2
            // 
            this.splcJobMain.Panel2.Controls.Add(this.splcJobProducts);
            this.splcJobMain.Size = new System.Drawing.Size(1055, 497);
            this.splcJobMain.SplitterDistance = 350;
            this.splcJobMain.TabIndex = 0;
            // 
            // dgJobOrders
            // 
            this.dgJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgJobOrders.Location = new System.Drawing.Point(6, 6);
            this.dgJobOrders.Name = "dgJobOrders";
            this.dgJobOrders.RowTemplate.Height = 25;
            this.dgJobOrders.Size = new System.Drawing.Size(338, 485);
            this.dgJobOrders.TabIndex = 0;
            // 
            // splcJobProducts
            // 
            this.splcJobProducts.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splcJobProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcJobProducts.Location = new System.Drawing.Point(0, 0);
            this.splcJobProducts.Name = "splcJobProducts";
            this.splcJobProducts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcJobProducts.Panel1
            // 
            this.splcJobProducts.Panel1.Controls.Add(this.dgProducts);
            // 
            // splcJobProducts.Panel2
            // 
            this.splcJobProducts.Panel2.Controls.Add(this.tbTabs);
            this.splcJobProducts.Size = new System.Drawing.Size(701, 497);
            this.splcJobProducts.SplitterDistance = 161;
            this.splcJobProducts.TabIndex = 0;
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProducts.Location = new System.Drawing.Point(0, 0);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowTemplate.Height = 25;
            this.dgProducts.Size = new System.Drawing.Size(701, 161);
            this.dgProducts.TabIndex = 0;
            // 
            // tbTabs
            // 
            this.tbTabs.Controls.Add(this.tbSubAssemblies);
            this.tbTabs.Controls.Add(this.tbProductDocuments);
            this.tbTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTabs.Location = new System.Drawing.Point(0, 0);
            this.tbTabs.Name = "tbTabs";
            this.tbTabs.SelectedIndex = 0;
            this.tbTabs.Size = new System.Drawing.Size(701, 332);
            this.tbTabs.TabIndex = 1;
            // 
            // tbSubAssemblies
            // 
            this.tbSubAssemblies.Controls.Add(this.dgSubAssemblies);
            this.tbSubAssemblies.Location = new System.Drawing.Point(4, 24);
            this.tbSubAssemblies.Name = "tbSubAssemblies";
            this.tbSubAssemblies.Padding = new System.Windows.Forms.Padding(3);
            this.tbSubAssemblies.Size = new System.Drawing.Size(693, 304);
            this.tbSubAssemblies.TabIndex = 0;
            this.tbSubAssemblies.Text = "SubAssemblies";
            this.tbSubAssemblies.UseVisualStyleBackColor = true;
            // 
            // dgSubAssemblies
            // 
            this.dgSubAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSubAssemblies.Location = new System.Drawing.Point(3, 3);
            this.dgSubAssemblies.Name = "dgSubAssemblies";
            this.dgSubAssemblies.RowTemplate.Height = 25;
            this.dgSubAssemblies.Size = new System.Drawing.Size(687, 298);
            this.dgSubAssemblies.TabIndex = 0;
            // 
            // tbProductDocuments
            // 
            this.tbProductDocuments.Controls.Add(this.dgProductDocuments);
            this.tbProductDocuments.Location = new System.Drawing.Point(4, 24);
            this.tbProductDocuments.Name = "tbProductDocuments";
            this.tbProductDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tbProductDocuments.Size = new System.Drawing.Size(688, 312);
            this.tbProductDocuments.TabIndex = 1;
            this.tbProductDocuments.Text = "Documents";
            this.tbProductDocuments.UseVisualStyleBackColor = true;
            // 
            // dgProductDocuments
            // 
            this.dgProductDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductDocuments.Location = new System.Drawing.Point(3, 3);
            this.dgProductDocuments.Name = "dgProductDocuments";
            this.dgProductDocuments.RowTemplate.Height = 25;
            this.dgProductDocuments.Size = new System.Drawing.Size(682, 306);
            this.dgProductDocuments.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(364, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // cboJobs
            // 
            this.cboJobs.FormattingEnabled = true;
            this.cboJobs.Location = new System.Drawing.Point(6, 22);
            this.cboJobs.Name = "cboJobs";
            this.cboJobs.Size = new System.Drawing.Size(269, 23);
            this.cboJobs.TabIndex = 0;
            this.cboJobs.SelectedIndexChanged += new System.EventHandler(this.cboJobs_SelectedIndexChanged);
            // 
            // Job
            // 
            this.Job.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Job.Controls.Add(this.cboJobs);
            this.Job.Location = new System.Drawing.Point(10, 14);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(349, 100);
            this.Job.TabIndex = 2;
            this.Job.TabStop = false;
            this.Job.Text = "Job";
            // 
            // JobManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Job);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splcJobMain);
            this.Name = "JobManager";
            this.Padding = new System.Windows.Forms.Padding(10, 120, 10, 10);
            this.Size = new System.Drawing.Size(1075, 627);
            this.splcJobMain.Panel1.ResumeLayout(false);
            this.splcJobMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcJobMain)).EndInit();
            this.splcJobMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgJobOrders)).EndInit();
            this.splcJobProducts.Panel1.ResumeLayout(false);
            this.splcJobProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcJobProducts)).EndInit();
            this.splcJobProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.tbTabs.ResumeLayout(false);
            this.tbSubAssemblies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSubAssemblies)).EndInit();
            this.tbProductDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductDocuments)).EndInit();
            this.Job.ResumeLayout(false);
            this.ResumeLayout(false);

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
