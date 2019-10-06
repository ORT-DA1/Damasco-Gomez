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
    public partial class ChangeCostParkingInterface : Form
    {
        private Controller MyControl;
        public ChangeCostParkingInterface(Controller myController)
        {
            InitializeComponent();
            MyControl = myController;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (TextBoxCost.TextLength == 0)
            {
                MessageBox.Show("Need a new cost to change the old one.");
            } 
            else if (TextBoxCost.Text.All(char.IsDigit))
            {
                
    
            } else
            {
                MessageBox.Show("The cost should be in numbers");
            }
        }
    }
}
