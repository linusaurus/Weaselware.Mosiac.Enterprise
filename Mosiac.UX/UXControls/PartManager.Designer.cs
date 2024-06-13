
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
            txtSearch = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            txtSecondTerm = new System.Windows.Forms.TextBox();
            txtThirdTerm = new System.Windows.Forms.TextBox();
            btnOpenPart = new System.Windows.Forms.Button();
            txtPartIDLookup = new System.Windows.Forms.TextBox();
            ckbUseManufacturer = new System.Windows.Forms.CheckBox();
            cboManu = new System.Windows.Forms.ComboBox();
            btnNewPart = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnShowAll = new System.Windows.Forms.Button();
            tsResources = new System.Windows.Forms.ToolStrip();
            tsbCollapsePanel = new System.Windows.Forms.ToolStripButton();
            btnPrintLabel = new System.Windows.Forms.Button();
            tabPartsManager = new System.Windows.Forms.TabPage();
            spcPartsManager = new System.Windows.Forms.SplitContainer();
            tabPartDetail = new System.Windows.Forms.TabControl();
            tabOrderHistory = new System.Windows.Forms.TabPage();
            dgPartOrders = new System.Windows.Forms.DataGridView();
            tabResourceManager = new System.Windows.Forms.TabPage();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            panel2 = new System.Windows.Forms.Panel();
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            dgResources = new System.Windows.Forms.DataGridView();
            dgPartsSearch = new System.Windows.Forms.DataGridView();
            tabPartManager = new System.Windows.Forms.TabControl();
            panel1.SuspendLayout();
            tsResources.SuspendLayout();
            tabPartsManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcPartsManager).BeginInit();
            spcPartsManager.Panel1.SuspendLayout();
            spcPartsManager.Panel2.SuspendLayout();
            spcPartsManager.SuspendLayout();
            tabPartDetail.SuspendLayout();
            tabOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPartOrders).BeginInit();
            tabResourceManager.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPartsSearch).BeginInit();
            tabPartManager.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(6, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Search ....";
            txtSearch.Size = new System.Drawing.Size(173, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.MouseDoubleClick += txtSearch_MouseDoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSecondTerm);
            panel1.Controls.Add(txtThirdTerm);
            panel1.Controls.Add(btnOpenPart);
            panel1.Controls.Add(txtPartIDLookup);
            panel1.Controls.Add(ckbUseManufacturer);
            panel1.Controls.Add(cboManu);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new System.Drawing.Point(10, 18);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1298, 45);
            panel1.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(417, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(91, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSecondTerm
            // 
            txtSecondTerm.Location = new System.Drawing.Point(199, 6);
            txtSecondTerm.Name = "txtSecondTerm";
            txtSecondTerm.Size = new System.Drawing.Size(100, 23);
            txtSecondTerm.TabIndex = 2;
            // 
            // txtThirdTerm
            // 
            txtThirdTerm.Location = new System.Drawing.Point(306, 6);
            txtThirdTerm.Name = "txtThirdTerm";
            txtThirdTerm.Size = new System.Drawing.Size(100, 23);
            txtThirdTerm.TabIndex = 3;
            // 
            // btnOpenPart
            // 
            btnOpenPart.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpenPart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            btnOpenPart.FlatAppearance.BorderSize = 2;
            btnOpenPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenPart.Location = new System.Drawing.Point(1117, 5);
            btnOpenPart.Name = "btnOpenPart";
            btnOpenPart.Size = new System.Drawing.Size(65, 25);
            btnOpenPart.TabIndex = 17;
            btnOpenPart.Text = "PartID";
            btnOpenPart.UseVisualStyleBackColor = true;
            btnOpenPart.Click += button1_Click;
            btnOpenPart.KeyPress += btnOpenPart_KeyPress;
            // 
            // txtPartIDLookup
            // 
            txtPartIDLookup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtPartIDLookup.Location = new System.Drawing.Point(1205, 6);
            txtPartIDLookup.Name = "txtPartIDLookup";
            txtPartIDLookup.Size = new System.Drawing.Size(75, 23);
            txtPartIDLookup.TabIndex = 16;
            txtPartIDLookup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbUseManufacturer
            // 
            ckbUseManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ckbUseManufacturer.AutoSize = true;
            ckbUseManufacturer.Location = new System.Drawing.Point(998, 8);
            ckbUseManufacturer.Name = "ckbUseManufacturer";
            ckbUseManufacturer.Size = new System.Drawing.Size(98, 19);
            ckbUseManufacturer.TabIndex = 14;
            ckbUseManufacturer.Text = "Manufacturer";
            ckbUseManufacturer.UseVisualStyleBackColor = true;
            ckbUseManufacturer.CheckedChanged += ckbUseManufacturer_CheckedChanged;
            // 
            // cboManu
            // 
            cboManu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboManu.Enabled = false;
            cboManu.FormattingEnabled = true;
            cboManu.Location = new System.Drawing.Point(833, 5);
            cboManu.Name = "cboManu";
            cboManu.Size = new System.Drawing.Size(159, 23);
            cboManu.TabIndex = 13;
            cboManu.SelectedIndexChanged += cboManu_SelectedIndexChanged;
            // 
            // btnNewPart
            // 
            btnNewPart.AutoSize = true;
            btnNewPart.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            btnNewPart.FlatAppearance.BorderSize = 2;
            btnNewPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewPart.Location = new System.Drawing.Point(176, 70);
            btnNewPart.Name = "btnNewPart";
            btnNewPart.Size = new System.Drawing.Size(122, 29);
            btnNewPart.TabIndex = 15;
            btnNewPart.Text = "New Part";
            btnNewPart.UseVisualStyleBackColor = true;
            btnNewPart.Click += btnNewPart_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(10, 69);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(122, 32);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.AutoSize = true;
            btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            btnShowAll.FlatAppearance.BorderSize = 2;
            btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowAll.Location = new System.Drawing.Point(304, 70);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(110, 29);
            btnShowAll.TabIndex = 17;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // tsResources
            // 
            tsResources.Dock = System.Windows.Forms.DockStyle.Bottom;
            tsResources.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbCollapsePanel });
            tsResources.Location = new System.Drawing.Point(10, 697);
            tsResources.Margin = new System.Windows.Forms.Padding(3);
            tsResources.Name = "tsResources";
            tsResources.Size = new System.Drawing.Size(1301, 25);
            tsResources.TabIndex = 18;
            tsResources.Text = "toolStrip1";
            tsResources.ItemClicked += tsResources_ItemClicked_1;
            // 
            // tsbCollapsePanel
            // 
            tsbCollapsePanel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbCollapsePanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbCollapsePanel.Image = Properties.Resources.round_keyboard_arrow_down_black_24dp;
            tsbCollapsePanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbCollapsePanel.Name = "tsbCollapsePanel";
            tsbCollapsePanel.Size = new System.Drawing.Size(23, 22);
            tsbCollapsePanel.Text = "toolStripButton3";
            // 
            // btnPrintLabel
            // 
            btnPrintLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPrintLabel.AutoSize = true;
            btnPrintLabel.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            btnPrintLabel.FlatAppearance.BorderSize = 2;
            btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrintLabel.Location = new System.Drawing.Point(1169, 68);
            btnPrintLabel.Name = "btnPrintLabel";
            btnPrintLabel.Size = new System.Drawing.Size(139, 29);
            btnPrintLabel.TabIndex = 17;
            btnPrintLabel.Text = "Print Label";
            btnPrintLabel.UseVisualStyleBackColor = true;
            btnPrintLabel.Click += btnPrintLabel_Click;
            // 
            // tabPartsManager
            // 
            tabPartsManager.Controls.Add(spcPartsManager);
            tabPartsManager.Location = new System.Drawing.Point(4, 24);
            tabPartsManager.Name = "tabPartsManager";
            tabPartsManager.Padding = new System.Windows.Forms.Padding(6);
            tabPartsManager.Size = new System.Drawing.Size(1290, 555);
            tabPartsManager.TabIndex = 0;
            tabPartsManager.Text = "Part Manager";
            tabPartsManager.UseVisualStyleBackColor = true;
            // 
            // spcPartsManager
            // 
            spcPartsManager.Dock = System.Windows.Forms.DockStyle.Fill;
            spcPartsManager.Location = new System.Drawing.Point(6, 6);
            spcPartsManager.Name = "spcPartsManager";
            // 
            // spcPartsManager.Panel1
            // 
            spcPartsManager.Panel1.Controls.Add(dgPartsSearch);
            spcPartsManager.Panel1.Padding = new System.Windows.Forms.Padding(6);
            spcPartsManager.Panel1MinSize = 300;
            // 
            // spcPartsManager.Panel2
            // 
            spcPartsManager.Panel2.Controls.Add(tabPartDetail);
            spcPartsManager.Panel2.Padding = new System.Windows.Forms.Padding(6);
            spcPartsManager.Size = new System.Drawing.Size(1278, 543);
            spcPartsManager.SplitterDistance = 845;
            spcPartsManager.TabIndex = 19;
            // 
            // tabPartDetail
            // 
            tabPartDetail.Controls.Add(tabResourceManager);
            tabPartDetail.Controls.Add(tabOrderHistory);
            tabPartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            tabPartDetail.Location = new System.Drawing.Point(6, 6);
            tabPartDetail.Name = "tabPartDetail";
            tabPartDetail.SelectedIndex = 0;
            tabPartDetail.Size = new System.Drawing.Size(417, 531);
            tabPartDetail.TabIndex = 1;
            // 
            // tabOrderHistory
            // 
            tabOrderHistory.Controls.Add(dgPartOrders);
            tabOrderHistory.Location = new System.Drawing.Point(4, 24);
            tabOrderHistory.Name = "tabOrderHistory";
            tabOrderHistory.Padding = new System.Windows.Forms.Padding(6);
            tabOrderHistory.Size = new System.Drawing.Size(409, 503);
            tabOrderHistory.TabIndex = 1;
            tabOrderHistory.Text = "Part Order History";
            tabOrderHistory.UseVisualStyleBackColor = true;
            // 
            // dgPartOrders
            // 
            dgPartOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPartOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgPartOrders.Location = new System.Drawing.Point(6, 6);
            dgPartOrders.Name = "dgPartOrders";
            dgPartOrders.RowTemplate.Height = 25;
            dgPartOrders.Size = new System.Drawing.Size(397, 491);
            dgPartOrders.TabIndex = 13;
            dgPartOrders.CellMouseDoubleClick += dgPartOrders_CellMouseDoubleClick;
            // 
            // tabResourceManager
            // 
            tabResourceManager.Controls.Add(splitContainer1);
            tabResourceManager.Controls.Add(toolStrip1);
            tabResourceManager.Location = new System.Drawing.Point(4, 24);
            tabResourceManager.Name = "tabResourceManager";
            tabResourceManager.Padding = new System.Windows.Forms.Padding(3);
            tabResourceManager.Size = new System.Drawing.Size(409, 503);
            tabResourceManager.TabIndex = 0;
            tabResourceManager.Text = "Resource Manager";
            tabResourceManager.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new System.Drawing.Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(403, 31);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.round_add_circle_outline_black_24dp1;
            toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            toolStripButton1.Size = new System.Drawing.Size(32, 28);
            toolStripButton1.Text = "tsbOpenResource";
            toolStripButton1.Click += btnNewResource_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.baseline_launch_black_24dp;
            toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            toolStripButton2.Size = new System.Drawing.Size(32, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += btnOpenResource_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.baseline_get_app_black_24dp;
            toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            toolStripButton3.Size = new System.Drawing.Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Open Resource Cache";
            toolStripButton3.Click += btnOpenCache_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.baseline_clear_black_24dp;
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new System.Drawing.Size(23, 28);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += btnClearCache_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.outline_delete_black_24dp2;
            toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new System.Drawing.Size(119, 28);
            toolStripButton5.Text = "Delete Resource";
            toolStripButton5.ToolTipText = "Delete the Resource";
            toolStripButton5.Click += btnDeleteResource_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripButton6.BackColor = System.Drawing.Color.PapayaWhip;
            toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (System.Drawing.Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new System.Drawing.Size(100, 28);
            toolStripButton6.Text = "Update Resource";
            toolStripButton6.Click += button1_Click_1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 34);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgResources);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6);
            splitContainer1.Size = new System.Drawing.Size(403, 466);
            splitContainer1.SplitterDistance = 267;
            splitContainer1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Gainsboro;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(propertyGrid1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(391, 183);
            panel2.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGrid1.Location = new System.Drawing.Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new System.Drawing.Size(389, 181);
            propertyGrid1.TabIndex = 0;
            // 
            // dgResources
            // 
            dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResources.Dock = System.Windows.Forms.DockStyle.Fill;
            dgResources.Location = new System.Drawing.Point(6, 6);
            dgResources.Name = "dgResources";
            dgResources.RowTemplate.Height = 25;
            dgResources.Size = new System.Drawing.Size(391, 255);
            dgResources.TabIndex = 8;
            dgResources.CellMouseDoubleClick += dgResources_CellMouseDoubleClick;
            dgResources.SelectionChanged += dgResources_SelectionChanged;
            // 
            // dgPartsSearch
            // 
            dgPartsSearch.AllowUserToAddRows = false;
            dgPartsSearch.AllowUserToDeleteRows = false;
            dgPartsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPartsSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            dgPartsSearch.Location = new System.Drawing.Point(6, 6);
            dgPartsSearch.Name = "dgPartsSearch";
            dgPartsSearch.ReadOnly = true;
            dgPartsSearch.RowTemplate.Height = 25;
            dgPartsSearch.Size = new System.Drawing.Size(833, 531);
            dgPartsSearch.TabIndex = 9;
            dgPartsSearch.VirtualMode = true;
            dgPartsSearch.CellMouseDoubleClick += dgPartsSearch_CellMouseDoubleClick;
            dgPartsSearch.SelectionChanged += dgAttachments_SelectionChanged;
            // 
            // tabPartManager
            // 
            tabPartManager.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabPartManager.Controls.Add(tabPartsManager);
            tabPartManager.Location = new System.Drawing.Point(10, 107);
            tabPartManager.Name = "tabPartManager";
            tabPartManager.SelectedIndex = 0;
            tabPartManager.Size = new System.Drawing.Size(1298, 583);
            tabPartManager.TabIndex = 20;
            tabPartManager.SelectedIndexChanged += tabPartManager_SelectedIndexChanged;
            // 
            // PartManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabPartManager);
            Controls.Add(tsResources);
            Controls.Add(btnPrintLabel);
            Controls.Add(btnShowAll);
            Controls.Add(btnSave);
            Controls.Add(btnNewPart);
            Controls.Add(panel1);
            MinimumSize = new System.Drawing.Size(1095, 650);
            Name = "PartManager";
            Padding = new System.Windows.Forms.Padding(10);
            Size = new System.Drawing.Size(1321, 732);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tsResources.ResumeLayout(false);
            tsResources.PerformLayout();
            tabPartsManager.ResumeLayout(false);
            spcPartsManager.Panel1.ResumeLayout(false);
            spcPartsManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcPartsManager).EndInit();
            spcPartsManager.ResumeLayout(false);
            tabPartDetail.ResumeLayout(false);
            tabOrderHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPartOrders).EndInit();
            tabResourceManager.ResumeLayout(false);
            tabResourceManager.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPartsSearch).EndInit();
            tabPartManager.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Button btnOpenPart;
        private System.Windows.Forms.TextBox txtPartIDLookup;
        private System.Windows.Forms.DataGridView dgPartOrders;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabPartDetail;
        private System.Windows.Forms.TabPage tabResourceManager;
        private System.Windows.Forms.TabPage tabOrderHistory;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSecondTerm;
        private System.Windows.Forms.TextBox txtThirdTerm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStrip tsResources;
        private System.Windows.Forms.ToolStripButton tsbCollapsePanel;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.SplitContainer spcPartsManager;
        private System.Windows.Forms.TabControl tabPartManager;
        private System.Windows.Forms.TabPage tabPartsManager;
        private System.Windows.Forms.TabPage tabStockTransactions;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvStockParts;
        private System.Windows.Forms.SplitContainer spcTransactionDetails;
        private System.Windows.Forms.DataGridView dgTransactionsGrid;
        private System.Windows.Forms.ToolStrip tsTransactions;
        private System.Windows.Forms.ToolStripButton tsbReceipts;
        private System.Windows.Forms.ToolStripButton tsbAudits;
        private System.Windows.Forms.ToolStripButton tsbPulls;
        private System.Windows.Forms.ToolStripButton tsbAll;
        private System.Windows.Forms.ToolStripButton tsbRemoveSelected;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPullStock;
        private System.Windows.Forms.Button btnRollup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEditSelected;
        private System.Windows.Forms.TabPage tabLocations;
        private System.Windows.Forms.SplitContainer spcLocations;
        private System.Windows.Forms.DataGridView dgLocations;
        private System.Windows.Forms.ToolStrip tsLocationMenu;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbFilter;
        private System.Windows.Forms.DataGridView dgLocationParts;
        private System.Windows.Forms.ToolStrip tsLocationPartsToolBar;
        private System.Windows.Forms.ToolStripButton tsbSaveLocationParts;
        private System.Windows.Forms.ToolStripTextBox txtAreaFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel3;
    }
}
