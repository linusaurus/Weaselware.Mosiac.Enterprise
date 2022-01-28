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
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.dgvPartsSearchResults = new System.Windows.Forms.DataGridView();
            this.PartID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tbSupplier.Size = new System.Drawing.Size(926, 222);
            this.tbSupplier.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbStartsWith);
            this.tabPage1.Controls.Add(this.rbContains);
            this.tabPage1.Controls.Add(this.dgvPartsSearchResults);
            this.tabPage1.Controls.Add(this.tbSearchParts);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(918, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parts Finder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbStartsWith
            // 
            this.rbStartsWith.AutoSize = true;
            this.rbStartsWith.Location = new System.Drawing.Point(566, 10);
            this.rbStartsWith.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(82, 19);
            this.rbStartsWith.TabIndex = 3;
            this.rbStartsWith.Text = "Starts With";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            this.rbStartsWith.CheckedChanged += new System.EventHandler(this.rbStartsWith_CheckedChanged);
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Location = new System.Drawing.Point(415, 10);
            this.rbContains.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(72, 19);
            this.rbContains.TabIndex = 2;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "Contains";
            this.rbContains.UseVisualStyleBackColor = true;
            this.rbContains.CheckedChanged += new System.EventHandler(this.rbContains_CheckedChanged);
            // 
            // dgvPartsSearchResults
            // 
            this.dgvPartsSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartsSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID_Col,
            this.Description_Col,
            this.PartNumber_col});
            this.dgvPartsSearchResults.Location = new System.Drawing.Point(7, 37);
            this.dgvPartsSearchResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPartsSearchResults.Name = "dgvPartsSearchResults";
            this.dgvPartsSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartsSearchResults.Size = new System.Drawing.Size(902, 151);
            this.dgvPartsSearchResults.TabIndex = 1;
            this.dgvPartsSearchResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartsSearchResults_CellContentDoubleClick);
            this.dgvPartsSearchResults.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartsSearchResults_RowHeaderMouseDoubleClick);
            this.dgvPartsSearchResults.SelectionChanged += new System.EventHandler(this.dgvPartsSearchResults_SelectionChanged);
            // 
            // PartID_Col
            // 
            this.PartID_Col.DataPropertyName = "PartID";
            this.PartID_Col.HeaderText = "PartID";
            this.PartID_Col.Name = "PartID_Col";
            this.PartID_Col.Width = 70;
            // 
            // Description_Col
            // 
            this.Description_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_Col.DataPropertyName = "ItemDescription";
            this.Description_Col.HeaderText = "Description";
            this.Description_Col.Name = "Description_Col";
            // 
            // PartNumber_col
            // 
            this.PartNumber_col.DataPropertyName = "PartNumber";
            this.PartNumber_col.HeaderText = "Part Number";
            this.PartNumber_col.Name = "PartNumber_col";
            // 
            // tbSearchParts
            // 
            this.tbSearchParts.Location = new System.Drawing.Point(7, 7);
            this.tbSearchParts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearchParts.Name = "tbSearchParts";
            this.tbSearchParts.Size = new System.Drawing.Size(261, 23);
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
            this.tabPage2.Size = new System.Drawing.Size(918, 194);
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
            this.dgSupplierParts.Size = new System.Drawing.Size(910, 188);
            this.dgSupplierParts.TabIndex = 0;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToOrder.Image")));
            this.btnAddToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToOrder.Location = new System.Drawing.Point(477, 10);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(144, 37);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnNewPart
            // 
            this.btnNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPart.Enabled = false;
            this.btnNewPart.Location = new System.Drawing.Point(628, 10);
            this.btnNewPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(144, 37);
            this.btnNewPart.TabIndex = 4;
            this.btnNewPart.Text = "Use Supplier Part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // btnAddJobPart
            // 
            this.btnAddJobPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJobPart.Location = new System.Drawing.Point(778, 10);
            this.btnAddJobPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddJobPart.Name = "btnAddJobPart";
            this.btnAddJobPart.Size = new System.Drawing.Size(144, 37);
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
            this.Size = new System.Drawing.Size(933, 258);
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
        private System.Windows.Forms.RadioButton rbStartsWith;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.DataGridView dgvPartsSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber_col;
        private System.Windows.Forms.TextBox tbSearchParts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnAddJobPart;
        private System.Windows.Forms.DataGridView dgSupplierParts;
    }
}
