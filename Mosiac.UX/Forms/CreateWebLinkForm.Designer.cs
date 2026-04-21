
namespace Mosiac.UX.Forms
{
    partial class CreateResourceForm
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
            txtResourceDescription = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtSourceFile = new System.Windows.Forms.TextBox();
            btnBrowse = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtFileSize = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtResourceDescription
            // 
            txtResourceDescription.Location = new System.Drawing.Point(12, 12);
            txtResourceDescription.Name = "txtResourceDescription";
            txtResourceDescription.PlaceholderText = "  Enter a Resource Description";
            txtResourceDescription.Size = new System.Drawing.Size(394, 23);
            txtResourceDescription.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(318, 88);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(237, 88);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtSourceFile
            // 
            txtSourceFile.Location = new System.Drawing.Point(91, 56);
            txtSourceFile.Name = "txtSourceFile";
            txtSourceFile.Size = new System.Drawing.Size(234, 23);
            txtSourceFile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(331, 56);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Source File";
            // 
            // txtFileSize
            // 
            txtFileSize.Location = new System.Drawing.Point(91, 85);
            txtFileSize.Name = "txtFileSize";
            txtFileSize.Size = new System.Drawing.Size(90, 23);
            txtFileSize.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "File Size (KB)";
            // 
            // CreateResourceForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            CausesValidation = false;
            ClientSize = new System.Drawing.Size(424, 127);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFileSize);
            Controls.Add(txtSourceFile);
            Controls.Add(txtResourceDescription);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "CreateResourceForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Resource";
            Activated += CreateResourceForm_Activated;
            Load += CreateResourceForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResourceDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label label3;
    }
}