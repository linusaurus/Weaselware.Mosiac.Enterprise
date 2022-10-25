namespace Mosiac.UX.UXControls
{
    partial class ProductsControl
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
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSelectJob = new System.Windows.Forms.ComboBox();
            this.tsProductToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(10, 10);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.panel1);
            this.spcMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.tsProductToolStrip);
            this.spcMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.spcMain.Size = new System.Drawing.Size(1064, 679);
            this.spcMain.SplitterDistance = 120;
            this.spcMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSelectJob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 100);
            this.panel1.TabIndex = 0;
            // 
            // cboSelectJob
            // 
            this.cboSelectJob.FormattingEnabled = true;
            this.cboSelectJob.Location = new System.Drawing.Point(19, 14);
            this.cboSelectJob.Name = "cboSelectJob";
            this.cboSelectJob.Size = new System.Drawing.Size(356, 23);
            this.cboSelectJob.TabIndex = 0;
            // 
            // tsProductToolStrip
            // 
            this.tsProductToolStrip.Location = new System.Drawing.Point(10, 10);
            this.tsProductToolStrip.Name = "tsProductToolStrip";
            this.tsProductToolStrip.Size = new System.Drawing.Size(1044, 25);
            this.tsProductToolStrip.TabIndex = 0;
            this.tsProductToolStrip.Text = "toolStrip1";
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMain);
            this.Name = "ProductsControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1084, 699);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboSelectJob;
        private System.Windows.Forms.ToolStrip tsProductToolStrip;
    }
}
