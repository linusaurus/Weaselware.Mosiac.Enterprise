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
            this.spcMainContainer = new System.Windows.Forms.SplitContainer();
            this.dgPendingOrders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.rbPartialReceieved = new System.Windows.Forms.RadioButton();
            this.rbNotRecieved = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbCompleted = new System.Windows.Forms.CheckBox();
            this.txtOrderReceiptDate = new System.Windows.Forms.TextBox();
            this.txtOrderReceiptID = new System.Windows.Forms.TextBox();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.txtPurchaseOrderID = new System.Windows.Forms.TextBox();
            this.dgOrderReceiptItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.tsbOrderReciept = new System.Windows.Forms.ToolStripButton();
            this.tsbProccessInventory = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintReceipt = new System.Windows.Forms.ToolStripButton();
            this.tsbBarCode = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).BeginInit();
            this.spcMainContainer.Panel1.SuspendLayout();
            this.spcMainContainer.Panel2.SuspendLayout();
            this.spcMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).BeginInit();
            this.orToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMainContainer
            // 
            this.spcMainContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.spcMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcMainContainer.Location = new System.Drawing.Point(6, 37);
            this.spcMainContainer.Name = "spcMainContainer";
            // 
            // spcMainContainer.Panel1
            // 
            this.spcMainContainer.Panel1.Controls.Add(this.dgPendingOrders);
            this.spcMainContainer.Panel1.Controls.Add(this.panel1);
            this.spcMainContainer.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // spcMainContainer.Panel2
            // 
            this.spcMainContainer.Panel2.Controls.Add(this.panel2);
            this.spcMainContainer.Panel2.Controls.Add(this.dgOrderReceiptItems);
            this.spcMainContainer.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.spcMainContainer.Size = new System.Drawing.Size(1111, 683);
            this.spcMainContainer.SplitterDistance = 300;
            this.spcMainContainer.TabIndex = 1;
            // 
            // dgPendingOrders
            // 
            this.dgPendingOrders.AllowUserToAddRows = false;
            this.dgPendingOrders.AllowUserToDeleteRows = false;
            this.dgPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPendingOrders.Location = new System.Drawing.Point(6, 126);
            this.dgPendingOrders.Name = "dgPendingOrders";
            this.dgPendingOrders.ReadOnly = true;
            this.dgPendingOrders.RowHeadersVisible = false;
            this.dgPendingOrders.RowTemplate.Height = 25;
            this.dgPendingOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPendingOrders.Size = new System.Drawing.Size(288, 551);
            this.dgPendingOrders.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFilters);
            this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(288, 120);
            this.panel1.TabIndex = 1;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.rbComplete);
            this.gbFilters.Controls.Add(this.rbPartialReceieved);
            this.gbFilters.Controls.Add(this.rbNotRecieved);
            this.gbFilters.Location = new System.Drawing.Point(3, 8);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(282, 100);
            this.gbFilters.TabIndex = 0;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // rbComplete
            // 
            this.rbComplete.AutoSize = true;
            this.rbComplete.Location = new System.Drawing.Point(19, 72);
            this.rbComplete.Name = "rbComplete";
            this.rbComplete.Size = new System.Drawing.Size(77, 19);
            this.rbComplete.TabIndex = 0;
            this.rbComplete.Text = "Complete";
            this.rbComplete.UseVisualStyleBackColor = true;
            this.rbComplete.CheckedChanged += new System.EventHandler(this.rbComplete_CheckedChanged);
            // 
            // rbPartialReceieved
            // 
            this.rbPartialReceieved.AutoSize = true;
            this.rbPartialReceieved.Location = new System.Drawing.Point(19, 47);
            this.rbPartialReceieved.Name = "rbPartialReceieved";
            this.rbPartialReceieved.Size = new System.Drawing.Size(85, 19);
            this.rbPartialReceieved.TabIndex = 0;
            this.rbPartialReceieved.Text = "Incomplete";
            this.rbPartialReceieved.UseVisualStyleBackColor = true;
            // 
            // rbNotRecieved
            // 
            this.rbNotRecieved.AutoSize = true;
            this.rbNotRecieved.Checked = true;
            this.rbNotRecieved.Location = new System.Drawing.Point(19, 22);
            this.rbNotRecieved.Name = "rbNotRecieved";
            this.rbNotRecieved.Size = new System.Drawing.Size(95, 19);
            this.rbNotRecieved.TabIndex = 0;
            this.rbNotRecieved.TabStop = true;
            this.rbNotRecieved.Text = "Not Recieved";
            this.rbNotRecieved.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 120);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbCompleted);
            this.groupBox1.Controls.Add(this.txtOrderReceiptDate);
            this.groupBox1.Controls.Add(this.txtOrderReceiptID);
            this.groupBox1.Controls.Add(this.txtReceivedBy);
            this.groupBox1.Controls.Add(this.txtPurchaseOrderID);
            this.groupBox1.Location = new System.Drawing.Point(10, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Receipt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Receiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Receipt Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Receipt #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Purchase Order No.";
            // 
            // ckbCompleted
            // 
            this.ckbCompleted.AutoSize = true;
            this.ckbCompleted.Enabled = false;
            this.ckbCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbCompleted.Location = new System.Drawing.Point(639, 39);
            this.ckbCompleted.Name = "ckbCompleted";
            this.ckbCompleted.Size = new System.Drawing.Size(82, 19);
            this.ckbCompleted.TabIndex = 5;
            this.ckbCompleted.Text = "Completed";
            this.ckbCompleted.UseVisualStyleBackColor = true;
            // 
            // txtOrderReceiptDate
            // 
            this.txtOrderReceiptDate.Location = new System.Drawing.Point(285, 46);
            this.txtOrderReceiptDate.Name = "txtOrderReceiptDate";
            this.txtOrderReceiptDate.ReadOnly = true;
            this.txtOrderReceiptDate.Size = new System.Drawing.Size(137, 23);
            this.txtOrderReceiptDate.TabIndex = 4;
            this.txtOrderReceiptDate.Text = "Receipt Date";
            this.txtOrderReceiptDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiptID
            // 
            this.txtOrderReceiptID.Location = new System.Drawing.Point(142, 46);
            this.txtOrderReceiptID.Name = "txtOrderReceiptID";
            this.txtOrderReceiptID.ReadOnly = true;
            this.txtOrderReceiptID.Size = new System.Drawing.Size(137, 23);
            this.txtOrderReceiptID.TabIndex = 4;
            this.txtOrderReceiptID.Text = "OrderReceiptID";
            this.txtOrderReceiptID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Location = new System.Drawing.Point(428, 46);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.ReadOnly = true;
            this.txtReceivedBy.Size = new System.Drawing.Size(129, 23);
            this.txtReceivedBy.TabIndex = 4;
            this.txtReceivedBy.Text = "Received By";
            this.txtReceivedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPurchaseOrderID
            // 
            this.txtPurchaseOrderID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPurchaseOrderID.Location = new System.Drawing.Point(7, 46);
            this.txtPurchaseOrderID.Name = "txtPurchaseOrderID";
            this.txtPurchaseOrderID.ReadOnly = true;
            this.txtPurchaseOrderID.Size = new System.Drawing.Size(129, 23);
            this.txtPurchaseOrderID.TabIndex = 4;
            this.txtPurchaseOrderID.Text = "PurchaseOrderID";
            this.txtPurchaseOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgOrderReceiptItems
            // 
            this.dgOrderReceiptItems.AllowUserToAddRows = false;
            this.dgOrderReceiptItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrderReceiptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderReceiptItems.Location = new System.Drawing.Point(0, 127);
            this.dgOrderReceiptItems.Name = "dgOrderReceiptItems";
            this.dgOrderReceiptItems.RowTemplate.Height = 25;
            this.dgOrderReceiptItems.Size = new System.Drawing.Size(807, 553);
            this.dgOrderReceiptItems.TabIndex = 0;
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
            this.orToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveChanges,
            this.tsbOrderReciept,
            this.tsbProccessInventory,
            this.tsbPrintReceipt,
            this.tsbBarCode});
            this.orToolStrip.Location = new System.Drawing.Point(6, 6);
            this.orToolStrip.Name = "orToolStrip";
            this.orToolStrip.Size = new System.Drawing.Size(1111, 31);
            this.orToolStrip.TabIndex = 2;
            this.orToolStrip.Text = "toolStrip1";
            this.orToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.orToolStrip_ItemClicked);
            this.orToolStrip.Click += new System.EventHandler(this.orToolStrip_Click);
            // 
            // tsSaveChanges
            // 
            this.tsSaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveChanges.Image")));
            this.tsSaveChanges.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveChanges.Name = "tsSaveChanges";
            this.tsSaveChanges.Size = new System.Drawing.Size(108, 28);
            this.tsSaveChanges.Text = "Save Changes";
            // 
            // tsbOrderReciept
            // 
            this.tsbOrderReciept.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrderReciept.Image")));
            this.tsbOrderReciept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrderReciept.Name = "tsbOrderReciept";
            this.tsbOrderReciept.Size = new System.Drawing.Size(111, 28);
            this.tsbOrderReciept.Text = "Create Receipt";
            // 
            // tsbProccessInventory
            // 
            this.tsbProccessInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsbProccessInventory.Image")));
            this.tsbProccessInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProccessInventory.Name = "tsbProccessInventory";
            this.tsbProccessInventory.Size = new System.Drawing.Size(128, 28);
            this.tsbProccessInventory.Text = "Push to Inventory";
            // 
            // tsbPrintReceipt
            // 
            this.tsbPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintReceipt.Image")));
            this.tsbPrintReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintReceipt.Name = "tsbPrintReceipt";
            this.tsbPrintReceipt.Size = new System.Drawing.Size(102, 28);
            this.tsbPrintReceipt.Text = "Print Receipt";
            // 
            // tsbBarCode
            // 
            this.tsbBarCode.Image = ((System.Drawing.Image)(resources.GetObject("tsbBarCode.Image")));
            this.tsbBarCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBarCode.Name = "tsbBarCode";
            this.tsbBarCode.Size = new System.Drawing.Size(95, 28);
            this.tsbBarCode.Text = "Item Labels";
            // 
            // OrderRecieptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMainContainer);
            this.Controls.Add(this.orToolStrip);
            this.Name = "OrderRecieptManager";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1123, 726);
            this.Load += new System.EventHandler(this.OrderRecieptManager_Load);
            this.spcMainContainer.Panel1.ResumeLayout(false);
            this.spcMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).EndInit();
            this.spcMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).EndInit();
            this.orToolStrip.ResumeLayout(false);
            this.orToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer spcMainContainer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgOrderReceiptItems;
        private System.Windows.Forms.TextBox txtPurchaseOrderID;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.TextBox txtOrderReceiptID;
        private System.Windows.Forms.TextBox txtOrderReceiptDate;
        private System.Windows.Forms.CheckBox ckbCompleted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPendingOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip orToolStrip;
        private System.Windows.Forms.ToolStripButton tsSaveChanges;
        private System.Windows.Forms.ToolStripButton tsbOrderReciept;
        private System.Windows.Forms.ToolStripButton tsbProccessInventory;
        private System.Windows.Forms.ToolStripButton tsbPrintReceipt;
        private System.Windows.Forms.ToolStripButton tsbBarCode;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.RadioButton rbComplete;
        private System.Windows.Forms.RadioButton rbPartialReceieved;
        private System.Windows.Forms.RadioButton rbNotRecieved;
        private System.Windows.Forms.Panel panel2;
    }
}
