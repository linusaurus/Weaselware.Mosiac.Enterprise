namespace Mosiac.UX.UXControls
{
    partial class AttachmentControl
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
            this.dgResources = new System.Windows.Forms.DataGridView();
            this.btnDeleteResource = new System.Windows.Forms.Button();
            this.btnOpenResource = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResources
            // 
            this.dgResources.AllowUserToAddRows = false;
            this.dgResources.AllowUserToResizeColumns = false;
            this.dgResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Location = new System.Drawing.Point(8, 50);
            this.dgResources.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgResources.Name = "dgResources";
            this.dgResources.Size = new System.Drawing.Size(897, 222);
            this.dgResources.TabIndex = 16;
            this.dgResources.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResources_CellContentClick);
            // 
            // btnDeleteResource
            // 
            this.btnDeleteResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteResource.FlatAppearance.BorderSize = 0;
            this.btnDeleteResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteResource.Image = global::Mosiac.UX.Properties.Resources.outline_delete_black_24dp2;
            this.btnDeleteResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteResource.Location = new System.Drawing.Point(206, 9);
            this.btnDeleteResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteResource.Name = "btnDeleteResource";
            this.btnDeleteResource.Size = new System.Drawing.Size(67, 35);
            this.btnDeleteResource.TabIndex = 17;
            this.btnDeleteResource.Text = "Delete";
            this.btnDeleteResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteResource.UseVisualStyleBackColor = false;
            this.btnDeleteResource.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenResource
            // 
            this.btnOpenResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenResource.FlatAppearance.BorderSize = 0;
            this.btnOpenResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenResource.Image = global::Mosiac.UX.Properties.Resources.baseline_launch_black_24dp;
            this.btnOpenResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenResource.Location = new System.Drawing.Point(81, 9);
            this.btnOpenResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenResource.Name = "btnOpenResource";
            this.btnOpenResource.Size = new System.Drawing.Size(72, 35);
            this.btnOpenResource.TabIndex = 19;
            this.btnOpenResource.Text = "Open";
            this.btnOpenResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenResource.UseVisualStyleBackColor = false;
            this.btnOpenResource.Click += new System.EventHandler(this.btnOpenResource_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddResource.FlatAppearance.BorderSize = 0;
            this.btnAddResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResource.Image = global::Mosiac.UX.Properties.Resources.round_add_circle_black_24dp1;
            this.btnAddResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddResource.Location = new System.Drawing.Point(10, 8);
            this.btnAddResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(63, 35);
            this.btnAddResource.TabIndex = 20;
            this.btnAddResource.Text = "Add ";
            this.btnAddResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddResource.UseVisualStyleBackColor = false;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // AttachmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteResource);
            this.Controls.Add(this.btnOpenResource);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.dgResources);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AttachmentControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(913, 279);
            this.Load += new System.EventHandler(this.AttachmentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenResource;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Button btnDeleteResource;
    }
}
