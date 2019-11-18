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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(186, 26);
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
            this.AddBalanceButton.Location = new System.Drawing.Point(186, 82);
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
            this.CheckParkingButton.Location = new System.Drawing.Point(186, 189);
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
            this.BuyParkingButton.Location = new System.Drawing.Point(186, 136);
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
            this.CostParkingButton.Location = new System.Drawing.Point(186, 239);
            this.CostParkingButton.Margin = new System.Windows.Forms.Padding(2);
            this.CostParkingButton.Name = "CostParkingButton";
            this.CostParkingButton.Size = new System.Drawing.Size(162, 35);
            this.CostParkingButton.TabIndex = 4;
            this.CostParkingButton.Text = "Set Cost Parking";
            this.CostParkingButton.UseVisualStyleBackColor = true;
            this.CostParkingButton.Click += new System.EventHandler(this.CostParkingButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "ArgFlag";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(419, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // First
            // 
            this.AccessibleName = "UruFlag";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(533, 288);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CostParkingButton);
            this.Controls.Add(this.BuyParkingButton);
            this.Controls.Add(this.CheckParkingButton);
            this.Controls.Add(this.AddBalanceButton);
            this.Controls.Add(this.AddAccountButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "First";
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button AddBalanceButton;
        private System.Windows.Forms.Button CheckParkingButton;
        private System.Windows.Forms.Button BuyParkingButton;
        private System.Windows.Forms.Button CostParkingButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

