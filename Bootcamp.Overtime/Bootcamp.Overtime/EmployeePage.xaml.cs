using Overtime.BussinessLogic.Services;
using Overtime.BussinessLogic.Services.Master;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
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
using WPF.Overtime.Properties;
using MahApps.Metro.Controls;

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : MetroWindow
    {
        MyContex _contex = new MyContex();
        
        IOvertimeService overtimeService = new OvertimeService();
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int Id = Settings.Default.Id;
            OvertimeEmployeeGrid.ItemsSource = overtimeService.Get(Id);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            OvertimeParam overtimeParam = new OvertimeParam();
            MessageBoxResult result = MessageBox.Show("Yakin ingin Log out?", "Peringatan", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                overtimeParam.check_out = DateTimeOffset.Now.LocalDateTime;
                overtimeService.Update(Settings.Default.Id, overtimeParam);
                LoginPage login = new LoginPage();
                login.Show();
                this.Close();
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeUserPass change = new ChangeUserPass();
            change.Show();
        }
    }
}
