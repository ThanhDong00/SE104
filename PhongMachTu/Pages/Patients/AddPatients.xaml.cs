using Microsoft.Win32;
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
    /// Interaction logic for AddPatients.xaml
    /// </summary>
    public partial class AddPatients : Page
    {
        public AddPatients()
        {
            InitializeComponent();
        }

        
        Dashboard dashboard = Application.Current.Windows.OfType<Dashboard>().FirstOrDefault();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            dashboard.fContainer.Navigate(new System.Uri("Pages/Patients/patientsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Choose_image(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var image = new BitmapImage(new Uri(openFileDialog.FileName));
                var brush = new ImageBrush(image);
                brush.Stretch = Stretch.Uniform;
                img_button.Background = brush;
            }
            icon_visibility.Visibility = Visibility.Collapsed;
        }
    }
}
