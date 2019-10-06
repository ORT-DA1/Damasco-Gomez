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
        public AddAccountInterface(bool CreateAccount)
        {
            InitializeComponent();
            MyController = new Controller();
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
            LogicException MyExc = new TextIncompliteException();
            if (textBoxNumber.TextLength == 0 || textBoxBalance.Text.Length == 0)
            {   
                MessageBox.Show(MyExc.ToString());
            } 
            else
            {
                Account MyAccount = new Account();
                string number = textBoxNumber.Text.ToString();
                if (MyAccount.ValidateFormat(number))
                {
                    number = MyAccount.Format(number);
                }
                MyAccount = MyController.FindAccount(textBoxNumber.Text);
                if ( !MyController.isAccountEmpty(MyAccount) )
                {
                    if (textBoxBalance.Text.Length > 0 && textBoxBalance.Text.All(char.IsDigit))
                    {
                        int BalanceToAdd = Int32.Parse(textBoxNumber.Text);
                        MyAccount.AddBalance(BalanceToAdd);
                        MessageBox.Show("Balance added correctly!");
                        GoToFirstInterface();
                    }
                    
                } 
                else
                {
                    MyExc = new NotAccountException();
                    MessageBox.Show(MyExc.ToString());
                }
            }
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            LogicException MyExc;
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
                MyExc = new HaveAccountException();
                MessageBox.Show(MyExc.ToString());
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
