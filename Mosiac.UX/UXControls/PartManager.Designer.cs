
namespace Mosiac.UX.UXControls
{
    partial class PartManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartManager));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgPartsSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSecondTerm = new System.Windows.Forms.TextBox();
            this.txtThirdTerm = new System.Windows.Forms.TextBox();
            this.btnOpenPart = new System.Windows.Forms.Button();
            this.txtPartIDLookup = new System.Windows.Forms.TextBox();
            this.ckbUseManufacturer = new System.Windows.Forms.CheckBox();
            this.cboManu = new System.Windows.Forms.ComboBox();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.btnOpenCache = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnOpenResource = new System.Windows.Forms.Button();
            this.btnNewResource = new System.Windows.Forms.Button();
            this.dgResources = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgPartOrders = new System.Windows.Forms.DataGridView();
            this.btnNewPart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPartDetail = new System.Windows.Forms.TabControl();
            this.tabResourceManager = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabOrderHistory = new System.Windows.Forms.TabPage();
            this.tsResources = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPartDetail.SuspendLayout();
            this.tabResourceManager.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabOrderHistory.SuspendLayout();
            this.tsResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Enter Search ....";
            this.txtSearch.Size = new System.Drawing.Size(186, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // dgPartsSearch
            // 
            this.dgPartsSearch.AllowUserToAddRows = false;
            this.dgPartsSearch.AllowUserToDeleteRows = false;
            this.dgPartsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPartsSearch.Location = new System.Drawing.Point(0, 0);
            this.dgPartsSearch.Name = "dgPartsSearch";
            this.dgPartsSearch.ReadOnly = true;
            this.dgPartsSearch.RowTemplate.Height = 25;
            this.dgPartsSearch.Size = new System.Drawing.Size(1122, 306);
            this.dgPartsSearch.TabIndex = 9;
            this.dgPartsSearch.VirtualMode = true;
            this.dgPartsSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPartsSearch_CellMouseDoubleClick);
            this.dgPartsSearch.SelectionChanged += new System.EventHandler(this.dgAttachments_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSecondTerm);
            this.panel1.Controls.Add(this.txtThirdTerm);
            this.panel1.Controls.Add(this.btnOpenPart);
            this.panel1.Controls.Add(this.txtPartIDLookup);
            this.panel1.Controls.Add(this.ckbUseManufacturer);
            this.panel1.Controls.Add(this.cboManu);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(22, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 45);
            this.panel1.TabIndex = 11;
            // 
            // txtSecondTerm
            // 
            this.txtSecondTerm.Location = new System.Drawing.Point(209, 6);
            this.txtSecondTerm.Name = "txtSecondTerm";
            this.txtSecondTerm.Size = new System.Drawing.Size(100, 23);
            this.txtSecondTerm.TabIndex = 18;
            // 
            // txtThirdTerm
            // 
            this.txtThirdTerm.Location = new System.Drawing.Point(317, 6);
            this.txtThirdTerm.Name = "txtThirdTerm";
            this.txtThirdTerm.Size = new System.Drawing.Size(100, 23);
            this.txtThirdTerm.TabIndex = 18;
            // 
            // btnOpenPart
            // 
            this.btnOpenPart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOpenPart.FlatAppearance.BorderSize = 2;
            this.btnOpenPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPart.Location = new System.Drawing.Point(909, 5);
            this.btnOpenPart.Name = "btnOpenPart";
            this.btnOpenPart.Size = new System.Drawing.Size(75, 25);
            this.btnOpenPart.TabIndex = 17;
            this.btnOpenPart.Text = "PartID";
            this.btnOpenPart.UseVisualStyleBackColor = true;
            this.btnOpenPart.Click += new System.EventHandler(this.button1_Click);
            this.btnOpenPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOpenPart_KeyPress);
            // 
            // txtPartIDLookup
            // 
            this.txtPartIDLookup.Location = new System.Drawing.Point(990, 6);
            this.txtPartIDLookup.Name = "txtPartIDLookup";
            this.txtPartIDLookup.Size = new System.Drawing.Size(100, 23);
            this.txtPartIDLookup.TabIndex = 16;
            this.txtPartIDLookup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbUseManufacturer
            // 
            this.ckbUseManufacturer.AutoSize = true;
            this.ckbUseManufacturer.Location = new System.Drawing.Point(770, 8);
            this.ckbUseManufacturer.Name = "ckbUseManufacturer";
            this.ckbUseManufacturer.Size = new System.Drawing.Size(98, 19);
            this.ckbUseManufacturer.TabIndex = 14;
            this.ckbUseManufacturer.Text = "Manufacturer";
            this.ckbUseManufacturer.UseVisualStyleBackColor = true;
            this.ckbUseManufacturer.CheckedChanged += new System.EventHandler(this.ckbUseManufacturer_CheckedChanged);
            // 
            // cboManu
            // 
            this.cboManu.Enabled = false;
            this.cboManu.FormattingEnabled = true;
            this.cboManu.Location = new System.Drawing.Point(605, 5);
            this.cboManu.Name = "cboManu";
            this.cboManu.Size = new System.Drawing.Size(159, 23);
            this.cboManu.TabIndex = 13;
            this.cboManu.SelectedIndexChanged += new System.EventHandler(this.cboManu_SelectedIndexChanged);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSourceFile.Location = new System.Drawing.Point(314, 225);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.ReadOnly = true;
            this.txtSourceFile.Size = new System.Drawing.Size(498, 23);
            this.txtSourceFile.TabIndex = 13;
            this.txtSourceFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCache.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClearCache.FlatAppearance.BorderSize = 0;
            this.btnClearCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCache.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCache.Image")));
            this.btnClearCache.Location = new System.Drawing.Point(901, 8);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(44, 23);
            this.btnClearCache.TabIndex = 12;
            this.btnClearCache.UseVisualStyleBackColor = false;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // btnOpenCache
            // 
            this.btnOpenCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCache.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOpenCache.FlatAppearance.BorderSize = 0;
            this.btnOpenCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCache.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCache.Image")));
            this.btnOpenCache.Location = new System.Drawing.Point(849, 8);
            this.btnOpenCache.Name = "btnOpenCache";
            this.btnOpenCache.Size = new System.Drawing.Size(46, 23);
            this.btnOpenCache.TabIndex = 12;
            this.btnOpenCache.UseVisualStyleBackColor = false;
            this.btnOpenCache.Click += new System.EventHandler(this.btnOpenCache_Click);
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDeleteResource.FlatAppearance.BorderSize = 0;
            this.btnDeleteResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteResource.Image = global::Mosiac.UX.Properties.Resources.outline_delete_black_24dp4;
            this.btnDeleteResource.Location = new System.Drawing.Point(85, 11);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(25, 23);
            this.btnDeleteResource.TabIndex = 12;
            this.btnDeleteResource.UseVisualStyleBackColor = false;
            this.btnDeleteResource.Click += new System.EventHandler(this.btnDeleteResource_Click);
            // 
            // btnOpenResource
            // 
            this.btnOpenResource.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOpenResource.FlatAppearance.BorderSize = 0;
            this.btnOpenResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenResource.Image = global::Mosiac.UX.Properties.Resources.baseline_launch_black_24dp2;
            this.btnOpenResource.Location = new System.Drawing.Point(44, 11);
            this.btnOpenResource.Name = "btnOpenResource";
            this.btnOpenResource.Size = new System.Drawing.Size(25, 23);
            this.btnOpenResource.TabIndex = 12;
            this.btnOpenResource.UseVisualStyleBackColor = false;
            this.btnOpenResource.Click += new System.EventHandler(this.btnOpenResource_Click);
            // 
            // btnNewResource
            // 
            this.btnNewResource.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNewResource.FlatAppearance.BorderSize = 0;
            this.btnNewResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewResource.Image = global::Mosiac.UX.Properties.Resources.round_add_circle_outline_black_24dp1;
            this.btnNewResource.Location = new System.Drawing.Point(12, 11);
            this.btnNewResource.Name = "btnNewResource";
            this.btnNewResource.Size = new System.Drawing.Size(25, 23);
            this.btnNewResource.TabIndex = 12;
            this.btnNewResource.UseVisualStyleBackColor = false;
            this.btnNewResource.Click += new System.EventHandler(this.btnNewResource_Click);
            // 
            // dgResources
            // 
            this.dgResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Location = new System.Drawing.Point(27, 40);
            this.dgResources.Name = "dgResources";
            this.dgResources.RowTemplate.Height = 25;
            this.dgResources.Size = new System.Drawing.Size(1061, 179);
            this.dgResources.TabIndex = 8;
            this.dgResources.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgResources_CellMouseDoubleClick);
            this.dgResources.SelectionChanged += new System.EventHandler(this.dgResources_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(163, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPartOrders
            // 
            this.dgPartOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartOrders.Location = new System.Drawing.Point(27, 34);
            this.dgPartOrders.Name = "dgPartOrders";
            this.dgPartOrders.RowTemplate.Height = 25;
            this.dgPartOrders.Size = new System.Drawing.Size(782, 175);
            this.dgPartOrders.TabIndex = 13;
            this.dgPartOrders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPartOrders_CellMouseDoubleClick);
            // 
            // btnNewPart
            // 
            this.btnNewPart.AutoSize = true;
            this.btnNewPart.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnNewPart.FlatAppearance.BorderSize = 2;
            this.btnNewPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPart.Location = new System.Drawing.Point(189, 62);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(122, 29);
            this.btnNewPart.TabIndex = 15;
            this.btnNewPart.Text = "New Part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Location = new System.Drawing.Point(22, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgPartsSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabPartDetail);
            this.splitContainer1.Panel2.Controls.Add(this.tsResources);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 624);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 16;
            // 
            // tabPartDetail
            // 
            this.tabPartDetail.Controls.Add(this.tabResourceManager);
            this.tabPartDetail.Controls.Add(this.tabOrderHistory);
            this.tabPartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPartDetail.Location = new System.Drawing.Point(0, 25);
            this.tabPartDetail.Name = "tabPartDetail";
            this.tabPartDetail.SelectedIndex = 0;
            this.tabPartDetail.Size = new System.Drawing.Size(1122, 289);
            this.tabPartDetail.TabIndex = 1;
            // 
            // tabResourceManager
            // 
            this.tabResourceManager.Controls.Add(this.btnNewResource);
            this.tabResourceManager.Controls.Add(this.txtSourceFile);
            this.tabResourceManager.Controls.Add(this.label2);
            this.tabResourceManager.Controls.Add(this.dgResources);
            this.tabResourceManager.Controls.Add(this.btnDeleteResource);
            this.tabResourceManager.Controls.Add(this.btnOpenResource);
            this.tabResourceManager.Controls.Add(this.panel2);
            this.tabResourceManager.Location = new System.Drawing.Point(4, 24);
            this.tabResourceManager.Name = "tabResourceManager";
            this.tabResourceManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabResourceManager.Size = new System.Drawing.Size(1114, 261);
            this.tabResourceManager.TabIndex = 0;
            this.tabResourceManager.Text = "Resource Manager";
            this.tabResourceManager.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.btnOpenCache);
            this.panel2.Controls.Add(this.btnClearCache);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 255);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabOrderHistory
            // 
            this.tabOrderHistory.Controls.Add(this.dgPartOrders);
            this.tabOrderHistory.Location = new System.Drawing.Point(4, 24);
            this.tabOrderHistory.Name = "tabOrderHistory";
            this.tabOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderHistory.Size = new System.Drawing.Size(1114, 261);
            this.tabOrderHistory.TabIndex = 1;
            this.tabOrderHistory.Text = "Part Order History";
            this.tabOrderHistory.UseVisualStyleBackColor = true;
            // 
            // tsResources
            // 
            this.tsResources.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.tsResources.Location = new System.Drawing.Point(0, 0);
            this.tsResources.Margin = new System.Windows.Forms.Padding(3);
            this.tsResources.Name = "tsResources";
            this.tsResources.Size = new System.Drawing.Size(1122, 25);
            this.tsResources.TabIndex = 0;
            this.tsResources.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Open Resource";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton2.Text = "Add Resource";
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoSize = true;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnShowAll.FlatAppearance.BorderSize = 2;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Location = new System.Drawing.Point(328, 62);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(110, 29);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(441, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // PartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewPart);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1095, 650);
            this.Name = "PartManager";
            this.Size = new System.Drawing.Size(1192, 764);
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartOrders)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPartDetail.ResumeLayout(false);
            this.tabResourceManager.ResumeLayout(false);
            this.tabResourceManager.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabOrderHistory.ResumeLayout(false);
            this.tsResources.ResumeLayout(false);
            this.tsResources.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;   
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgPartsSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboManu;
        private System.Windows.Forms.CheckBox ckbUseManufacturer;
        private System.Windows.Forms.ComboBox cboPartManu;
        private System.Windows.Forms.Button btnAddManu;
        private System.Windows.Forms.Button btnNewResource;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Button btnOpenResource;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.Button btnOpenPart;
        private System.Windows.Forms.TextBox txtPartIDLookup;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenCache;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.DataGridView dgPartOrders;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabPartDetail;
        private System.Windows.Forms.TabPage tabResourceManager;
        private System.Windows.Forms.TabPage tabOrderHistory;
        private System.Windows.Forms.ToolStrip tsResources;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSecondTerm;
        private System.Windows.Forms.TextBox txtThirdTerm;
        private System.Windows.Forms.Button btnSearch;
    }
}
