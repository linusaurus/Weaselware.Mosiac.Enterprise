
using System.Drawing;
using System.Windows.Forms;

namespace Mosiac.UX.UXControls
{
    partial class PartManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartManager));
            txtSearch = new TextBox();
            dgPartsSearch = new DataGridView();
            panel1 = new Panel();
            btnSearch = new Button();
            txtSecondTerm = new TextBox();
            txtThirdTerm = new TextBox();
            btnOpenPart = new Button();
            txtPartIDLookup = new TextBox();
            ckbUseManufacturer = new CheckBox();
            cboManu = new ComboBox();
            dgResources = new DataGridView();
            dgPartOrders = new DataGridView();
            btnNewPart = new Button();
            btnSave = new Button();
            tabPartDetail = new TabControl();
            tabResourceManager = new TabPage();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            txtFileSource = new TextBox();
            btnShowFile = new Button();
            panel2 = new Panel();
            propertyGrid1 = new PropertyGrid();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            tabOrderHistory = new TabPage();
            btnShowAll = new Button();
            tsResources = new ToolStrip();
            tsbCollapsePanel = new ToolStripButton();
            btnPrintLabel = new Button();
            spcPartsManager = new SplitContainer();
            tabPartManager = new TabControl();
            tabPartsManager = new TabPage();
            tabStockTransactions = new TabPage();
            splitContainer2 = new SplitContainer();
            dgvStockParts = new DataGridView();
            toolStrip2 = new ToolStrip();
            spcTransactionDetails = new SplitContainer();
            dgTransactionsGrid = new DataGridView();
            tsTransactions = new ToolStrip();
            tsbReceipts = new ToolStripButton();
            tsbAudits = new ToolStripButton();
            tsbPulls = new ToolStripButton();
            tsbAll = new ToolStripButton();
            tsbRemoveSelected = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbEditSelected = new ToolStripButton();
            panel3 = new Panel();
            btnPullStock = new Button();
            txtStockLevel = new TextBox();
            btnRollup = new Button();
            label1 = new Label();
            button1 = new Button();
            tabLocations = new TabPage();
            spcLocations = new SplitContainer();
            dgLocations = new DataGridView();
            tsLocationMenu = new ToolStrip();
            tsbNew = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbFilter = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            txtAreaFilter = new ToolStripTextBox();
            tsLocationPartsToolBar = new ToolStrip();
            tsbSaveLocationParts = new ToolStripButton();
            dgLocationParts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPartsSearch).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPartOrders).BeginInit();
            tabPartDetail.SuspendLayout();
            tabResourceManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabOrderHistory.SuspendLayout();
            tsResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcPartsManager).BeginInit();
            spcPartsManager.Panel1.SuspendLayout();
            spcPartsManager.Panel2.SuspendLayout();
            spcPartsManager.SuspendLayout();
            tabPartManager.SuspendLayout();
            tabPartsManager.SuspendLayout();
            tabStockTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcTransactionDetails).BeginInit();
            spcTransactionDetails.Panel1.SuspendLayout();
            spcTransactionDetails.Panel2.SuspendLayout();
            spcTransactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTransactionsGrid).BeginInit();
            tsTransactions.SuspendLayout();
            panel3.SuspendLayout();
            tabLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcLocations).BeginInit();
            spcLocations.Panel1.SuspendLayout();
            spcLocations.Panel2.SuspendLayout();
            spcLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocations).BeginInit();
            tsLocationMenu.SuspendLayout();
            tsLocationPartsToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocationParts).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Search ....";
            txtSearch.Size = new Size(173, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.MouseDoubleClick += txtSearch_MouseDoubleClick;
            // 
            // dgPartsSearch
            // 
            dgPartsSearch.AllowUserToAddRows = false;
            dgPartsSearch.AllowUserToDeleteRows = false;
            dgPartsSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPartsSearch.Dock = DockStyle.Fill;
            dgPartsSearch.Location = new Point(6, 6);
            dgPartsSearch.Name = "dgPartsSearch";
            dgPartsSearch.ReadOnly = true;
            dgPartsSearch.Size = new Size(850, 531);
            dgPartsSearch.TabIndex = 9;
            dgPartsSearch.VirtualMode = true;
            dgPartsSearch.CellMouseDoubleClick += dgPartsSearch_CellMouseDoubleClick;
            dgPartsSearch.SelectionChanged += dgAttachments_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSecondTerm);
            panel1.Controls.Add(txtThirdTerm);
            panel1.Controls.Add(btnOpenPart);
            panel1.Controls.Add(txtPartIDLookup);
            panel1.Controls.Add(ckbUseManufacturer);
            panel1.Controls.Add(cboManu);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(10, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 45);
            panel1.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(417, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSecondTerm
            // 
            txtSecondTerm.Location = new Point(199, 6);
            txtSecondTerm.Name = "txtSecondTerm";
            txtSecondTerm.Size = new Size(100, 23);
            txtSecondTerm.TabIndex = 2;
            // 
            // txtThirdTerm
            // 
            txtThirdTerm.Location = new Point(306, 6);
            txtThirdTerm.Name = "txtThirdTerm";
            txtThirdTerm.Size = new Size(100, 23);
            txtThirdTerm.TabIndex = 3;
            // 
            // btnOpenPart
            // 
            btnOpenPart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenPart.FlatAppearance.BorderColor = Color.Red;
            btnOpenPart.FlatAppearance.BorderSize = 2;
            btnOpenPart.FlatStyle = FlatStyle.Flat;
            btnOpenPart.Location = new Point(1144, 5);
            btnOpenPart.Name = "btnOpenPart";
            btnOpenPart.Size = new Size(65, 25);
            btnOpenPart.TabIndex = 17;
            btnOpenPart.Text = "PartID";
            btnOpenPart.UseVisualStyleBackColor = true;
            btnOpenPart.Click += button1_Click;
            btnOpenPart.KeyPress += btnOpenPart_KeyPress;
            // 
            // txtPartIDLookup
            // 
            txtPartIDLookup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPartIDLookup.Location = new Point(1232, 6);
            txtPartIDLookup.Name = "txtPartIDLookup";
            txtPartIDLookup.Size = new Size(75, 23);
            txtPartIDLookup.TabIndex = 16;
            txtPartIDLookup.TextAlign = HorizontalAlignment.Center;
            // 
            // ckbUseManufacturer
            // 
            ckbUseManufacturer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckbUseManufacturer.AutoSize = true;
            ckbUseManufacturer.Location = new Point(1025, 8);
            ckbUseManufacturer.Name = "ckbUseManufacturer";
            ckbUseManufacturer.Size = new Size(98, 19);
            ckbUseManufacturer.TabIndex = 14;
            ckbUseManufacturer.Text = "Manufacturer";
            ckbUseManufacturer.UseVisualStyleBackColor = true;
            ckbUseManufacturer.CheckedChanged += ckbUseManufacturer_CheckedChanged;
            // 
            // cboManu
            // 
            cboManu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboManu.Enabled = false;
            cboManu.FormattingEnabled = true;
            cboManu.Location = new Point(860, 5);
            cboManu.Name = "cboManu";
            cboManu.Size = new Size(159, 23);
            cboManu.TabIndex = 13;
            cboManu.SelectedIndexChanged += cboManu_SelectedIndexChanged;
            // 
            // dgResources
            // 
            dgResources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResources.Dock = DockStyle.Fill;
            dgResources.Location = new Point(6, 45);
            dgResources.Name = "dgResources";
            dgResources.Size = new Size(401, 216);
            dgResources.TabIndex = 8;
            dgResources.CellMouseDoubleClick += dgResources_CellMouseDoubleClick;
            dgResources.SelectionChanged += dgResources_SelectionChanged;
            // 
            // dgPartOrders
            // 
            dgPartOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPartOrders.Dock = DockStyle.Fill;
            dgPartOrders.Location = new Point(6, 6);
            dgPartOrders.Name = "dgPartOrders";
            dgPartOrders.Size = new Size(407, 491);
            dgPartOrders.TabIndex = 13;
            dgPartOrders.CellMouseDoubleClick += dgPartOrders_CellMouseDoubleClick;
            // 
            // btnNewPart
            // 
            btnNewPart.AutoSize = true;
            btnNewPart.FlatAppearance.BorderColor = Color.Sienna;
            btnNewPart.FlatAppearance.BorderSize = 2;
            btnNewPart.FlatStyle = FlatStyle.Flat;
            btnNewPart.Location = new Point(176, 70);
            btnNewPart.Name = "btnNewPart";
            btnNewPart.Size = new Size(122, 29);
            btnNewPart.TabIndex = 15;
            btnNewPart.Text = "New Part";
            btnNewPart.UseVisualStyleBackColor = true;
            btnNewPart.Click += btnNewPart_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 69);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 32);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabPartDetail
            // 
            tabPartDetail.Controls.Add(tabResourceManager);
            tabPartDetail.Controls.Add(tabOrderHistory);
            tabPartDetail.Dock = DockStyle.Fill;
            tabPartDetail.Location = new Point(6, 6);
            tabPartDetail.Name = "tabPartDetail";
            tabPartDetail.SelectedIndex = 0;
            tabPartDetail.Size = new Size(427, 531);
            tabPartDetail.TabIndex = 1;
            // 
            // tabResourceManager
            // 
            tabResourceManager.Controls.Add(splitContainer1);
            tabResourceManager.Controls.Add(toolStrip1);
            tabResourceManager.Location = new Point(4, 24);
            tabResourceManager.Name = "tabResourceManager";
            tabResourceManager.Padding = new Padding(3);
            tabResourceManager.Size = new Size(419, 503);
            tabResourceManager.TabIndex = 0;
            tabResourceManager.Text = "Resource Manager";
            tabResourceManager.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 34);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgResources);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Padding = new Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Padding = new Padding(6);
            splitContainer1.Size = new Size(413, 466);
            splitContainer1.SplitterDistance = 267;
            splitContainer1.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtFileSource);
            panel4.Controls.Add(btnShowFile);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(401, 39);
            panel4.TabIndex = 11;
            // 
            // txtFileSource
            // 
            txtFileSource.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileSource.Location = new Point(6, 8);
            txtFileSource.Name = "txtFileSource";
            txtFileSource.Size = new Size(297, 23);
            txtFileSource.TabIndex = 9;
            // 
            // btnShowFile
            // 
            btnShowFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowFile.Location = new Point(318, 7);
            btnShowFile.Name = "btnShowFile";
            btnShowFile.Size = new Size(69, 23);
            btnShowFile.TabIndex = 10;
            btnShowFile.Text = "Show";
            btnShowFile.UseVisualStyleBackColor = true;
            btnShowFile.Click += btnShowFile_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(propertyGrid1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 183);
            panel2.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            propertyGrid1.BackColor = Color.Gainsboro;
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(399, 181);
            propertyGrid1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(413, 31);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.round_add_circle_outline_black_24dp1;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(0, 0, 4, 0);
            toolStripButton1.Size = new Size(32, 28);
            toolStripButton1.Text = "tsbOpenResource";
            toolStripButton1.ToolTipText = "Add a Resource";
            toolStripButton1.Click += btnNewResource_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.baseline_launch_black_24dp;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new Padding(0, 0, 4, 0);
            toolStripButton2.Size = new Size(32, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Open the Resource";
            toolStripButton2.Click += btnOpenResource_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.baseline_get_app_black_24dp;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Padding = new Padding(0, 0, 6, 0);
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Open the Local Resource";
            toolStripButton3.Click += btnOpenCache_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.baseline_clear_black_24dp;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 28);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += btnClearCache_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.outline_delete_black_24dp2;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(28, 28);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.ToolTipText = "Delete the Resource";
            toolStripButton5.Click += btnDeleteResource_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Alignment = ToolStripItemAlignment.Right;
            toolStripButton6.BackColor = Color.PapayaWhip;
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(100, 28);
            toolStripButton6.Text = "Update Resource";
            toolStripButton6.Click += button1_Click_1;
            // 
            // tabOrderHistory
            // 
            tabOrderHistory.Controls.Add(dgPartOrders);
            tabOrderHistory.Location = new Point(4, 24);
            tabOrderHistory.Name = "tabOrderHistory";
            tabOrderHistory.Padding = new Padding(6);
            tabOrderHistory.Size = new Size(419, 503);
            tabOrderHistory.TabIndex = 1;
            tabOrderHistory.Text = "Part Order History";
            tabOrderHistory.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.AutoSize = true;
            btnShowAll.FlatAppearance.BorderColor = Color.Sienna;
            btnShowAll.FlatAppearance.BorderSize = 2;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Location = new Point(304, 70);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(110, 29);
            btnShowAll.TabIndex = 17;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // tsResources
            // 
            tsResources.Dock = DockStyle.Bottom;
            tsResources.Items.AddRange(new ToolStripItem[] { tsbCollapsePanel });
            tsResources.Location = new Point(10, 697);
            tsResources.Margin = new Padding(3);
            tsResources.Name = "tsResources";
            tsResources.Size = new Size(1328, 25);
            tsResources.TabIndex = 18;
            tsResources.Text = "toolStrip1";
            tsResources.ItemClicked += tsResources_ItemClicked_1;
            // 
            // tsbCollapsePanel
            // 
            tsbCollapsePanel.Alignment = ToolStripItemAlignment.Right;
            tsbCollapsePanel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCollapsePanel.Image = Properties.Resources.round_keyboard_arrow_down_black_24dp;
            tsbCollapsePanel.ImageTransparentColor = Color.Magenta;
            tsbCollapsePanel.Name = "tsbCollapsePanel";
            tsbCollapsePanel.Size = new Size(23, 22);
            tsbCollapsePanel.Text = "toolStripButton3";
            // 
            // btnPrintLabel
            // 
            btnPrintLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintLabel.AutoSize = true;
            btnPrintLabel.FlatAppearance.BorderColor = Color.Sienna;
            btnPrintLabel.FlatAppearance.BorderSize = 2;
            btnPrintLabel.FlatStyle = FlatStyle.Flat;
            btnPrintLabel.Location = new Point(1196, 68);
            btnPrintLabel.Name = "btnPrintLabel";
            btnPrintLabel.Size = new Size(139, 29);
            btnPrintLabel.TabIndex = 17;
            btnPrintLabel.Text = "Print Label";
            btnPrintLabel.UseVisualStyleBackColor = true;
            btnPrintLabel.Click += btnPrintLabel_Click;
            // 
            // spcPartsManager
            // 
            spcPartsManager.Dock = DockStyle.Fill;
            spcPartsManager.Location = new Point(6, 6);
            spcPartsManager.Name = "spcPartsManager";
            // 
            // spcPartsManager.Panel1
            // 
            spcPartsManager.Panel1.Controls.Add(dgPartsSearch);
            spcPartsManager.Panel1.Padding = new Padding(6);
            spcPartsManager.Panel1MinSize = 300;
            // 
            // spcPartsManager.Panel2
            // 
            spcPartsManager.Panel2.Controls.Add(tabPartDetail);
            spcPartsManager.Panel2.Padding = new Padding(6);
            spcPartsManager.Size = new Size(1305, 543);
            spcPartsManager.SplitterDistance = 862;
            spcPartsManager.TabIndex = 19;
            // 
            // tabPartManager
            // 
            tabPartManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPartManager.Controls.Add(tabPartsManager);
            tabPartManager.Controls.Add(tabStockTransactions);
            tabPartManager.Controls.Add(tabLocations);
            tabPartManager.Location = new Point(10, 107);
            tabPartManager.Name = "tabPartManager";
            tabPartManager.SelectedIndex = 0;
            tabPartManager.Size = new Size(1325, 583);
            tabPartManager.TabIndex = 20;
            tabPartManager.SelectedIndexChanged += tabPartManager_SelectedIndexChanged;
            // 
            // tabPartsManager
            // 
            tabPartsManager.Controls.Add(spcPartsManager);
            tabPartsManager.Location = new Point(4, 24);
            tabPartsManager.Name = "tabPartsManager";
            tabPartsManager.Padding = new Padding(6);
            tabPartsManager.Size = new Size(1317, 555);
            tabPartsManager.TabIndex = 0;
            tabPartsManager.Text = "Part Manager";
            tabPartsManager.UseVisualStyleBackColor = true;
            // 
            // tabStockTransactions
            // 
            tabStockTransactions.Controls.Add(splitContainer2);
            tabStockTransactions.Location = new Point(4, 24);
            tabStockTransactions.Name = "tabStockTransactions";
            tabStockTransactions.Padding = new Padding(6);
            tabStockTransactions.Size = new Size(1317, 555);
            tabStockTransactions.TabIndex = 1;
            tabStockTransactions.Text = "Stock Transactions";
            tabStockTransactions.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(6, 6);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvStockParts);
            splitContainer2.Panel1.Controls.Add(toolStrip2);
            splitContainer2.Panel1.Padding = new Padding(6);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(spcTransactionDetails);
            splitContainer2.Panel2.Padding = new Padding(6);
            splitContainer2.Size = new Size(1305, 543);
            splitContainer2.SplitterDistance = 446;
            splitContainer2.TabIndex = 0;
            // 
            // dgvStockParts
            // 
            dgvStockParts.AllowUserToAddRows = false;
            dgvStockParts.AllowUserToDeleteRows = false;
            dgvStockParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockParts.Dock = DockStyle.Fill;
            dgvStockParts.Location = new Point(6, 31);
            dgvStockParts.Margin = new Padding(3, 12, 3, 3);
            dgvStockParts.Name = "dgvStockParts";
            dgvStockParts.ReadOnly = true;
            dgvStockParts.Size = new Size(434, 506);
            dgvStockParts.TabIndex = 0;
            dgvStockParts.SelectionChanged += dgvStockParts_SelectionChanged;
            // 
            // toolStrip2
            // 
            toolStrip2.Location = new Point(6, 6);
            toolStrip2.Margin = new Padding(0, 0, 0, 12);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(434, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // spcTransactionDetails
            // 
            spcTransactionDetails.Dock = DockStyle.Fill;
            spcTransactionDetails.FixedPanel = FixedPanel.Panel2;
            spcTransactionDetails.Location = new Point(6, 6);
            spcTransactionDetails.Name = "spcTransactionDetails";
            spcTransactionDetails.Orientation = Orientation.Horizontal;
            // 
            // spcTransactionDetails.Panel1
            // 
            spcTransactionDetails.Panel1.Controls.Add(dgTransactionsGrid);
            spcTransactionDetails.Panel1.Controls.Add(tsTransactions);
            spcTransactionDetails.Panel1.Padding = new Padding(6);
            // 
            // spcTransactionDetails.Panel2
            // 
            spcTransactionDetails.Panel2.Controls.Add(panel3);
            spcTransactionDetails.Size = new Size(843, 531);
            spcTransactionDetails.SplitterDistance = 462;
            spcTransactionDetails.TabIndex = 0;
            // 
            // dgTransactionsGrid
            // 
            dgTransactionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransactionsGrid.Dock = DockStyle.Fill;
            dgTransactionsGrid.Location = new Point(6, 37);
            dgTransactionsGrid.Margin = new Padding(3, 6, 3, 3);
            dgTransactionsGrid.Name = "dgTransactionsGrid";
            dgTransactionsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTransactionsGrid.Size = new Size(831, 419);
            dgTransactionsGrid.TabIndex = 1;
            dgTransactionsGrid.RowStateChanged += dgTransactionsGrid_RowStateChanged;
            dgTransactionsGrid.SelectionChanged += dgTransactionsGrid_SelectionChanged;
            // 
            // tsTransactions
            // 
            tsTransactions.Items.AddRange(new ToolStripItem[] { tsbReceipts, tsbAudits, tsbPulls, tsbAll, tsbRemoveSelected, toolStripSeparator1, tsbEditSelected });
            tsTransactions.Location = new Point(6, 6);
            tsTransactions.Margin = new Padding(0, 0, 0, 6);
            tsTransactions.Name = "tsTransactions";
            tsTransactions.Padding = new Padding(0, 0, 1, 8);
            tsTransactions.Size = new Size(831, 31);
            tsTransactions.TabIndex = 0;
            tsTransactions.Text = "toolStrip2";
            tsTransactions.ItemClicked += tsTransactions_ItemClicked;
            // 
            // tsbReceipts
            // 
            tsbReceipts.AutoSize = false;
            tsbReceipts.BackColor = Color.Gainsboro;
            tsbReceipts.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbReceipts.Image = (Image)resources.GetObject("tsbReceipts.Image");
            tsbReceipts.ImageTransparentColor = Color.Magenta;
            tsbReceipts.Margin = new Padding(4, 1, 4, 2);
            tsbReceipts.Name = "tsbReceipts";
            tsbReceipts.Padding = new Padding(6, 0, 6, 0);
            tsbReceipts.Size = new Size(67, 19);
            tsbReceipts.Text = "Receipts";
            // 
            // tsbAudits
            // 
            tsbAudits.AutoSize = false;
            tsbAudits.BackColor = Color.Gainsboro;
            tsbAudits.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAudits.Image = (Image)resources.GetObject("tsbAudits.Image");
            tsbAudits.ImageTransparentColor = Color.Magenta;
            tsbAudits.Margin = new Padding(0, 1, 4, 2);
            tsbAudits.Name = "tsbAudits";
            tsbAudits.Padding = new Padding(6, 0, 6, 0);
            tsbAudits.Size = new Size(90, 19);
            tsbAudits.Text = "Adjustments";
            // 
            // tsbPulls
            // 
            tsbPulls.AutoSize = false;
            tsbPulls.BackColor = Color.Gainsboro;
            tsbPulls.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbPulls.Image = (Image)resources.GetObject("tsbPulls.Image");
            tsbPulls.ImageTransparentColor = Color.Magenta;
            tsbPulls.Margin = new Padding(0, 1, 4, 2);
            tsbPulls.Name = "tsbPulls";
            tsbPulls.Padding = new Padding(6, 0, 6, 0);
            tsbPulls.Size = new Size(90, 19);
            tsbPulls.Text = "Pull Stock";
            // 
            // tsbAll
            // 
            tsbAll.AutoSize = false;
            tsbAll.BackColor = Color.Moccasin;
            tsbAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAll.Image = (Image)resources.GetObject("tsbAll.Image");
            tsbAll.ImageTransparentColor = Color.Magenta;
            tsbAll.Name = "tsbAll";
            tsbAll.Padding = new Padding(6, 0, 6, 0);
            tsbAll.Size = new Size(60, 19);
            tsbAll.Text = "All";
            // 
            // tsbRemoveSelected
            // 
            tsbRemoveSelected.Alignment = ToolStripItemAlignment.Right;
            tsbRemoveSelected.AutoSize = false;
            tsbRemoveSelected.BackColor = Color.LightBlue;
            tsbRemoveSelected.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbRemoveSelected.Image = (Image)resources.GetObject("tsbRemoveSelected.Image");
            tsbRemoveSelected.ImageTransparentColor = Color.Magenta;
            tsbRemoveSelected.Name = "tsbRemoveSelected";
            tsbRemoveSelected.Padding = new Padding(6, 0, 6, 0);
            tsbRemoveSelected.Size = new Size(113, 19);
            tsbRemoveSelected.Text = "Remove Selected";
            tsbRemoveSelected.Click += tsbRemoveSelected_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 23);
            // 
            // tsbEditSelected
            // 
            tsbEditSelected.Alignment = ToolStripItemAlignment.Right;
            tsbEditSelected.BackColor = Color.Black;
            tsbEditSelected.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEditSelected.ForeColor = SystemColors.ControlLightLight;
            tsbEditSelected.Image = (Image)resources.GetObject("tsbEditSelected.Image");
            tsbEditSelected.ImageTransparentColor = Color.Magenta;
            tsbEditSelected.Margin = new Padding(2, 1, 2, 2);
            tsbEditSelected.Name = "tsbEditSelected";
            tsbEditSelected.Padding = new Padding(12, 0, 6, 0);
            tsbEditSelected.Size = new Size(96, 20);
            tsbEditSelected.Text = "Edit Selected";
            tsbEditSelected.Click += EditInventoryItem;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnPullStock);
            panel3.Controls.Add(txtStockLevel);
            panel3.Controls.Add(btnRollup);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 65);
            panel3.TabIndex = 3;
            // 
            // btnPullStock
            // 
            btnPullStock.Location = new Point(143, 22);
            btnPullStock.Name = "btnPullStock";
            btnPullStock.Size = new Size(119, 25);
            btnPullStock.TabIndex = 2;
            btnPullStock.Text = "Pull Stock";
            btnPullStock.UseVisualStyleBackColor = true;
            btnPullStock.Click += btnPullStock_Click;
            // 
            // txtStockLevel
            // 
            txtStockLevel.Location = new Point(287, 24);
            txtStockLevel.Name = "txtStockLevel";
            txtStockLevel.ReadOnly = true;
            txtStockLevel.Size = new Size(113, 23);
            txtStockLevel.TabIndex = 0;
            txtStockLevel.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRollup
            // 
            btnRollup.BackColor = Color.Black;
            btnRollup.FlatStyle = FlatStyle.Flat;
            btnRollup.ForeColor = SystemColors.ControlLightLight;
            btnRollup.Location = new Point(619, 24);
            btnRollup.Name = "btnRollup";
            btnRollup.Size = new Size(119, 25);
            btnRollup.TabIndex = 2;
            btnRollup.Text = "Roll Up";
            btnRollup.UseVisualStyleBackColor = false;
            btnRollup.Click += btnRollup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 6);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Stock Level";
            // 
            // button1
            // 
            button1.Location = new Point(18, 22);
            button1.Name = "button1";
            button1.Size = new Size(119, 25);
            button1.TabIndex = 2;
            button1.Text = "Set Level";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // tabLocations
            // 
            tabLocations.Controls.Add(spcLocations);
            tabLocations.Location = new Point(4, 24);
            tabLocations.Name = "tabLocations";
            tabLocations.Padding = new Padding(12);
            tabLocations.Size = new Size(1317, 555);
            tabLocations.TabIndex = 2;
            tabLocations.Text = "Stock Locations";
            tabLocations.UseVisualStyleBackColor = true;
            // 
            // spcLocations
            // 
            spcLocations.Dock = DockStyle.Fill;
            spcLocations.FixedPanel = FixedPanel.Panel1;
            spcLocations.Location = new Point(12, 12);
            spcLocations.Name = "spcLocations";
            // 
            // spcLocations.Panel1
            // 
            spcLocations.Panel1.Controls.Add(dgLocations);
            spcLocations.Panel1.Controls.Add(tsLocationMenu);
            spcLocations.Panel1.Padding = new Padding(12);
            // 
            // spcLocations.Panel2
            // 
            spcLocations.Panel2.Controls.Add(tsLocationPartsToolBar);
            spcLocations.Panel2.Controls.Add(dgLocationParts);
            spcLocations.Panel2.Margin = new Padding(0, 0, 0, 12);
            spcLocations.Panel2.Padding = new Padding(12);
            spcLocations.Size = new Size(1293, 531);
            spcLocations.SplitterDistance = 280;
            spcLocations.TabIndex = 0;
            // 
            // dgLocations
            // 
            dgLocations.AllowUserToAddRows = false;
            dgLocations.AllowUserToDeleteRows = false;
            dgLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLocations.Dock = DockStyle.Fill;
            dgLocations.Location = new Point(12, 44);
            dgLocations.Margin = new Padding(3, 12, 3, 3);
            dgLocations.Name = "dgLocations";
            dgLocations.Size = new Size(256, 475);
            dgLocations.TabIndex = 1;
            dgLocations.SelectionChanged += dgLocations_SelectionChanged;
            // 
            // tsLocationMenu
            // 
            tsLocationMenu.Items.AddRange(new ToolStripItem[] { tsbNew, tsbEdit, tsbFilter, toolStripSeparator2, txtAreaFilter });
            tsLocationMenu.Location = new Point(12, 12);
            tsLocationMenu.Margin = new Padding(0, 0, 0, 12);
            tsLocationMenu.Name = "tsLocationMenu";
            tsLocationMenu.Padding = new Padding(2);
            tsLocationMenu.Size = new Size(256, 32);
            tsLocationMenu.TabIndex = 0;
            tsLocationMenu.Text = "toolStrip3";
            tsLocationMenu.ItemClicked += tsLocationMenu_ItemClicked;
            // 
            // tsbNew
            // 
            tsbNew.AutoSize = false;
            tsbNew.BackColor = Color.PowderBlue;
            tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNew.Image = (Image)resources.GetObject("tsbNew.Image");
            tsbNew.ImageTransparentColor = Color.Magenta;
            tsbNew.Margin = new Padding(4, 1, 4, 2);
            tsbNew.Name = "tsbNew";
            tsbNew.Padding = new Padding(3);
            tsbNew.Size = new Size(41, 25);
            tsbNew.Text = "All";
            // 
            // tsbEdit
            // 
            tsbEdit.AutoSize = false;
            tsbEdit.BackColor = Color.Wheat;
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Margin = new Padding(0, 1, 4, 2);
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Padding = new Padding(0, 0, 4, 0);
            tsbEdit.Size = new Size(31, 25);
            tsbEdit.Text = "Edit";
            // 
            // tsbFilter
            // 
            tsbFilter.AutoSize = false;
            tsbFilter.BackColor = Color.Black;
            tsbFilter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbFilter.ForeColor = SystemColors.Control;
            tsbFilter.Image = (Image)resources.GetObject("tsbFilter.Image");
            tsbFilter.ImageTransparentColor = Color.Magenta;
            tsbFilter.Name = "tsbFilter";
            tsbFilter.Size = new Size(44, 25);
            tsbFilter.Text = "Filter";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // txtAreaFilter
            // 
            txtAreaFilter.AutoSize = false;
            txtAreaFilter.Margin = new Padding(4, 0, 4, 0);
            txtAreaFilter.Name = "txtAreaFilter";
            txtAreaFilter.Size = new Size(50, 23);
            txtAreaFilter.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // tsLocationPartsToolBar
            // 
            tsLocationPartsToolBar.Items.AddRange(new ToolStripItem[] { tsbSaveLocationParts });
            tsLocationPartsToolBar.Location = new Point(12, 12);
            tsLocationPartsToolBar.Name = "tsLocationPartsToolBar";
            tsLocationPartsToolBar.Size = new Size(985, 25);
            tsLocationPartsToolBar.TabIndex = 1;
            tsLocationPartsToolBar.Text = "toolStrip4";
            tsLocationPartsToolBar.ItemClicked += tsLocationPartsToolBar_ItemClicked;
            // 
            // tsbSaveLocationParts
            // 
            tsbSaveLocationParts.BackColor = Color.Gainsboro;
            tsbSaveLocationParts.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSaveLocationParts.Image = (Image)resources.GetObject("tsbSaveLocationParts.Image");
            tsbSaveLocationParts.ImageTransparentColor = Color.Magenta;
            tsbSaveLocationParts.Name = "tsbSaveLocationParts";
            tsbSaveLocationParts.Size = new Size(84, 22);
            tsbSaveLocationParts.Text = "Save Changes";
            // 
            // dgLocationParts
            // 
            dgLocationParts.AllowUserToAddRows = false;
            dgLocationParts.AllowUserToDeleteRows = false;
            dgLocationParts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgLocationParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLocationParts.Location = new Point(15, 44);
            dgLocationParts.Name = "dgLocationParts";
            dgLocationParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLocationParts.Size = new Size(979, 475);
            dgLocationParts.TabIndex = 0;
            // 
            // PartManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabPartManager);
            Controls.Add(tsResources);
            Controls.Add(btnPrintLabel);
            Controls.Add(btnShowAll);
            Controls.Add(btnSave);
            Controls.Add(btnNewPart);
            Controls.Add(panel1);
            MinimumSize = new Size(1095, 650);
            Name = "PartManager";
            Padding = new Padding(10);
            Size = new Size(1348, 732);
            ((System.ComponentModel.ISupportInitialize)dgPartsSearch).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPartOrders).EndInit();
            tabPartDetail.ResumeLayout(false);
            tabResourceManager.ResumeLayout(false);
            tabResourceManager.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabOrderHistory.ResumeLayout(false);
            tsResources.ResumeLayout(false);
            tsResources.PerformLayout();
            spcPartsManager.Panel1.ResumeLayout(false);
            spcPartsManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcPartsManager).EndInit();
            spcPartsManager.ResumeLayout(false);
            tabPartManager.ResumeLayout(false);
            tabPartsManager.ResumeLayout(false);
            tabStockTransactions.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockParts).EndInit();
            spcTransactionDetails.Panel1.ResumeLayout(false);
            spcTransactionDetails.Panel1.PerformLayout();
            spcTransactionDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcTransactionDetails).EndInit();
            spcTransactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgTransactionsGrid).EndInit();
            tsTransactions.ResumeLayout(false);
            tsTransactions.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabLocations.ResumeLayout(false);
            spcLocations.Panel1.ResumeLayout(false);
            spcLocations.Panel1.PerformLayout();
            spcLocations.Panel2.ResumeLayout(false);
            spcLocations.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spcLocations).EndInit();
            spcLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLocations).EndInit();
            tsLocationMenu.ResumeLayout(false);
            tsLocationMenu.PerformLayout();
            tsLocationPartsToolBar.ResumeLayout(false);
            tsLocationPartsToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocationParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgPartsSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboManu;
        private System.Windows.Forms.CheckBox ckbUseManufacturer;
        private System.Windows.Forms.ComboBox cboPartManu;
        private System.Windows.Forms.Button btnAddManu;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Button btnOpenPart;
        private System.Windows.Forms.TextBox txtPartIDLookup;
        private System.Windows.Forms.DataGridView dgPartOrders;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabPartDetail;
        private System.Windows.Forms.TabPage tabResourceManager;
        private System.Windows.Forms.TabPage tabOrderHistory;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtSecondTerm;
        private System.Windows.Forms.TextBox txtThirdTerm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStrip tsResources;
        private System.Windows.Forms.ToolStripButton tsbCollapsePanel;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.SplitContainer spcPartsManager;
        private System.Windows.Forms.TabControl tabPartManager;
        private System.Windows.Forms.TabPage tabPartsManager;
        private System.Windows.Forms.TabPage tabStockTransactions;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvStockParts;
        private System.Windows.Forms.SplitContainer spcTransactionDetails;
        private System.Windows.Forms.DataGridView dgTransactionsGrid;
        private System.Windows.Forms.ToolStrip tsTransactions;
        private System.Windows.Forms.ToolStripButton tsbReceipts;
        private System.Windows.Forms.ToolStripButton tsbAudits;
        private System.Windows.Forms.ToolStripButton tsbPulls;
        private System.Windows.Forms.ToolStripButton tsbAll;
        private System.Windows.Forms.ToolStripButton tsbRemoveSelected;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPullStock;
        private System.Windows.Forms.Button btnRollup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEditSelected;
        private System.Windows.Forms.TabPage tabLocations;
        private System.Windows.Forms.SplitContainer spcLocations;
        private System.Windows.Forms.DataGridView dgLocations;
        private System.Windows.Forms.ToolStrip tsLocationMenu;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbFilter;
        private System.Windows.Forms.DataGridView dgLocationParts;
        private System.Windows.Forms.ToolStrip tsLocationPartsToolBar;
        private System.Windows.Forms.ToolStripButton tsbSaveLocationParts;
        private System.Windows.Forms.ToolStripTextBox txtAreaFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel3;
        private TextBox txtFileSource;
        private Button btnShowFile;
        private Panel panel4;
    }
}
