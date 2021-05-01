namespace Mosiac.UX.UXControls
{
    partial class PartManagerControl
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
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcPartSplitContatiner = new System.Windows.Forms.SplitContainer();
            this.dgPartsSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRowColorNone = new System.Windows.Forms.RadioButton();
            this.rbRowColorNoInventory = new System.Windows.Forms.RadioButton();
            this.rbRowColorNeverOrdered = new System.Windows.Forms.RadioButton();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUseManufacturer = new System.Windows.Forms.CheckBox();
            this.cboManuFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartIDSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbResources = new System.Windows.Forms.TabPage();
            this.tbDocument = new System.Windows.Forms.TabPage();
            this.tsPartManagerBottom = new System.Windows.Forms.ToolStrip();
            this.tsbCollapse = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPartSplitContatiner)).BeginInit();
            this.spcPartSplitContatiner.Panel1.SuspendLayout();
            this.spcPartSplitContatiner.Panel2.SuspendLayout();
            this.spcPartSplitContatiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tsPartManagerBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(7, 7);
            this.spcMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcPartSplitContatiner);
            this.spcMain.Size = new System.Drawing.Size(1314, 761);
            this.spcMain.SplitterDistance = 380;
            this.spcMain.SplitterWidth = 5;
            this.spcMain.TabIndex = 0;
            // 
            // spcPartSplitContatiner
            // 
            this.spcPartSplitContatiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPartSplitContatiner.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcPartSplitContatiner.Location = new System.Drawing.Point(0, 0);
            this.spcPartSplitContatiner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.spcPartSplitContatiner.Name = "spcPartSplitContatiner";
            this.spcPartSplitContatiner.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcPartSplitContatiner.Panel1
            // 
            this.spcPartSplitContatiner.Panel1.Controls.Add(this.dgPartsSearch);
            this.spcPartSplitContatiner.Panel1.Controls.Add(this.panel1);
            // 
            // spcPartSplitContatiner.Panel2
            // 
            this.spcPartSplitContatiner.Panel2.Controls.Add(this.tabControl1);
            this.spcPartSplitContatiner.Panel2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.spcPartSplitContatiner.Size = new System.Drawing.Size(929, 761);
            this.spcPartSplitContatiner.SplitterDistance = 475;
            this.spcPartSplitContatiner.SplitterWidth = 5;
            this.spcPartSplitContatiner.TabIndex = 0;
            // 
            // dgPartsSearch
            // 
            this.dgPartsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPartsSearch.Location = new System.Drawing.Point(0, 98);
            this.dgPartsSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgPartsSearch.Name = "dgPartsSearch";
            this.dgPartsSearch.Size = new System.Drawing.Size(929, 377);
            this.dgPartsSearch.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtPartSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxUseManufacturer);
            this.panel1.Controls.Add(this.cboManuFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPartIDSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 98);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRowColorNone);
            this.groupBox1.Controls.Add(this.rbRowColorNoInventory);
            this.groupBox1.Controls.Add(this.rbRowColorNeverOrdered);
            this.groupBox1.Location = new System.Drawing.Point(513, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(377, 55);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Row Color";
            // 
            // rbRowColorNone
            // 
            this.rbRowColorNone.AutoSize = true;
            this.rbRowColorNone.Checked = true;
            this.rbRowColorNone.Location = new System.Drawing.Point(40, 22);
            this.rbRowColorNone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbRowColorNone.Name = "rbRowColorNone";
            this.rbRowColorNone.Size = new System.Drawing.Size(54, 19);
            this.rbRowColorNone.TabIndex = 8;
            this.rbRowColorNone.TabStop = true;
            this.rbRowColorNone.Text = "None";
            this.rbRowColorNone.UseVisualStyleBackColor = true;
            this.rbRowColorNone.CheckedChanged += new System.EventHandler(this.rbRowColorNone_CheckedChanged);
            // 
            // rbRowColorNoInventory
            // 
            this.rbRowColorNoInventory.AutoSize = true;
            this.rbRowColorNoInventory.Location = new System.Drawing.Point(247, 22);
            this.rbRowColorNoInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbRowColorNoInventory.Name = "rbRowColorNoInventory";
            this.rbRowColorNoInventory.Size = new System.Drawing.Size(94, 19);
            this.rbRowColorNoInventory.TabIndex = 9;
            this.rbRowColorNoInventory.Text = "No Inventory";
            this.rbRowColorNoInventory.UseVisualStyleBackColor = true;
            // 
            // rbRowColorNeverOrdered
            // 
            this.rbRowColorNeverOrdered.AutoSize = true;
            this.rbRowColorNeverOrdered.Location = new System.Drawing.Point(120, 22);
            this.rbRowColorNeverOrdered.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbRowColorNeverOrdered.Name = "rbRowColorNeverOrdered";
            this.rbRowColorNeverOrdered.Size = new System.Drawing.Size(102, 19);
            this.rbRowColorNeverOrdered.TabIndex = 10;
            this.rbRowColorNeverOrdered.Text = "Never Ordered";
            this.rbRowColorNeverOrdered.UseVisualStyleBackColor = true;
            this.rbRowColorNeverOrdered.CheckedChanged += new System.EventHandler(this.rbRowColorNone_CheckedChanged);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(84, 5);
            this.txtPartSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(422, 23);
            this.txtPartSearch.TabIndex = 1;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.txtPartSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // cbxUseManufacturer
            // 
            this.cbxUseManufacturer.AutoSize = true;
            this.cbxUseManufacturer.Location = new System.Drawing.Point(776, 9);
            this.cbxUseManufacturer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxUseManufacturer.Name = "cbxUseManufacturer";
            this.cbxUseManufacturer.Size = new System.Drawing.Size(98, 19);
            this.cbxUseManufacturer.TabIndex = 7;
            this.cbxUseManufacturer.Text = "Manufacturer";
            this.cbxUseManufacturer.UseVisualStyleBackColor = true;
            this.cbxUseManufacturer.CheckedChanged += new System.EventHandler(this.cbxUseManufacturer_CheckedChanged);
            // 
            // cboManuFilter
            // 
            this.cboManuFilter.FormattingEnabled = true;
            this.cboManuFilter.Location = new System.Drawing.Point(513, 5);
            this.cboManuFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboManuFilter.Name = "cboManuFilter";
            this.cboManuFilter.Size = new System.Drawing.Size(241, 23);
            this.cboManuFilter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "PartID";
            // 
            // txtPartIDSearch
            // 
            this.txtPartIDSearch.Location = new System.Drawing.Point(84, 33);
            this.txtPartIDSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartIDSearch.Name = "txtPartIDSearch";
            this.txtPartIDSearch.Size = new System.Drawing.Size(116, 23);
            this.txtPartIDSearch.TabIndex = 3;
            this.txtPartIDSearch.TextChanged += new System.EventHandler(this.txtPartIDSearch_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbResources);
            this.tabControl1.Controls.Add(this.tbDocument);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // tbResources
            // 
            this.tbResources.Location = new System.Drawing.Point(4, 24);
            this.tbResources.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResources.Name = "tbResources";
            this.tbResources.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbResources.Size = new System.Drawing.Size(907, 239);
            this.tbResources.TabIndex = 0;
            this.tbResources.Text = "Resources";
            this.tbResources.UseVisualStyleBackColor = true;
            // 
            // tbDocument
            // 
            this.tbDocument.Location = new System.Drawing.Point(4, 24);
            this.tbDocument.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDocument.Size = new System.Drawing.Size(947, 239);
            this.tbDocument.TabIndex = 1;
            this.tbDocument.Text = "Document";
            this.tbDocument.UseVisualStyleBackColor = true;
            // 
            // tsPartManagerBottom
            // 
            this.tsPartManagerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsPartManagerBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCollapse});
            this.tsPartManagerBottom.Location = new System.Drawing.Point(7, 768);
            this.tsPartManagerBottom.Name = "tsPartManagerBottom";
            this.tsPartManagerBottom.Size = new System.Drawing.Size(1314, 25);
            this.tsPartManagerBottom.TabIndex = 1;
            this.tsPartManagerBottom.Text = "toolStrip1";
            // 
            // tsbCollapse
            // 
            this.tsbCollapse.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCollapse.Image = global::Mosiac.UX.Properties.Resources.round_keyboard_arrow_down_black_24dp;
            this.tsbCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCollapse.Name = "tsbCollapse";
            this.tsbCollapse.Size = new System.Drawing.Size(23, 22);
            this.tsbCollapse.Text = "toolStripButton1";
            this.tsbCollapse.Click += new System.EventHandler(this.tsbCollapse_Click);
            // 
            // PartManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.tsPartManagerBottom);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PartManagerControl";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Size = new System.Drawing.Size(1328, 800);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcPartSplitContatiner.Panel1.ResumeLayout(false);
            this.spcPartSplitContatiner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPartSplitContatiner)).EndInit();
            this.spcPartSplitContatiner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tsPartManagerBottom.ResumeLayout(false);
            this.tsPartManagerBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcPartSplitContatiner;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbResources;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartIDSearch;
        private System.Windows.Forms.ComboBox cboManuFilter;
        private System.Windows.Forms.CheckBox cbxUseManufacturer;
        private System.Windows.Forms.TabPage tbDocument;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsPartManagerBottom;
        private System.Windows.Forms.ToolStripButton tsbCollapse;
        private System.Windows.Forms.DataGridView dgPartsSearch;
        private System.Windows.Forms.RadioButton rbRowColorNeverOrdered;
        private System.Windows.Forms.RadioButton rbRowColorNoInventory;
        private System.Windows.Forms.RadioButton rbRowColorNone;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
