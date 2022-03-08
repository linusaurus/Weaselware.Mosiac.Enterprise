
namespace Mosiac.UX.Forms
{
    partial class OrderReceiptViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderReceiptViewerForm));
            this.tsbClose = new System.Windows.Forms.ToolStrip();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbClose
            // 
            this.tsbClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsbClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose,
            this.tsbPrint});
            this.tsbClose.Location = new System.Drawing.Point(0, 612);
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(1016, 25);
            this.tsbClose.TabIndex = 0;
            this.tsbClose.Text = "toolStrip1";
            this.tsbClose.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsbClose_ItemClicked);
            // 
            // tsClose
            // 
            this.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(40, 22);
            this.tsClose.Text = "Close";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(36, 22);
            this.tsbPrint.Text = "Print";
            // 
            // OrderReceiptViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 637);
            this.Controls.Add(this.tsbClose);
            this.Name = "OrderReceiptViewerForm";
            this.Text = "OrderReceiptViewerForm";
            this.Load += new System.EventHandler(this.OrderReceiptViewerForm_Load);
            this.tsbClose.ResumeLayout(false);
            this.tsbClose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbClose;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsbPrint;
    }
}