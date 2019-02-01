using Overtime.BusinessLogic;
using Overtime.BusinessLogic.Master;
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
using Bootcamp.Overtime;

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : MetroWindow
    {
        MyContex _contex = new MyContex();
        OvertimeParam overtimeParam = new OvertimeParam();
        iEmployeeService _employeeService = new EmployeeService();
        IOvertimeService _overtimeService = new OvertimeService();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var login = _employeeService.Login(UsernameBox.Text, PasswordBox.Password);
            if (login == null)
            {
                MessageBox.Show("Username or Password Wrong");
            }
            else
            {

                Settings.Default.Id = login.Id;
                Settings.Default.Position = login.Position.name;
                Settings.Default.Username = UsernameBox.Text;
                Settings.Default.Password = PasswordBox.Password;
                
                Settings.Default.Save();
                overtimeParam.employee_id = login.Id;
                overtimeParam.check_in = DateTimeOffset.Now.LocalDateTime;
                overtimeParam.createDate = DateTime.Now.ToLocalTime();
                _overtimeService.Insert(overtimeParam);

                if (login.password == "bootcamp" && login.question == "")
                {
                    PasswordDefault pass = new PasswordDefault();
                    pass.Show();
                    this.Close();
                }
                else if (login.password != "bootcamp" && login.question == "")
                {

                }
                else
                {
                    if (Settings.Default.Position == "Admin")
                    {
                        MainWindow main = new MainWindow();
                        main.Show();
                        this.Close();
                    }
                    else
                    {
                        EmployeePage emp = new EmployeePage();
                        emp.Show();
                        this.Close();
                    }
                }
                

            }
        }

        private void UsernameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));

        }

        private void PasswordBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void UsernameBox_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
