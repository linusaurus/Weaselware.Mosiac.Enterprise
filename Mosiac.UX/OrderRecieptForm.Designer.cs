
namespace Mosiac.UX
{
    partial class OrderRecieptForm
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
            this.dgOrderReceiptItemGrid = new System.Windows.Forms.DataGridView();
            this.tsOrderReceipts = new System.Windows.Forms.ToolStrip();
            this.tsSubmit = new System.Windows.Forms.ToolStripButton();
            this.tsCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPrintLabels = new System.Windows.Forms.ToolStripButton();
            this.tsBottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsCollapse = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItemGrid)).BeginInit();
            this.tsOrderReceipts.SuspendLayout();
            this.tsBottomToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOrderReceiptItemGrid
            // 
            this.dgOrderReceiptItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderReceiptItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderReceiptItemGrid.Location = new System.Drawing.Point(0, 0);
            this.dgOrderReceiptItemGrid.Name = "dgOrderReceiptItemGrid";
            this.dgOrderReceiptItemGrid.RowTemplate.Height = 25;
            this.dgOrderReceiptItemGrid.Size = new System.Drawing.Size(1083, 558);
            this.dgOrderReceiptItemGrid.TabIndex = 0;
            this.dgOrderReceiptItemGrid.SelectionChanged += new System.EventHandler(this.dgOrderReceiptItemGrid_SelectionChanged);
            // 
            // tsOrderReceipts
            // 
            this.tsOrderReceipts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSubmit,
            this.tsCancel,
            this.toolStripSeparator1,
            this.tsPrintLabels});
            this.tsOrderReceipts.Location = new System.Drawing.Point(0, 0);
            this.tsOrderReceipts.Name = "tsOrderReceipts";
            this.tsOrderReceipts.Size = new System.Drawing.Size(1083, 25);
            this.tsOrderReceipts.TabIndex = 1;
            this.tsOrderReceipts.Text = "toolStrip1";
            this.tsOrderReceipts.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsOrderReceipts_ItemClicked);
            // 
            // tsSubmit
            // 
            this.tsSubmit.Image = global::Mosiac.UX.Properties.Resources.baseline_done_black_24dp;
            this.tsSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSubmit.Name = "tsSubmit";
            this.tsSubmit.Size = new System.Drawing.Size(65, 22);
            this.tsSubmit.Text = "Submit";
            // 
            // tsCancel
            // 
            this.tsCancel.Image = global::Mosiac.UX.Properties.Resources.baseline_clear_black_24dp1;
            this.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancel.Name = "tsCancel";
            this.tsCancel.Size = new System.Drawing.Size(63, 22);
            this.tsCancel.Text = "Cancel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsPrintLabels
            // 
            this.tsPrintLabels.Image = global::Mosiac.UX.Properties.Resources.round_print_black_24dp;
            this.tsPrintLabels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrintLabels.Name = "tsPrintLabels";
            this.tsPrintLabels.Size = new System.Drawing.Size(143, 22);
            this.tsPrintLabels.Text = "Print Selected Label(s)";
            // 
            // tsBottomToolStrip
            // 
            this.tsBottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCollapse});
            this.tsBottomToolStrip.Location = new System.Drawing.Point(0, 583);
            this.tsBottomToolStrip.Name = "tsBottomToolStrip";
            this.tsBottomToolStrip.Size = new System.Drawing.Size(1083, 25);
            this.tsBottomToolStrip.TabIndex = 3;
            this.tsBottomToolStrip.Text = "toolStrip1";
            this.tsBottomToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsBottomToolStrip_ItemClicked);
            // 
            // tsCollapse
            // 
            this.tsCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCollapse.Image = global::Mosiac.UX.Properties.Resources.round_keyboard_arrow_up_black_24dp;
            this.tsCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCollapse.Name = "tsCollapse";
            this.tsCollapse.Size = new System.Drawing.Size(23, 22);
            this.tsCollapse.Text = "toolStripButton1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgOrderReceiptItemGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(1083, 558);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 4;
            // 
            // OrderRecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 608);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsBottomToolStrip);
            this.Controls.Add(this.tsOrderReceipts);
            this.Name = "OrderRecieptForm";
            this.Text = "OrderRecieptForm";
            this.Load += new System.EventHandler(this.OrderRecieptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItemGrid)).EndInit();
            this.tsOrderReceipts.ResumeLayout(false);
            this.tsOrderReceipts.PerformLayout();
            this.tsBottomToolStrip.ResumeLayout(false);
            this.tsBottomToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderReceiptItemGrid;
        private System.Windows.Forms.ToolStrip tsOrderReceipts;
        private System.Windows.Forms.ToolStripButton tsSubmit;
        private System.Windows.Forms.ToolStripButton tsCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsPrintLabels;
        private System.Windows.Forms.ToolStrip tsBottomToolStrip;
        private System.Windows.Forms.ToolStripButton tsCollapse;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}