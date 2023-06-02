using PhongMachTu.Database;
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
using static PhongMachTu.Pages.patientsPage;

namespace PhongMachTu.Pages.Employees
{
    /// <summary>
    /// Interaction logic for Employee_MainPage.xaml
    /// </summary>
    public partial class Employee_MainPage : Page
    {
        PhongMach db= new PhongMach();
        public Employee_MainPage()
        {
            InitializeComponent();
            List <NhanVien> nhanVien = db.NhanVien.ToList();
            ObservableCollection<NhanVien> nhanViens = new ObservableCollection<NhanVien>(nhanVien);  
            dsNhanVien.ItemsSource = nhanViens;
        }
        Dashboard dashboard = Application.Current.Windows.OfType<Dashboard>().FirstOrDefault();
        private void btnAddNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            dashboard.fContainer.Navigate(new System.Uri("Pages/Employees/NewEmployee.xaml", UriKind.RelativeOrAbsolute));
        }
       
    }
}
