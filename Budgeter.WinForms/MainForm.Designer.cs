
namespace Budgeter.WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.navigationToolStrip = new System.Windows.Forms.ToolStrip();
            this.overviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.transactionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.accountsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.categoriesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.storesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.budgetsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mainToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.bottomStatusStrip.SuspendLayout();
            this.navigationToolStrip.SuspendLayout();
            this.topMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStripContainer
            // 
            // 
            // mainToolStripContainer.BottomToolStripPanel
            // 
            this.mainToolStripContainer.BottomToolStripPanel.Controls.Add(this.bottomStatusStrip);
            // 
            // mainToolStripContainer.ContentPanel
            // 
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.contentPanel);
            this.mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(723, 404);
            this.mainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // mainToolStripContainer.LeftToolStripPanel
            // 
            this.mainToolStripContainer.LeftToolStripPanel.Controls.Add(this.navigationToolStrip);
            this.mainToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.mainToolStripContainer.Name = "mainToolStripContainer";
            this.mainToolStripContainer.Size = new System.Drawing.Size(800, 450);
            this.mainToolStripContainer.TabIndex = 0;
            this.mainToolStripContainer.Text = "toolStripContainer1";
            // 
            // mainToolStripContainer.TopToolStripPanel
            // 
            this.mainToolStripContainer.TopToolStripPanel.Controls.Add(this.topMenuStrip);
            // 
            // bottomStatusStrip
            // 
            this.bottomStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainProgressBar});
            this.bottomStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bottomStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.bottomStatusStrip.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.contentPanel.Size = new System.Drawing.Size(723, 404);
            this.contentPanel.TabIndex = 0;
            // 
            // navigationToolStrip
            // 
            this.navigationToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.navigationToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navigationToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripButton,
            this.transactionsToolStripButton,
            this.accountsToolStripButton,
            this.categoriesToolStripButton,
            this.storesToolStripButton,
            this.budgetsToolStripButton});
            this.navigationToolStrip.Location = new System.Drawing.Point(0, 3);
            this.navigationToolStrip.Name = "navigationToolStrip";
            this.navigationToolStrip.Size = new System.Drawing.Size(77, 230);
            this.navigationToolStrip.TabIndex = 1;
            // 
            // overviewToolStripButton
            // 
            this.overviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("overviewToolStripButton.Image")));
            this.overviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.overviewToolStripButton.Name = "overviewToolStripButton";
            this.overviewToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.overviewToolStripButton.Text = "Overview";
            this.overviewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.overviewToolStripButton.Click += new System.EventHandler(this.OverviewToolStripButton_Click);
            // 
            // transactionsToolStripButton
            // 
            this.transactionsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("transactionsToolStripButton.Image")));
            this.transactionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transactionsToolStripButton.Name = "transactionsToolStripButton";
            this.transactionsToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.transactionsToolStripButton.Text = "Transactions";
            this.transactionsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.transactionsToolStripButton.Click += new System.EventHandler(this.TransactionsToolStripButton_Click);
            // 
            // accountsToolStripButton
            // 
            this.accountsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("accountsToolStripButton.Image")));
            this.accountsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.accountsToolStripButton.Name = "accountsToolStripButton";
            this.accountsToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.accountsToolStripButton.Text = "Accounts";
            this.accountsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // categoriesToolStripButton
            // 
            this.categoriesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("categoriesToolStripButton.Image")));
            this.categoriesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categoriesToolStripButton.Name = "categoriesToolStripButton";
            this.categoriesToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.categoriesToolStripButton.Text = "Categories";
            this.categoriesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // storesToolStripButton
            // 
            this.storesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("storesToolStripButton.Image")));
            this.storesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.storesToolStripButton.Name = "storesToolStripButton";
            this.storesToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.storesToolStripButton.Text = "Stores";
            this.storesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // budgetsToolStripButton
            // 
            this.budgetsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("budgetsToolStripButton.Image")));
            this.budgetsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.budgetsToolStripButton.Name = "budgetsToolStripButton";
            this.budgetsToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.budgetsToolStripButton.Text = "Budgets";
            this.budgetsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.topMenuStrip.TabIndex = 0;
            this.topMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainToolStripContainer);
            this.MainMenuStrip = this.topMenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            this.navigationToolStrip.ResumeLayout(false);
            this.navigationToolStrip.PerformLayout();
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer mainToolStripContainer;
        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStrip navigationToolStrip;
        private System.Windows.Forms.ToolStripButton transactionsToolStripButton;
        private System.Windows.Forms.ToolStripButton overviewToolStripButton;
        private System.Windows.Forms.ToolStripButton accountsToolStripButton;
        private System.Windows.Forms.ToolStripButton categoriesToolStripButton;
        private System.Windows.Forms.ToolStripButton storesToolStripButton;
        private System.Windows.Forms.ToolStripButton budgetsToolStripButton;
        private System.Windows.Forms.MenuStrip topMenuStrip;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar mainProgressBar;
    }
}

