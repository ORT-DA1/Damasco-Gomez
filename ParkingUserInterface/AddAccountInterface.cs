using Contracts;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public partial class AddAccountInterface : Form
    {
        private Controller MyController;
        public AddAccountInterface(Controller controller, bool CreateAccount)
        {
            InitializeComponent();
            MyController = controller;
            if (CreateAccount)
            {
                LabelAddBalance.Visible = false;
                AddBalanceButton.Visible = false;
            } else
            {
                LabelAddAccount.Visible = false;
                AddAccountButton.Visible = false;

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GoToFirstInterface();
        }

        private void AddBalanceButton_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.TextLength == 0 || textBoxBalance.Text.Length == 0)
            {   
                MessageBox.Show("We need values in ALL the empty boxes");
            } 
            else
            {                
                String number = textBoxNumber.Text;
                String balance = textBoxBalance.Text;
                Account account = MyController.FindAccount(number);
                if (MyController.isAccountEmpty(account))
                {
                    MessageBox.Show("Theres no account with that number, try to add it first.");
                }
                else if (balance.All(char.IsDigit))
                {
                    MyController.AddBalanceInAccount(account, Int32.Parse(balance));
                    
                } 
                else
                {
                    MessageBox.Show("The amount to add in balance should be in number.");
                }
            }
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            Account MyAccount = new Account();
            string Number = textBoxNumber.Text.ToString();
            if (MyAccount.ValidateFormat(Number))
            {
                Number = MyAccount.Format(Number);
            }
            MyAccount = MyController.FindAccount(Number);
            if (MyController.isAccountEmpty(MyAccount))
            {
                MyAccount = new Account(Number, 0);
                MyController.RegisterAccount(MyAccount);
                MessageBox.Show("Account created succesfully!");
                
            }
            else
            {
                MessageBox.Show("The number is already register, try to add balance, not create a new account.");
            }
        }

        public void GoToFirstInterface()
        {
            this.Hide();
            First sistema = new First();
            sistema.ShowDialog();
            this.Close();
        }

    }
}
