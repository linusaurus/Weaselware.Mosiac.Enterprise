
namespace Mosiac.UX.UXControls
{
    partial class OrderReceiptHistoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderReceiptHistoryPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbViewReceipt = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscboFilter = new System.Windows.Forms.ToolStripComboBox();
            this.tsRecordsReturned = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(954, 622);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbViewReceipt,
            this.tsbOpenOrder,
            this.toolStripSeparator1,
            this.tscboFilter,
            this.tsRecordsReturned});
            this.toolStrip1.Location = new System.Drawing.Point(10, 10);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(954, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbViewReceipt
            // 
            this.tsbViewReceipt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewReceipt.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewReceipt.Image")));
            this.tsbViewReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewReceipt.Name = "tsbViewReceipt";
            this.tsbViewReceipt.Size = new System.Drawing.Size(78, 22);
            this.tsbViewReceipt.Text = "View Receipt";
            // 
            // tsbOpenOrder
            // 
            this.tsbOpenOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenOrder.Image")));
            this.tsbOpenOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenOrder.Name = "tsbOpenOrder";
            this.tsbOpenOrder.Size = new System.Drawing.Size(73, 22);
            this.tsbOpenOrder.Text = "Open Order";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tscboFilter
            // 
            this.tscboFilter.Items.AddRange(new object[] {
            "All",
            "Completed",
            "Not Complete"});
            this.tscboFilter.Name = "tscboFilter";
            this.tscboFilter.Size = new System.Drawing.Size(121, 25);
            this.tscboFilter.SelectedIndexChanged += new System.EventHandler(this.tscboFilter_SelectedIndexChanged);
            // 
            // tsRecordsReturned
            // 
            this.tsRecordsReturned.Name = "tsRecordsReturned";
            this.tsRecordsReturned.Size = new System.Drawing.Size(22, 22);
            this.tsRecordsReturned.Text = ".....";
            // 
            // OrderReceiptHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrderReceiptHistoryPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(974, 667);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbViewReceipt;
        private System.Windows.Forms.ToolStripButton tsbOpenOrder;
        private System.Windows.Forms.ToolStripComboBox tscboFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsRecordsReturned;
    }
}
