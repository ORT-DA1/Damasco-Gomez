using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public class FirstAndPrincipal : Form
    {
        private string Country { get; set; }
        private Button btnAddAccount;
        private Button btnAddBalance;
        private Button btnCheckParking;
        private Button btnBuyParking;
        private Button btnSetCostParking;
        private ComboBox comboBoxCountry;

        public FirstAndPrincipal(string country)
        {
            InitializeComponent();
            Country = country;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBoxCountry.Items.Add("Uruguay");
            comboBoxCountry.Items.Add("Argentina");
            if (country == "None")
            {
                string Country = (string)comboBoxCountry.SelectedValue;
            }
            else if (country == "Uruguay")
            {
                comboBoxCountry.SelectedValue = "Uruguay";
            }
            else
            {
                comboBoxCountry.SelectedValue = "Argentina";

            }
            
           
            
        }

       
        private void InitializeComponent()
        {
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.btnCheckParking = new System.Windows.Forms.Button();
            this.btnBuyParking = new System.Windows.Forms.Button();
            this.btnSetCostParking = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(251, 107);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(138, 29);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Location = new System.Drawing.Point(251, 176);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(138, 33);
            this.btnAddBalance.TabIndex = 5;
            this.btnAddBalance.Text = "Add Balance";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            this.btnAddBalance.Click += new System.EventHandler(this.BtnAddBalance_Click);
            // 
            // btnCheckParking
            // 
            this.btnCheckParking.Location = new System.Drawing.Point(251, 305);
            this.btnCheckParking.Name = "btnCheckParking";
            this.btnCheckParking.Size = new System.Drawing.Size(138, 29);
            this.btnCheckParking.TabIndex = 6;
            this.btnCheckParking.Text = "Check Parking";
            this.btnCheckParking.UseVisualStyleBackColor = true;
            this.btnCheckParking.Click += new System.EventHandler(this.BtnCheckParking_Click);
            // 
            // btnBuyParking
            // 
            this.btnBuyParking.Location = new System.Drawing.Point(251, 238);
            this.btnBuyParking.Name = "btnBuyParking";
            this.btnBuyParking.Size = new System.Drawing.Size(138, 30);
            this.btnBuyParking.TabIndex = 7;
            this.btnBuyParking.Text = "Buy Parking";
            this.btnBuyParking.UseVisualStyleBackColor = true;
            this.btnBuyParking.Click += new System.EventHandler(this.BtnBuyParking_Click);
            // 
            // btnSetCostParking
            // 
            this.btnSetCostParking.Location = new System.Drawing.Point(251, 367);
            this.btnSetCostParking.Name = "btnSetCostParking";
            this.btnSetCostParking.Size = new System.Drawing.Size(138, 28);
            this.btnSetCostParking.TabIndex = 8;
            this.btnSetCostParking.Text = "Set Cost Parking";
            this.btnSetCostParking.UseVisualStyleBackColor = true;
            this.btnSetCostParking.Click += new System.EventHandler(this.BtnSetCostParking_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(251, 44);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(138, 24);
            this.comboBoxCountry.TabIndex = 9;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCountry_SelectedIndexChanged);
            // 
            // FirstAndPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(635, 444);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.btnSetCostParking);
            this.Controls.Add(this.btnBuyParking);
            this.Controls.Add(this.btnCheckParking);
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.btnAddAccount);
            this.Name = "FirstAndPrincipal";
            this.Load += new System.EventHandler(this.FirstAndPrincipal_Load);
            this.ResumeLayout(false);

        }

        private void ValidateIsSelectedCountry()
        {
            if (Country== "None") 
            {
                MessageBox.Show(new SelectCountryException().Message);
            }
        }


        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidateIsSelectedCountry();
            SetAccions second = new SetAccions("AddAccount",Country);
            second.ShowDialog();
            this.Close();
     
           
        }

       
        private void FirstAndPrincipal_Load(object sender, EventArgs e)
        {

        }

       
        private void BtnAddBalance_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ValidateIsSelectedCountry();
            SetAccions second = new SetAccions("AddBalance", Country);
            second.ShowDialog();
            this.Close();

        }

        private void BtnBuyParking_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ValidateIsSelectedCountry();
            SetAccions second = new SetAccions("BuyParking", Country);
            second.ShowDialog();
            this.Close();
        }

        private void BtnCheckParking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidateIsSelectedCountry();
            SetAccions second = new SetAccions("CheckParking", Country);
            second.ShowDialog();
            this.Close();

        }

        private void BtnSetCostParking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidateIsSelectedCountry();
            SetAccions second = new SetAccions("SetCostParking", Country);
            second.ShowDialog();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Country = (string)comboBoxCountry.SelectedValue;
        }
    }

  }

