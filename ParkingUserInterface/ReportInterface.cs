using Contracts;
using EFramework;
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

    public partial class ReportInterface : Form
    {
        private MyContext myContext;
        private DataFindPurchase dataFindPurchase;
        string license = "";
        string initDay = "";
        string initHour = "";
        string finHour = "";
        string finDay = "";
        DateParser dateParser;
        LicensePlateParser licenseParser;
        List<Purchase> listFindPurchases;
        bool IsByRank;

        public ReportInterface(bool byRank)
        {
            InitializeComponent();
            IsByRank = byRank;
            listPurchases.Hide();
            listFindPurchases = new List<Purchase>();
            dateParser = new DateParser();
            licenseParser = new LicensePlateParser();
            myContext = new MyContext();
            dataFindPurchase = new DataFindPurchase(myContext);
            listPurchases.HorizontalScrollbar = true;
            if (!IsByRank)
            {
                LabelFinDay.Hide();
                LabelInitDay.Hide();
                textInitDay.Hide();
                textFinDay.Hide();
                labelInitTime.Hide();
                labelFinTime.Hide();
                textInitTime.Hide();
                textFinTime.Hide();

            }
            else
            {
                LabelLicensePlate.Hide();
                textLicense.Hide();
            }
        }



        private void ReportInterfaceLoad(List<Purchase> list)
        {
            foreach(var p in list)
            {
                listPurchases.Items.Add(p);
            }
            
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            try
            {                
                if (IsByRank)
                {
                    string initTime = dateParser.ValidateAndFormatTime(textInitTime.Text);
                    string finTime = dateParser.ValidateAndFormatTime(textFinTime.Text);
                    string initDay = dateParser.ValidateDateAndFormat(textInitDay.Text);
                    string finDay = dateParser.ValidateDateAndFormat(textFinDay.Text);
                    listFindPurchases = dataFindPurchase.FindPurchaseBetweenDate(initDay, finDay, initTime, finTime);
                }
                else
                {
                    string license = licenseParser.FormatAndValidateLicensePlate(textLicense.Text);
                    listFindPurchases = dataFindPurchase.FindPurchaseByLicense(license);

                }
                if (listFindPurchases.Count == 0)
                {
                    MessageBox.Show(new NotPurchaseFound().Message);
                }
                else
                {
                    listPurchases.Show();
                    ReportInterfaceLoad(listFindPurchases);
                }
            }
            catch (LogicException f )
            {
                MessageBox.Show(f.Message);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstAndPrincipal second = new FirstAndPrincipal("None");
            second.ShowDialog();
            this.Close();
            dataFindPurchase.DisposeMyContext();
        }

      
    }
}
