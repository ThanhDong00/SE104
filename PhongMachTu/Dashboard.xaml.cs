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
using System.Windows.Shapes;

namespace PhongMachTu
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

        //Click vao Dashboard khi khoi dong lan dau
        private void MyWindowLoadedHandler(object sender, RoutedEventArgs e)
        {
            btnDashboard.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/dashBoardPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = Brushes.Blue;
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnPatients_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Patients/patientsPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = Brushes.Blue;
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnAppointment_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Appointments/appointmentsPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = Brushes.Blue;
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnDoctor_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Employees/Employee_MainPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = Brushes.Blue;
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnBilling_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Billing/billingPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = Brushes.Blue;
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnMedicine_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/medicinePage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = Brushes.Blue;
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/settingPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = Brushes.Blue;
            btnReport.Foreground = new SolidColorBrush(color);
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/reportPage.xaml", UriKind.RelativeOrAbsolute));
            fContainer.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            //Thay doi mau 
            Color color = (Color)ColorConverter.ConvertFromString("#969795");
            btnDashboard.Foreground = new SolidColorBrush(color);
            btnPatients.Foreground = new SolidColorBrush(color);
            btnAppointment.Foreground = new SolidColorBrush(color);
            btnDoctor.Foreground = new SolidColorBrush(color);
            btnBilling.Foreground = new SolidColorBrush(color);
            btnMedicine.Foreground = new SolidColorBrush(color);
            btnSetting.Foreground = new SolidColorBrush(color);
            btnReport.Foreground = Brushes.Blue;
        }

    }
}
