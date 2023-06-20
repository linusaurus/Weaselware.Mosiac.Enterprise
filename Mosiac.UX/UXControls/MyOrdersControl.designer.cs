namespace Mosiac.UX.UXControls
{
    partial class MyOrdersControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dgMyOrdersGrid = new System.Windows.Forms.DataGridView();
            colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRecieved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            rbOutStanding = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbShowReturned = new System.Windows.Forms.RadioButton();
            rbShowAll = new System.Windows.Forms.RadioButton();
            rbShowReceived = new System.Windows.Forms.RadioButton();
            ckbShowAll = new System.Windows.Forms.CheckBox();
            btnOpenOrder = new System.Windows.Forms.Button();
            txtOrderNumber = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cbJobName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgMyOrdersGrid).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgMyOrdersGrid
            // 
            dgMyOrdersGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgMyOrdersGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dgMyOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMyOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOrderNum, colOrderDate, colSupplier, colJobName, colOrderTotal, colRecieved });
            dgMyOrdersGrid.Location = new System.Drawing.Point(12, 107);
            dgMyOrdersGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgMyOrdersGrid.Name = "dgMyOrdersGrid";
            dgMyOrdersGrid.Size = new System.Drawing.Size(1222, 767);
            dgMyOrdersGrid.TabIndex = 0;
            dgMyOrdersGrid.SelectionChanged += dgMyOrdersGrid_SelectionChanged;
            dgMyOrdersGrid.MouseDoubleClick += dgMyOrdersGrid_MouseDoubleClick;
            // 
            // colOrderNum
            // 
            colOrderNum.DataPropertyName = "PurchaseOrderID";
            colOrderNum.HeaderText = "Order#";
            colOrderNum.Name = "colOrderNum";
            // 
            // colOrderDate
            // 
            colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            colOrderDate.HeaderText = "Order Date";
            colOrderDate.Name = "colOrderDate";
            // 
            // colSupplier
            // 
            colSupplier.DataPropertyName = "Supplier";
            colSupplier.HeaderText = "Supplier";
            colSupplier.Name = "colSupplier";
            colSupplier.Width = 200;
            // 
            // colJobName
            // 
            colJobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colJobName.DataPropertyName = "JobName";
            colJobName.HeaderText = "Jobname";
            colJobName.Name = "colJobName";
            // 
            // colOrderTotal
            // 
            colOrderTotal.DataPropertyName = "OrderTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            colOrderTotal.DefaultCellStyle = dataGridViewCellStyle2;
            colOrderTotal.HeaderText = "Total";
            colOrderTotal.Name = "colOrderTotal";
            colOrderTotal.Width = 125;
            // 
            // colRecieved
            // 
            colRecieved.DataPropertyName = "Recieved";
            colRecieved.HeaderText = "Received";
            colRecieved.Name = "colRecieved";
            colRecieved.Width = 75;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(ckbShowAll);
            panel1.Controls.Add(btnOpenOrder);
            panel1.Controls.Add(txtOrderNumber);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbJobName);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1220, 89);
            panel1.TabIndex = 1;
            // 
            // rbOutStanding
            // 
            rbOutStanding.AutoSize = true;
            rbOutStanding.Location = new System.Drawing.Point(6, 51);
            rbOutStanding.Name = "rbOutStanding";
            rbOutStanding.Size = new System.Drawing.Size(123, 19);
            rbOutStanding.TabIndex = 5;
            rbOutStanding.TabStop = true;
            rbOutStanding.Text = "Show Outstanding";
            rbOutStanding.UseVisualStyleBackColor = true;
            rbOutStanding.CheckedChanged += rbOutStanding_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOutStanding);
            groupBox1.Controls.Add(rbShowReturned);
            groupBox1.Controls.Add(rbShowAll);
            groupBox1.Controls.Add(rbShowReceived);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(489, 81);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // rbShowReturned
            // 
            rbShowReturned.AutoSize = true;
            rbShowReturned.Location = new System.Drawing.Point(254, 28);
            rbShowReturned.Name = "rbShowReturned";
            rbShowReturned.Size = new System.Drawing.Size(105, 19);
            rbShowReturned.TabIndex = 4;
            rbShowReturned.TabStop = true;
            rbShowReturned.Text = "Show Returned";
            rbShowReturned.UseVisualStyleBackColor = true;
            rbShowReturned.CheckedChanged += rbShowReturned_CheckedChanged;
            // 
            // rbShowAll
            // 
            rbShowAll.AutoSize = true;
            rbShowAll.Location = new System.Drawing.Point(163, 27);
            rbShowAll.Name = "rbShowAll";
            rbShowAll.Size = new System.Drawing.Size(71, 19);
            rbShowAll.TabIndex = 3;
            rbShowAll.TabStop = true;
            rbShowAll.Text = "Show All";
            rbShowAll.UseVisualStyleBackColor = true;
            rbShowAll.CheckedChanged += rbShowAll_CheckedChanged;
            // 
            // rbShowReceived
            // 
            rbShowReceived.AutoSize = true;
            rbShowReceived.Location = new System.Drawing.Point(6, 26);
            rbShowReceived.Name = "rbShowReceived";
            rbShowReceived.Size = new System.Drawing.Size(142, 19);
            rbShowReceived.TabIndex = 2;
            rbShowReceived.TabStop = true;
            rbShowReceived.Text = "Show Received Orders";
            rbShowReceived.UseVisualStyleBackColor = true;
            rbShowReceived.CheckedChanged += rbShowReceived_CheckedChanged;
            // 
            // ckbShowAll
            // 
            ckbShowAll.AutoSize = true;
            ckbShowAll.Location = new System.Drawing.Point(765, 29);
            ckbShowAll.Name = "ckbShowAll";
            ckbShowAll.Size = new System.Drawing.Size(132, 19);
            ckbShowAll.TabIndex = 6;
            ckbShowAll.Text = "Show All Purchasers";
            ckbShowAll.UseVisualStyleBackColor = true;
            ckbShowAll.CheckedChanged += ckbShowAll_CheckedChanged;
            // 
            // btnOpenOrder
            // 
            btnOpenOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btnOpenOrder.FlatAppearance.BorderSize = 3;
            btnOpenOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenOrder.Location = new System.Drawing.Point(1065, 22);
            btnOpenOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOpenOrder.Name = "btnOpenOrder";
            btnOpenOrder.Size = new System.Drawing.Size(106, 31);
            btnOpenOrder.TabIndex = 5;
            btnOpenOrder.Text = "Open Order";
            btnOpenOrder.UseVisualStyleBackColor = true;
            btnOpenOrder.Click += btnOpenOrder_Click;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new System.Drawing.Point(941, 27);
            txtOrderNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new System.Drawing.Size(116, 23);
            txtOrderNumber.TabIndex = 4;
            txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(499, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Employee";
            // 
            // cbJobName
            // 
            cbJobName.FormattingEnabled = true;
            cbJobName.Location = new System.Drawing.Point(576, 27);
            cbJobName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbJobName.Name = "cbJobName";
            cbJobName.Size = new System.Drawing.Size(173, 23);
            cbJobName.TabIndex = 2;
            cbJobName.SelectedIndexChanged += cbJobName_SelectedIndexChanged;
            // 
            // MyOrdersControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(dgMyOrdersGrid);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MyOrdersControl";
            Padding = new System.Windows.Forms.Padding(12);
            Size = new System.Drawing.Size(1244, 886);
            Load += MyOrdersControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgMyOrdersGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgMyOrdersGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbJobName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenOrder;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.CheckBox ckbShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRecieved;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbShowReturned;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbShowReceived;
        private System.Windows.Forms.RadioButton rbOutStanding;
    }
}
