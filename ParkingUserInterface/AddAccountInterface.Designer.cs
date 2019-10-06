namespace ParkingUserInterface
{
    partial class AddAccountInterface
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
            this.LabelBalance = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddBalanceButton = new System.Windows.Forms.Button();
            this.LabelAddAccount = new System.Windows.Forms.Label();
            this.LabelAddBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Location = new System.Drawing.Point(175, 204);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(90, 25);
            this.LabelBalance.TabIndex = 0;
            this.LabelBalance.Text = "Balance";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(178, 125);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(87, 25);
            this.LabelNumber.TabIndex = 1;
            this.LabelNumber.Text = "Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(307, 125);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(180, 31);
            this.textBoxNumber.TabIndex = 2;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(307, 204);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(104, 31);
            this.textBoxBalance.TabIndex = 3;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(493, 350);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(205, 53);
            this.AddAccountButton.TabIndex = 4;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(37, 322);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(132, 53);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddBalanceButton
            // 
            this.AddBalanceButton.Location = new System.Drawing.Point(493, 276);
            this.AddBalanceButton.Name = "AddBalanceButton";
            this.AddBalanceButton.Size = new System.Drawing.Size(205, 56);
            this.AddBalanceButton.TabIndex = 6;
            this.AddBalanceButton.Text = "Add Balance";
            this.AddBalanceButton.UseVisualStyleBackColor = true;
            this.AddBalanceButton.Click += new System.EventHandler(this.AddBalanceButton_Click);
            // 
            // LabelAddAccount
            // 
            this.LabelAddAccount.AutoSize = true;
            this.LabelAddAccount.Location = new System.Drawing.Point(113, 46);
            this.LabelAddAccount.Name = "LabelAddAccount";
            this.LabelAddAccount.Size = new System.Drawing.Size(134, 25);
            this.LabelAddAccount.TabIndex = 7;
            this.LabelAddAccount.Text = "Add Account";
            // 
            // LabelAddBalance
            // 
            this.LabelAddBalance.AutoSize = true;
            this.LabelAddBalance.Location = new System.Drawing.Point(363, 46);
            this.LabelAddBalance.Name = "LabelAddBalance";
            this.LabelAddBalance.Size = new System.Drawing.Size(134, 25);
            this.LabelAddBalance.TabIndex = 8;
            this.LabelAddBalance.Text = "Add Balance";
            // 
            // AddAccountInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.LabelAddBalance);
            this.Controls.Add(this.LabelAddAccount);
            this.Controls.Add(this.AddBalanceButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelBalance);
            this.Name = "AddAccountInterface";
            this.Text = "AddAccountInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddBalanceButton;
        private System.Windows.Forms.Label LabelAddAccount;
        private System.Windows.Forms.Label LabelAddBalance;
    }
}