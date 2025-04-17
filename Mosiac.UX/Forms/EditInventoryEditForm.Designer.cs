namespace Mosiac.UX.Forms
{
    partial class EditInventoryEditForm
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
            btnCancel = new Button();
            btnOK = new Button();
            txtTransactionID = new TextBox();
            txtDescription = new TextBox();
            txtNote = new TextBox();
            txtEmployee = new TextBox();
            txtDate = new TextBox();
            txtLineId = new TextBox();
            txtPartID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUnitOfMeasure = new TextBox();
            txtLocation = new TextBox();
            txtTransactionType = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtInventoryAmount = new TextBox();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(398, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 35);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(493, 208);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(93, 35);
            btnOK.TabIndex = 1;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(22, 30);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(104, 23);
            txtTransactionID.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(132, 30);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(454, 23);
            txtDescription.TabIndex = 2;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(24, 187);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(280, 56);
            txtNote.TabIndex = 2;
            txtNote.TextChanged += txtNote_TextChanged;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(344, 80);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(122, 23);
            txtEmployee.TabIndex = 2;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(22, 80);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(104, 23);
            txtDate.TabIndex = 2;
            // 
            // txtLineId
            // 
            txtLineId.Location = new Point(132, 80);
            txtLineId.Name = "txtLineId";
            txtLineId.Size = new Size(100, 23);
            txtLineId.TabIndex = 2;
            // 
            // txtPartID
            // 
            txtPartID.Location = new Point(238, 80);
            txtPartID.Name = "txtPartID";
            txtPartID.Size = new Size(100, 23);
            txtPartID.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 3;
            label1.Text = "TransID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(132, 8);
            label2.Name = "label2";
            label2.Size = new Size(454, 19);
            label2.TabIndex = 3;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(22, 58);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 3;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.Location = new Point(132, 58);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 3;
            label4.Text = "LineID";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.Location = new Point(238, 58);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 3;
            label5.Text = "PartID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.Location = new Point(24, 165);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 3;
            label6.Text = "Notes";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.Location = new Point(344, 58);
            label7.Name = "label7";
            label7.Size = new Size(122, 19);
            label7.TabIndex = 3;
            label7.Text = "Employee";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label1_Click;
            // 
            // txtUnitOfMeasure
            // 
            txtUnitOfMeasure.Location = new Point(238, 127);
            txtUnitOfMeasure.Name = "txtUnitOfMeasure";
            txtUnitOfMeasure.Size = new Size(53, 23);
            txtUnitOfMeasure.TabIndex = 2;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(132, 127);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 23);
            txtLocation.TabIndex = 2;
            // 
            // txtTransactionType
            // 
            txtTransactionType.Location = new Point(22, 127);
            txtTransactionType.Name = "txtTransactionType";
            txtTransactionType.Size = new Size(104, 23);
            txtTransactionType.TabIndex = 2;
            // 
            // label8
            // 
            label8.Location = new Point(22, 106);
            label8.Name = "label8";
            label8.Size = new Size(104, 19);
            label8.TabIndex = 3;
            label8.Text = "TransAction";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.Location = new Point(132, 106);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 3;
            label9.Text = "Location";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            label9.Click += label1_Click;
            // 
            // txtInventoryAmount
            // 
            txtInventoryAmount.Location = new Point(344, 127);
            txtInventoryAmount.Name = "txtInventoryAmount";
            txtInventoryAmount.Size = new Size(75, 23);
            txtInventoryAmount.TabIndex = 2;
            // 
            // label10
            // 
            label10.Location = new Point(238, 105);
            label10.Name = "label10";
            label10.Size = new Size(53, 19);
            label10.TabIndex = 3;
            label10.Text = "Unit";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Click += label1_Click;
            // 
            // label11
            // 
            label11.Location = new Point(344, 106);
            label11.Name = "label11";
            label11.Size = new Size(53, 19);
            label11.TabIndex = 3;
            label11.Text = "Amount";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            label11.Click += label1_Click;
            // 
            // EditInventoryEditForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(611, 260);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPartID);
            Controls.Add(txtLineId);
            Controls.Add(txtDate);
            Controls.Add(txtTransactionType);
            Controls.Add(txtLocation);
            Controls.Add(txtInventoryAmount);
            Controls.Add(txtUnitOfMeasure);
            Controls.Add(txtEmployee);
            Controls.Add(txtNote);
            Controls.Add(txtDescription);
            Controls.Add(txtTransactionID);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditInventoryEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stock Transaction Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private TextBox txtTransactionID;
        private TextBox txtDescription;
        private TextBox txtNote;
        private TextBox txtEmployee;
        private TextBox txtDate;
        private TextBox txtLineId;
        private TextBox txtPartID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUnitOfMeasure;
        private TextBox txtLocation;
        private TextBox txtTransactionType;
        private Label label8;
        private Label label9;
        private TextBox txtInventoryAmount;
        private Label label10;
        private Label label11;
    }
}