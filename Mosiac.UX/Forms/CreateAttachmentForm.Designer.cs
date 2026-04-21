
namespace Mosiac.UX.Forms
{
    partial class CreateAttachmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAttachmentForm));
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtAttachmentDescription = new System.Windows.Forms.TextBox();
            txtSourceFile = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnBrowse = new System.Windows.Forms.Button();
            txtFileSize = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Enabled = false;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Location = new System.Drawing.Point(300, 155);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(79, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(219, 155);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 32);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAttachmentDescription
            // 
            txtAttachmentDescription.Location = new System.Drawing.Point(12, 69);
            txtAttachmentDescription.Name = "txtAttachmentDescription";
            txtAttachmentDescription.PlaceholderText = "  Enter description.....";
            txtAttachmentDescription.Size = new System.Drawing.Size(367, 23);
            txtAttachmentDescription.TabIndex = 1;
            // 
            // txtSourceFile
            // 
            txtSourceFile.Location = new System.Drawing.Point(87, 123);
            txtSourceFile.Name = "txtSourceFile";
            txtSourceFile.ReadOnly = true;
            txtSourceFile.Size = new System.Drawing.Size(216, 23);
            txtSourceFile.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "File Size (KB)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Source File";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(309, 123);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(70, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += button3_Click;
            // 
            // txtFileSize
            // 
            txtFileSize.Location = new System.Drawing.Point(87, 152);
            txtFileSize.Name = "txtFileSize";
            txtFileSize.ReadOnly = true;
            txtFileSize.Size = new System.Drawing.Size(108, 23);
            txtFileSize.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(486, 54);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(369, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "Attach a File";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CreateAttachmentForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(486, 212);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(txtFileSize);
            Controls.Add(btnBrowse);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSourceFile);
            Controls.Add(txtAttachmentDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "CreateAttachmentForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Document =";
            Load += CreateAttachmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAttachmentDescription;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}