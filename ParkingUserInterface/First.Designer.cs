﻿namespace ParkingUserInterface
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
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.AddBalanceButton = new System.Windows.Forms.Button();
            this.CheckParkingButton = new System.Windows.Forms.Button();
            this.BuyParkingButton = new System.Windows.Forms.Button();
            this.CostParkingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(303, 40);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(191, 55);
            this.AddAccountButton.TabIndex = 0;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // AddBalanceButton
            // 
            this.AddBalanceButton.Location = new System.Drawing.Point(303, 128);
            this.AddBalanceButton.Name = "AddBalanceButton";
            this.AddBalanceButton.Size = new System.Drawing.Size(191, 55);
            this.AddBalanceButton.TabIndex = 1;
            this.AddBalanceButton.Text = "Add Balance";
            this.AddBalanceButton.UseVisualStyleBackColor = true;
            this.AddBalanceButton.Click += new System.EventHandler(this.AddBalanceButton_Click);
            // 
            // CheckParkingButton
            // 
            this.CheckParkingButton.Location = new System.Drawing.Point(279, 296);
            this.CheckParkingButton.Name = "CheckParkingButton";
            this.CheckParkingButton.Size = new System.Drawing.Size(243, 55);
            this.CheckParkingButton.TabIndex = 2;
            this.CheckParkingButton.Text = "Check Licence Parking";
            this.CheckParkingButton.UseVisualStyleBackColor = true;
            this.CheckParkingButton.Click += new System.EventHandler(this.CheckParkingButton_Click);
            // 
            // BuyParkingButton
            // 
            this.BuyParkingButton.Location = new System.Drawing.Point(303, 212);
            this.BuyParkingButton.Name = "BuyParkingButton";
            this.BuyParkingButton.Size = new System.Drawing.Size(191, 55);
            this.BuyParkingButton.TabIndex = 3;
            this.BuyParkingButton.Text = "Buy Parking";
            this.BuyParkingButton.UseVisualStyleBackColor = true;
            this.BuyParkingButton.Click += new System.EventHandler(this.BuyParkingButton_Click);
            // 
            // CostParkingButton
            // 
            this.CostParkingButton.Location = new System.Drawing.Point(303, 373);
            this.CostParkingButton.Name = "CostParkingButton";
            this.CostParkingButton.Size = new System.Drawing.Size(201, 55);
            this.CostParkingButton.TabIndex = 4;
            this.CostParkingButton.Text = "Set Cost Parking";
            this.CostParkingButton.UseVisualStyleBackColor = true;
            this.CostParkingButton.Click += new System.EventHandler(this.CostParkingButton_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CostParkingButton);
            this.Controls.Add(this.BuyParkingButton);
            this.Controls.Add(this.CheckParkingButton);
            this.Controls.Add(this.AddBalanceButton);
            this.Controls.Add(this.AddAccountButton);
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
    }
}

