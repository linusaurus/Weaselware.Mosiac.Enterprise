namespace Mosiac.UX.UXControls
{
    partial class OrderFeeControl
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
            this.dgOrderFees = new System.Windows.Forms.DataGridView();
            this.btnAddOrderFee = new System.Windows.Forms.Button();
            this.btnRemoveFee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderFees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrderFees
            // 
            this.dgOrderFees.AllowUserToAddRows = false;
            this.dgOrderFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderFees.Location = new System.Drawing.Point(7, 44);
            this.dgOrderFees.Name = "dgOrderFees";
            this.dgOrderFees.Size = new System.Drawing.Size(786, 148);
            this.dgOrderFees.TabIndex = 12;
            // 
            // btnAddOrderFee
            // 
            this.btnAddOrderFee.Image = global::Mosiac.UX.Properties.Resources.outline_note_add_black_24dp;
            this.btnAddOrderFee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOrderFee.Location = new System.Drawing.Point(7, 7);
            this.btnAddOrderFee.Name = "btnAddOrderFee";
            this.btnAddOrderFee.Size = new System.Drawing.Size(145, 31);
            this.btnAddOrderFee.TabIndex = 14;
            this.btnAddOrderFee.Text = "Add Fee / Surcharge";
            this.btnAddOrderFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrderFee.UseVisualStyleBackColor = true;
            this.btnAddOrderFee.Click += new System.EventHandler(this.btnAddOrderFee_Click);
            // 
            // btnRemoveFee
            // 
            this.btnRemoveFee.Image = global::Mosiac.UX.Properties.Resources.outline_delete_black_24dp3;
            this.btnRemoveFee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveFee.Location = new System.Drawing.Point(158, 7);
            this.btnRemoveFee.Name = "btnRemoveFee";
            this.btnRemoveFee.Size = new System.Drawing.Size(107, 31);
            this.btnRemoveFee.TabIndex = 13;
            this.btnRemoveFee.Text = "RemoveFee";
            this.btnRemoveFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFee.UseVisualStyleBackColor = true;
            this.btnRemoveFee.Click += new System.EventHandler(this.btnRemoveFee_Click);
            // 
            // OrderFeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddOrderFee);
            this.Controls.Add(this.btnRemoveFee);
            this.Controls.Add(this.dgOrderFees);
            this.Name = "OrderFeeControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(800, 199);
            this.Load += new System.EventHandler(this.OrderFeeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrderFee;
        private System.Windows.Forms.Button btnRemoveFee;
        private System.Windows.Forms.DataGridView dgOrderFees;
    }
}
