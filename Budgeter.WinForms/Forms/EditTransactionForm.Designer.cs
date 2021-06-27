
namespace Budgeter.WinForms.Forms
{
    partial class EditTransactionForm
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
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sourceComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.bottomButtonPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(104, 11);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(42, 11);
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.Location = new System.Drawing.Point(0, 156);
            this.bottomButtonPanel.Size = new System.Drawing.Size(272, 46);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.transactionGroupBox);
            this.mainPanel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainPanel.Size = new System.Drawing.Size(272, 156);
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.transactionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionGroupBox.Location = new System.Drawing.Point(6, 0);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Size = new System.Drawing.Size(260, 156);
            this.transactionGroupBox.TabIndex = 0;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.sourceComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.locationComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.locationLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.categoryComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 137);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.Location = new System.Drawing.Point(79, 51);
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(172, 21);
            this.sourceComboBox.TabIndex = 7;
            // 
            // locationComboBox
            // 
            this.locationComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(79, 27);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(172, 21);
            this.locationComboBox.TabIndex = 6;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Location = new System.Drawing.Point(3, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(70, 24);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationLabel.Location = new System.Drawing.Point(3, 24);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(70, 24);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location:";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceLabel.Location = new System.Drawing.Point(3, 48);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(70, 24);
            this.sourceLabel.TabIndex = 2;
            this.sourceLabel.Text = "Source:";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 72);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(70, 41);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel.Location = new System.Drawing.Point(3, 113);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(70, 24);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Value:";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(79, 3);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(172, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(79, 75);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(172, 35);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTextBox.Location = new System.Drawing.Point(79, 116);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(172, 20);
            this.valueTextBox.TabIndex = 9;
            // 
            // EditTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 202);
            this.Name = "EditTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Transaction";
            this.bottomButtonPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.transactionGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox sourceComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
    }
}