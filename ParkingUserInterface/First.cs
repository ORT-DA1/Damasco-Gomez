using ParkingBusinessLogic;
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
    public partial class First : Form
    {
        Controller MyController;
        public First()
        {
            InitializeComponent();
            MyController = new Controller();

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
            AddAccountInterface sistema = new AddAccountInterface(IsAccount);
            sistema.ShowDialog();
            this.Close();
        }

        public void GoToParkingLicense( bool IsParking)
        {
            this.Hide();
            BuyParkingInterface sistema = new BuyParkingInterface(IsParking);
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
    }
}
