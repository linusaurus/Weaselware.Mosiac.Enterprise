namespace Mosiac.UX.UXControls
{
    partial class PartResourceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartResourceControl));
            this.dgResources = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddResource = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpenResource = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpenLocalFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdateFromLocal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearCache = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResources
            // 
            this.dgResources.AllowUserToAddRows = false;
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResources.Location = new System.Drawing.Point(3, 28);
            this.dgResources.Name = "dgResources";
            this.dgResources.Size = new System.Drawing.Size(758, 243);
            this.dgResources.TabIndex = 0;
            this.dgResources.Text = "dataGridView1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddResource,
            this.toolStripSeparator3,
            this.tsbOpenResource,
            this.toolStripSeparator1,
            this.tsbOpenLocalFolder,
            this.toolStripSeparator2,
            this.tsbUpdateFromLocal,
            this.toolStripSeparator4,
            this.tsbClearCache});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddResource
            // 
            this.tsbAddResource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddResource.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddResource.Image")));
            this.tsbAddResource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddResource.Name = "tsbAddResource";
            this.tsbAddResource.Size = new System.Drawing.Size(84, 22);
            this.tsbAddResource.Text = "Add Resource";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOpenResource
            // 
            this.tsbOpenResource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenResource.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenResource.Image")));
            this.tsbOpenResource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenResource.Name = "tsbOpenResource";
            this.tsbOpenResource.Size = new System.Drawing.Size(91, 22);
            this.tsbOpenResource.Text = "Open Resource";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOpenLocalFolder
            // 
            this.tsbOpenLocalFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenLocalFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenLocalFolder.Image")));
            this.tsbOpenLocalFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenLocalFolder.Name = "tsbOpenLocalFolder";
            this.tsbOpenLocalFolder.Size = new System.Drawing.Size(107, 22);
            this.tsbOpenLocalFolder.Text = "Open Local Cache";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUpdateFromLocal
            // 
            this.tsbUpdateFromLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpdateFromLocal.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateFromLocal.Image")));
            this.tsbUpdateFromLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateFromLocal.Name = "tsbUpdateFromLocal";
            this.tsbUpdateFromLocal.Size = new System.Drawing.Size(140, 22);
            this.tsbUpdateFromLocal.Text = "Update from Local Copy";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClearCache
            // 
            this.tsbClearCache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearCache.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearCache.Image")));
            this.tsbClearCache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearCache.Name = "tsbClearCache";
            this.tsbClearCache.Size = new System.Drawing.Size(74, 22);
            this.tsbClearCache.Text = "Clear Cache";
            // 
            // PartResourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgResources);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PartResourceControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(764, 274);
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddResource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOpenResource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbOpenLocalFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbUpdateFromLocal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbClearCache;
    }
}
