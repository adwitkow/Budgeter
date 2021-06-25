
namespace Budgeter.WinForms.Views
{
    partial class TransactionView
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
            this.TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsDataGridView
            // 
            this.TransactionsDataGridView.AllowUserToAddRows = false;
            this.TransactionsDataGridView.AllowUserToDeleteRows = false;
            this.TransactionsDataGridView.AllowUserToResizeRows = false;
            this.TransactionsDataGridView.AutoGenerateColumns = false;
            this.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.sourceNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.TransactionsDataGridView.DataSource = this.TransactionViewModelBindingSource;
            this.TransactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TransactionsDataGridView.Name = "TransactionsDataGridView";
            this.TransactionsDataGridView.ReadOnly = true;
            this.TransactionsDataGridView.RowHeadersVisible = false;
            this.TransactionsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.TransactionsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransactionsDataGridView.RowTemplate.Height = 16;
            this.TransactionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionsDataGridView.Size = new System.Drawing.Size(489, 242);
            this.TransactionsDataGridView.TabIndex = 3;
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
            // TransactionViewModelBindingSource
            // 
            this.TransactionViewModelBindingSource.DataSource = typeof(Budgeter.Model.Models.TransactionModel);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TransactionsDataGridView);
            this.Name = "TransactionView";
            this.Size = new System.Drawing.Size(489, 242);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource TransactionViewModelBindingSource;
    }
}
