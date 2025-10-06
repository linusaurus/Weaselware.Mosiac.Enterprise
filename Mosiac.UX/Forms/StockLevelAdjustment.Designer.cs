namespace Mosiac.UX.Forms
{
    partial class StockLevelAdjustment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            txtAdjustment = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(149, 53);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(101, 37);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(256, 53);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(101, 37);
            btnOK.TabIndex = 0;
            btnOK.Text = "Commit";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtAdjustment
            // 
            txtAdjustment.Location = new System.Drawing.Point(12, 34);
            txtAdjustment.Name = "txtAdjustment";
            txtAdjustment.Size = new System.Drawing.Size(101, 23);
            txtAdjustment.TabIndex = 1;
            txtAdjustment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtAdjustment.TextChanged += txtAdjustment_TextChanged;
            txtAdjustment.KeyPress += txtAdjustment_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Amount";
            // 
            // StockLevelAdjustment
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(377, 102);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(txtAdjustment);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "StockLevelAdjustment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Set Stock Level";
            Load += StockLevelAdjustmentForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAdjustment;
        private System.Windows.Forms.Label label1;
    }
}