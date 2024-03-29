﻿
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
            this.tsbPrintReceipt = new System.Windows.Forms.ToolStripButton();
            this.dgPendingOrders = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgOrderLineItems = new System.Windows.Forms.DataGridView();
            this.tsOpenOrder = new System.Windows.Forms.ToolStripButton();
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
            this.tsbPrintReceipt});
            this.orToolStrip.Location = new System.Drawing.Point(6, 6);
            this.orToolStrip.Name = "orToolStrip";
            this.orToolStrip.Size = new System.Drawing.Size(1160, 31);
            this.orToolStrip.TabIndex = 2;
            this.orToolStrip.Text = "toolStrip1";
            this.orToolStrip.Click += new System.EventHandler(this.orToolStrip_Click);
            // 
            // tsbOrderReciept
            // 
            this.tsbOrderReciept.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrderReciept.Image")));
            this.tsbOrderReciept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrderReciept.Name = "tsbOrderReciept";
            this.tsbOrderReciept.Size = new System.Drawing.Size(155, 28);
            this.tsbOrderReciept.Text = "Receive Selected Order";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbPrintReceipt
            // 
            this.tsbPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintReceipt.Image")));
            this.tsbPrintReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintReceipt.Name = "tsbPrintReceipt";
            this.tsbPrintReceipt.Size = new System.Drawing.Size(102, 28);
            this.tsbPrintReceipt.Text = "Print Receipt";
            // 
            // dgPendingOrders
            // 
            this.dgPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPendingOrders.Location = new System.Drawing.Point(0, 0);
            this.dgPendingOrders.Name = "dgPendingOrders";
            this.dgPendingOrders.RowTemplate.Height = 25;
            this.dgPendingOrders.Size = new System.Drawing.Size(1160, 463);
            this.dgPendingOrders.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 37);
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
            this.splitContainer1.Size = new System.Drawing.Size(1160, 722);
            this.splitContainer1.SplitterDistance = 463;
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
            // tsOpenOrder
            // 
            this.tsOpenOrder.Image = global::Mosiac.UX.Properties.Resources.baseline_launch_black_24dp;
            this.tsOpenOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenOrder.Name = "tsOpenOrder";
            this.tsOpenOrder.Size = new System.Drawing.Size(144, 28);
            this.tsOpenOrder.Text = "Open Selected Order";
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
    }
}
