namespace Mosiac.UX.UXControls
{
    partial class ManufacturerControl
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
            this.tsManufacturersToolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.lbManufacturers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlSearchBackground = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchManu = new System.Windows.Forms.TextBox();
            this.dgvManuParts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.txtTerm2 = new System.Windows.Forms.TextBox();
            this.txtTerm1 = new System.Windows.Forms.TextBox();
            this.txtPartSearchMain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSearchBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManuParts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsManufacturersToolStrip
            // 
            this.tsManufacturersToolStrip.Location = new System.Drawing.Point(10, 10);
            this.tsManufacturersToolStrip.Name = "tsManufacturersToolStrip";
            this.tsManufacturersToolStrip.Size = new System.Drawing.Size(1012, 25);
            this.tsManufacturersToolStrip.TabIndex = 0;
            this.tsManufacturersToolStrip.Text = "toolStrip1";
            this.tsManufacturersToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsManufacturersToolStrip_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(10, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(10, 35);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.lbManufacturers);
            this.spcMain.Panel1.Controls.Add(this.panel1);
            this.spcMain.Panel1.Controls.Add(this.pnlSearchBackground);
            this.spcMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.dgvManuParts);
            this.spcMain.Panel2.Controls.Add(this.panel2);
            this.spcMain.Size = new System.Drawing.Size(1012, 535);
            this.spcMain.SplitterDistance = 320;
            this.spcMain.TabIndex = 2;
            // 
            // lbManufacturers
            // 
            this.lbManufacturers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbManufacturers.FormattingEnabled = true;
            this.lbManufacturers.ItemHeight = 15;
            this.lbManufacturers.Location = new System.Drawing.Point(10, 55);
            this.lbManufacturers.Name = "lbManufacturers";
            this.lbManufacturers.Size = new System.Drawing.Size(300, 295);
            this.lbManufacturers.TabIndex = 2;
            this.lbManufacturers.SelectedValueChanged += new System.EventHandler(this.lbManufacturers_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 350);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 175);
            this.panel1.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(180, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(19, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Manufacturer";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // pnlSearchBackground
            // 
            this.pnlSearchBackground.Controls.Add(this.btnSearch);
            this.pnlSearchBackground.Controls.Add(this.txtSearchManu);
            this.pnlSearchBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBackground.Location = new System.Drawing.Point(10, 10);
            this.pnlSearchBackground.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnlSearchBackground.Name = "pnlSearchBackground";
            this.pnlSearchBackground.Size = new System.Drawing.Size(300, 45);
            this.pnlSearchBackground.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(218, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchManu
            // 
            this.txtSearchManu.Location = new System.Drawing.Point(2, 11);
            this.txtSearchManu.Name = "txtSearchManu";
            this.txtSearchManu.Size = new System.Drawing.Size(214, 23);
            this.txtSearchManu.TabIndex = 0;
            // 
            // dgvManuParts
            // 
            this.dgvManuParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManuParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManuParts.Location = new System.Drawing.Point(0, 54);
            this.dgvManuParts.Margin = new System.Windows.Forms.Padding(10);
            this.dgvManuParts.Name = "dgvManuParts";
            this.dgvManuParts.RowTemplate.Height = 25;
            this.dgvManuParts.Size = new System.Drawing.Size(688, 481);
            this.dgvManuParts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPartSearch);
            this.panel2.Controls.Add(this.txtTerm2);
            this.panel2.Controls.Add(this.txtTerm1);
            this.panel2.Controls.Add(this.txtPartSearchMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(688, 54);
            this.panel2.TabIndex = 1;
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Location = new System.Drawing.Point(523, 20);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(107, 23);
            this.btnPartSearch.TabIndex = 1;
            this.btnPartSearch.Text = "Part Search";
            this.btnPartSearch.UseVisualStyleBackColor = true;
            // 
            // txtTerm2
            // 
            this.txtTerm2.Location = new System.Drawing.Point(353, 20);
            this.txtTerm2.Name = "txtTerm2";
            this.txtTerm2.Size = new System.Drawing.Size(80, 23);
            this.txtTerm2.TabIndex = 0;
            // 
            // txtTerm1
            // 
            this.txtTerm1.Location = new System.Drawing.Point(238, 20);
            this.txtTerm1.Name = "txtTerm1";
            this.txtTerm1.Size = new System.Drawing.Size(109, 23);
            this.txtTerm1.TabIndex = 0;
            // 
            // txtPartSearchMain
            // 
            this.txtPartSearchMain.Location = new System.Drawing.Point(21, 20);
            this.txtPartSearchMain.Name = "txtPartSearchMain";
            this.txtPartSearchMain.Size = new System.Drawing.Size(211, 23);
            this.txtPartSearchMain.TabIndex = 0;
            // 
            // ManufacturerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsManufacturersToolStrip);
            this.Name = "ManufacturerControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1032, 602);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlSearchBackground.ResumeLayout(false);
            this.pnlSearchBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManuParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsManufacturersToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.ListBox lbManufacturers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSearchBackground;
        private System.Windows.Forms.TextBox txtSearchManu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvManuParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPartSearchMain;
        private System.Windows.Forms.TextBox txtTerm2;
        private System.Windows.Forms.TextBox txtTerm1;
        private System.Windows.Forms.Button btnPartSearch;
    }
}
