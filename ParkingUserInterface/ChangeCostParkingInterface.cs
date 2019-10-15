using ParkingBusinessLogic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ParkingUserInterface
{
    public partial class ChangeCostParkingInterface : Form
    {
        private Controller MyController;
        public ChangeCostParkingInterface(Controller myController)
        {
            InitializeComponent();
            MyController = myController;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (TextBoxCost.TextLength == 0)
            {
                MessageBox.Show("Need a new cost to change the old one.");
            }
            else if (TextBoxCost.Text.All(char.IsDigit))
            {
                int NewValue = Int32.Parse(TextBoxCost.Text);
                MyController.ChageValueMinute(NewValue);
                MessageBox.Show("The cost was change.");
                GoToFirst();
            }
            else
            {
                MessageBox.Show("The cost should be in numbers");
            }
        }
        public void GoToFirst()
        {
            this.Hide();
            First sistema = new First(MyController);
            sistema.ShowDialog();
            this.Close();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            GoToFirst();
        }
    }
}
