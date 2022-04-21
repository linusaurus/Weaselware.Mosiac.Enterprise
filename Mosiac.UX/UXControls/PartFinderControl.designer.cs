namespace Mosiac.UX.UXControls
{
    partial class PartFinderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartFinderControl));
            this.tbSupplier = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTerm3 = new System.Windows.Forms.TextBox();
            this.txtTerm2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.dgvPartsSearchResults = new System.Windows.Forms.DataGridView();
            this.PartID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchParts = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgSupplierParts = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnNewPart = new System.Windows.Forms.Button();
            this.btnAddJobPart = new System.Windows.Forms.Button();
            this.tbSupplier.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsSearchResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierParts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSupplier
            // 
            this.tbSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupplier.Controls.Add(this.tabPage1);
            this.tbSupplier.Controls.Add(this.tabPage2);
            this.tbSupplier.Location = new System.Drawing.Point(4, 29);
            this.tbSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.SelectedIndex = 0;
            this.tbSupplier.Size = new System.Drawing.Size(940, 221);
            this.tbSupplier.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtTerm3);
            this.tabPage1.Controls.Add(this.txtTerm2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtPartNumber);
            this.tabPage1.Controls.Add(this.dgvPartsSearchResults);
            this.tabPage1.Controls.Add(this.tbSearchParts);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(932, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parts Finder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Mosiac.UX.Properties.Resources.outline_search_black_24dp;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(331, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTerm3
            // 
            this.txtTerm3.Location = new System.Drawing.Point(242, 10);
            this.txtTerm3.Name = "txtTerm3";
            this.txtTerm3.Size = new System.Drawing.Size(83, 23);
            this.txtTerm3.TabIndex = 2;
            // 
            // txtTerm2
            // 
            this.txtTerm2.Location = new System.Drawing.Point(149, 10);
            this.txtTerm2.Name = "txtTerm2";
            this.txtTerm2.Size = new System.Drawing.Size(86, 23);
            this.txtTerm2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::Mosiac.UX.Properties.Resources.twotone_add_box_black_24dp2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(823, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Part #";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartNumber.Location = new System.Drawing.Point(736, 10);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(81, 23);
            this.txtPartNumber.TabIndex = 4;
            // 
            // dgvPartsSearchResults
            // 
            this.dgvPartsSearchResults.AllowUserToAddRows = false;
            this.dgvPartsSearchResults.AllowUserToDeleteRows = false;
            this.dgvPartsSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartsSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID_Col,
            this.Description_Col,
            this.Manu,
            this.PartNumber_col});
            this.dgvPartsSearchResults.Location = new System.Drawing.Point(7, 40);
            this.dgvPartsSearchResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPartsSearchResults.Name = "dgvPartsSearchResults";
            this.dgvPartsSearchResults.ReadOnly = true;
            this.dgvPartsSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartsSearchResults.Size = new System.Drawing.Size(916, 147);
            this.dgvPartsSearchResults.TabIndex = 9;
            this.dgvPartsSearchResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartsSearchResults_CellContentDoubleClick);
            this.dgvPartsSearchResults.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartsSearchResults_RowHeaderMouseDoubleClick);
            this.dgvPartsSearchResults.SelectionChanged += new System.EventHandler(this.dgvPartsSearchResults_SelectionChanged);
            // 
            // PartID_Col
            // 
            this.PartID_Col.DataPropertyName = "PartID";
            this.PartID_Col.HeaderText = "PartID";
            this.PartID_Col.Name = "PartID_Col";
            this.PartID_Col.ReadOnly = true;
            this.PartID_Col.Width = 70;
            // 
            // Description_Col
            // 
            this.Description_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_Col.DataPropertyName = "ItemDescription";
            this.Description_Col.HeaderText = "Description";
            this.Description_Col.Name = "Description_Col";
            this.Description_Col.ReadOnly = true;
            // 
            // Manu
            // 
            this.Manu.DataPropertyName = "ManuName";
            this.Manu.HeaderText = "Manufacturer";
            this.Manu.Name = "Manu";
            this.Manu.ReadOnly = true;
            // 
            // PartNumber_col
            // 
            this.PartNumber_col.DataPropertyName = "PartNumber";
            this.PartNumber_col.HeaderText = "Part Number";
            this.PartNumber_col.Name = "PartNumber_col";
            this.PartNumber_col.ReadOnly = true;
            // 
            // tbSearchParts
            // 
            this.tbSearchParts.Location = new System.Drawing.Point(7, 10);
            this.tbSearchParts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearchParts.Name = "tbSearchParts";
            this.tbSearchParts.Size = new System.Drawing.Size(135, 23);
            this.tbSearchParts.TabIndex = 0;
            this.tbSearchParts.Text = "Search...";
            this.tbSearchParts.TextChanged += new System.EventHandler(this.tbSearchParts_TextChanged);
            this.tbSearchParts.Enter += new System.EventHandler(this.tbSearchParts_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgSupplierParts);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(932, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier Purchases";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgSupplierParts
            // 
            this.dgSupplierParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSupplierParts.Location = new System.Drawing.Point(4, 3);
            this.dgSupplierParts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgSupplierParts.Name = "dgSupplierParts";
            this.dgSupplierParts.Size = new System.Drawing.Size(924, 187);
            this.dgSupplierParts.TabIndex = 0;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToOrder.Image")));
            this.btnAddToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToOrder.Location = new System.Drawing.Point(491, 10);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(144, 30);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnNewPart
            // 
            this.btnNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPart.Enabled = false;
            this.btnNewPart.Location = new System.Drawing.Point(642, 10);
            this.btnNewPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(144, 30);
            this.btnNewPart.TabIndex = 4;
            this.btnNewPart.Text = "Use Supplier Part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // btnAddJobPart
            // 
            this.btnAddJobPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJobPart.Location = new System.Drawing.Point(792, 10);
            this.btnAddJobPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddJobPart.Name = "btnAddJobPart";
            this.btnAddJobPart.Size = new System.Drawing.Size(144, 30);
            this.btnAddJobPart.TabIndex = 4;
            this.btnAddJobPart.Text = "Add Job Part";
            this.btnAddJobPart.UseVisualStyleBackColor = true;
            this.btnAddJobPart.Click += new System.EventHandler(this.btnAddJobPart_Click);
            // 
            // PartFinderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddJobPart);
            this.Controls.Add(this.btnNewPart);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.tbSupplier);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PartFinderControl";
            this.Size = new System.Drawing.Size(947, 251);
            this.Load += new System.EventHandler(this.PartFinderControl_Load);
            this.tbSupplier.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsSearchResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbSupplier;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPartsSearchResults;
        private System.Windows.Forms.TextBox tbSearchParts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnAddJobPart;
        private System.Windows.Forms.DataGridView dgSupplierParts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtTerm3;
        private System.Windows.Forms.TextBox txtTerm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber_col;
        private System.Windows.Forms.Button btnSearch;
    }
}
