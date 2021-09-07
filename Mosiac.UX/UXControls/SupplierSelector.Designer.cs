
namespace Mosiac.UX.UXControls
{
    partial class SupplierSelector
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntEdit = new System.Windows.Forms.Button();
            this.btnNewSupplierOrder = new System.Windows.Forms.Button();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.lbSuppliersList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.Size = new System.Drawing.Size(326, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bntEdit);
            this.panel1.Controls.Add(this.btnNewSupplierOrder);
            this.panel1.Controls.Add(this.btnNewSupplier);
            this.panel1.Location = new System.Drawing.Point(15, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 47);
            this.panel1.TabIndex = 1;
            // 
            // bntEdit
            // 
            this.bntEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntEdit.Location = new System.Drawing.Point(216, 8);
            this.bntEdit.Margin = new System.Windows.Forms.Padding(15);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(94, 30);
            this.bntEdit.TabIndex = 0;
            this.bntEdit.Text = "Edit";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntStats_Click);
            // 
            // btnNewSupplierOrder
            // 
            this.btnNewSupplierOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSupplierOrder.Location = new System.Drawing.Point(126, 8);
            this.btnNewSupplierOrder.Margin = new System.Windows.Forms.Padding(15);
            this.btnNewSupplierOrder.Name = "btnNewSupplierOrder";
            this.btnNewSupplierOrder.Size = new System.Drawing.Size(88, 30);
            this.btnNewSupplierOrder.TabIndex = 0;
            this.btnNewSupplierOrder.Text = "New Order";
            this.btnNewSupplierOrder.UseVisualStyleBackColor = true;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(12, 8);
            this.btnNewSupplier.Margin = new System.Windows.Forms.Padding(15);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(75, 30);
            this.btnNewSupplier.TabIndex = 0;
            this.btnNewSupplier.Text = "New";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // lbSuppliersList
            // 
            this.lbSuppliersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuppliersList.FormattingEnabled = true;
            this.lbSuppliersList.ItemHeight = 15;
            this.lbSuppliersList.Location = new System.Drawing.Point(15, 102);
            this.lbSuppliersList.Name = "lbSuppliersList";
            this.lbSuppliersList.Size = new System.Drawing.Size(322, 424);
            this.lbSuppliersList.TabIndex = 2;
            this.lbSuppliersList.SelectedIndexChanged += new System.EventHandler(this.lbSuppliersList_SelectedIndexChanged);
            // 
            // SupplierSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSuppliersList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SupplierSelector";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(352, 700);
            this.Load += new System.EventHandler(this.SupplierSelector_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button btnNewSupplierOrder;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.ListBox lbSuppliersList;
    }
}
