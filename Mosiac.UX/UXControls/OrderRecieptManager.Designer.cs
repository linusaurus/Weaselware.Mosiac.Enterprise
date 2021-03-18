
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
            this.spcMainContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgPendingOrders = new System.Windows.Forms.DataGridView();
            this.dgOrderReceiptItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.btnProccessInventory = new System.Windows.Forms.Button();
            this.btnLoadOrderReciept = new System.Windows.Forms.Button();
            this.txtPurchaseOrderID = new System.Windows.Forms.TextBox();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.txtOrderReceiptID = new System.Windows.Forms.TextBox();
            this.txtOrderReceiptDate = new System.Windows.Forms.TextBox();
            this.ckbCompleted = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).BeginInit();
            this.spcMainContainer.Panel1.SuspendLayout();
            this.spcMainContainer.Panel2.SuspendLayout();
            this.spcMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // spcMainContainer
            // 
            this.spcMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcMainContainer.Location = new System.Drawing.Point(6, 160);
            this.spcMainContainer.Name = "spcMainContainer";
            // 
            // spcMainContainer.Panel1
            // 
            this.spcMainContainer.Panel1.Controls.Add(this.splitContainer2);
            // 
            // spcMainContainer.Panel2
            // 
            this.spcMainContainer.Panel2.Controls.Add(this.dgOrderReceiptItems);
            this.spcMainContainer.Size = new System.Drawing.Size(1118, 560);
            this.spcMainContainer.SplitterDistance = 300;
            this.spcMainContainer.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgPendingOrders);
            this.splitContainer2.Size = new System.Drawing.Size(300, 560);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgPendingOrders
            // 
            this.dgPendingOrders.AllowUserToAddRows = false;
            this.dgPendingOrders.AllowUserToDeleteRows = false;
            this.dgPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPendingOrders.Location = new System.Drawing.Point(0, 0);
            this.dgPendingOrders.Name = "dgPendingOrders";
            this.dgPendingOrders.ReadOnly = true;
            this.dgPendingOrders.RowHeadersVisible = false;
            this.dgPendingOrders.RowTemplate.Height = 25;
            this.dgPendingOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPendingOrders.Size = new System.Drawing.Size(300, 336);
            this.dgPendingOrders.TabIndex = 0;
            // 
            // dgOrderReceiptItems
            // 
            this.dgOrderReceiptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderReceiptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderReceiptItems.Location = new System.Drawing.Point(0, 0);
            this.dgOrderReceiptItems.Name = "dgOrderReceiptItems";
            this.dgOrderReceiptItems.RowTemplate.Height = 25;
            this.dgOrderReceiptItems.Size = new System.Drawing.Size(814, 560);
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
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(6, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveOrder.Location = new System.Drawing.Point(6, 40);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(116, 34);
            this.btnReceiveOrder.TabIndex = 2;
            this.btnReceiveOrder.Text = "Load Order";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // btnProccessInventory
            // 
            this.btnProccessInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProccessInventory.Location = new System.Drawing.Point(145, 120);
            this.btnProccessInventory.Name = "btnProccessInventory";
            this.btnProccessInventory.Size = new System.Drawing.Size(161, 34);
            this.btnProccessInventory.TabIndex = 2;
            this.btnProccessInventory.Text = "Process";
            this.btnProccessInventory.UseVisualStyleBackColor = true;
            // 
            // btnLoadOrderReciept
            // 
            this.btnLoadOrderReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadOrderReciept.Location = new System.Drawing.Point(145, 80);
            this.btnLoadOrderReciept.Name = "btnLoadOrderReciept";
            this.btnLoadOrderReciept.Size = new System.Drawing.Size(161, 34);
            this.btnLoadOrderReciept.TabIndex = 2;
            this.btnLoadOrderReciept.Text = "Load Order Receipt";
            this.btnLoadOrderReciept.UseVisualStyleBackColor = true;
            this.btnLoadOrderReciept.Click += new System.EventHandler(this.btnLoadOrderReciept_Click);
            // 
            // txtPurchaseOrderID
            // 
            this.txtPurchaseOrderID.Location = new System.Drawing.Point(354, 80);
            this.txtPurchaseOrderID.Name = "txtPurchaseOrderID";
            this.txtPurchaseOrderID.ReadOnly = true;
            this.txtPurchaseOrderID.Size = new System.Drawing.Size(129, 23);
            this.txtPurchaseOrderID.TabIndex = 4;
            this.txtPurchaseOrderID.Text = "PurchaseOrderID";
            this.txtPurchaseOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Location = new System.Drawing.Point(775, 80);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.ReadOnly = true;
            this.txtReceivedBy.Size = new System.Drawing.Size(129, 23);
            this.txtReceivedBy.TabIndex = 4;
            this.txtReceivedBy.Text = "Received By";
            this.txtReceivedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiptID
            // 
            this.txtOrderReceiptID.Location = new System.Drawing.Point(489, 80);
            this.txtOrderReceiptID.Name = "txtOrderReceiptID";
            this.txtOrderReceiptID.ReadOnly = true;
            this.txtOrderReceiptID.Size = new System.Drawing.Size(137, 23);
            this.txtOrderReceiptID.TabIndex = 4;
            this.txtOrderReceiptID.Text = "OrderReceiptID";
            this.txtOrderReceiptID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderReceiptDate
            // 
            this.txtOrderReceiptDate.Location = new System.Drawing.Point(632, 80);
            this.txtOrderReceiptDate.Name = "txtOrderReceiptDate";
            this.txtOrderReceiptDate.ReadOnly = true;
            this.txtOrderReceiptDate.Size = new System.Drawing.Size(137, 23);
            this.txtOrderReceiptDate.TabIndex = 4;
            this.txtOrderReceiptDate.Text = "Receipt Date";
            this.txtOrderReceiptDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbCompleted
            // 
            this.ckbCompleted.AutoSize = true;
            this.ckbCompleted.Enabled = false;
            this.ckbCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbCompleted.Location = new System.Drawing.Point(923, 82);
            this.ckbCompleted.Name = "ckbCompleted";
            this.ckbCompleted.Size = new System.Drawing.Size(82, 19);
            this.ckbCompleted.TabIndex = 5;
            this.ckbCompleted.Text = "Completed";
            this.ckbCompleted.UseVisualStyleBackColor = true;
            // 
            // OrderRecieptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbCompleted);
            this.Controls.Add(this.txtOrderReceiptDate);
            this.Controls.Add(this.txtOrderReceiptID);
            this.Controls.Add(this.txtReceivedBy);
            this.Controls.Add(this.txtPurchaseOrderID);
            this.Controls.Add(this.btnReceiveOrder);
            this.Controls.Add(this.btnLoadOrderReciept);
            this.Controls.Add(this.btnProccessInventory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.spcMainContainer);
            this.Name = "OrderRecieptManager";
            this.Padding = new System.Windows.Forms.Padding(6, 160, 6, 6);
            this.Size = new System.Drawing.Size(1130, 726);
            this.spcMainContainer.Panel1.ResumeLayout(false);
            this.spcMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).EndInit();
            this.spcMainContainer.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer spcMainContainer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgPendingOrders;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.DataGridView dgOrderReceiptItems;
        private System.Windows.Forms.Button btnProccessInventory;
        private System.Windows.Forms.Button btnLoadOrderReciept;
        private System.Windows.Forms.TextBox txtPurchaseOrderID;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.TextBox txtOrderReceiptID;
        private System.Windows.Forms.TextBox txtOrderReceiptDate;
        private System.Windows.Forms.CheckBox ckbCompleted;
    }
}
