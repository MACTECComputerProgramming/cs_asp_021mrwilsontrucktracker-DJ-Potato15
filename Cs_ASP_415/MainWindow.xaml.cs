using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cs_ASP_415
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Instantiate Variables


            int SocialSec , totMiles, totDays, numTotDays, vacDays;

            double totPay, phoneNum, ratePay;

            string driverName;

            DateTime startDate, endDate;

            ratePay = .25;



            // Format Drivers Info

            driverName = driversName.Text;

            phoneNum = int.Parse(DptextBox.Text);

            SocialSec = int.Parse(DsstextBox.Text);




            // Get Total Days

            startDate = StartDateCal.SelectedDate.Value;

            endDate = ReturnDateCal.SelectedDate.Value;

            numTotDays = (endDate - startDate).Days;

            // Get Days Off

            if (numTotDays > 4)
            {
                int leftOver = numTotDays % 5;

                totDays = numTotDays - leftOver;

                vacDays = (totDays / 5) * 2;


            }
            else { vacDays = 0;  }

            // Get Total Miles

            totMiles = (int.Parse(endMile.Text) - int.Parse(startMile.Text));



            // Get Total Pay

            if ((bool)(checkBox.IsChecked == true))
            {
                ratePay = ratePay + .12;
            }

            totPay = ratePay * totMiles;



            // Print Driver's Ticket

            labelDN.Content = "Driver - " + driversName;

            labelDss.Content = string.Format("Social Security Number # {0:000-00-0000}", DsstextBox);

            labelDP.Content = string.Format("Phone Number : {0: (000)000-0000}", phoneNum);

            this.totMiles.Content = ("Total Miles :" + this.totMiles);

            labelTD.Content = string.Format("Total Pay Due - {0:c}", totalPay);

            labelDO.Content = ("Number of vaction days earned :" + vacDays);











        }
    }
}
