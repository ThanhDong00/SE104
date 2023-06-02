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

namespace PhongMachTu.Pages.Patients
{
    /// <summary>
    /// Interaction logic for DetailPatients.xaml
    /// </summary>
    public partial class DetailPatients : Page
    {
        public DetailPatients()
        {
            InitializeComponent();
        }

        Dashboard dashboard = Application.Current.Windows.OfType<Dashboard>().FirstOrDefault();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            dashboard.fContainer.Navigate(new System.Uri("Pages/Patients/patientsPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
