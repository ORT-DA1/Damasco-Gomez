﻿using ParkingBusinessLogic;
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
            } else
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
            this.Hide();
            First sistema = new First(MyController);
            sistema.ShowDialog();
            this.Close();
        }

    }
}
