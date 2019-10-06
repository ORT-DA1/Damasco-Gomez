namespace ParkingUserInterface
{
    partial class BuyParkingInterface
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
            this.LabelText = new System.Windows.Forms.Label();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.CheckLicenseButton = new System.Windows.Forms.Button();
            this.BuyParkingButton = new System.Windows.Forms.Button();
            this.LabelLicensePlate = new System.Windows.Forms.Label();
            this.TextBoxLicense = new System.Windows.Forms.TextBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Location = new System.Drawing.Point(105, 124);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(54, 25);
            this.LabelText.TabIndex = 0;
            this.LabelText.Text = "Text";
            // 
            // TextBoxText
            // 
            this.TextBoxText.Location = new System.Drawing.Point(251, 118);
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(204, 31);
            this.TextBoxText.TabIndex = 1;
            // 
            // CheckLicenseButton
            // 
            this.CheckLicenseButton.Location = new System.Drawing.Point(535, 326);
            this.CheckLicenseButton.Name = "CheckLicenseButton";
            this.CheckLicenseButton.Size = new System.Drawing.Size(213, 63);
            this.CheckLicenseButton.TabIndex = 2;
            this.CheckLicenseButton.Text = "Check License";
            this.CheckLicenseButton.UseVisualStyleBackColor = true;
            // 
            // BuyParkingButton
            // 
            this.BuyParkingButton.Location = new System.Drawing.Point(535, 242);
            this.BuyParkingButton.Name = "BuyParkingButton";
            this.BuyParkingButton.Size = new System.Drawing.Size(213, 58);
            this.BuyParkingButton.TabIndex = 3;
            this.BuyParkingButton.Text = "Buy Parking";
            this.BuyParkingButton.UseVisualStyleBackColor = true;
            // 
            // LabelLicensePlate
            // 
            this.LabelLicensePlate.AutoSize = true;
            this.LabelLicensePlate.Location = new System.Drawing.Point(66, 207);
            this.LabelLicensePlate.Name = "LabelLicensePlate";
            this.LabelLicensePlate.Size = new System.Drawing.Size(154, 25);
            this.LabelLicensePlate.TabIndex = 4;
            this.LabelLicensePlate.Text = "Lincense Plate";
            // 
            // TextBoxLicense
            // 
            this.TextBoxLicense.Location = new System.Drawing.Point(251, 201);
            this.TextBoxLicense.Name = "TextBoxLicense";
            this.TextBoxLicense.Size = new System.Drawing.Size(204, 31);
            this.TextBoxLicense.TabIndex = 5;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(115, 276);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(59, 25);
            this.LabelTime.TabIndex = 6;
            this.LabelTime.Text = "Time";
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Location = new System.Drawing.Point(251, 269);
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(204, 31);
            this.TextBoxTime.TabIndex = 7;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(29, 372);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(191, 66);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(101, 44);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(87, 25);
            this.LabelNumber.TabIndex = 9;
            this.LabelNumber.Text = "Number";
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Location = new System.Drawing.Point(251, 44);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(204, 31);
            this.TextBoxNumber.TabIndex = 10;
            // 
            // BuyParkingInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxNumber);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.TextBoxTime);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.TextBoxLicense);
            this.Controls.Add(this.LabelLicensePlate);
            this.Controls.Add(this.BuyParkingButton);
            this.Controls.Add(this.CheckLicenseButton);
            this.Controls.Add(this.TextBoxText);
            this.Controls.Add(this.LabelText);
            this.Name = "BuyParkingInterface";
            this.Text = "BuyParkingInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.TextBox TextBoxText;
        private System.Windows.Forms.Button CheckLicenseButton;
        private System.Windows.Forms.Button BuyParkingButton;
        private System.Windows.Forms.Label LabelLicensePlate;
        private System.Windows.Forms.TextBox TextBoxLicense;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.TextBox TextBoxTime;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.TextBox TextBoxNumber;
    }
}