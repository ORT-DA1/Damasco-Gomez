﻿using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public class FirstAndPrincipal : Form
    {
        private Button btnArgentina;
        private Button btnAddAccount;
        private Button btnAddBalance;
        private Button btnCheckParking;
        private Button btnBuyParking;
        private Button btnSetCostParking;
        private Button btnUruguay;

        public FirstAndPrincipal()
        {
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstAndPrincipal));
            this.btnArgentina = new System.Windows.Forms.Button();
            this.btnUruguay = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.btnCheckParking = new System.Windows.Forms.Button();
            this.btnBuyParking = new System.Windows.Forms.Button();
            this.btnSetCostParking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArgentina
            // 
            this.btnArgentina.Image = ((System.Drawing.Image)(resources.GetObject("btnArgentina.Image")));
            this.btnArgentina.Location = new System.Drawing.Point(507, 12);
            this.btnArgentina.Name = "btnArgentina";
            this.btnArgentina.Size = new System.Drawing.Size(127, 87);
            this.btnArgentina.TabIndex = 2;
            this.btnArgentina.UseVisualStyleBackColor = true;
            // 
            // btnUruguay
            // 
            this.btnUruguay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUruguay.Image = ((System.Drawing.Image)(resources.GetObject("btnUruguay.Image")));
            this.btnUruguay.Location = new System.Drawing.Point(12, 12);
            this.btnUruguay.Name = "btnUruguay";
            this.btnUruguay.Size = new System.Drawing.Size(127, 87);
            this.btnUruguay.TabIndex = 3;
            this.btnUruguay.UseVisualStyleBackColor = true;
            this.btnUruguay.Click += new System.EventHandler(this.BtnUruguay_Click_1);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(251, 107);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(138, 47);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Location = new System.Drawing.Point(251, 176);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(138, 47);
            this.btnAddBalance.TabIndex = 5;
            this.btnAddBalance.Text = "Add Balance";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            // 
            // btnCheckParking
            // 
            this.btnCheckParking.Location = new System.Drawing.Point(251, 305);
            this.btnCheckParking.Name = "btnCheckParking";
            this.btnCheckParking.Size = new System.Drawing.Size(138, 47);
            this.btnCheckParking.TabIndex = 6;
            this.btnCheckParking.Text = "Check Parking";
            this.btnCheckParking.UseVisualStyleBackColor = true;
            // 
            // btnBuyParking
            // 
            this.btnBuyParking.Location = new System.Drawing.Point(251, 238);
            this.btnBuyParking.Name = "btnBuyParking";
            this.btnBuyParking.Size = new System.Drawing.Size(138, 47);
            this.btnBuyParking.TabIndex = 7;
            this.btnBuyParking.Text = "Buy Parking";
            this.btnBuyParking.UseVisualStyleBackColor = true;
            // 
            // btnSetCostParking
            // 
            this.btnSetCostParking.Location = new System.Drawing.Point(251, 371);
            this.btnSetCostParking.Name = "btnSetCostParking";
            this.btnSetCostParking.Size = new System.Drawing.Size(138, 47);
            this.btnSetCostParking.TabIndex = 8;
            this.btnSetCostParking.Text = "Set Cost Parking";
            this.btnSetCostParking.UseVisualStyleBackColor = true;
            // 
            // FirstAndPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(646, 532);
            this.Controls.Add(this.btnSetCostParking);
            this.Controls.Add(this.btnBuyParking);
            this.Controls.Add(this.btnCheckParking);
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnUruguay);
            this.Controls.Add(this.btnArgentina);
            this.Name = "FirstAndPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }


        

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            if ((btnArgentina.click ==false) || ((btnUruguay.click == false)))
            {
                throw new  SelectCountryException();
               
            }









        }

        private void BtnUruguay_Click_1(object sender, EventArgs e)
        {
            if (btnArgentina.FlatAppearance.BorderColor == System.Drawing.Color.Red)
            {
                btnArgentina.FlatAppearance.BorderColor == System.Drawing.Color.White; 
            }
            btnUruguay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
        }
    }
    }
}
