
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
            this.dgPendingOrders = new System.Windows.Forms.DataGridView();
            this.dgOrderReceiptItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.btnProccessInventory = new System.Windows.Forms.Button();
            this.txtPurchaseOrderID = new System.Windows.Forms.TextBox();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.txtOrderReceiptID = new System.Windows.Forms.TextBox();
            this.txtOrderReceiptDate = new System.Windows.Forms.TextBox();
            this.ckbCompleted = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).BeginInit();
            this.spcMainContainer.Panel1.SuspendLayout();
            this.spcMainContainer.Panel2.SuspendLayout();
            this.spcMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.spcMainContainer.Panel1.Controls.Add(this.dgPendingOrders);
            // 
            // spcMainContainer.Panel2
            // 
            this.spcMainContainer.Panel2.Controls.Add(this.dgOrderReceiptItems);
            this.spcMainContainer.Size = new System.Drawing.Size(1118, 560);
            this.spcMainContainer.SplitterDistance = 300;
            this.spcMainContainer.TabIndex = 1;
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
            this.dgPendingOrders.Size = new System.Drawing.Size(300, 560);
            this.dgPendingOrders.TabIndex = 0;
            // 
            // dgOrderReceiptItems
            // 
            this.dgOrderReceiptItems.AllowUserToAddRows = false;
            this.dgOrderReceiptItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.btnSave.Location = new System.Drawing.Point(173, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveOrder.Location = new System.Drawing.Point(15, 108);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(133, 36);
            this.btnReceiveOrder.TabIndex = 2;
            this.btnReceiveOrder.Text = "Open Order Receipt";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // btnProccessInventory
            // 
            this.btnProccessInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProccessInventory.Location = new System.Drawing.Point(6, 34);
            this.btnProccessInventory.Name = "btnProccessInventory";
            this.btnProccessInventory.Size = new System.Drawing.Size(133, 36);
            this.btnProccessInventory.TabIndex = 2;
            this.btnProccessInventory.Text = "Process Inventory";
            this.btnProccessInventory.UseVisualStyleBackColor = true;
            // 
            // txtPurchaseOrderID
            // 
            this.txtPurchaseOrderID.Location = new System.Drawing.Point(7, 46);
            this.txtPurchaseOrderID.Name = "txtPurchaseOrderID";
            this.txtPurchaseOrderID.ReadOnly = true;
            this.txtPurchaseOrderID.Size = new System.Drawing.Size(129, 23);
            this.txtPurchaseOrderID.TabIndex = 4;
            this.txtPurchaseOrderID.Text = "PurchaseOrderID";
            this.txtPurchaseOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbCompleted);
            this.groupBox1.Controls.Add(this.txtOrderReceiptDate);
            this.groupBox1.Controls.Add(this.txtOrderReceiptID);
            this.groupBox1.Controls.Add(this.txtReceivedBy);
            this.groupBox1.Controls.Add(this.txtPurchaseOrderID);
            this.groupBox1.Location = new System.Drawing.Point(312, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Receipt";
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
            // OrderRecieptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReceiveOrder);
            this.Controls.Add(this.btnProccessInventory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.spcMainContainer);
            this.Name = "OrderRecieptManager";
            this.Padding = new System.Windows.Forms.Padding(6, 160, 6, 6);
            this.Size = new System.Drawing.Size(1130, 726);
            this.Load += new System.EventHandler(this.OrderRecieptManager_Load);
            this.spcMainContainer.Panel1.ResumeLayout(false);
            this.spcMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).EndInit();
            this.spcMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPendingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spcMainContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgPendingOrders;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.DataGridView dgOrderReceiptItems;
        private System.Windows.Forms.Button btnProccessInventory;
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
    }
}
