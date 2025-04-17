namespace Mosiac.UX.UXControls
{
    partial class ProductsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsControl));
            spcMain = new SplitContainer();
            panel1 = new Panel();
            dgJobSearchResults = new DataGridView();
            cboSelectJob = new ComboBox();
            panel2 = new Panel();
            txtJobSearch = new TextBox();
            JobSearchBottomPanel = new Panel();
            splitContainer1 = new SplitContainer();
            dgProductsAssemblies = new DataGridView();
            dgProductSubAssemblies = new DataGridView();
            tsProductToolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tslActiveJob = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)spcMain).BeginInit();
            spcMain.Panel1.SuspendLayout();
            spcMain.Panel2.SuspendLayout();
            spcMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgJobSearchResults).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductsAssemblies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductSubAssemblies).BeginInit();
            tsProductToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // spcMain
            // 
            spcMain.Dock = DockStyle.Fill;
            spcMain.Location = new Point(10, 10);
            spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            spcMain.Panel1.Controls.Add(panel1);
            spcMain.Panel1.Padding = new Padding(10);
            // 
            // spcMain.Panel2
            // 
            spcMain.Panel2.Controls.Add(splitContainer1);
            spcMain.Panel2.Controls.Add(tsProductToolStrip);
            spcMain.Panel2.Padding = new Padding(10);
            spcMain.Size = new Size(1186, 679);
            spcMain.SplitterDistance = 312;
            spcMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgJobSearchResults);
            panel1.Controls.Add(cboSelectJob);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(JobSearchBottomPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 659);
            panel1.TabIndex = 0;
            // 
            // dgJobSearchResults
            // 
            dgJobSearchResults.AllowUserToAddRows = false;
            dgJobSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJobSearchResults.Location = new Point(0, 33);
            dgJobSearchResults.Name = "dgJobSearchResults";
            dgJobSearchResults.RowHeadersVisible = false;
            dgJobSearchResults.Size = new Size(292, 419);
            dgJobSearchResults.TabIndex = 2;
            dgJobSearchResults.SelectionChanged += dgJobSearchResults_SelectionChanged;
            // 
            // cboSelectJob
            // 
            cboSelectJob.FormattingEnabled = true;
            cboSelectJob.Location = new Point(627, 53);
            cboSelectJob.Name = "cboSelectJob";
            cboSelectJob.Size = new Size(356, 23);
            cboSelectJob.TabIndex = 0;
            cboSelectJob.SelectedIndexChanged += cboSelectJob_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtJobSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 34);
            panel2.TabIndex = 3;
            // 
            // txtJobSearch
            // 
            txtJobSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtJobSearch.Location = new Point(3, 3);
            txtJobSearch.Name = "txtJobSearch";
            txtJobSearch.Size = new Size(284, 23);
            txtJobSearch.TabIndex = 1;
            // 
            // JobSearchBottomPanel
            // 
            JobSearchBottomPanel.BackColor = SystemColors.ControlLight;
            JobSearchBottomPanel.BorderStyle = BorderStyle.Fixed3D;
            JobSearchBottomPanel.Dock = DockStyle.Bottom;
            JobSearchBottomPanel.Location = new Point(0, 453);
            JobSearchBottomPanel.Name = "JobSearchBottomPanel";
            JobSearchBottomPanel.Size = new Size(292, 206);
            JobSearchBottomPanel.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 35);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgProductsAssemblies);
            splitContainer1.Panel1.Padding = new Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgProductSubAssemblies);
            splitContainer1.Panel2.Padding = new Padding(6);
            splitContainer1.Size = new Size(850, 634);
            splitContainer1.SplitterDistance = 234;
            splitContainer1.TabIndex = 1;
            // 
            // dgProductsAssemblies
            // 
            dgProductsAssemblies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductsAssemblies.Dock = DockStyle.Fill;
            dgProductsAssemblies.Location = new Point(6, 6);
            dgProductsAssemblies.Name = "dgProductsAssemblies";
            dgProductsAssemblies.Size = new Size(838, 222);
            dgProductsAssemblies.TabIndex = 0;
            dgProductsAssemblies.SelectionChanged += dgProductsAssemblies_SelectionChanged;
            // 
            // dgProductSubAssemblies
            // 
            dgProductSubAssemblies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductSubAssemblies.Dock = DockStyle.Fill;
            dgProductSubAssemblies.Location = new Point(6, 6);
            dgProductSubAssemblies.Name = "dgProductSubAssemblies";
            dgProductSubAssemblies.Size = new Size(838, 384);
            dgProductSubAssemblies.TabIndex = 0;
            // 
            // tsProductToolStrip
            // 
            tsProductToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, tslActiveJob });
            tsProductToolStrip.Location = new Point(10, 10);
            tsProductToolStrip.Name = "tsProductToolStrip";
            tsProductToolStrip.Size = new Size(850, 25);
            tsProductToolStrip.TabIndex = 0;
            tsProductToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 22);
            toolStripButton1.Text = "Search";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tslActiveJob
            // 
            tslActiveJob.Alignment = ToolStripItemAlignment.Right;
            tslActiveJob.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslActiveJob.Name = "tslActiveJob";
            tslActiveJob.Size = new Size(61, 22);
            tslActiveJob.Text = "Active Job";
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(spcMain);
            Name = "ProductsControl";
            Padding = new Padding(10);
            Size = new Size(1206, 699);
            spcMain.Panel1.ResumeLayout(false);
            spcMain.Panel2.ResumeLayout(false);
            spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spcMain).EndInit();
            spcMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgJobSearchResults).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductsAssemblies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductSubAssemblies).EndInit();
            tsProductToolStrip.ResumeLayout(false);
            tsProductToolStrip.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboSelectJob;
        private System.Windows.Forms.ToolStrip tsProductToolStrip;
        private SplitContainer splitContainer1;
        private DataGridView dgProductsAssemblies;
        private DataGridView dgProductSubAssemblies;
        private TextBox txtJobSearch;
        private DataGridView dgJobSearchResults;
        private ToolStripButton toolStripButton1;
        private Panel panel2;
        private Panel JobSearchBottomPanel;
        private ToolStripLabel tslActiveJob;
    }
}
