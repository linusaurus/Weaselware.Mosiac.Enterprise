using System.Drawing;

namespace Mosiac.UX
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            mainToolStrip = new System.Windows.Forms.ToolStrip();
            tsOrderButton = new System.Windows.Forms.ToolStripButton();
            tsMyOrders = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsSupplerOrders = new System.Windows.Forms.ToolStripButton();
            tsbReceiveOrder = new System.Windows.Forms.ToolStripButton();
            tsbReceipts = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            tsPartEditor = new System.Windows.Forms.ToolStripButton();
            tsStockPage = new System.Windows.Forms.ToolStripButton();
            tsManufacturer = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsJobsManager = new System.Windows.Forms.ToolStripButton();
            tsbJobItems = new System.Windows.Forms.ToolStripButton();
            tsDeliveries = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            MainTabControl = new System.Windows.Forms.TabControl();
            tsbTransmittals = new System.Windows.Forms.ToolStripButton();
            mainToolStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainToolStrip
            // 
            mainToolStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mainToolStrip.ImageScalingSize = new Size(32, 32);
            mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsOrderButton, tsMyOrders, toolStripSeparator1, tsSupplerOrders, tsbReceiveOrder, tsbReceipts, toolStripSeparator4, tsPartEditor, tsStockPage, tsManufacturer, toolStripSeparator2, tsJobsManager, tsbJobItems, tsDeliveries, toolStripSeparator3, tsbTransmittals });
            mainToolStrip.Location = new Point(0, 0);
            mainToolStrip.Name = "mainToolStrip";
            mainToolStrip.Size = new Size(1209, 55);
            mainToolStrip.TabIndex = 0;
            mainToolStrip.Text = "mainToolStrip";
            mainToolStrip.ItemClicked += mainToolStrip_ItemClicked;
            // 
            // tsOrderButton
            // 
            tsOrderButton.Image = Properties.Resources.twotone_add_box_black_24dp1;
            tsOrderButton.ImageTransparentColor = Color.Magenta;
            tsOrderButton.Name = "tsOrderButton";
            tsOrderButton.Size = new Size(68, 52);
            tsOrderButton.Text = "New Order";
            tsOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            tsOrderButton.ToolTipText = "New Order";
            // 
            // tsMyOrders
            // 
            tsMyOrders.ForeColor = SystemColors.ControlText;
            tsMyOrders.Image = Properties.Resources.twotone_account_box_black_24dp;
            tsMyOrders.ImageTransparentColor = Color.Magenta;
            tsMyOrders.Name = "tsMyOrders";
            tsMyOrders.Size = new Size(66, 52);
            tsMyOrders.Text = "My Orders";
            tsMyOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 55);
            // 
            // tsSupplerOrders
            // 
            tsSupplerOrders.Image = Properties.Resources.twotone_local_shipping_black_24dp;
            tsSupplerOrders.ImageTransparentColor = Color.Magenta;
            tsSupplerOrders.Name = "tsSupplerOrders";
            tsSupplerOrders.Size = new Size(92, 52);
            tsSupplerOrders.Text = "Supplier Orders";
            tsSupplerOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbReceiveOrder
            // 
            tsbReceiveOrder.Image = Properties.Resources.twotone_save_alt_black_24dp;
            tsbReceiveOrder.ImageTransparentColor = Color.Magenta;
            tsbReceiveOrder.Name = "tsbReceiveOrder";
            tsbReceiveOrder.Size = new Size(89, 52);
            tsbReceiveOrder.Text = "Recieve Orders";
            tsbReceiveOrder.TextAlign = ContentAlignment.BottomCenter;
            tsbReceiveOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbReceipts
            // 
            tsbReceipts.Image = (Image)resources.GetObject("tsbReceipts.Image");
            tsbReceipts.ImageTransparentColor = Color.Magenta;
            tsbReceipts.Name = "tsbReceipts";
            tsbReceipts.Size = new Size(55, 52);
            tsbReceipts.Text = "Receipts";
            tsbReceipts.TextAlign = ContentAlignment.BottomCenter;
            tsbReceipts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 55);
            // 
            // tsPartEditor
            // 
            tsPartEditor.Image = Properties.Resources.twotone_extension_black_24dp;
            tsPartEditor.ImageTransparentColor = Color.Magenta;
            tsPartEditor.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            tsPartEditor.Name = "tsPartEditor";
            tsPartEditor.Size = new Size(82, 51);
            tsPartEditor.Text = "Part Manager";
            tsPartEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            tsPartEditor.ToolTipText = "Parts Manager";
            // 
            // tsStockPage
            // 
            tsStockPage.CheckOnClick = true;
            tsStockPage.Image = Properties.Resources.outline_message_black_24dp1;
            tsStockPage.ImageTransparentColor = Color.Magenta;
            tsStockPage.Name = "tsStockPage";
            tsStockPage.Size = new Size(98, 52);
            tsStockPage.Text = "Line Item Search";
            tsStockPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            tsStockPage.Click += tsSettingsButton_Click;
            // 
            // tsManufacturer
            // 
            tsManufacturer.Image = (Image)resources.GetObject("tsManufacturer.Image");
            tsManufacturer.Margin = new System.Windows.Forms.Padding(15, 1, 15, 2);
            tsManufacturer.Name = "tsManufacturer";
            tsManufacturer.Size = new Size(84, 52);
            tsManufacturer.Text = "Manufacturers";
            tsManufacturer.TextAlign = ContentAlignment.MiddleRight;
            tsManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            tsManufacturer.ToolTipText = "Manufacturer Manager";
            tsManufacturer.Click += tsScanBarCode_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 55);
            // 
            // tsJobsManager
            // 
            tsJobsManager.Image = Properties.Resources.twotone_home_work_black_24dp;
            tsJobsManager.ImageTransparentColor = Color.Magenta;
            tsJobsManager.Name = "tsJobsManager";
            tsJobsManager.Size = new Size(36, 52);
            tsJobsManager.Text = "Jobs";
            tsJobsManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbJobItems
            // 
            tsbJobItems.Image = Properties.Resources.twotone_account_tree_black_24dp;
            tsbJobItems.ImageTransparentColor = Color.Magenta;
            tsbJobItems.Name = "tsbJobItems";
            tsbJobItems.Size = new Size(61, 52);
            tsbJobItems.Text = "Job Items";
            tsbJobItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            tsbJobItems.ToolTipText = "Pull Stock";
            tsbJobItems.Click += tsbJobItems_OnClick;
            // 
            // tsDeliveries
            // 
            tsDeliveries.Image = (Image)resources.GetObject("tsDeliveries.Image");
            tsDeliveries.ImageTransparentColor = Color.Magenta;
            tsDeliveries.Name = "tsDeliveries";
            tsDeliveries.Size = new Size(61, 52);
            tsDeliveries.Text = "Deliveries";
            tsDeliveries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 55);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 796);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1209, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(84, 17);
            toolStripStatusLabel1.Text = "{{Current Tab}}";
            // 
            // MainTabControl
            // 
            MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            MainTabControl.ItemSize = new Size(58, 24);
            MainTabControl.Location = new Point(0, 55);
            MainTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.ShowToolTips = true;
            MainTabControl.Size = new Size(1209, 741);
            MainTabControl.TabIndex = 2;
            MainTabControl.DrawItem += MainTabControl_DrawItem;
            MainTabControl.SelectedIndexChanged += MaintabControl_SelectedIndexChanged;
            MainTabControl.MouseClick += MainTabControl_MouseClick;
            // 
            // tsbTransmittals
            // 
            tsbTransmittals.Image = (Image)resources.GetObject("tsbTransmittals.Image");
            tsbTransmittals.ImageTransparentColor = Color.Magenta;
            tsbTransmittals.Name = "tsbTransmittals";
            tsbTransmittals.Size = new Size(74, 52);
            tsbTransmittals.Text = "Transmittals";
            tsbTransmittals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1209, 818);
            Controls.Add(MainTabControl);
            Controls.Add(statusStrip1);
            Controls.Add(mainToolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 700);
            Name = "Main";
            Text = "Mosiac";
            Load += Main_Load;
            mainToolStrip.ResumeLayout(false);
            mainToolStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        Point _imageLocation = new Point(20, 4);
        Point _imgHitArea = new Point(20, 4);
        Image closeImage;

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripButton tsStockPage;
        private System.Windows.Forms.ToolStripLabel tsManufacturer;
        private System.Windows.Forms.ToolStripButton tsbJobItems;
        private System.Windows.Forms.ToolStripButton tsPartEditor;
        private System.Windows.Forms.ToolStripButton tsOrderButton;
        private System.Windows.Forms.ToolStripButton tsbReceiveOrder;
        private System.Windows.Forms.ToolStripButton tsSupplerOrders;
        private System.Windows.Forms.ToolStripButton tsMyOrders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsJobsManager;

        #endregion
        private System.Windows.Forms.ToolStripButton tsbReceipts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsDeliveries;
        private System.Windows.Forms.ToolStripButton tsbTransmittals;
    }
}

