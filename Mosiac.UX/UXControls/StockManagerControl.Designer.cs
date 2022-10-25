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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagerControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSearchLineItems = new System.Windows.Forms.ToolStripButton();
            this.tsTransactions = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemSearchPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchthree = new System.Windows.Forms.TextBox();
            this.txtSearchTwo = new System.Windows.Forms.TextBox();
            this.txtSearchOne = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ItemSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSearchLineItems,
            this.tsTransactions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(103, 726);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // tsSearchLineItems
            // 
            this.tsSearchLineItems.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchLineItems.Image")));
            this.tsSearchLineItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchLineItems.Margin = new System.Windows.Forms.Padding(6);
            this.tsSearchLineItems.Name = "tsSearchLineItems";
            this.tsSearchLineItems.Padding = new System.Windows.Forms.Padding(6);
            this.tsSearchLineItems.Size = new System.Drawing.Size(88, 55);
            this.tsSearchLineItems.Text = "Search Items";
            this.tsSearchLineItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsTransactions
            // 
            this.tsTransactions.Image = ((System.Drawing.Image)(resources.GetObject("tsTransactions.Image")));
            this.tsTransactions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTransactions.Margin = new System.Windows.Forms.Padding(6);
            this.tsTransactions.Name = "tsTransactions";
            this.tsTransactions.Size = new System.Drawing.Size(88, 43);
            this.tsTransactions.Text = "Transactions";
            this.tsTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(883, 669);
            this.dataGridView1.TabIndex = 4;
            // 
            // ItemSearchPanel
            // 
            this.ItemSearchPanel.Controls.Add(this.button1);
            this.ItemSearchPanel.Controls.Add(this.txtSearchthree);
            this.ItemSearchPanel.Controls.Add(this.txtSearchTwo);
            this.ItemSearchPanel.Controls.Add(this.txtSearchOne);
            this.ItemSearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemSearchPanel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 35);
            this.ItemSearchPanel.Name = "ItemSearchPanel";
            this.ItemSearchPanel.Size = new System.Drawing.Size(883, 57);
            this.ItemSearchPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchthree
            // 
            this.txtSearchthree.Location = new System.Drawing.Point(335, 19);
            this.txtSearchthree.Name = "txtSearchthree";
            this.txtSearchthree.Size = new System.Drawing.Size(160, 23);
            this.txtSearchthree.TabIndex = 2;
            // 
            // txtSearchTwo
            // 
            this.txtSearchTwo.Location = new System.Drawing.Point(169, 19);
            this.txtSearchTwo.Name = "txtSearchTwo";
            this.txtSearchTwo.Size = new System.Drawing.Size(160, 23);
            this.txtSearchTwo.TabIndex = 1;
            // 
            // txtSearchOne
            // 
            this.txtSearchOne.Location = new System.Drawing.Point(3, 19);
            this.txtSearchOne.Name = "txtSearchOne";
            this.txtSearchOne.Size = new System.Drawing.Size(160, 23);
            this.txtSearchOne.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.ItemSearchPanel);
            this.splitContainer1.Size = new System.Drawing.Size(987, 726);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 5;
            // 
            // StockManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "StockManagerControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(999, 738);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ItemSearchPanel.ResumeLayout(false);
            this.ItemSearchPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSearchLineItems;
        private System.Windows.Forms.ToolStripButton tsTransactions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ItemSearchPanel;
        private System.Windows.Forms.TextBox txtSearchthree;
        private System.Windows.Forms.TextBox txtSearchTwo;
        private System.Windows.Forms.TextBox txtSearchOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
