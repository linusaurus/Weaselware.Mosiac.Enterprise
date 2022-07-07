
namespace Mosiac.UX.UXControls
{
    partial class OrderRecieptManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRecieptManager));
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbOrderReciept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOpenOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintReceipt = new System.Windows.Forms.ToolStripButton();
            this.tsPrintSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFilterCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsSearchEntry = new System.Windows.Forms.ToolStripTextBox();
            this.tsRequestStatus = new System.Windows.Forms.ToolStripButton();
            this.dgPendingOrders = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgOrderLineItems = new System.Windows.Forms.DataGridView();
            this.orToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsOrderComplete";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Complete";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ReceiptDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // orToolStrip
            // 
            this.orToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.orToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOrderReciept,
            this.toolStripSeparator1,
            this.tsOpenOrder,
            this.tsbPrintReceipt,
            this.tsPrintSettings,
            this.toolStripSeparator2,
            this.tsbFilterCombo,
            this.toolStripLabel1,
            this.tsSearchEntry,
            this.tsRequestStatus});
            this.orToolStrip.Location = new System.Drawing.Point(6, 6);
            this.orToolStrip.Name = "orToolStrip";
            this.orToolStrip.Size = new System.Drawing.Size(1160, 33);
            this.orToolStrip.TabIndex = 2;
            this.orToolStrip.Text = "toolStrip1";
            this.orToolStrip.Click += new System.EventHandler(this.orToolStrip_Click);
            // 
            // tsbOrderReciept
            // 
            this.tsbOrderReciept.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrderReciept.Image")));
            this.tsbOrderReciept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrderReciept.Name = "tsbOrderReciept";
            this.tsbOrderReciept.Size = new System.Drawing.Size(155, 30);
            this.tsbOrderReciept.Text = "Receive Selected Order";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsOpenOrder
            // 
            this.tsOpenOrder.Image = global::Mosiac.UX.Properties.Resources.baseline_launch_black_24dp;
            this.tsOpenOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenOrder.Name = "tsOpenOrder";
            this.tsOpenOrder.Size = new System.Drawing.Size(144, 30);
            this.tsOpenOrder.Text = "Open Selected Order";
            // 
            // tsbPrintReceipt
            // 
            this.tsbPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintReceipt.Image")));
            this.tsbPrintReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintReceipt.Name = "tsbPrintReceipt";
            this.tsbPrintReceipt.Size = new System.Drawing.Size(102, 30);
            this.tsbPrintReceipt.Text = "Print Receipt";
            // 
            // tsPrintSettings
            // 
            this.tsPrintSettings.Image = global::Mosiac.UX.Properties.Resources.Settings_Settings_11;
            this.tsPrintSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrintSettings.Name = "tsPrintSettings";
            this.tsPrintSettings.Size = new System.Drawing.Size(105, 30);
            this.tsPrintSettings.Text = "Print Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbFilterCombo
            // 
            this.tsbFilterCombo.Items.AddRange(new object[] {
            "Pending",
            "InComplete",
            "30 day",
            "60 day"});
            this.tsbFilterCombo.Name = "tsbFilterCombo";
            this.tsbFilterCombo.Size = new System.Drawing.Size(121, 33);
            this.tsbFilterCombo.SelectedIndexChanged += new System.EventHandler(this.tsbFilterCombo_SelectedIndexChanged);
            this.tsbFilterCombo.Click += new System.EventHandler(this.tsbFilterCombo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 30);
            this.toolStripLabel1.Text = "Search by Order#";
            // 
            // tsSearchEntry
            // 
            this.tsSearchEntry.Margin = new System.Windows.Forms.Padding(12, 2, 1, 2);
            this.tsSearchEntry.Name = "tsSearchEntry";
            this.tsSearchEntry.Size = new System.Drawing.Size(100, 29);
            // 
            // tsRequestStatus
            // 
            this.tsRequestStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsRequestStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.tsRequestStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsRequestStatus.Image = ((System.Drawing.Image)(resources.GetObject("tsRequestStatus.Image")));
            this.tsRequestStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRequestStatus.Margin = new System.Windows.Forms.Padding(0, 1, 0, 4);
            this.tsRequestStatus.Name = "tsRequestStatus";
            this.tsRequestStatus.Size = new System.Drawing.Size(145, 28);
            this.tsRequestStatus.Text = "Request Order Status";
            // 
            // dgPendingOrders
            // 
            this.dgPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPendingOrders.Location = new System.Drawing.Point(0, 0);
            this.dgPendingOrders.Name = "dgPendingOrders";
            this.dgPendingOrders.RowTemplate.Height = 25;
            this.dgPendingOrders.Size = new System.Drawing.Size(1160, 461);
            this.dgPendingOrders.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 39);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgPendingOrders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgOrderLineItems);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 720);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 16;
            this.splitContainer1.TabIndex = 4;
            // 
            // dgOrderLineItems
            // 
            this.dgOrderLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderLineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderLineItems.Location = new System.Drawing.Point(0, 0);
            this.dgOrderLineItems.Name = "dgOrderLineItems";
            this.dgOrderLineItems.Size = new System.Drawing.Size(1160, 243);
            this.dgOrderLineItems.TabIndex = 0;
            // 
            // OrderRecieptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.orToolStrip);
            this.Name = "OrderRecieptManager";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1172, 765);
            this.Load += new System.EventHandler(this.OrderRecieptManager_Load);
            this.orToolStrip.ResumeLayout(false);
            this.orToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip orToolStrip;
        private System.Windows.Forms.ToolStripButton tsbOrderReciept;
        private System.Windows.Forms.ToolStripButton tsbPrintReceipt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgPendingOrders;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgOrderLineItems;
        private System.Windows.Forms.ToolStripButton tsOpenOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tsbFilterCombo;
        private System.Windows.Forms.ToolStripTextBox tsSearchEntry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsPrintSettings;
        private System.Windows.Forms.ToolStripButton tsRequestStatus;
    }
}
