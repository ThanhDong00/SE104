using PhongMachTu.Pages.Patients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PhongMachTu.Pages
{
    /// <summary>
    /// Interaction logic for patientsPage.xaml
    /// </summary>
    public partial class patientsPage : Page
    {
        public patientsPage()
        {
            InitializeComponent();
            ObservableCollection<User> items = new ObservableCollection<User>();
            items.Add(new User() { ID = 1, FullName = "Nguyen Thuc Bao", Sex = "nam", SDT = "0999999999", DiaChi = "CNTT" });
            items.Add(new User() { ID = 2, FullName = "Nguyen ", Sex = "nam", SDT = "0999999999", DiaChi = "CNTT" });
            items.Add(new User() { ID = 3, FullName = "Thuc", Sex = "nam", SDT = "0999999999", DiaChi = "CNTT" });
            items.Add(new User() { ID = 4, FullName = "Bao", Sex = "nam", SDT = "0999999999", DiaChi = "CNTT" });
            items.Add(new User() { ID = 5, FullName = "NguyenThucBao", Sex = "nam", SDT = "0999999999", DiaChi = "CNTT" });

            lvUsers.ItemsSource = items;
        }
        public class User
        {
            public int ID { get; set; }
            public string FullName { get; set; }
            public DateTime Birthday { get; set; }
            public string SDT { get; set; }
            public string Sex { get; set; }
            public string DiaChi { get; set; }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            {
                var button = sender as Button;
                if (button != null)
                {
                    var User = button.DataContext as User;

                    ((ObservableCollection<User>)lvUsers.ItemsSource).Remove(User);
                }
                else
                {
                    return;
                }
            }
        }
        Dashboard dashboard = Application.Current.Windows.OfType<Dashboard>().FirstOrDefault();
        private void Add_Click(object sender, RoutedEventArgs e)
        {
           
            dashboard.fContainer.Navigate(new System.Uri("Pages/Patients/AddPatients.xaml", UriKind.RelativeOrAbsolute));
        }

        private void OpenDetail_Click(object sender, RoutedEventArgs e)
        {
            dashboard.fContainer.Navigate(new System.Uri("Pages/Patients/DetailPatients.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
