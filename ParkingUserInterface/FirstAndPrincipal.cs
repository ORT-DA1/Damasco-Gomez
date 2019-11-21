using Contracts;
using EFramework;
using ParkingBusinessLogic;
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
        private Button buttonByLicense;
        private Button buttonByDate;
        private ComboBox comboBoxCountry;

        public FirstAndPrincipal(string country)
        {
            InitializeComponent();
            Country = country;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBoxCountry.Items.Add("Uruguay");
            comboBoxCountry.Items.Add("Argentina");
            //LoadDataBase();
            if (country == "None")
            {
                Country = comboBoxCountry.Text;
            }
            else if (country == "Uruguay")
            {
                comboBoxCountry.Text = country; 
            }
            else
            {
                comboBoxCountry.Text = country;
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
            this.buttonByLicense = new System.Windows.Forms.Button();
            this.buttonByDate = new System.Windows.Forms.Button();
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
            // buttonByLicense
            // 
            this.buttonByLicense.Location = new System.Drawing.Point(456, 312);
            this.buttonByLicense.Name = "buttonByLicense";
            this.buttonByLicense.Size = new System.Drawing.Size(147, 42);
            this.buttonByLicense.TabIndex = 10;
            this.buttonByLicense.Text = "Report by License";
            this.buttonByLicense.UseVisualStyleBackColor = true;
            this.buttonByLicense.Click += new System.EventHandler(this.ButtonByLicense_Click);
            // 
            // buttonByDate
            // 
            this.buttonByDate.Location = new System.Drawing.Point(443, 360);
            this.buttonByDate.Name = "buttonByDate";
            this.buttonByDate.Size = new System.Drawing.Size(180, 46);
            this.buttonByDate.TabIndex = 11;
            this.buttonByDate.Text = "Report between date";
            this.buttonByDate.UseVisualStyleBackColor = true;
            this.buttonByDate.Click += new System.EventHandler(this.ButtonByDate_Click);
            // 
            // FirstAndPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(635, 444);
            this.Controls.Add(this.buttonByDate);
            this.Controls.Add(this.buttonByLicense);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.btnSetCostParking);
            this.Controls.Add(this.btnBuyParking);
            this.Controls.Add(this.btnCheckParking);
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.btnAddAccount);
            this.Name = "FirstAndPrincipal";
            this.ResumeLayout(false);

        }

        private bool ValidateIsSelectedCountry()
        {
            if (comboBoxCountry.Text == "")
            {
                MessageBox.Show(new SelectCountryException().Message);
                return false;
            }
            else
            {
                return true;
            }
        
        }


        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            if (ValidateIsSelectedCountry())
            {
                this.Hide();
                SetAccions second = new SetAccions("AddAccount", Country);
                second.ShowDialog();
                this.Close();
            }
        }
       
        private void BtnAddBalance_Click(object sender, EventArgs e)
        {
            if (ValidateIsSelectedCountry())
            {
                this.Hide();
                SetAccions second = new SetAccions("AddBalance", Country);
                second.ShowDialog();
                this.Close();
            }

        }

        private void BtnBuyParking_Click(object sender, EventArgs e)
        {

            if (ValidateIsSelectedCountry())
            {
                this.Hide();
                SetAccions second = new SetAccions("BuyParking", Country);
                second.ShowDialog();
                this.Close();
            }
            
        }

        private void BtnCheckParking_Click(object sender, EventArgs e)
        {
            if (ValidateIsSelectedCountry())
            {
                this.Hide();
                SetAccions second = new SetAccions("CheckParking", Country);
                second.ShowDialog();
                this.Close();
            }
            
        }

        private void BtnSetCostParking_Click(object sender, EventArgs e)
        {
            if (ValidateIsSelectedCountry())
            {
                this.Hide();
                SetAccions second = new SetAccions("SetCostParking", Country);
                second.ShowDialog();
                this.Close();
            }
            
        }

        private void ComboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            Country = comboBoxCountry.Text;
            
        }

        private void ButtonByLicense_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportInterface second = new ReportInterface(false);
            second.ShowDialog();
            this.Close();
        }

        private void ButtonByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportInterface second = new ReportInterface(true);
            second.ShowDialog();
            this.Close();
        }

        public void LoadDataBase()
        {
            try
            {
                MyContext myContext = new MyContext();
                DataAccessAccount dataAccount = new DataAccessAccount(myContext);
                DataAccessPurchase dataPurchase = new DataAccessPurchase(myContext);
                DataFindAccount findAccount = new DataFindAccount(myContext);
                DataFindPurchase findPurchase = new DataFindPurchase(myContext);
                ControllerPurchase controllerPurchase = new ControllerPurchase(dataPurchase, dataAccount, findAccount, findPurchase);
                Account newA = new AccountUruguay("099 999 999", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 998", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 997", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 996", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 995", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 994", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 993", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 992", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 991", "1000");
                dataAccount.Insert(newA);
                newA = new AccountUruguay("099 999 990", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-78", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-77", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-76", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-75", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-74", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-73", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-72", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-71", "1000");
                dataAccount.Insert(newA);
                newA = new AccountArgentina("123-456-70", "1000");
                dataAccount.Insert(newA);
                string txtCompre = "AAA1234 30 10:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 11:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 12:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 13:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 14:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 15:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 16:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1234 30 17:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 999");
                txtCompre = "AAA1235 30 11:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 998");
                txtCompre = "AAA1235 30 12:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 998");
                txtCompre = "AAA1235 30 13:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 998");
                txtCompre = "AAA1235 30 14:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 998");
                txtCompre = "AAA1235 30 15:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 998");
                txtCompre = "AAA1235 30 16:00";
                controllerPurchase.BuyParkingPurchaseUru(txtCompre, "099 999 998");


                txtCompre = "AAA2324 15:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-78");
                txtCompre = "BAA1234 16:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-78");
                txtCompre = "BAA1234 17:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-78");
                txtCompre = "BAA1234 14:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-78");
                txtCompre = "BAA1234 13:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-78");
                txtCompre = "BAA1234 12:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-78");
                txtCompre = "BAA1234 10:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-77");
                txtCompre = "BAA1234 11:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-77");
                txtCompre = "BAA1239 12:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-77");
                txtCompre = "AAA1239 13:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-77");
                txtCompre = "AAA1239 14:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-77");
                txtCompre = "AAA1239 15:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-77");
                txtCompre = "AAA1230 15:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-76");
                txtCompre = "AAA1230 14:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-76");
                txtCompre = "AAA1230 13:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-76");
                txtCompre = "AAA1231 12:00 23";
                controllerPurchase.BuyParkingPurchaseArg(txtCompre, "123-456-76");
            }
            catch (LogicException f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }

  }

