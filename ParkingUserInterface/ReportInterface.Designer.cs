namespace ParkingUserInterface
{
    partial class ReportInterface
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
            this.LabelInitDay = new System.Windows.Forms.Label();
            this.textInitDay = new System.Windows.Forms.TextBox();
            this.LabelFinDay = new System.Windows.Forms.Label();
            this.textFinDay = new System.Windows.Forms.TextBox();
            this.listPurchases = new System.Windows.Forms.ListBox();
            this.labelInitTime = new System.Windows.Forms.Label();
            this.labelFinTime = new System.Windows.Forms.Label();
            this.textFinTime = new System.Windows.Forms.TextBox();
            this.textInitTime = new System.Windows.Forms.TextBox();
            this.textLicense = new System.Windows.Forms.TextBox();
            this.LabelLicensePlate = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelInitDay
            // 
            this.LabelInitDay.AutoSize = true;
            this.LabelInitDay.Location = new System.Drawing.Point(85, 31);
            this.LabelInitDay.Name = "LabelInitDay";
            this.LabelInitDay.Size = new System.Drawing.Size(67, 17);
            this.LabelInitDay.TabIndex = 0;
            this.LabelInitDay.Text = "Start Day";
            // 
            // textInitDay
            // 
            this.textInitDay.Location = new System.Drawing.Point(203, 31);
            this.textInitDay.Name = "textInitDay";
            this.textInitDay.Size = new System.Drawing.Size(100, 22);
            this.textInitDay.TabIndex = 1;
            // 
            // LabelFinDay
            // 
            this.LabelFinDay.AutoSize = true;
            this.LabelFinDay.Location = new System.Drawing.Point(85, 70);
            this.LabelFinDay.Name = "LabelFinDay";
            this.LabelFinDay.Size = new System.Drawing.Size(65, 17);
            this.LabelFinDay.TabIndex = 2;
            this.LabelFinDay.Text = "Until Day";
            // 
            // textFinDay
            // 
            this.textFinDay.Location = new System.Drawing.Point(203, 70);
            this.textFinDay.Name = "textFinDay";
            this.textFinDay.Size = new System.Drawing.Size(100, 22);
            this.textFinDay.TabIndex = 3;
            // 
            // listPurchases
            // 
            this.listPurchases.AllowDrop = true;
            this.listPurchases.ColumnWidth = 6;
            this.listPurchases.FormattingEnabled = true;
            this.listPurchases.ItemHeight = 16;
            this.listPurchases.Items.AddRange(new object[] {
            "Purchase"});
            this.listPurchases.Location = new System.Drawing.Point(75, 204);
            this.listPurchases.MultiColumn = true;
            this.listPurchases.Name = "listPurchases";
            this.listPurchases.Size = new System.Drawing.Size(277, 372);
            this.listPurchases.Sorted = true;
            this.listPurchases.TabIndex = 6;
            // 
            // labelInitTime
            // 
            this.labelInitTime.AutoSize = true;
            this.labelInitTime.Location = new System.Drawing.Point(85, 108);
            this.labelInitTime.Name = "labelInitTime";
            this.labelInitTime.Size = new System.Drawing.Size(73, 17);
            this.labelInitTime.TabIndex = 7;
            this.labelInitTime.Text = "Start Time";
            // 
            // labelFinTime
            // 
            this.labelFinTime.AutoSize = true;
            this.labelFinTime.Location = new System.Drawing.Point(85, 144);
            this.labelFinTime.Name = "labelFinTime";
            this.labelFinTime.Size = new System.Drawing.Size(71, 17);
            this.labelFinTime.TabIndex = 8;
            this.labelFinTime.Text = "Until Time";
            // 
            // textFinTime
            // 
            this.textFinTime.Location = new System.Drawing.Point(203, 144);
            this.textFinTime.Name = "textFinTime";
            this.textFinTime.Size = new System.Drawing.Size(100, 22);
            this.textFinTime.TabIndex = 9;
            // 
            // textInitTime
            // 
            this.textInitTime.Location = new System.Drawing.Point(203, 108);
            this.textInitTime.Name = "textInitTime";
            this.textInitTime.Size = new System.Drawing.Size(100, 22);
            this.textInitTime.TabIndex = 10;
            // 
            // textLicense
            // 
            this.textLicense.Location = new System.Drawing.Point(449, 67);
            this.textLicense.Name = "textLicense";
            this.textLicense.Size = new System.Drawing.Size(100, 22);
            this.textLicense.TabIndex = 11;
            // 
            // LabelLicensePlate
            // 
            this.LabelLicensePlate.AutoSize = true;
            this.LabelLicensePlate.Location = new System.Drawing.Point(351, 72);
            this.LabelLicensePlate.Name = "LabelLicensePlate";
            this.LabelLicensePlate.Size = new System.Drawing.Size(93, 17);
            this.LabelLicensePlate.TabIndex = 12;
            this.LabelLicensePlate.Text = "License Plate";
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonFind.Location = new System.Drawing.Point(423, 157);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(126, 51);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(423, 282);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 43);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ReportInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 593);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.LabelLicensePlate);
            this.Controls.Add(this.textLicense);
            this.Controls.Add(this.textInitTime);
            this.Controls.Add(this.textFinTime);
            this.Controls.Add(this.labelFinTime);
            this.Controls.Add(this.labelInitTime);
            this.Controls.Add(this.listPurchases);
            this.Controls.Add(this.textFinDay);
            this.Controls.Add(this.LabelFinDay);
            this.Controls.Add(this.textInitDay);
            this.Controls.Add(this.LabelInitDay);
            this.Name = "ReportInterface";
            this.Text = "ReportInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInitDay;
        private System.Windows.Forms.TextBox textInitDay;
        private System.Windows.Forms.Label LabelFinDay;
        private System.Windows.Forms.TextBox textFinDay;
        private System.Windows.Forms.ListBox listPurchases;
        private System.Windows.Forms.Label labelInitTime;
        private System.Windows.Forms.Label labelFinTime;
        private System.Windows.Forms.TextBox textFinTime;
        private System.Windows.Forms.TextBox textInitTime;
        private System.Windows.Forms.TextBox textLicense;
        private System.Windows.Forms.Label LabelLicensePlate;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonBack;
    }
}