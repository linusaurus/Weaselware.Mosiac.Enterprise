
using System.Drawing;

namespace Mosiac.UX.UXControls
{
    partial class SupplierManager
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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tbcOrderReciepts = new System.Windows.Forms.TabControl();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgSupplierOrders = new System.Windows.Forms.DataGridView();
            this.dgOrderLineItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.tbcOrderReciepts.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.Location = new System.Drawing.Point(6, 6);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.tbcOrderReciepts);
            this.MainSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.MainSplitContainer.Size = new System.Drawing.Size(1138, 690);
            this.MainSplitContainer.SplitterDistance = 285;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // tbcOrderReciepts
            // 
            this.tbcOrderReciepts.Controls.Add(this.OrdersPage);
            this.tbcOrderReciepts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbcOrderReciepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcOrderReciepts.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbcOrderReciepts.Location = new System.Drawing.Point(10, 15);
            this.tbcOrderReciepts.Name = "tbcOrderReciepts";
            this.tbcOrderReciepts.SelectedIndex = 0;
            this.tbcOrderReciepts.Size = new System.Drawing.Size(829, 665);
            this.tbcOrderReciepts.TabIndex = 2;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.splitContainer1);
            this.OrdersPage.Location = new System.Drawing.Point(4, 24);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(821, 637);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Supplier Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgSupplierOrders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgOrderLineItems);
            this.splitContainer1.Size = new System.Drawing.Size(815, 631);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgSupplierOrders
            // 
            this.dgSupplierOrders.AllowUserToAddRows = false;
            this.dgSupplierOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSupplierOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSupplierOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSupplierOrders.Location = new System.Drawing.Point(0, 0);
            this.dgSupplierOrders.Name = "dgSupplierOrders";
            this.dgSupplierOrders.Size = new System.Drawing.Size(815, 371);
            this.dgSupplierOrders.TabIndex = 0;
            this.dgSupplierOrders.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dgSupplierOrders.DoubleClick += new System.EventHandler(this.dgSupplierOrders_DoubleClick);
            // 
            // dgOrderLineItems
            // 
            this.dgOrderLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderLineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderLineItems.Location = new System.Drawing.Point(0, 0);
            this.dgOrderLineItems.Name = "dgOrderLineItems";
            this.dgOrderLineItems.RowTemplate.Height = 25;
            this.dgOrderLineItems.Size = new System.Drawing.Size(815, 256);
            this.dgOrderLineItems.TabIndex = 1;
            this.dgOrderLineItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderLineItems_CellContentClick);
            // 
            // SupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "SupplierManager";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1150, 702);
            this.Load += new System.EventHandler(this.SupplierManager_Load);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.tbcOrderReciepts.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItems)).EndInit();
            this.ResumeLayout(false);

        }

        Point _imageLocation = new Point(20, 4);
        Point _imgHitArea = new Point(20, 4);
        Image closeImage;

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.DataGridView dgSupplierOrders;
        private System.Windows.Forms.DataGridView dgOrderLineItems;
        private System.Windows.Forms.TabControl tbcOrderReciepts;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
