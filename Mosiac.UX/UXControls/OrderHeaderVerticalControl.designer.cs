namespace Mosiac.UX.UXControls { 
    partial class OrderHeaderVerticalControl
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
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurchaser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAttention = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOtherFees = new System.Windows.Forms.TextBox();
            this.NetTotalLabel = new System.Windows.Forms.Label();
            this.cbTaxable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.POLabel = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lbTaxRate = new System.Windows.Forms.Label();
            this.gbCOst = new System.Windows.Forms.GroupBox();
            this.gbSpecialnstruction = new System.Windows.Forms.GroupBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnJobChange = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFax = new System.Windows.Forms.MaskedTextBox();
            this.btnChangeSupplier = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.gbCOst.SuspendLayout();
            this.gbSpecialnstruction.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(16, 22);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.ReadOnly = true;
            this.txtJobName.Size = new System.Drawing.Size(265, 23);
            this.txtJobName.TabIndex = 19;
            this.txtJobName.Tag = "lock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phone#";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(254, 94);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(109, 23);
            this.txtZip.TabIndex = 11;
            this.txtZip.Tag = "lock";
            this.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(206, 94);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(42, 23);
            this.txtState.TabIndex = 13;
            this.txtState.Tag = "lock";
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(21, 94);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(180, 23);
            this.txtCity.TabIndex = 14;
            this.txtCity.Tag = "lock";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(21, 67);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.ReadOnly = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(342, 23);
            this.txtSupplierAddress.TabIndex = 15;
            this.txtSupplierAddress.Tag = "lock";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(21, 39);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(342, 23);
            this.txtSupplierName.TabIndex = 16;
            this.txtSupplierName.Tag = "lock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchaser";
            // 
            // txtPurchaser
            // 
            this.txtPurchaser.Location = new System.Drawing.Point(75, 78);
            this.txtPurchaser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPurchaser.Name = "txtPurchaser";
            this.txtPurchaser.Size = new System.Drawing.Size(85, 23);
            this.txtPurchaser.TabIndex = 20;
            this.txtPurchaser.Tag = "lock";
            this.txtPurchaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Attn";
            // 
            // txtAttention
            // 
            this.txtAttention.Location = new System.Drawing.Point(207, 78);
            this.txtAttention.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAttention.Name = "txtAttention";
            this.txtAttention.Size = new System.Drawing.Size(135, 23);
            this.txtAttention.TabIndex = 22;
            this.txtAttention.Tag = "lock";
            this.txtAttention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(8, 20);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(329, 53);
            this.txtMemo.TabIndex = 25;
            this.txtMemo.Tag = "lock";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Other Cost/Fees";
            // 
            // txtOtherFees
            // 
            this.txtOtherFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOtherFees.Location = new System.Drawing.Point(221, 64);
            this.txtOtherFees.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtherFees.Name = "txtOtherFees";
            this.txtOtherFees.ReadOnly = true;
            this.txtOtherFees.Size = new System.Drawing.Size(116, 23);
            this.txtOtherFees.TabIndex = 26;
            this.txtOtherFees.Tag = "lock";
            this.txtOtherFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NetTotalLabel
            // 
            this.NetTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NetTotalLabel.AutoSize = true;
            this.NetTotalLabel.Location = new System.Drawing.Point(112, 15);
            this.NetTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetTotalLabel.Name = "NetTotalLabel";
            this.NetTotalLabel.Size = new System.Drawing.Size(89, 15);
            this.NetTotalLabel.TabIndex = 37;
            this.NetTotalLabel.Text = "Line Items Total";
            // 
            // cbTaxable
            // 
            this.cbTaxable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTaxable.AutoSize = true;
            this.cbTaxable.Checked = true;
            this.cbTaxable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTaxable.Location = new System.Drawing.Point(21, 90);
            this.cbTaxable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTaxable.Name = "cbTaxable";
            this.cbTaxable.Size = new System.Drawing.Size(65, 19);
            this.cbTaxable.TabIndex = 36;
            this.cbTaxable.Tag = "lock";
            this.cbTaxable.Text = "Taxable";
            this.cbTaxable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Order Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date";
            // 
            // POLabel
            // 
            this.POLabel.AutoSize = true;
            this.POLabel.Location = new System.Drawing.Point(14, 53);
            this.POLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.POLabel.Name = "POLabel";
            this.POLabel.Size = new System.Drawing.Size(30, 15);
            this.POLabel.TabIndex = 35;
            this.POLabel.Text = "PO#";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubTotal.Location = new System.Drawing.Point(221, 11);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(116, 23);
            this.txtSubTotal.TabIndex = 28;
            this.txtSubTotal.Tag = "lock";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderTotal.Location = new System.Drawing.Point(221, 91);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(116, 23);
            this.txtOrderTotal.TabIndex = 29;
            this.txtOrderTotal.Tag = "lock";
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTax.Location = new System.Drawing.Point(221, 37);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(116, 23);
            this.txtTax.TabIndex = 30;
            this.txtTax.Tag = "lock";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(207, 49);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(135, 23);
            this.txtOrderDate.TabIndex = 31;
            this.txtOrderDate.Tag = "lock";
            this.txtOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(75, 49);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(85, 23);
            this.txtOrderNumber.TabIndex = 32;
            this.txtOrderNumber.Tag = "lock";
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaxRate.Location = new System.Drawing.Point(149, 37);
            this.txtTaxRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.ReadOnly = true;
            this.txtTaxRate.Size = new System.Drawing.Size(59, 23);
            this.txtTaxRate.TabIndex = 38;
            this.txtTaxRate.Tag = "lock";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTaxRate
            // 
            this.lbTaxRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTaxRate.AutoSize = true;
            this.lbTaxRate.Location = new System.Drawing.Point(93, 40);
            this.lbTaxRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaxRate.Name = "lbTaxRate";
            this.lbTaxRate.Size = new System.Drawing.Size(50, 15);
            this.lbTaxRate.TabIndex = 39;
            this.lbTaxRate.Text = "Tax Rate";
            // 
            // gbCOst
            // 
            this.gbCOst.BackColor = System.Drawing.Color.Transparent;
            this.gbCOst.Controls.Add(this.txtSubTotal);
            this.gbCOst.Controls.Add(this.lbTaxRate);
            this.gbCOst.Controls.Add(this.txtOtherFees);
            this.gbCOst.Controls.Add(this.txtTaxRate);
            this.gbCOst.Controls.Add(this.label10);
            this.gbCOst.Controls.Add(this.NetTotalLabel);
            this.gbCOst.Controls.Add(this.txtTax);
            this.gbCOst.Controls.Add(this.cbTaxable);
            this.gbCOst.Controls.Add(this.txtOrderTotal);
            this.gbCOst.Controls.Add(this.label8);
            this.gbCOst.Location = new System.Drawing.Point(21, 421);
            this.gbCOst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCOst.Name = "gbCOst";
            this.gbCOst.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCOst.Size = new System.Drawing.Size(355, 129);
            this.gbCOst.TabIndex = 40;
            this.gbCOst.TabStop = false;
            this.gbCOst.Text = "Cost Summary";
            this.gbCOst.Enter += new System.EventHandler(this.gbCOst_Enter);
            // 
            // gbSpecialnstruction
            // 
            this.gbSpecialnstruction.Controls.Add(this.txtMemo);
            this.gbSpecialnstruction.Location = new System.Drawing.Point(22, 331);
            this.gbSpecialnstruction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSpecialnstruction.Name = "gbSpecialnstruction";
            this.gbSpecialnstruction.Padding = new System.Windows.Forms.Padding(7);
            this.gbSpecialnstruction.Size = new System.Drawing.Size(354, 84);
            this.gbSpecialnstruction.TabIndex = 41;
            this.gbSpecialnstruction.TabStop = false;
            this.gbSpecialnstruction.Text = "Special Instruction";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.btnJobChange);
            this.gbDetails.Controls.Add(this.txtOrderDate);
            this.gbDetails.Controls.Add(this.txtPurchaser);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.txtAttention);
            this.gbDetails.Controls.Add(this.txtJobName);
            this.gbDetails.Controls.Add(this.POLabel);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.txtOrderNumber);
            this.gbDetails.Location = new System.Drawing.Point(21, 210);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDetails.Size = new System.Drawing.Size(354, 117);
            this.gbDetails.TabIndex = 42;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Order Details";
            // 
            // btnJobChange
            // 
            this.btnJobChange.Location = new System.Drawing.Point(284, 21);
            this.btnJobChange.Name = "btnJobChange";
            this.btnJobChange.Size = new System.Drawing.Size(58, 25);
            this.btnJobChange.TabIndex = 36;
            this.btnJobChange.Tag = "lock";
            this.btnJobChange.Text = "Edit";
            this.btnJobChange.UseVisualStyleBackColor = true;
            this.btnJobChange.Click += new System.EventHandler(this.btnJobChange_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(96, 150);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(262, 23);
            this.txtAccountNumber.TabIndex = 43;
            this.txtAccountNumber.Tag = "lock";
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Acct. No";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 47;
            this.button1.Tag = "lock";
            this.button1.Text = "Clone";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Image = global::Mosiac.UX.Properties.Resources.outline_message_black_24dp2;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Location = new System.Drawing.Point(225, 177);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(133, 31);
            this.btnEditSupplier.TabIndex = 48;
            this.btnEditSupplier.Tag = "lock";
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Mosiac.UX.Properties.Resources.baseline_save_black_24dp1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(212, 556);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 33);
            this.btnSave.TabIndex = 46;
            this.btnSave.Tag = "lock";
            this.btnSave.Text = "Save Changes";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::Mosiac.UX.Properties.Resources.round_print_black_24dp;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(121, 556);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 33);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(104, 122);
            this.mtxtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.ReadOnly = true;
            this.mtxtPhone.Size = new System.Drawing.Size(96, 23);
            this.mtxtPhone.TabIndex = 49;
            this.mtxtPhone.Tag = "lock";
            // 
            // mtxtFax
            // 
            this.mtxtFax.Location = new System.Drawing.Point(254, 122);
            this.mtxtFax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtxtFax.Mask = "(999) 000-0000";
            this.mtxtFax.Name = "mtxtFax";
            this.mtxtFax.ReadOnly = true;
            this.mtxtFax.Size = new System.Drawing.Size(109, 23);
            this.mtxtFax.TabIndex = 50;
            this.mtxtFax.Tag = "lock";
            // 
            // btnChangeSupplier
            // 
            this.btnChangeSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSupplier.Image = global::Mosiac.UX.Properties.Resources.outline_published_with_changes_black_24dp1;
            this.btnChangeSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeSupplier.Location = new System.Drawing.Point(83, 177);
            this.btnChangeSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeSupplier.Name = "btnChangeSupplier";
            this.btnChangeSupplier.Size = new System.Drawing.Size(133, 31);
            this.btnChangeSupplier.TabIndex = 51;
            this.btnChangeSupplier.Tag = "lock";
            this.btnChangeSupplier.Text = "Switch Supplier";
            this.btnChangeSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeSupplier.UseVisualStyleBackColor = true;
            this.btnChangeSupplier.Click += new System.EventHandler(this.btnChangeSupplier_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(21, 4);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(92, 27);
            this.btnCancelOrder.TabIndex = 52;
            this.btnCancelOrder.Tag = "lock";
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // OrderHeaderVerticalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnChangeSupplier);
            this.Controls.Add(this.mtxtFax);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbSpecialnstruction);
            this.Controls.Add(this.gbCOst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(379, 0);
            this.Name = "OrderHeaderVerticalControl";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(399, 724);
            this.Tag = "lock";
            this.Load += new System.EventHandler(this.OrderHeaderVerticalControl_Load);
            this.gbCOst.ResumeLayout(false);
            this.gbCOst.PerformLayout();
            this.gbSpecialnstruction.ResumeLayout(false);
            this.gbSpecialnstruction.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurchaser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAttention;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOtherFees;
        private System.Windows.Forms.Label NetTotalLabel;
        private System.Windows.Forms.CheckBox cbTaxable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label POLabel;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lbTaxRate;
        private System.Windows.Forms.GroupBox gbCOst;
        private System.Windows.Forms.GroupBox gbSpecialnstruction;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtFax;
        private System.Windows.Forms.Button btnChangeSupplier;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnJobChange;
        public System.Windows.Forms.Button btnPrint;
    }
}
