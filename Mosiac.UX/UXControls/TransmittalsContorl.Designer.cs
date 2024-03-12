namespace Mosiac.UX.UXControls
{
    partial class TransmittalsContorl
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lbJobsList = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            btnNewTransmittal = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(10, 10);
            splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbJobsList);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6);
            splitContainer1.Size = new System.Drawing.Size(1105, 777);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 0;
            // 
            // lbJobsList
            // 
            lbJobsList.Dock = System.Windows.Forms.DockStyle.Fill;
            lbJobsList.FormattingEnabled = true;
            lbJobsList.ItemHeight = 15;
            lbJobsList.Location = new System.Drawing.Point(0, 61);
            lbJobsList.Name = "lbJobsList";
            lbJobsList.Size = new System.Drawing.Size(250, 283);
            lbJobsList.TabIndex = 0;
            lbJobsList.SelectedIndexChanged += lbJobsList_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNewTransmittal);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(250, 61);
            panel1.TabIndex = 1;
            // 
            // btnNewTransmittal
            // 
            btnNewTransmittal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewTransmittal.Location = new System.Drawing.Point(50, 15);
            btnNewTransmittal.Name = "btnNewTransmittal";
            btnNewTransmittal.Size = new System.Drawing.Size(127, 33);
            btnNewTransmittal.TabIndex = 0;
            btnNewTransmittal.Text = "New Transmittal";
            btnNewTransmittal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 344);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(250, 433);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(250, 433);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(839, 61);
            panel3.TabIndex = 1;
            // 
            // TransmittalsContorl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "TransmittalsContorl";
            Padding = new System.Windows.Forms.Padding(10);
            Size = new System.Drawing.Size(1125, 797);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbJobsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewTransmittal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
    }
}
