
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
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabOrderHistory = new System.Windows.Forms.TabPage();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tsResources = new System.Windows.Forms.ToolStrip();
            this.tsbCollapsePanel = new System.Windows.Forms.ToolStripButton();
            this.btnPrintLabel = new System.Windows.Forms.Button();
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
            this.txtSearch.Location = new System.Drawing.Point(6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Enter Search ....";
            this.txtSearch.Size = new System.Drawing.Size(173, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // dgPartsSearch
            // 
            this.dgPartsSearch.AllowUserToAddRows = false;
            this.dgPartsSearch.AllowUserToDeleteRows = false;
            this.dgPartsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsSearch.Location = new System.Drawing.Point(0, 0);
            this.dgPartsSearch.Name = "dgPartsSearch";
            this.dgPartsSearch.ReadOnly = true;
            this.dgPartsSearch.RowTemplate.Height = 25;
            this.dgPartsSearch.Size = new System.Drawing.Size(1131, 310);
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
            this.panel1.Size = new System.Drawing.Size(1120, 45);
            this.panel1.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(417, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSecondTerm
            // 
            this.txtSecondTerm.Location = new System.Drawing.Point(199, 6);
            this.txtSecondTerm.Name = "txtSecondTerm";
            this.txtSecondTerm.Size = new System.Drawing.Size(100, 23);
            this.txtSecondTerm.TabIndex = 2;
            // 
            // txtThirdTerm
            // 
            this.txtThirdTerm.Location = new System.Drawing.Point(306, 6);
            this.txtThirdTerm.Name = "txtThirdTerm";
            this.txtThirdTerm.Size = new System.Drawing.Size(100, 23);
            this.txtThirdTerm.TabIndex = 3;
            // 
            // btnOpenPart
            // 
            this.btnOpenPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOpenPart.FlatAppearance.BorderSize = 2;
            this.btnOpenPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPart.Location = new System.Drawing.Point(939, 5);
            this.btnOpenPart.Name = "btnOpenPart";
            this.btnOpenPart.Size = new System.Drawing.Size(65, 25);
            this.btnOpenPart.TabIndex = 17;
            this.btnOpenPart.Text = "PartID";
            this.btnOpenPart.UseVisualStyleBackColor = true;
            this.btnOpenPart.Click += new System.EventHandler(this.button1_Click);
            this.btnOpenPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOpenPart_KeyPress);
            // 
            // txtPartIDLookup
            // 
            this.txtPartIDLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartIDLookup.Location = new System.Drawing.Point(1027, 6);
            this.txtPartIDLookup.Name = "txtPartIDLookup";
            this.txtPartIDLookup.Size = new System.Drawing.Size(75, 23);
            this.txtPartIDLookup.TabIndex = 16;
            this.txtPartIDLookup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbUseManufacturer
            // 
            this.ckbUseManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbUseManufacturer.AutoSize = true;
            this.ckbUseManufacturer.Location = new System.Drawing.Point(820, 8);
            this.ckbUseManufacturer.Name = "ckbUseManufacturer";
            this.ckbUseManufacturer.Size = new System.Drawing.Size(98, 19);
            this.ckbUseManufacturer.TabIndex = 14;
            this.ckbUseManufacturer.Text = "Manufacturer";
            this.ckbUseManufacturer.UseVisualStyleBackColor = true;
            this.ckbUseManufacturer.CheckedChanged += new System.EventHandler(this.ckbUseManufacturer_CheckedChanged);
            // 
            // cboManu
            // 
            this.cboManu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboManu.Enabled = false;
            this.cboManu.FormattingEnabled = true;
            this.cboManu.Location = new System.Drawing.Point(655, 5);
            this.cboManu.Name = "cboManu";
            this.cboManu.Size = new System.Drawing.Size(159, 23);
            this.cboManu.TabIndex = 13;
            this.cboManu.SelectedIndexChanged += new System.EventHandler(this.cboManu_SelectedIndexChanged);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSourceFile.Location = new System.Drawing.Point(314, 252);
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
            this.btnDeleteResource.Location = new System.Drawing.Point(148, 8);
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
            this.btnOpenResource.Location = new System.Drawing.Point(53, 8);
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
            this.dgResources.Size = new System.Drawing.Size(1061, 206);
            this.dgResources.TabIndex = 8;
            this.dgResources.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgResources_CellMouseDoubleClick);
            this.dgResources.SelectionChanged += new System.EventHandler(this.dgResources_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(163, 252);
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
            this.splitContainer1.Size = new System.Drawing.Size(1122, 626);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 16;
            // 
            // tabPartDetail
            // 
            this.tabPartDetail.Controls.Add(this.tabResourceManager);
            this.tabPartDetail.Controls.Add(this.tabOrderHistory);
            this.tabPartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPartDetail.Location = new System.Drawing.Point(0, 0);
            this.tabPartDetail.Name = "tabPartDetail";
            this.tabPartDetail.SelectedIndex = 0;
            this.tabPartDetail.Size = new System.Drawing.Size(1122, 316);
            this.tabPartDetail.TabIndex = 1;
            // 
            // tabResourceManager
            // 
            this.tabResourceManager.Controls.Add(this.btnNewResource);
            this.tabResourceManager.Controls.Add(this.txtSourceFile);
            this.tabResourceManager.Controls.Add(this.label2);
            this.tabResourceManager.Controls.Add(this.dgResources);
            this.tabResourceManager.Controls.Add(this.panel2);
            this.tabResourceManager.Location = new System.Drawing.Point(4, 24);
            this.tabResourceManager.Name = "tabResourceManager";
            this.tabResourceManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabResourceManager.Size = new System.Drawing.Size(1114, 288);
            this.tabResourceManager.TabIndex = 0;
            this.tabResourceManager.Text = "Resource Manager";
            this.tabResourceManager.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnOpenCache);
            this.panel2.Controls.Add(this.btnClearCache);
            this.panel2.Controls.Add(this.btnOpenResource);
            this.panel2.Controls.Add(this.btnDeleteResource);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 282);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update Selected Resource";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabOrderHistory
            // 
            this.tabOrderHistory.Controls.Add(this.dgPartOrders);
            this.tabOrderHistory.Location = new System.Drawing.Point(4, 24);
            this.tabOrderHistory.Name = "tabOrderHistory";
            this.tabOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderHistory.Size = new System.Drawing.Size(1114, 291);
            this.tabOrderHistory.TabIndex = 1;
            this.tabOrderHistory.Text = "Part Order History";
            this.tabOrderHistory.UseVisualStyleBackColor = true;
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
            // tsResources
            // 
            this.tsResources.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsResources.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCollapsePanel});
            this.tsResources.Location = new System.Drawing.Point(0, 732);
            this.tsResources.Margin = new System.Windows.Forms.Padding(3);
            this.tsResources.Name = "tsResources";
            this.tsResources.Size = new System.Drawing.Size(1190, 25);
            this.tsResources.TabIndex = 18;
            this.tsResources.Text = "toolStrip1";
            this.tsResources.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsResources_ItemClicked_1);
            // 
            // tsbCollapsePanel
            // 
            this.tsbCollapsePanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCollapsePanel.Image = global::Mosiac.UX.Properties.Resources.round_keyboard_arrow_down_black_24dp;
            this.tsbCollapsePanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCollapsePanel.Name = "tsbCollapsePanel";
            this.tsbCollapsePanel.Size = new System.Drawing.Size(23, 22);
            this.tsbCollapsePanel.Text = "toolStripButton3";
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintLabel.AutoSize = true;
            this.btnPrintLabel.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnPrintLabel.FlatAppearance.BorderSize = 2;
            this.btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintLabel.Location = new System.Drawing.Point(1003, 62);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(139, 29);
            this.btnPrintLabel.TabIndex = 17;
            this.btnPrintLabel.Text = "Print Label";
            this.btnPrintLabel.UseVisualStyleBackColor = true;
            this.btnPrintLabel.Click += new System.EventHandler(this.btnPrintLabel_Click);
            // 
            // PartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsResources);
            this.Controls.Add(this.btnPrintLabel);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewPart);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1095, 650);
            this.Name = "PartManager";
            this.Size = new System.Drawing.Size(1190, 757);
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartOrders)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSecondTerm;
        private System.Windows.Forms.TextBox txtThirdTerm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStrip tsResources;
        private System.Windows.Forms.ToolStripButton tsbCollapsePanel;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.Button button1;
    }
}
