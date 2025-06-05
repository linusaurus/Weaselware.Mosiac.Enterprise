

namespace Mosiac.UX.UXControls
{
    partial class OrderEditSplitPanelControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            tsOrderEditToolBar = new System.Windows.Forms.ToolStrip();
            tsTooglePanels = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbLoadPartFinder = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbToogleOrderFee = new System.Windows.Forms.ToolStripButton();
            tsToogleHeader = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbToggleAttachment = new System.Windows.Forms.ToolStripButton();
            tsOrderState = new System.Windows.Forms.ToolStripLabel();
            splitContainerMain = new System.Windows.Forms.SplitContainer();
            ckbHideJobName = new System.Windows.Forms.CheckBox();
            orderHeaderVerticalControl1 = new OrderHeaderVerticalControl();
            scLineItems = new System.Windows.Forms.SplitContainer();
            dgOrderLineItem = new System.Windows.Forms.DataGridView();
            tsOrderEditToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLineItems).BeginInit();
            scLineItems.Panel1.SuspendLayout();
            scLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderLineItem).BeginInit();
            SuspendLayout();
            // 
            // tsOrderEditToolBar
            // 
            tsOrderEditToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            tsOrderEditToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            tsOrderEditToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsTooglePanels, toolStripSeparator3, tsbLoadPartFinder, toolStripSeparator2, tsbToogleOrderFee, tsToogleHeader, toolStripSeparator1, tsbToggleAttachment, tsOrderState });
            tsOrderEditToolBar.Location = new System.Drawing.Point(7, 696);
            tsOrderEditToolBar.Name = "tsOrderEditToolBar";
            tsOrderEditToolBar.Size = new System.Drawing.Size(1340, 31);
            tsOrderEditToolBar.TabIndex = 0;
            tsOrderEditToolBar.Text = "Toogle Part Tools";
            // 
            // tsTooglePanels
            // 
            tsTooglePanels.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsTooglePanels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsTooglePanels.Image = Properties.Resources.round_keyboard_arrow_up_black_24dp;
            tsTooglePanels.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsTooglePanels.Name = "tsTooglePanels";
            tsTooglePanels.Size = new System.Drawing.Size(28, 28);
            tsTooglePanels.Text = "toolStripButton1";
            tsTooglePanels.ToolTipText = "tsToogleToolSet";
            tsTooglePanels.Click += tsTooglePanels_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbLoadPartFinder
            // 
            tsbLoadPartFinder.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbLoadPartFinder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbLoadPartFinder.Image = Properties.Resources.outline_attach_file_black_24dp;
            tsbLoadPartFinder.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbLoadPartFinder.Name = "tsbLoadPartFinder";
            tsbLoadPartFinder.Size = new System.Drawing.Size(28, 28);
            tsbLoadPartFinder.Text = "toolStripButton1";
            tsbLoadPartFinder.ToolTipText = "Add Attachments";
            tsbLoadPartFinder.Click += tsbToggleAttachment_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbToogleOrderFee
            // 
            tsbToogleOrderFee.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbToogleOrderFee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbToogleOrderFee.Image = Properties.Resources.outline_request_quote_black_24dp;
            tsbToogleOrderFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbToogleOrderFee.Name = "tsbToogleOrderFee";
            tsbToogleOrderFee.Size = new System.Drawing.Size(28, 28);
            tsbToogleOrderFee.Text = "toolStripButton1";
            tsbToogleOrderFee.ToolTipText = "Add Order Fees";
            tsbToogleOrderFee.Click += tsbToogleOrderFee_Click;
            // 
            // tsToogleHeader
            // 
            tsToogleHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsToogleHeader.Image = Properties.Resources.twotone_view_list_black_24dp;
            tsToogleHeader.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsToogleHeader.Name = "tsToogleHeader";
            tsToogleHeader.Size = new System.Drawing.Size(28, 28);
            tsToogleHeader.Text = "toolStripButton1";
            tsToogleHeader.ToolTipText = "Toogle Header";
            tsToogleHeader.Click += tsToogleHeader_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbToggleAttachment
            // 
            tsbToggleAttachment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbToggleAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbToggleAttachment.Image = Properties.Resources.baseline_post_add_black_24dp;
            tsbToggleAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbToggleAttachment.Name = "tsbToggleAttachment";
            tsbToggleAttachment.Size = new System.Drawing.Size(28, 28);
            tsbToggleAttachment.Text = "toolStripButton1";
            tsbToggleAttachment.ToolTipText = "find parts";
            tsbToggleAttachment.Click += tsbLoadPartFinder_Click;
            // 
            // tsOrderState
            // 
            tsOrderState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsOrderState.IsLink = true;
            tsOrderState.Name = "tsOrderState";
            tsOrderState.Size = new System.Drawing.Size(0, 28);
            tsOrderState.Click += tsOrderState_Click;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainerMain.Location = new System.Drawing.Point(7, 7);
            splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(ckbHideJobName);
            splitContainerMain.Panel1.Controls.Add(orderHeaderVerticalControl1);
            splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(scLineItems);
            splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(5, 5, 14, 5);
            splitContainerMain.Size = new System.Drawing.Size(1340, 689);
            splitContainerMain.SplitterDistance = 370;
            splitContainerMain.SplitterWidth = 5;
            splitContainerMain.TabIndex = 1;
            // 
            // ckbHideJobName
            // 
            ckbHideJobName.AutoSize = true;
            ckbHideJobName.Location = new System.Drawing.Point(28, 635);
            ckbHideJobName.Name = "ckbHideJobName";
            ckbHideJobName.Size = new System.Drawing.Size(102, 19);
            ckbHideJobName.TabIndex = 1;
            ckbHideJobName.Text = "Print Jobname";
            ckbHideJobName.UseVisualStyleBackColor = true;
            // 
            // orderHeaderVerticalControl1
            // 
            orderHeaderVerticalControl1.AutoScroll = true;
            orderHeaderVerticalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            orderHeaderVerticalControl1.Location = new System.Drawing.Point(5, 5);
            orderHeaderVerticalControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            orderHeaderVerticalControl1.MinimumSize = new System.Drawing.Size(379, 0);
            orderHeaderVerticalControl1.Name = "orderHeaderVerticalControl1";
            orderHeaderVerticalControl1.Padding = new System.Windows.Forms.Padding(7);
            orderHeaderVerticalControl1.Size = new System.Drawing.Size(379, 679);
            orderHeaderVerticalControl1.TabIndex = 0;
            orderHeaderVerticalControl1.Tag = "lock";
            orderHeaderVerticalControl1.Load += orderHeaderVerticalControl1_Load;
            // 
            // scLineItems
            // 
            scLineItems.Cursor = System.Windows.Forms.Cursors.HSplit;
            scLineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            scLineItems.Location = new System.Drawing.Point(5, 5);
            scLineItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scLineItems.Name = "scLineItems";
            scLineItems.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLineItems.Panel1
            // 
            scLineItems.Panel1.Controls.Add(dgOrderLineItem);
            scLineItems.Panel1.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            // 
            // scLineItems.Panel2
            // 
            scLineItems.Panel2.Padding = new System.Windows.Forms.Padding(5);
            scLineItems.Size = new System.Drawing.Size(946, 679);
            scLineItems.SplitterDistance = 282;
            scLineItems.SplitterWidth = 5;
            scLineItems.TabIndex = 0;
            // 
            // dgOrderLineItem
            // 
            dgOrderLineItem.AllowUserToAddRows = false;
            dgOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderLineItem.Dock = System.Windows.Forms.DockStyle.Fill;
            dgOrderLineItem.Location = new System.Drawing.Point(5, 30);
            dgOrderLineItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgOrderLineItem.Name = "dgOrderLineItem";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgOrderLineItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgOrderLineItem.Size = new System.Drawing.Size(936, 247);
            dgOrderLineItem.TabIndex = 0;
            dgOrderLineItem.Tag = "lock";
            // 
            // OrderEditSplitPanelControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainerMain);
            Controls.Add(tsOrderEditToolBar);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "OrderEditSplitPanelControl";
            Padding = new System.Windows.Forms.Padding(7);
            Size = new System.Drawing.Size(1354, 734);
            tsOrderEditToolBar.ResumeLayout(false);
            tsOrderEditToolBar.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel1.PerformLayout();
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            scLineItems.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scLineItems).EndInit();
            scLineItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderLineItem).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsOrderEditToolBar;
        private System.Windows.Forms.ToolStripButton tsTooglePanels;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer scLineItems;
        private System.Windows.Forms.DataGridView dgOrderLineItem;
        private System.Windows.Forms.ToolStripButton tsToogleHeader;
        private OrderHeaderVerticalControl orderHeaderVerticalControl1;
        private System.Windows.Forms.ToolStripButton tsbToggleAttachment;
        private System.Windows.Forms.ToolStripButton tsbLoadPartFinder;
        private System.Windows.Forms.ToolStripButton tsbToogleOrderFee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsOrderState;
        private System.Windows.Forms.CheckBox ckbHideJobName;
    }
}
