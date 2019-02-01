using MahApps.Metro.Controls;
using Overtime.BusinessLogic;
using Overtime.BusinessLogic.Master;
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


namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for PopUpForgetPassword.xaml
    /// </summary>
    public partial class PopUpForgetPassword : MetroWindow
    {
        iEmployeeService _employeeService = new EmployeeService();
        EmployeeParam employeeParam = new EmployeeParam();
        public PopUpForgetPassword()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            //var Password = textBoxNewPassword.Text;
            if (textBoxNewPassword.Password.Length < 8 || textBoxReNewPassword.Password.Length < 8)
            {
                MessageBox.Show("Create your new password !");
            }
            else
            {
                if (textBoxNewPassword.Password == textBoxReNewPassword.Password)
                {
                    employeeParam.password = textBoxNewPassword.Password;
                    _employeeService.UpdatePass(Settings.Default.Id, employeeParam);
                    MessageBox.Show("Reset Password Successfuly");
                }
                else
                {
                    MessageBox.Show("Your password not match !");
                }
               
             
            }
      
        }
    }
}

//var position = PositionTextbox.Text;
//if (string.IsNullOrWhiteSpace(position) == true)
//{
//    MessageBox.Show("Position must not be empty or whitespace");
//}
//else
//{
//    positionParam.Name = position;
//    _positionService.insert(positionParam);
//    MessageBox.Show("Data Saved");
//    this.Close();
//}
//MainWindow main = new MainWindow();
//main.Show();
//main.LoadGrid();