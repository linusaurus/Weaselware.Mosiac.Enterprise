namespace Mosiac.UX.UXControls
{
    partial class StockManagerControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchthree = new System.Windows.Forms.TextBox();
            this.txtSearchTwo = new System.Windows.Forms.TextBox();
            this.txtSearchOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(989, 637);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchthree
            // 
            this.txtSearchthree.Location = new System.Drawing.Point(347, 38);
            this.txtSearchthree.Name = "txtSearchthree";
            this.txtSearchthree.Size = new System.Drawing.Size(160, 23);
            this.txtSearchthree.TabIndex = 2;
            // 
            // txtSearchTwo
            // 
            this.txtSearchTwo.Location = new System.Drawing.Point(181, 38);
            this.txtSearchTwo.Name = "txtSearchTwo";
            this.txtSearchTwo.Size = new System.Drawing.Size(160, 23);
            this.txtSearchTwo.TabIndex = 1;
            // 
            // txtSearchOne
            // 
            this.txtSearchOne.Location = new System.Drawing.Point(15, 38);
            this.txtSearchOne.Name = "txtSearchOne";
            this.txtSearchOne.Size = new System.Drawing.Size(160, 23);
            this.txtSearchOne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Line Item Search";
            // 
            // StockManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchOne);
            this.Controls.Add(this.txtSearchTwo);
            this.Controls.Add(this.txtSearchthree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockManagerControl";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(1017, 719);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchthree;
        private System.Windows.Forms.TextBox txtSearchTwo;
        private System.Windows.Forms.TextBox txtSearchOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
