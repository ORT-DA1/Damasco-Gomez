﻿using ContractDataBase;
using Contracts;
using EFramework;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public class SetAccions : Form
    {
        private string Country { set; get; }
        private TextBox textBoxChange1;
        private Label labelChange2;
        private TextBox textBoxChange2;
        private Button btnMoveAlong;
        private Button btnBack;
        private ComboBox comboBoxCountry2;
        private Label labelChange1;
        private string Action { set; get; }

        public SetAccions(string action, string country)
        {
            InitializeComponent();
            labelChange2.Hide();
            labelChange1.Hide();
            textBoxChange1.Hide();
            textBoxChange2.Hide();
            btnMoveAlong.Hide();
            Country = country;
            Action = action;
            comboBoxCountry2.Items.Add("Uruguay");
            comboBoxCountry2.Items.Add("Argentina");
            comboBoxCountry2.Text = country;

            
           

            if (Action=="AddAccount")
            {
                
                labelChange1.Text = "Number";
                labelChange1.Show();
                labelChange2.Text = "Balance";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Add Account";
                btnMoveAlong.Show();
            }

            if (Action == "AddBalance")
            {
                labelChange1.Text = "Number";
                labelChange1.Show();
                labelChange2.Text = "Balance";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Add Balance";
                btnMoveAlong.Show();
            }
            if (Action == "BuyParking")
            {
                labelChange1.Text = "Number";
                labelChange1.Show();
                labelChange2.Text = "Text";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Buy Parking";
                btnMoveAlong.Show();
            }
            if (Action == "CheckParking")
            {
                labelChange1.Text = "License Plate";
                labelChange1.Show();
                labelChange2.Text = "Date";
                labelChange2.Show();
                textBoxChange2.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Check License";
                btnMoveAlong.Show();
            }
            if (Action == "SetCostParking")
            {
                labelChange1.Text = "Cost Per Minute";
                labelChange1.Show();
                textBoxChange1.Show();
                btnMoveAlong.Text = "Change";
                btnMoveAlong.Show();
            }
            


        }

        private void InitializeComponent()
        {
            this.labelChange1 = new System.Windows.Forms.Label();
            this.textBoxChange1 = new System.Windows.Forms.TextBox();
            this.labelChange2 = new System.Windows.Forms.Label();
            this.textBoxChange2 = new System.Windows.Forms.TextBox();
            this.btnMoveAlong = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxCountry2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelChange1
            // 
            this.labelChange1.AutoSize = true;
            this.labelChange1.Location = new System.Drawing.Point(121, 181);
            this.labelChange1.Name = "labelChange1";
            this.labelChange1.Size = new System.Drawing.Size(46, 17);
            this.labelChange1.TabIndex = 0;
            this.labelChange1.Text = "label1";
            this.labelChange1.Click += new System.EventHandler(this.LabelChange1_Click);
            // 
            // textBoxChange1
            // 
            this.textBoxChange1.Location = new System.Drawing.Point(212, 181);
            this.textBoxChange1.Name = "textBoxChange1";
            this.textBoxChange1.Size = new System.Drawing.Size(132, 22);
            this.textBoxChange1.TabIndex = 1;
            // 
            // labelChange2
            // 
            this.labelChange2.AutoSize = true;
            this.labelChange2.Location = new System.Drawing.Point(121, 254);
            this.labelChange2.Name = "labelChange2";
            this.labelChange2.Size = new System.Drawing.Size(46, 17);
            this.labelChange2.TabIndex = 2;
            this.labelChange2.Text = "label2";
            // 
            // textBoxChange2
            // 
            this.textBoxChange2.Location = new System.Drawing.Point(212, 254);
            this.textBoxChange2.Name = "textBoxChange2";
            this.textBoxChange2.Size = new System.Drawing.Size(132, 22);
            this.textBoxChange2.TabIndex = 3;
            // 
            // btnMoveAlong
            // 
            this.btnMoveAlong.Location = new System.Drawing.Point(337, 360);
            this.btnMoveAlong.Name = "btnMoveAlong";
            this.btnMoveAlong.Size = new System.Drawing.Size(129, 36);
            this.btnMoveAlong.TabIndex = 5;
            this.btnMoveAlong.Text = "MoveAlong";
            this.btnMoveAlong.UseVisualStyleBackColor = true;
            this.btnMoveAlong.Click += new System.EventHandler(this.BtnMoveAlong_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(101, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // comboBoxCountry2
            // 
            this.comboBoxCountry2.FormattingEnabled = true;
            this.comboBoxCountry2.Location = new System.Drawing.Point(212, 95);
            this.comboBoxCountry2.Name = "comboBoxCountry2";
            this.comboBoxCountry2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCountry2.TabIndex = 7;
            // 
            // SetAccions
            // 
            this.ClientSize = new System.Drawing.Size(549, 478);
            this.Controls.Add(this.comboBoxCountry2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMoveAlong);
            this.Controls.Add(this.textBoxChange2);
            this.Controls.Add(this.labelChange2);
            this.Controls.Add(this.textBoxChange1);
            this.Controls.Add(this.labelChange1);
            this.Name = "SetAccions";
            this.Load += new System.EventHandler(this.SetAccions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SetAccions_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddAccountSecond_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            goPrincipal();

        }
        public void goPrincipal()
        {
            this.Hide();
            FirstAndPrincipal firstAndPrincipal = new FirstAndPrincipal(Country);
            firstAndPrincipal.ShowDialog();
            this.Close();
        }

        private void LabelChange1_Click(object sender, EventArgs e)
        {

        }

        private void BtnUruguay2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMoveAlong_Click(object sender, EventArgs e)
        {
            try
            {
                if (Action == "AddAccount")
                {
                    MyContext context = new MyContext();
                    ControllerAccount controllerAccount = new ControllerAccount(new DataAccessAccount(context), new DataFindAccount(context));
                    //ControllerPurchase controllerPurchase = new ControllerPurchase(new DataAccessPurchase(context),new DataAccessAccount(context),new DataFindAccount(context), new DataFindPurchase(context));
                    string number = textBoxChange1.Text;
                    string balance = textBoxChange2.Text;
                    Account newAccount = new AccountArgentina();
                    if (Country == "Uruguay")
                    {
                        newAccount = new AccountUruguay(number, balance);
                    }
                    else
                    {
                        newAccount = new AccountArgentina(number, balance);
                    }
                    controllerAccount.RegisterAccount(newAccount);
                    MessageBox.Show("Account registered successfully");
                }
                if (Action == "AddBalance")
                {

                }
                if (Action == "BuyParking")
                {

                }
                if (Action == "CheckParking")
                {

                }
                if (Action == "SetCostParking")
                {

                }
            }
            catch (DataBaseException f)
            {
                MessageBox.Show(new DataBaseException("account could not be registered").Message);
            }
            catch (LogicException d)
            {

            }
        }
    }
}
