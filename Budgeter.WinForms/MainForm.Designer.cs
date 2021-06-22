
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cashflowsDataGridView = new System.Windows.Forms.DataGridView();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashflowViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.navigationToolStrip = new System.Windows.Forms.ToolStrip();
            this.transactionsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.overviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.accountsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.categoriesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.storesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.budgetsToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowViewModelBindingSource)).BeginInit();
            this.mainToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.navigationToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashflowsDataGridView
            // 
            this.cashflowsDataGridView.AllowUserToAddRows = false;
            this.cashflowsDataGridView.AllowUserToDeleteRows = false;
            this.cashflowsDataGridView.AllowUserToResizeRows = false;
            this.cashflowsDataGridView.AutoGenerateColumns = false;
            this.cashflowsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashflowsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.sourceNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.cashflowsDataGridView.DataSource = this.cashflowViewModelBindingSource;
            this.cashflowsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashflowsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cashflowsDataGridView.Name = "cashflowsDataGridView";
            this.cashflowsDataGridView.ReadOnly = true;
            this.cashflowsDataGridView.RowHeadersVisible = false;
            this.cashflowsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.cashflowsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashflowsDataGridView.RowTemplate.Height = 16;
            this.cashflowsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cashflowsDataGridView.Size = new System.Drawing.Size(723, 404);
            this.cashflowsDataGridView.TabIndex = 0;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timestampDataGridViewTextBoxColumn.Width = 83;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryNameDataGridViewTextBoxColumn.Width = 74;
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationNameDataGridViewTextBoxColumn.Width = 73;
            // 
            // sourceNameDataGridViewTextBoxColumn
            // 
            this.sourceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sourceNameDataGridViewTextBoxColumn.DataPropertyName = "SourceName";
            this.sourceNameDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceNameDataGridViewTextBoxColumn.Name = "sourceNameDataGridViewTextBoxColumn";
            this.sourceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.Width = 59;
            // 
            // cashflowViewModelBindingSource
            // 
            this.cashflowViewModelBindingSource.DataSource = typeof(Budgeter.ViewModel.CashflowViewModel);
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
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.cashflowsDataGridView);
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
            this.bottomStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.bottomStatusStrip.TabIndex = 0;
            // 
            // navigationToolStrip
            // 
            this.navigationToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navigationToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripButton,
            this.transactionsToolStripButton,
            this.accountsToolStripButton,
            this.categoriesToolStripButton,
            this.storesToolStripButton,
            this.budgetsToolStripButton});
            this.navigationToolStrip.Location = new System.Drawing.Point(0, 8);
            this.navigationToolStrip.Name = "navigationToolStrip";
            this.navigationToolStrip.Size = new System.Drawing.Size(77, 230);
            this.navigationToolStrip.TabIndex = 1;
            // 
            // transactionsToolStripButton
            // 
            this.transactionsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("transactionsToolStripButton.Image")));
            this.transactionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transactionsToolStripButton.Name = "transactionsToolStripButton";
            this.transactionsToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.transactionsToolStripButton.Text = "Transactions";
            this.transactionsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // overviewToolStripButton
            // 
            this.overviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("overviewToolStripButton.Image")));
            this.overviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.overviewToolStripButton.Name = "overviewToolStripButton";
            this.overviewToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.overviewToolStripButton.Text = "Overview";
            this.overviewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // topMenuStrip
            // 
            this.topMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.topMenuStrip.TabIndex = 0;
            this.topMenuStrip.Text = "menuStrip1";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainToolStripContainer);
            this.MainMenuStrip = this.topMenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cashflowsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowViewModelBindingSource)).EndInit();
            this.mainToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.navigationToolStrip.ResumeLayout(false);
            this.navigationToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cashflowsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cashflowViewModelBindingSource;
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
    }
}

