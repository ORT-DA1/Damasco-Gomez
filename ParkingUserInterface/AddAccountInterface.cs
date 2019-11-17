using Contracts;
using ParkingBusinessLogic;
using System;
using System.Linq;
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
            }
            else
            {
                LabelAddAccount.Visible = false;
                AddAccountButton.Visible = false;

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GoToFirstInterface(MyController);
        }

        private void AddBalanceButton_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.TextLength == 0 || textBoxBalance.Text.Length == 0)
            {
                MessageBox.Show("We need values in ALL the empty boxes");
            }
            else
            {
                try
                {/*
                    String number = textBoxNumber.Text;
                    String balance = textBoxBalance.Text;
                    Account account = MyController.FindAccount(number);
                    if (MyController.IsAccountEmpty(account))
                    {
                        MessageBox.Show("Theres no account with that number, try to add it first.");
                    }
                    else if (balance.All(char.IsDigit))
                    {
                        MyController.AddBalanceInAccount(account, Int32.Parse(balance));
                        MessageBox.Show("The balance was added to the account.");
                        GoToFirstInterface(MyController);
                    }
                    else
                    {
                        MessageBox.Show("The amount to add in balance should be in number.");
                    }*/
                }
                catch (LogicException exMessage)
                {
                    MessageBox.Show(exMessage.Message);
                }
            }
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            string Number = textBoxNumber.Text;
            string balance = textBoxBalance.Text;
            if (Number.Length != 0 && balance.Length != 0 && balance.All(char.IsDigit))
            {
                try { /*
                    Account myAccount = MyController.FindAccount(Number);
                    if (MyController.IsAccountEmpty(myAccount))
                    {
                        myAccount = new AccountUruguay(Number,balance);
                        MyController.RegisterAccount(myAccount);
                        MessageBox.Show("The account was successfully added.");
                        GoToFirstInterface(MyController);
                    }
                    else
                    {
                        MessageBox.Show("The account already exist, try to add balance and not add account.");
                    }*/
                }
                catch (LogicException exMessage)
                {
                    MessageBox.Show(exMessage.Message);
                }
            }
            else
            {
                MessageBox.Show("We need the correct info in all boxes.");
            }
        }

        public void GoToFirstInterface(Controller MyController)
        {
            this.Hide();
            First sistema = new First(MyController);
            sistema.ShowDialog();
            this.Close();
        }

    }
}
