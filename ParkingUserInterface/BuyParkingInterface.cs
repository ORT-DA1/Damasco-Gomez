using Contracts;
using ParkingBusinessLogic;
using System;
using System.Windows.Forms;

namespace ParkingUserInterface
{

    public partial class BuyParkingInterface : Form
    {
        private Controller MyController;
        public BuyParkingInterface(Controller controller, bool IsParking)
        {
            InitializeComponent();
            MyController = controller;
            if (IsParking)
            {
                LabelLicensePlate.Visible = false;
                LabelTime.Visible = false;
                TextBoxLicense.Visible = false;
                TextBoxTime.Visible = false;
                CheckLicenseButton.Visible = false;
            }
            else
            {
                LabelNumber.Visible = false;
                LabelText.Visible = false;
                TextBoxNumber.Visible = false;
                TextBoxText.Visible = false;
                BuyParkingButton.Visible = false;
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            GoFirst();
        }

        public void GoFirst()
        {
            MyController.ToString();
            this.Hide();
            First sistema = new First(MyController);
            sistema.ShowDialog();
            this.Close();
        }

        private void BuyParkingButton_Click(object sender, EventArgs e)
        {
            if (TextBoxNumber.Text.Length != 0 && TextBoxText.Text.Length != 0)
            {
                try 
                { 
                    MyController.BuyParking(TextBoxNumber.Text, TextBoxText.Text);
                    MessageBox.Show("The parking was succesfully purchase.");
                    GoFirst();
                }
                catch (LogicException exMessage)
                {
                    MessageBox.Show(exMessage.Message);
                }
            }
            else
            {
                MessageBox.Show("To continue you need to fill all empty boxes");
            }
        }

        private void CheckLicenseButton_Click(object sender, EventArgs e)
        {
            if (TextBoxLicense.Text.Length != 0 && TextBoxTime.Text.Length != 0)
            {
                string myLicense = TextBoxLicense.Text;
                string myDate = TextBoxTime.Text;
                try
                {
                    if (MyController.ChekPurchase(myLicense,myDate))
                    {
                        MessageBox.Show("There is a purchase to that time with the license plate.");
                    } 
                    else
                    {
                        MessageBox.Show("There is not a purchase to that time with the license plate.");
                    }
                    GoFirst();
                }
                catch (LogicException exMessage)
                {
                    MessageBox.Show(exMessage.Message);
                }
            }
            else
            {
                MessageBox.Show("To continue you need to fill all empty boxes");
            }
        }
    }
}
