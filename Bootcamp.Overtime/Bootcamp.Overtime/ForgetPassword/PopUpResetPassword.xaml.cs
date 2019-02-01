using Bootcamp.Overtime;
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

namespace WPF.Overtime.ForgetPassword
{
    /// <summary>
    /// Interaction logic for PopUpResetPassword.xaml
    /// </summary>
    public partial class PopUpResetPassword : Window
    {
        iEmployeeService _employeeService = new EmployeeService();
        EmployeeParam EmpParam = new EmployeeParam();
        public string currUser;
        public string currQuestion;
        public string currAnswer;
        public PopUpResetPassword()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewPassBox.Password.Length < 8 || ConfirmPassBox.Password.Length < 8)
            {
                MessageBox.Show("At Least Min 8 Character");
            }
            else
            {
                if (NewPassBox.Password == ConfirmPassBox.Password)
                {
                    EmpParam.password = NewPassBox.Password;
                    _employeeService.ResetPass(currUser, currQuestion, currAnswer, EmpParam);
                    MessageBox.Show("Change Successfully");
                    this.Close();
                    LoginPage login = new LoginPage();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Confirm Password not match");
                }
            }
        }
    }
}
