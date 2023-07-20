
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
            dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orToolStrip = new System.Windows.Forms.ToolStrip();
            tsbOrderReciept = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsOpenOrder = new System.Windows.Forms.ToolStripButton();
            tsbPrintReceipt = new System.Windows.Forms.ToolStripButton();
            tsPrintSettings = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            tsSearchEntry = new System.Windows.Forms.ToolStripTextBox();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbFilter = new System.Windows.Forms.ToolStripComboBox();
            tsComboSupplier = new System.Windows.Forms.ToolStripComboBox();
            dgPendingOrders = new System.Windows.Forms.DataGridView();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            dgOrderLineItems = new System.Windows.Forms.DataGridView();
            orToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPendingOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderLineItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "IsOrderComplete";
            dataGridViewCheckBoxColumn1.HeaderText = "Complete";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ReceiptDate";
            dataGridViewTextBoxColumn4.HeaderText = "Date";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 95;
            // 
            // orToolStrip
            // 
            orToolStrip.AutoSize = false;
            orToolStrip.BackColor = System.Drawing.SystemColors.Control;
            orToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            orToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbOrderReciept, toolStripSeparator1, tsOpenOrder, tsbPrintReceipt, tsPrintSettings, toolStripSeparator2, toolStripLabel1, tsSearchEntry, toolStripSeparator3, tsbFilter, tsComboSupplier });
            orToolStrip.Location = new System.Drawing.Point(6, 6);
            orToolStrip.Name = "orToolStrip";
            orToolStrip.Size = new System.Drawing.Size(1212, 40);
            orToolStrip.TabIndex = 2;
            orToolStrip.Text = "toolStrip1";
            orToolStrip.Click += orToolStrip_Click;
            // 
            // tsbOrderReciept
            // 
            tsbOrderReciept.AutoSize = false;
            tsbOrderReciept.Image = (System.Drawing.Image)resources.GetObject("tsbOrderReciept.Image");
            tsbOrderReciept.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOrderReciept.Name = "tsbOrderReciept";
            tsbOrderReciept.Size = new System.Drawing.Size(155, 33);
            tsbOrderReciept.Text = "Receive Selected Order";
            tsbOrderReciept.Click += tsbOrderReciept_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // tsOpenOrder
            // 
            tsOpenOrder.Image = Properties.Resources.baseline_launch_black_24dp;
            tsOpenOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsOpenOrder.Name = "tsOpenOrder";
            tsOpenOrder.Size = new System.Drawing.Size(144, 37);
            tsOpenOrder.Text = "Open Selected Order";
            // 
            // tsbPrintReceipt
            // 
            tsbPrintReceipt.Image = (System.Drawing.Image)resources.GetObject("tsbPrintReceipt.Image");
            tsbPrintReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbPrintReceipt.Name = "tsbPrintReceipt";
            tsbPrintReceipt.Size = new System.Drawing.Size(102, 37);
            tsbPrintReceipt.Text = "Print Receipt";
            // 
            // tsPrintSettings
            // 
            tsPrintSettings.Image = Properties.Resources.Settings_Settings_11;
            tsPrintSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsPrintSettings.Name = "tsPrintSettings";
            tsPrintSettings.Size = new System.Drawing.Size(105, 37);
            tsPrintSettings.Text = "Print Settings";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(44, 37);
            toolStripLabel1.Text = "Order#";
            // 
            // tsSearchEntry
            // 
            tsSearchEntry.Margin = new System.Windows.Forms.Padding(12, 2, 1, 2);
            tsSearchEntry.Name = "tsSearchEntry";
            tsSearchEntry.Size = new System.Drawing.Size(90, 36);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // tsbFilter
            // 
            tsbFilter.Items.AddRange(new object[] { "Pending", "InComplete", "30 day" });
            tsbFilter.Name = "tsbFilter";
            tsbFilter.Size = new System.Drawing.Size(141, 40);
            tsbFilter.SelectedIndexChanged += tsbFilterCombo_SelectedIndexChanged;
            // 
            // tsComboSupplier
            // 
            tsComboSupplier.Name = "tsComboSupplier";
            tsComboSupplier.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            tsComboSupplier.Size = new System.Drawing.Size(235, 40);
            tsComboSupplier.SelectedIndexChanged += tsComboSupplier_SelectedIndexChanged;
            // 
            // dgPendingOrders
            // 
            dgPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgPendingOrders.Location = new System.Drawing.Point(0, 0);
            dgPendingOrders.Name = "dgPendingOrders";
            dgPendingOrders.RowTemplate.Height = 25;
            dgPendingOrders.Size = new System.Drawing.Size(1212, 456);
            dgPendingOrders.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(6, 46);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgPendingOrders);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgOrderLineItems);
            splitContainer1.Size = new System.Drawing.Size(1212, 713);
            splitContainer1.SplitterDistance = 456;
            splitContainer1.SplitterWidth = 16;
            splitContainer1.TabIndex = 4;
            // 
            // dgOrderLineItems
            // 
            dgOrderLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderLineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            dgOrderLineItems.Location = new System.Drawing.Point(0, 0);
            dgOrderLineItems.Name = "dgOrderLineItems";
            dgOrderLineItems.Size = new System.Drawing.Size(1212, 241);
            dgOrderLineItems.TabIndex = 0;
            // 
            // OrderRecieptManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(orToolStrip);
            Name = "OrderRecieptManager";
            Padding = new System.Windows.Forms.Padding(6);
            Size = new System.Drawing.Size(1224, 765);
            Load += OrderRecieptManager_Load;
            orToolStrip.ResumeLayout(false);
            orToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPendingOrders).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderLineItems).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripTextBox tsSearchEntry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsPrintSettings;
        private System.Windows.Forms.ToolStripComboBox tsComboSupplier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox tsbFilter;
    }
}
