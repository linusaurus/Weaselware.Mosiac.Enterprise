namespace Mosiac.UX
{
    partial class NewOrderDialog
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
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbJobName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJobSelection = new System.Windows.Forms.TextBox();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGo.Location = new System.Drawing.Point(294, 90);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(88, 27);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(200, 90);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbJobName
            // 
            this.lbJobName.AutoSize = true;
            this.lbJobName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbJobName.Location = new System.Drawing.Point(29, 16);
            this.lbJobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJobName.Name = "lbJobName";
            this.lbJobName.Size = new System.Drawing.Size(55, 15);
            this.lbJobName.TabIndex = 4;
            this.lbJobName.Text = "Jobname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier";
            // 
            // tbJobSelection
            // 
            this.tbJobSelection.Location = new System.Drawing.Point(113, 13);
            this.tbJobSelection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbJobSelection.Name = "tbJobSelection";
            this.tbJobSelection.Size = new System.Drawing.Size(269, 23);
            this.tbJobSelection.TabIndex = 0;
            // 
            // tbSupplier
            // 
            this.tbSupplier.Location = new System.Drawing.Point(113, 42);
            this.tbSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(269, 23);
            this.tbSupplier.TabIndex = 1;
            // 
            // NewOrderDialog
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 138);
            this.ControlBox = false;
            this.Controls.Add(this.tbSupplier);
            this.Controls.Add(this.tbJobSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbJobName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGo);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewOrderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Purchase Order";
            this.Load += new System.EventHandler(this.NewOrderDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbJobName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJobSelection;
        private System.Windows.Forms.TextBox tbSupplier;
    }
}