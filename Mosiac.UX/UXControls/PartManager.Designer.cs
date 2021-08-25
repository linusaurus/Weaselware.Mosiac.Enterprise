
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
            this.btnOpenPart = new System.Windows.Forms.Button();
            this.txtPartIDLookup = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.Label();
            this.ckbUseManufacturer = new System.Windows.Forms.CheckBox();
            this.cboManu = new System.Windows.Forms.ComboBox();
            this.gpbResource = new System.Windows.Forms.GroupBox();
            this.txtResourceCreator = new System.Windows.Forms.TextBox();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.txtModDate = new System.Windows.Forms.TextBox();
            this.txtResourceCreateDate = new System.Windows.Forms.TextBox();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.btnOpenCache = new System.Windows.Forms.Button();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnOpenResource = new System.Windows.Forms.Button();
            this.btnNewResource = new System.Windows.Forms.Button();
            this.dgResources = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResourceID = new System.Windows.Forms.Label();
            this.dgPartOrders = new System.Windows.Forms.DataGridView();
            this.gbPartOrders = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpbResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartOrders)).BeginInit();
            this.gbPartOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Enter Search ....";
            this.txtSearch.Size = new System.Drawing.Size(276, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // dgPartsSearch
            // 
            this.dgPartsSearch.AllowUserToAddRows = false;
            this.dgPartsSearch.AllowUserToDeleteRows = false;
            this.dgPartsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsSearch.Location = new System.Drawing.Point(22, 49);
            this.dgPartsSearch.Name = "dgPartsSearch";
            this.dgPartsSearch.ReadOnly = true;
            this.dgPartsSearch.RowTemplate.Height = 25;
            this.dgPartsSearch.Size = new System.Drawing.Size(1096, 385);
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
            this.panel1.Controls.Add(this.btnOpenPart);
            this.panel1.Controls.Add(this.txtPartIDLookup);
            this.panel1.Controls.Add(this.lbResults);
            this.panel1.Controls.Add(this.ckbUseManufacturer);
            this.panel1.Controls.Add(this.cboManu);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(22, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 35);
            this.panel1.TabIndex = 11;
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
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Location = new System.Drawing.Point(576, 9);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(44, 15);
            this.lbResults.TabIndex = 15;
            this.lbResults.Text = "Results";
            this.lbResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResults.Click += new System.EventHandler(this.lbResults_Click);
            // 
            // ckbUseManufacturer
            // 
            this.ckbUseManufacturer.AutoSize = true;
            this.ckbUseManufacturer.Location = new System.Drawing.Point(458, 8);
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
            this.cboManu.Location = new System.Drawing.Point(288, 5);
            this.cboManu.Name = "cboManu";
            this.cboManu.Size = new System.Drawing.Size(159, 23);
            this.cboManu.TabIndex = 13;
            this.cboManu.SelectedIndexChanged += new System.EventHandler(this.cboManu_SelectedIndexChanged);
            // 
            // gpbResource
            // 
            this.gpbResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbResource.Controls.Add(this.txtResourceCreator);
            this.gpbResource.Controls.Add(this.txtSourceFile);
            this.gpbResource.Controls.Add(this.txtModDate);
            this.gpbResource.Controls.Add(this.txtResourceCreateDate);
            this.gpbResource.Controls.Add(this.btnClearCache);
            this.gpbResource.Controls.Add(this.btnOpenCache);
            this.gpbResource.Controls.Add(this.btnDeleteResource);
            this.gpbResource.Controls.Add(this.btnOpenResource);
            this.gpbResource.Controls.Add(this.btnNewResource);
            this.gpbResource.Controls.Add(this.dgResources);
            this.gpbResource.Controls.Add(this.label2);
            this.gpbResource.Controls.Add(this.label1);
            this.gpbResource.Controls.Add(this.label3);
            this.gpbResource.Controls.Add(this.lbResourceID);
            this.gpbResource.Location = new System.Drawing.Point(602, 453);
            this.gpbResource.Name = "gpbResource";
            this.gpbResource.Size = new System.Drawing.Size(516, 315);
            this.gpbResource.TabIndex = 12;
            this.gpbResource.TabStop = false;
            this.gpbResource.Text = "Part Resources";
            this.gpbResource.Enter += new System.EventHandler(this.gpbResource_Enter);
            // 
            // txtResourceCreator
            // 
            this.txtResourceCreator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResourceCreator.Location = new System.Drawing.Point(386, 253);
            this.txtResourceCreator.Name = "txtResourceCreator";
            this.txtResourceCreator.Size = new System.Drawing.Size(111, 23);
            this.txtResourceCreator.TabIndex = 13;
            this.txtResourceCreator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFile.Location = new System.Drawing.Point(165, 281);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.ReadOnly = true;
            this.txtSourceFile.Size = new System.Drawing.Size(332, 23);
            this.txtSourceFile.TabIndex = 13;
            this.txtSourceFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModDate
            // 
            this.txtModDate.Location = new System.Drawing.Point(226, 252);
            this.txtModDate.Name = "txtModDate";
            this.txtModDate.Size = new System.Drawing.Size(80, 23);
            this.txtModDate.TabIndex = 13;
            // 
            // txtResourceCreateDate
            // 
            this.txtResourceCreateDate.Location = new System.Drawing.Point(77, 252);
            this.txtResourceCreateDate.Name = "txtResourceCreateDate";
            this.txtResourceCreateDate.Size = new System.Drawing.Size(80, 23);
            this.txtResourceCreateDate.TabIndex = 13;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCache.FlatAppearance.BorderSize = 0;
            this.btnClearCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCache.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCache.Image")));
            this.btnClearCache.Location = new System.Drawing.Point(429, 25);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(44, 23);
            this.btnClearCache.TabIndex = 12;
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // btnOpenCache
            // 
            this.btnOpenCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCache.FlatAppearance.BorderSize = 0;
            this.btnOpenCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCache.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCache.Image")));
            this.btnOpenCache.Location = new System.Drawing.Point(386, 25);
            this.btnOpenCache.Name = "btnOpenCache";
            this.btnOpenCache.Size = new System.Drawing.Size(46, 23);
            this.btnOpenCache.TabIndex = 12;
            this.btnOpenCache.UseVisualStyleBackColor = true;
            this.btnOpenCache.Click += new System.EventHandler(this.btnOpenCache_Click);
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.FlatAppearance.BorderSize = 0;
            this.btnDeleteResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteResource.Image = global::Mosiac.UX.Properties.Resources.outline_delete_black_24dp4;
            this.btnDeleteResource.Location = new System.Drawing.Point(99, 25);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(25, 23);
            this.btnDeleteResource.TabIndex = 12;
            this.btnDeleteResource.UseVisualStyleBackColor = true;
            this.btnDeleteResource.Click += new System.EventHandler(this.btnDeleteResource_Click);
            // 
            // btnOpenResource
            // 
            this.btnOpenResource.FlatAppearance.BorderSize = 0;
            this.btnOpenResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenResource.Image = global::Mosiac.UX.Properties.Resources.baseline_launch_black_24dp2;
            this.btnOpenResource.Location = new System.Drawing.Point(50, 25);
            this.btnOpenResource.Name = "btnOpenResource";
            this.btnOpenResource.Size = new System.Drawing.Size(25, 23);
            this.btnOpenResource.TabIndex = 12;
            this.btnOpenResource.UseVisualStyleBackColor = true;
            this.btnOpenResource.Click += new System.EventHandler(this.btnOpenResource_Click);
            // 
            // btnNewResource
            // 
            this.btnNewResource.FlatAppearance.BorderSize = 0;
            this.btnNewResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewResource.Image = global::Mosiac.UX.Properties.Resources.round_add_circle_outline_black_24dp1;
            this.btnNewResource.Location = new System.Drawing.Point(14, 25);
            this.btnNewResource.Name = "btnNewResource";
            this.btnNewResource.Size = new System.Drawing.Size(25, 23);
            this.btnNewResource.TabIndex = 12;
            this.btnNewResource.UseVisualStyleBackColor = true;
            this.btnNewResource.Click += new System.EventHandler(this.btnNewResource_Click);
            // 
            // dgResources
            // 
            this.dgResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Location = new System.Drawing.Point(14, 58);
            this.dgResources.Name = "dgResources";
            this.dgResources.RowTemplate.Height = 25;
            this.dgResources.Size = new System.Drawing.Size(483, 177);
            this.dgResources.TabIndex = 8;
            this.dgResources.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgResources_CellMouseDoubleClick);
            this.dgResources.SelectionChanged += new System.EventHandler(this.dgResources_SelectionChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(14, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(309, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Created By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(163, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modified";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResourceID
            // 
            this.lbResourceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResourceID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbResourceID.Location = new System.Drawing.Point(14, 252);
            this.lbResourceID.Name = "lbResourceID";
            this.lbResourceID.Size = new System.Drawing.Size(57, 23);
            this.lbResourceID.TabIndex = 6;
            this.lbResourceID.Text = "Created";
            this.lbResourceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPartOrders
            // 
            this.dgPartOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartOrders.Location = new System.Drawing.Point(18, 58);
            this.dgPartOrders.Name = "dgPartOrders";
            this.dgPartOrders.RowTemplate.Height = 25;
            this.dgPartOrders.Size = new System.Drawing.Size(532, 246);
            this.dgPartOrders.TabIndex = 13;
            this.dgPartOrders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPartOrders_CellMouseDoubleClick);
            // 
            // gbPartOrders
            // 
            this.gbPartOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPartOrders.Controls.Add(this.dgPartOrders);
            this.gbPartOrders.Location = new System.Drawing.Point(22, 453);
            this.gbPartOrders.Name = "gbPartOrders";
            this.gbPartOrders.Size = new System.Drawing.Size(567, 319);
            this.gbPartOrders.TabIndex = 14;
            this.gbPartOrders.TabStop = false;
            this.gbPartOrders.Text = "Part Orders";
            // 
            // PartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPartOrders);
            this.Controls.Add(this.gpbResource);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPartsSearch);
            this.MinimumSize = new System.Drawing.Size(1095, 795);
            this.Name = "PartManager";
            this.Size = new System.Drawing.Size(1166, 795);
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbResource.ResumeLayout(false);
            this.gpbResource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartOrders)).EndInit();
            this.gbPartOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxCarbTrack;
        private System.Windows.Forms.CheckBox cbxObsolete;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtWaste;
        private System.Windows.Forms.TextBox txtMarkUp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.TextBox txtUnitPrice;
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
        private System.Windows.Forms.Label lbResourceID;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.ComboBox cboPartManu;
        private System.Windows.Forms.Button btnAddManu;
        private System.Windows.Forms.GroupBox gpbResource;
        private System.Windows.Forms.Button btnNewResource;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Button btnOpenResource;
        private System.Windows.Forms.TextBox txtResourceCreator;
        private System.Windows.Forms.TextBox txtResourceCreateDate;
        private System.Windows.Forms.Button btnDeleteResource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenPart;
        private System.Windows.Forms.TextBox txtPartIDLookup;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenCache;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.TextBox txtModDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgPartOrders;
        private System.Windows.Forms.GroupBox gbPartOrders;
    }
}
