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
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsOrderButton = new System.Windows.Forms.ToolStripButton();
            this.tsMyOrders = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSupplerOrders = new System.Windows.Forms.ToolStripButton();
            this.tsbReceiveOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbReceipts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPartEditor = new System.Windows.Forms.ToolStripButton();
            this.tsStockPage = new System.Windows.Forms.ToolStripButton();
            this.tsManufacturer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsJobsManager = new System.Windows.Forms.ToolStripButton();
            this.tsbJobItems = new System.Windows.Forms.ToolStripButton();
            this.tsDeliveries = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.mainToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOrderButton,
            this.tsMyOrders,
            this.toolStripSeparator1,
            this.tsSupplerOrders,
            this.tsbReceiveOrder,
            this.tsbReceipts,
            this.toolStripSeparator4,
            this.tsPartEditor,
            this.tsStockPage,
            this.tsManufacturer,
            this.toolStripSeparator2,
            this.tsJobsManager,
            this.tsbJobItems,
            this.tsDeliveries,
            this.toolStripSeparator3});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1209, 55);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "mainToolStrip";
            this.mainToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainToolStrip_ItemClicked);
            // 
            // tsOrderButton
            // 
            this.tsOrderButton.Image = global::Mosiac.UX.Properties.Resources.twotone_add_box_black_24dp1;
            this.tsOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOrderButton.Name = "tsOrderButton";
            this.tsOrderButton.Size = new System.Drawing.Size(68, 52);
            this.tsOrderButton.Text = "New Order";
            this.tsOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsOrderButton.ToolTipText = "New Order";
            // 
            // tsMyOrders
            // 
            this.tsMyOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsMyOrders.Image = global::Mosiac.UX.Properties.Resources.twotone_account_box_black_24dp;
            this.tsMyOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMyOrders.Name = "tsMyOrders";
            this.tsMyOrders.Size = new System.Drawing.Size(66, 52);
            this.tsMyOrders.Text = "My Orders";
            this.tsMyOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsSupplerOrders
            // 
            this.tsSupplerOrders.Image = global::Mosiac.UX.Properties.Resources.twotone_local_shipping_black_24dp;
            this.tsSupplerOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSupplerOrders.Name = "tsSupplerOrders";
            this.tsSupplerOrders.Size = new System.Drawing.Size(92, 52);
            this.tsSupplerOrders.Text = "Supplier Orders";
            this.tsSupplerOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbReceiveOrder
            // 
            this.tsbReceiveOrder.Image = global::Mosiac.UX.Properties.Resources.twotone_save_alt_black_24dp;
            this.tsbReceiveOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReceiveOrder.Name = "tsbReceiveOrder";
            this.tsbReceiveOrder.Size = new System.Drawing.Size(89, 52);
            this.tsbReceiveOrder.Text = "Recieve Orders";
            this.tsbReceiveOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbReceiveOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbReceipts
            // 
            this.tsbReceipts.Image = ((System.Drawing.Image)(resources.GetObject("tsbReceipts.Image")));
            this.tsbReceipts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReceipts.Name = "tsbReceipts";
            this.tsbReceipts.Size = new System.Drawing.Size(55, 52);
            this.tsbReceipts.Text = "Receipts";
            this.tsbReceipts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbReceipts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // tsPartEditor
            // 
            this.tsPartEditor.Image = global::Mosiac.UX.Properties.Resources.twotone_extension_black_24dp;
            this.tsPartEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPartEditor.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.tsPartEditor.Name = "tsPartEditor";
            this.tsPartEditor.Size = new System.Drawing.Size(82, 51);
            this.tsPartEditor.Text = "Part Manager";
            this.tsPartEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPartEditor.ToolTipText = "Parts Manager";
            // 
            // tsStockPage
            // 
            this.tsStockPage.CheckOnClick = true;
            this.tsStockPage.Image = ((System.Drawing.Image)(resources.GetObject("tsStockPage.Image")));
            this.tsStockPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockPage.Name = "tsStockPage";
            this.tsStockPage.Size = new System.Drawing.Size(40, 52);
            this.tsStockPage.Text = "Stock";
            this.tsStockPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockPage.Click += new System.EventHandler(this.tsSettingsButton_Click);
            // 
            // tsManufacturer
            // 
            this.tsManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("tsManufacturer.Image")));
            this.tsManufacturer.Margin = new System.Windows.Forms.Padding(15, 1, 15, 2);
            this.tsManufacturer.Name = "tsManufacturer";
            this.tsManufacturer.Size = new System.Drawing.Size(84, 52);
            this.tsManufacturer.Text = "Manufacturers";
            this.tsManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsManufacturer.ToolTipText = "Manufacturer Manager";
            this.tsManufacturer.Click += new System.EventHandler(this.tsScanBarCode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsJobsManager
            // 
            this.tsJobsManager.Image = global::Mosiac.UX.Properties.Resources.twotone_home_work_black_24dp;
            this.tsJobsManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsJobsManager.Name = "tsJobsManager";
            this.tsJobsManager.Size = new System.Drawing.Size(36, 52);
            this.tsJobsManager.Text = "Jobs";
            this.tsJobsManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbJobItems
            // 
            this.tsbJobItems.Image = global::Mosiac.UX.Properties.Resources.twotone_account_tree_black_24dp;
            this.tsbJobItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJobItems.Name = "tsbJobItems";
            this.tsbJobItems.Size = new System.Drawing.Size(61, 52);
            this.tsbJobItems.Text = "Job Items";
            this.tsbJobItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbJobItems.ToolTipText = "Pull Stock";
            this.tsbJobItems.Click += new System.EventHandler(this.tsbJobItems_OnClick);
            // 
            // tsDeliveries
            // 
            this.tsDeliveries.Image = ((System.Drawing.Image)(resources.GetObject("tsDeliveries.Image")));
            this.tsDeliveries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeliveries.Name = "tsDeliveries";
            this.tsDeliveries.Size = new System.Drawing.Size(61, 52);
            this.tsDeliveries.Text = "Deliveries";
            this.tsDeliveries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 796);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1209, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "{{Current Tab}}";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.ItemSize = new System.Drawing.Size(58, 24);
            this.MainTabControl.Location = new System.Drawing.Point(0, 55);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.ShowToolTips = true;
            this.MainTabControl.Size = new System.Drawing.Size(1209, 741);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainTabControl_DrawItem);
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MaintabControl_SelectedIndexChanged);
            this.MainTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainTabControl_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 818);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Main";
            this.Text = "Mosiac";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

