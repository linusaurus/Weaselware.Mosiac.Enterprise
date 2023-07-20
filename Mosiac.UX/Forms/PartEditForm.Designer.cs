
namespace Mosiac.UX.Forms
{
    partial class PartEditForm
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
            txtNotes = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(560, 281);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Part Details";
            groupBox1.Enter += groupBox1_Enter;
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
            btnLinkToUPC.Click += btnLinkToUPC_Click;
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
            btnAddManu.Click += btnAddManu_Click;
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
            bntCancel.Click += button1_Click;
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
            btnSave.Click += btnSave_Click;
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
            // txtNotes
            // 
            txtNotes.Location = new System.Drawing.Point(12, 310);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new System.Drawing.Size(560, 96);
            txtNotes.TabIndex = 10;
            // 
            // PartEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = bntCancel;
            ClientSize = new System.Drawing.Size(585, 431);
            Controls.Add(txtNotes);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "PartEditForm";
            Text = "PartEditForm";
            Load += PartEditForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddManu;
        private System.Windows.Forms.ComboBox cboPartManu;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Button btnLinkToUPC;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cboLocations;
    }
}