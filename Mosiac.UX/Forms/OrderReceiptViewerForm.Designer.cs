
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
            tsbClose = new System.Windows.Forms.ToolStrip();
            tsClose = new System.Windows.Forms.ToolStripButton();
            tsbPrint = new System.Windows.Forms.ToolStripButton();
            tsbClose.SuspendLayout();
            SuspendLayout();
            // 
            // tsbClose
            // 
            tsbClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            tsbClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsClose, tsbPrint });
            tsbClose.Location = new System.Drawing.Point(0, 756);
            tsbClose.Name = "tsbClose";
            tsbClose.Size = new System.Drawing.Size(1016, 25);
            tsbClose.TabIndex = 0;
            tsbClose.Text = "toolStrip1";
            tsbClose.ItemClicked += tsbClose_ItemClicked;
            // 
            // tsClose
            // 
            tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsClose.Image = (System.Drawing.Image)resources.GetObject("tsClose.Image");
            tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsClose.Name = "tsClose";
            tsClose.Size = new System.Drawing.Size(40, 22);
            tsClose.Text = "Close";
            // 
            // tsbPrint
            // 
            tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbPrint.Image = (System.Drawing.Image)resources.GetObject("tsbPrint.Image");
            tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbPrint.Name = "tsbPrint";
            tsbPrint.Size = new System.Drawing.Size(36, 22);
            tsbPrint.Text = "Print";
            // 
            // OrderReceiptViewerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1016, 781);
            Controls.Add(tsbClose);
            Name = "OrderReceiptViewerForm";
            Text = "OrderReceiptViewerForm";
            Load += OrderReceiptViewerForm_Load;
            tsbClose.ResumeLayout(false);
            tsbClose.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip tsbClose;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton tsbPrint;
    }
}