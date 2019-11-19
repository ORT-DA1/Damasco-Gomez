namespace ParkingUserInterface
{
    partial class First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.AddBalanceButton = new System.Windows.Forms.Button();
            this.CheckParkingButton = new System.Windows.Forms.Button();
            this.BuyParkingButton = new System.Windows.Forms.Button();
            this.CostParkingButton = new System.Windows.Forms.Button();
            this.btnArgentina = new System.Windows.Forms.Button();
            this.btnUruguay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(285, 80);
            this.AddAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(162, 35);
            this.AddAccountButton.TabIndex = 0;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // AddBalanceButton
            // 
            this.AddBalanceButton.Location = new System.Drawing.Point(285, 139);
            this.AddBalanceButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddBalanceButton.Name = "AddBalanceButton";
            this.AddBalanceButton.Size = new System.Drawing.Size(162, 35);
            this.AddBalanceButton.TabIndex = 1;
            this.AddBalanceButton.Text = "Add Balance";
            this.AddBalanceButton.UseVisualStyleBackColor = true;
            this.AddBalanceButton.Click += new System.EventHandler(this.AddBalanceButton_Click);
            // 
            // CheckParkingButton
            // 
            this.CheckParkingButton.Location = new System.Drawing.Point(285, 262);
            this.CheckParkingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckParkingButton.Name = "CheckParkingButton";
            this.CheckParkingButton.Size = new System.Drawing.Size(162, 35);
            this.CheckParkingButton.TabIndex = 2;
            this.CheckParkingButton.Text = "Check Licence Parking";
            this.CheckParkingButton.UseVisualStyleBackColor = true;
            this.CheckParkingButton.Click += new System.EventHandler(this.CheckParkingButton_Click);
            // 
            // BuyParkingButton
            // 
            this.BuyParkingButton.Location = new System.Drawing.Point(285, 201);
            this.BuyParkingButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuyParkingButton.Name = "BuyParkingButton";
            this.BuyParkingButton.Size = new System.Drawing.Size(162, 35);
            this.BuyParkingButton.TabIndex = 3;
            this.BuyParkingButton.Text = "Buy Parking";
            this.BuyParkingButton.UseVisualStyleBackColor = true;
            this.BuyParkingButton.Click += new System.EventHandler(this.BuyParkingButton_Click);
            // 
            // CostParkingButton
            // 
            this.CostParkingButton.Location = new System.Drawing.Point(285, 323);
            this.CostParkingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CostParkingButton.Name = "CostParkingButton";
            this.CostParkingButton.Size = new System.Drawing.Size(162, 35);
            this.CostParkingButton.TabIndex = 4;
            this.CostParkingButton.Text = "Set Cost Parking";
            this.CostParkingButton.UseVisualStyleBackColor = true;
            this.CostParkingButton.Click += new System.EventHandler(this.CostParkingButton_Click);
            // 
            // btnArgentina
            // 
            this.btnArgentina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArgentina.BackgroundImage")));
            this.btnArgentina.Image = ((System.Drawing.Image)(resources.GetObject("btnArgentina.Image")));
            this.btnArgentina.Location = new System.Drawing.Point(609, 12);
            this.btnArgentina.Name = "btnArgentina";
            this.btnArgentina.Size = new System.Drawing.Size(157, 101);
            this.btnArgentina.TabIndex = 7;
            this.btnArgentina.UseVisualStyleBackColor = true;
            this.btnArgentina.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUruguay
            // 
            this.btnUruguay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUruguay.BackgroundImage")));
            this.btnUruguay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUruguay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUruguay.Location = new System.Drawing.Point(46, 28);
            this.btnUruguay.Name = "btnUruguay";
            this.btnUruguay.Size = new System.Drawing.Size(133, 87);
            this.btnUruguay.TabIndex = 8;
            this.btnUruguay.UseVisualStyleBackColor = true;
            this.btnUruguay.Click += new System.EventHandler(this.BtnUruguay_Click);
            // 
            // First
            // 
            this.AccessibleName = "UruFlag";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 457);
            this.Controls.Add(this.btnUruguay);
            this.Controls.Add(this.btnArgentina);
            this.Controls.Add(this.CostParkingButton);
            this.Controls.Add(this.BuyParkingButton);
            this.Controls.Add(this.CheckParkingButton);
            this.Controls.Add(this.AddBalanceButton);
            this.Controls.Add(this.AddAccountButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "First";
            this.Text = "Welcome!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button AddBalanceButton;
        private System.Windows.Forms.Button CheckParkingButton;
        private System.Windows.Forms.Button BuyParkingButton;
        private System.Windows.Forms.Button CostParkingButton;
        private System.Windows.Forms.Button btnArgentina;
        private System.Windows.Forms.Button btnUruguay;
    }
}

