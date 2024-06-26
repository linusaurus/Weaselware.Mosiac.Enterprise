namespace Mosiac.UX.UXControls
{
    partial class InventoryManagerControl
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
            btnRollUp = new System.Windows.Forms.Button();
            btnPullStock = new System.Windows.Forms.Button();
            btnSetStockLevel = new System.Windows.Forms.Button();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            tabControl1 = new System.Windows.Forms.TabControl();
            tbPartsInventory = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cboLocations = new System.Windows.Forms.ComboBox();
            btnLinkToUPC = new System.Windows.Forms.Button();
            txtSKU = new System.Windows.Forms.TextBox();
            txtPartNum = new System.Windows.Forms.TextBox();
            btnAddManu = new System.Windows.Forms.Button();
            cboPartManu = new System.Windows.Forms.ComboBox();
            bntCancel = new System.Windows.Forms.Button();
            btnApply = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            cbxObsolete = new System.Windows.Forms.CheckBox();
            cbxUnit = new System.Windows.Forms.ComboBox();
            txtWaste = new System.Windows.Forms.TextBox();
            txtMarkUp = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtWeight = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            txtStockLevel = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtPartDescription = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPartName = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtPartID = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtSearchPart = new System.Windows.Forms.TextBox();
            btnFind = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tbCheckOuts = new System.Windows.Forms.TabPage();
            cboCheckOutJobs = new System.Windows.Forms.ComboBox();
            label14 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lable3 = new System.Windows.Forms.Label();
            txt2Qnty = new System.Windows.Forms.TextBox();
            txt2CheckOutUnits = new System.Windows.Forms.TextBox();
            btnCheckout = new System.Windows.Forms.Button();
            txtjDescription = new System.Windows.Forms.TextBox();
            txtjJobName = new System.Windows.Forms.TextBox();
            txt2StockReceived = new System.Windows.Forms.TextBox();
            txtjUnitOfMeasure = new System.Windows.Forms.TextBox();
            txtjJobID = new System.Windows.Forms.TextBox();
            txtjOrderDate = new System.Windows.Forms.TextBox();
            btnLoadLineItem = new System.Windows.Forms.Button();
            txtLineItemEntry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabControl1.SuspendLayout();
            tbPartsInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbCheckOuts.SuspendLayout();
            SuspendLayout();
            // 
            // btnRollUp
            // 
            btnRollUp.Location = new System.Drawing.Point(20, 109);
            btnRollUp.Name = "btnRollUp";
            btnRollUp.Size = new System.Drawing.Size(159, 37);
            btnRollUp.TabIndex = 2;
            btnRollUp.Text = "Roll-Up";
            btnRollUp.UseVisualStyleBackColor = true;
            btnRollUp.Click += btnRollUp_Click;
            // 
            // btnPullStock
            // 
            btnPullStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPullStock.Location = new System.Drawing.Point(20, 66);
            btnPullStock.Name = "btnPullStock";
            btnPullStock.Size = new System.Drawing.Size(159, 37);
            btnPullStock.TabIndex = 1;
            btnPullStock.Text = "Pull Stock";
            btnPullStock.UseVisualStyleBackColor = true;
            btnPullStock.Click += btnPullStock_Click;
            // 
            // btnSetStockLevel
            // 
            btnSetStockLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetStockLevel.Location = new System.Drawing.Point(20, 23);
            btnSetStockLevel.Name = "btnSetStockLevel";
            btnSetStockLevel.Size = new System.Drawing.Size(159, 37);
            btnSetStockLevel.TabIndex = 0;
            btnSetStockLevel.Text = "Set Level";
            btnSetStockLevel.UseVisualStyleBackColor = true;
            btnSetStockLevel.Click += btnSetStockLevel_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer2.Location = new System.Drawing.Point(9, 16);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnSetStockLevel);
            splitContainer2.Panel1.Controls.Add(btnPullStock);
            splitContainer2.Panel1.Controls.Add(btnRollUp);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tabControl1);
            splitContainer2.Size = new System.Drawing.Size(1276, 749);
            splitContainer2.SplitterDistance = 254;
            splitContainer2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPartsInventory);
            tabControl1.Controls.Add(tbCheckOuts);
            tabControl1.Location = new System.Drawing.Point(17, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(959, 698);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tbPartsInventory
            // 
            tbPartsInventory.Controls.Add(splitContainer1);
            tbPartsInventory.Location = new System.Drawing.Point(4, 24);
            tbPartsInventory.Name = "tbPartsInventory";
            tbPartsInventory.Padding = new System.Windows.Forms.Padding(3);
            tbPartsInventory.Size = new System.Drawing.Size(951, 670);
            tbPartsInventory.TabIndex = 0;
            tbPartsInventory.Text = "Part Inventory";
            tbPartsInventory.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(19, 19);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(txtSearchPart);
            splitContainer1.Panel1.Controls.Add(btnFind);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6);
            splitContainer1.Size = new System.Drawing.Size(906, 621);
            splitContainer1.SplitterDistance = 318;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboLocations);
            groupBox1.Controls.Add(btnLinkToUPC);
            groupBox1.Controls.Add(txtSKU);
            groupBox1.Controls.Add(txtPartNum);
            groupBox1.Controls.Add(btnAddManu);
            groupBox1.Controls.Add(cboPartManu);
            groupBox1.Controls.Add(bntCancel);
            groupBox1.Controls.Add(btnApply);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cbxObsolete);
            groupBox1.Controls.Add(cbxUnit);
            groupBox1.Controls.Add(txtWaste);
            groupBox1.Controls.Add(txtMarkUp);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtStockLevel);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPartDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPartName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPartID);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(28, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(562, 281);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Part Details";
            // 
            // cboLocations
            // 
            cboLocations.FormattingEnabled = true;
            cboLocations.Location = new System.Drawing.Point(455, 141);
            cboLocations.Name = "cboLocations";
            cboLocations.Size = new System.Drawing.Size(82, 23);
            cboLocations.TabIndex = 15;
            // 
            // btnLinkToUPC
            // 
            btnLinkToUPC.Location = new System.Drawing.Point(271, 201);
            btnLinkToUPC.Name = "btnLinkToUPC";
            btnLinkToUPC.Size = new System.Drawing.Size(90, 23);
            btnLinkToUPC.TabIndex = 14;
            btnLinkToUPC.Text = "Link UPC";
            btnLinkToUPC.UseVisualStyleBackColor = true;
            // 
            // txtSKU
            // 
            txtSKU.Location = new System.Drawing.Point(367, 200);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new System.Drawing.Size(169, 23);
            txtSKU.TabIndex = 13;
            txtSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPartNum
            // 
            txtPartNum.Location = new System.Drawing.Point(367, 174);
            txtPartNum.Name = "txtPartNum";
            txtPartNum.Size = new System.Drawing.Size(169, 23);
            txtPartNum.TabIndex = 13;
            txtPartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddManu
            // 
            btnAddManu.FlatAppearance.BorderSize = 0;
            btnAddManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddManu.Image = Properties.Resources.round_add_circle_outline_black_24dp1;
            btnAddManu.Location = new System.Drawing.Point(195, 239);
            btnAddManu.Name = "btnAddManu";
            btnAddManu.Size = new System.Drawing.Size(25, 23);
            btnAddManu.TabIndex = 12;
            btnAddManu.UseVisualStyleBackColor = true;
            // 
            // cboPartManu
            // 
            cboPartManu.FormattingEnabled = true;
            cboPartManu.Location = new System.Drawing.Point(23, 239);
            cboPartManu.Name = "cboPartManu";
            cboPartManu.Size = new System.Drawing.Size(168, 23);
            cboPartManu.TabIndex = 11;
            // 
            // bntCancel
            // 
            bntCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            bntCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntCancel.Location = new System.Drawing.Point(319, 238);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new System.Drawing.Size(68, 28);
            bntCancel.TabIndex = 10;
            bntCancel.Text = "Cancel";
            bntCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApply.Location = new System.Drawing.Point(393, 238);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(68, 28);
            btnApply.TabIndex = 10;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Location = new System.Drawing.Point(467, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(69, 28);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbxObsolete
            // 
            cbxObsolete.AutoSize = true;
            cbxObsolete.Location = new System.Drawing.Point(27, 87);
            cbxObsolete.Name = "cbxObsolete";
            cbxObsolete.Size = new System.Drawing.Size(73, 19);
            cbxObsolete.TabIndex = 8;
            cbxObsolete.Text = "Obsolete";
            cbxObsolete.UseVisualStyleBackColor = true;
            // 
            // cbxUnit
            // 
            cbxUnit.FormattingEnabled = true;
            cbxUnit.Location = new System.Drawing.Point(109, 141);
            cbxUnit.Name = "cbxUnit";
            cbxUnit.Size = new System.Drawing.Size(81, 23);
            cbxUnit.TabIndex = 7;
            // 
            // txtWaste
            // 
            txtWaste.Location = new System.Drawing.Point(367, 141);
            txtWaste.Name = "txtWaste";
            txtWaste.Size = new System.Drawing.Size(82, 23);
            txtWaste.TabIndex = 5;
            txtWaste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarkUp
            // 
            txtMarkUp.Location = new System.Drawing.Point(281, 141);
            txtMarkUp.Name = "txtMarkUp";
            txtMarkUp.Size = new System.Drawing.Size(81, 23);
            txtMarkUp.TabIndex = 5;
            txtMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label12.Location = new System.Drawing.Point(455, 114);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(82, 23);
            label12.TabIndex = 6;
            label12.Text = "Location";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(195, 141);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(81, 23);
            txtWeight.TabIndex = 5;
            txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label11.Location = new System.Drawing.Point(367, 114);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(81, 23);
            label11.TabIndex = 6;
            label11.Text = "Waste";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStockLevel
            // 
            txtStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtStockLevel.Location = new System.Drawing.Point(110, 175);
            txtStockLevel.Name = "txtStockLevel";
            txtStockLevel.Size = new System.Drawing.Size(81, 23);
            txtStockLevel.TabIndex = 5;
            txtStockLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(23, 141);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(81, 23);
            txtUnitPrice.TabIndex = 5;
            txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label10.Location = new System.Drawing.Point(281, 114);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(81, 23);
            label10.TabIndex = 6;
            label10.Text = "Markup";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label7.Location = new System.Drawing.Point(195, 114);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 23);
            label7.TabIndex = 6;
            label7.Text = "Weight";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Location = new System.Drawing.Point(271, 175);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 23);
            label2.TabIndex = 6;
            label2.Text = "Manu-Part#";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Location = new System.Drawing.Point(23, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 23);
            label1.TabIndex = 6;
            label1.Text = "Stock Level";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label13.Location = new System.Drawing.Point(23, 213);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(167, 23);
            label13.TabIndex = 6;
            label13.Text = "Manufacturer";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label9.Location = new System.Drawing.Point(109, 114);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(81, 23);
            label9.TabIndex = 6;
            label9.Text = "Unit";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label6.Location = new System.Drawing.Point(23, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 23);
            label6.TabIndex = 6;
            label6.Text = "Unit Cost";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPartDescription
            // 
            txtPartDescription.Location = new System.Drawing.Point(110, 56);
            txtPartDescription.Multiline = true;
            txtPartDescription.Name = "txtPartDescription";
            txtPartDescription.Size = new System.Drawing.Size(427, 55);
            txtPartDescription.TabIndex = 5;
            // 
            // label5
            // 
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label5.Location = new System.Drawing.Point(23, 56);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 23);
            label5.TabIndex = 6;
            label5.Text = "Description";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPartName
            // 
            txtPartName.Location = new System.Drawing.Point(281, 29);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new System.Drawing.Size(256, 23);
            txtPartName.TabIndex = 5;
            // 
            // label8
            // 
            label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label8.Location = new System.Drawing.Point(187, 29);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(89, 23);
            label8.TabIndex = 6;
            label8.Text = "Short Name";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPartID
            // 
            txtPartID.Location = new System.Drawing.Point(110, 29);
            txtPartID.Name = "txtPartID";
            txtPartID.Size = new System.Drawing.Size(73, 23);
            txtPartID.TabIndex = 5;
            txtPartID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.Location = new System.Drawing.Point(23, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 23);
            label4.TabIndex = 6;
            label4.Text = "PartID";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchPart
            // 
            txtSearchPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearchPart.Location = new System.Drawing.Point(644, 79);
            txtSearchPart.Name = "txtSearchPart";
            txtSearchPart.Size = new System.Drawing.Size(191, 23);
            txtSearchPart.TabIndex = 3;
            txtSearchPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFind
            // 
            btnFind.FlatAppearance.BorderSize = 2;
            btnFind.Location = new System.Drawing.Point(644, 36);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(191, 37);
            btnFind.TabIndex = 2;
            btnFind.Text = "Load Part#";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(894, 287);
            dataGridView1.TabIndex = 0;
            // 
            // tbCheckOuts
            // 
            tbCheckOuts.Controls.Add(cboCheckOutJobs);
            tbCheckOuts.Controls.Add(label14);
            tbCheckOuts.Controls.Add(label18);
            tbCheckOuts.Controls.Add(label17);
            tbCheckOuts.Controls.Add(label16);
            tbCheckOuts.Controls.Add(label19);
            tbCheckOuts.Controls.Add(label15);
            tbCheckOuts.Controls.Add(label3);
            tbCheckOuts.Controls.Add(lable3);
            tbCheckOuts.Controls.Add(txt2Qnty);
            tbCheckOuts.Controls.Add(txt2CheckOutUnits);
            tbCheckOuts.Controls.Add(btnCheckout);
            tbCheckOuts.Controls.Add(txtjDescription);
            tbCheckOuts.Controls.Add(txtjJobName);
            tbCheckOuts.Controls.Add(txt2StockReceived);
            tbCheckOuts.Controls.Add(txtjUnitOfMeasure);
            tbCheckOuts.Controls.Add(txtjJobID);
            tbCheckOuts.Controls.Add(txtjOrderDate);
            tbCheckOuts.Controls.Add(btnLoadLineItem);
            tbCheckOuts.Controls.Add(txtLineItemEntry);
            tbCheckOuts.Location = new System.Drawing.Point(4, 24);
            tbCheckOuts.Name = "tbCheckOuts";
            tbCheckOuts.Padding = new System.Windows.Forms.Padding(3);
            tbCheckOuts.Size = new System.Drawing.Size(951, 670);
            tbCheckOuts.TabIndex = 1;
            tbCheckOuts.Text = "Check Out Items";
            tbCheckOuts.UseVisualStyleBackColor = true;
            // 
            // cboCheckOutJobs
            // 
            cboCheckOutJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCheckOutJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboCheckOutJobs.FormattingEnabled = true;
            cboCheckOutJobs.Location = new System.Drawing.Point(424, 254);
            cboCheckOutJobs.Name = "cboCheckOutJobs";
            cboCheckOutJobs.Size = new System.Drawing.Size(466, 23);
            cboCheckOutJobs.TabIndex = 5;
            // 
            // label14
            // 
            label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label14.Location = new System.Drawing.Point(283, 65);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(607, 20);
            label14.TabIndex = 4;
            label14.Text = "Item Description";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label18.Location = new System.Drawing.Point(171, 176);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(97, 20);
            label18.TabIndex = 4;
            label18.Text = "Job Num#";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label17.Location = new System.Drawing.Point(55, 176);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(110, 20);
            label17.TabIndex = 4;
            label17.Text = "Order Date";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label16.Location = new System.Drawing.Point(283, 176);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(97, 20);
            label16.TabIndex = 4;
            label16.Text = "Job Name";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label19.Location = new System.Drawing.Point(68, 65);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(97, 20);
            label19.TabIndex = 4;
            label19.Text = "Amount";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label15.Location = new System.Drawing.Point(171, 65);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(97, 20);
            label15.TabIndex = 4;
            label15.Text = "Unit";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Location = new System.Drawing.Point(353, 254);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Qnty";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable3
            // 
            lable3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lable3.Location = new System.Drawing.Point(283, 254);
            lable3.Name = "lable3";
            lable3.Size = new System.Drawing.Size(59, 20);
            lable3.TabIndex = 4;
            lable3.Text = "Unit";
            lable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt2Qnty
            // 
            txt2Qnty.Location = new System.Drawing.Point(353, 277);
            txt2Qnty.Name = "txt2Qnty";
            txt2Qnty.Size = new System.Drawing.Size(59, 23);
            txt2Qnty.TabIndex = 4;
            // 
            // txt2CheckOutUnits
            // 
            txt2CheckOutUnits.Location = new System.Drawing.Point(283, 277);
            txt2CheckOutUnits.Name = "txt2CheckOutUnits";
            txt2CheckOutUnits.Size = new System.Drawing.Size(59, 23);
            txt2CheckOutUnits.TabIndex = 4;
            // 
            // btnCheckout
            // 
            btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCheckout.Location = new System.Drawing.Point(112, 254);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(156, 32);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Check Out Item";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // txtjDescription
            // 
            txtjDescription.Location = new System.Drawing.Point(283, 88);
            txtjDescription.Multiline = true;
            txtjDescription.Name = "txtjDescription";
            txtjDescription.Size = new System.Drawing.Size(607, 55);
            txtjDescription.TabIndex = 2;
            // 
            // txtjJobName
            // 
            txtjJobName.Location = new System.Drawing.Point(283, 199);
            txtjJobName.Name = "txtjJobName";
            txtjJobName.Size = new System.Drawing.Size(607, 23);
            txtjJobName.TabIndex = 2;
            // 
            // txt2StockReceived
            // 
            txt2StockReceived.Location = new System.Drawing.Point(68, 88);
            txt2StockReceived.Name = "txt2StockReceived";
            txt2StockReceived.Size = new System.Drawing.Size(97, 23);
            txt2StockReceived.TabIndex = 2;
            // 
            // txtjUnitOfMeasure
            // 
            txtjUnitOfMeasure.Location = new System.Drawing.Point(171, 88);
            txtjUnitOfMeasure.Name = "txtjUnitOfMeasure";
            txtjUnitOfMeasure.Size = new System.Drawing.Size(97, 23);
            txtjUnitOfMeasure.TabIndex = 2;
            // 
            // txtjJobID
            // 
            txtjJobID.Location = new System.Drawing.Point(171, 199);
            txtjJobID.Name = "txtjJobID";
            txtjJobID.Size = new System.Drawing.Size(97, 23);
            txtjJobID.TabIndex = 2;
            // 
            // txtjOrderDate
            // 
            txtjOrderDate.Location = new System.Drawing.Point(55, 199);
            txtjOrderDate.Name = "txtjOrderDate";
            txtjOrderDate.Size = new System.Drawing.Size(110, 23);
            txtjOrderDate.TabIndex = 2;
            // 
            // btnLoadLineItem
            // 
            btnLoadLineItem.Location = new System.Drawing.Point(171, 28);
            btnLoadLineItem.Name = "btnLoadLineItem";
            btnLoadLineItem.Size = new System.Drawing.Size(97, 30);
            btnLoadLineItem.TabIndex = 1;
            btnLoadLineItem.Text = "Load";
            btnLoadLineItem.UseVisualStyleBackColor = true;
            btnLoadLineItem.Click += btnLoadLineItem_Click;
            // 
            // txtLineItemEntry
            // 
            txtLineItemEntry.Location = new System.Drawing.Point(68, 33);
            txtLineItemEntry.Name = "txtLineItemEntry";
            txtLineItemEntry.Size = new System.Drawing.Size(97, 23);
            txtLineItemEntry.TabIndex = 0;
            txtLineItemEntry.Text = "56938";
            // 
            // InventoryManagerControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer2);
            Name = "InventoryManagerControl";
            Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            Size = new System.Drawing.Size(1295, 777);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tbPartsInventory.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbCheckOuts.ResumeLayout(false);
            tbCheckOuts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnRollUp;
        private System.Windows.Forms.Button btnPullStock;
        private System.Windows.Forms.Button btnSetStockLevel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPartsInventory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLocations;
        private System.Windows.Forms.Button btnLinkToUPC;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.Button btnAddManu;
        private System.Windows.Forms.ComboBox cboPartManu;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxObsolete;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.TextBox txtWaste;
        private System.Windows.Forms.TextBox txtMarkUp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchPart;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbCheckOuts;
        private System.Windows.Forms.Button btnLoadLineItem;
        private System.Windows.Forms.TextBox txtLineItemEntry;
        private System.Windows.Forms.TextBox txtjDescription;
        private System.Windows.Forms.TextBox txtjJobName;
        private System.Windows.Forms.TextBox txtjJobID;
        private System.Windows.Forms.TextBox txtjOrderDate;
        private System.Windows.Forms.TextBox txtjUnitOfMeasure;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt2CheckOutUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2Qnty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCheckOutJobs;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt2StockReceived;
    }
}
