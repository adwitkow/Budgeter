
namespace Budgeter.WinForms.Views
{
    partial class CashflowView
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
            this.components = new System.ComponentModel.Container();
            this.cashflowsDataGridView = new System.Windows.Forms.DataGridView();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashflowViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cashflowsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowViewModelBindingSource)).BeginInit();
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
            this.cashflowsDataGridView.Size = new System.Drawing.Size(489, 242);
            this.cashflowsDataGridView.TabIndex = 3;
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
            this.cashflowViewModelBindingSource.DataSource = typeof(Budgeter.Model.Models.CashflowModel);
            // 
            // CashflowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cashflowsDataGridView);
            this.Name = "CashflowView";
            this.Size = new System.Drawing.Size(489, 242);
            ((System.ComponentModel.ISupportInitialize)(this.cashflowsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowViewModelBindingSource)).EndInit();
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
    }
}
