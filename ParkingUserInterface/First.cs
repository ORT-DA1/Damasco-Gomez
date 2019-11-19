using EFramework;
using ParkingBusinessLogic;
using System;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public partial class First : Form
    {
        Controller MyController;
        MyContext myContext = new MyContext();
        
        public First()
        {
            InitializeComponent();
            

        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            GoToAddBalanceAccount(true);
        }

        private void AddBalanceButton_Click(object sender, EventArgs e)
        {
            GoToAddBalanceAccount(false);

        }

        public void GoToAddBalanceAccount(bool IsAccount)
        {
            this.Hide();
            AddAccountInterface sistema = new AddAccountInterface(MyController, IsAccount);
            sistema.ShowDialog();
            this.Close();
        }

        public void GoToParkingLicense(bool IsParking)
        {
            this.Hide();
            BuyParkingInterface sistema = new BuyParkingInterface(MyController, IsParking);
            sistema.ShowDialog();
            this.Close();
        }

        private void BuyParkingButton_Click(object sender, EventArgs e)
        {
            GoToParkingLicense(true);
        }

        private void CheckParkingButton_Click(object sender, EventArgs e)
        {
            GoToParkingLicense(false);
        }

        private void CostParkingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeCostParkingInterface sistema = new ChangeCostParkingInterface(MyController);
            sistema.ShowDialog();
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnUruguay_Click(object sender, EventArgs e)
        {

        }
    }
}
