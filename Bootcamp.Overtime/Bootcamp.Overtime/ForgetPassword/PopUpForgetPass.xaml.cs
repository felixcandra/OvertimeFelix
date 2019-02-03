using Overtime.BusinessLogic;
using Overtime.BusinessLogic.Master;
using Overtime.DataAccess.Model;
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
using MahApps.Metro.Controls;

namespace WPF.Overtime.ForgetPassword
{
    /// <summary>
    /// Interaction logic for PopUpForgetPass.xaml
    /// </summary>
    public partial class PopUpForgetPass : MetroWindow
    {
        public string currUsername;
        public string currQuestion;
        public string currAnswer;
        iEmployeeService _employeeService = new EmployeeService();
        MyContex _contex = new MyContex();
        public PopUpForgetPass()
        {
            InitializeComponent();
        }

        private void GetPassButton_Click(object sender, RoutedEventArgs e)
        {
            var search = _employeeService.getUser(UsernameTextbox.Text, QuestionBox.Text, AnswerTextbox.Text);
            if(search == null)
            {
                MessageBox.Show("Username/Question/Answer is incorrect");
            }
            else
            {
                currUsername = UsernameTextbox.Text;
                currQuestion = QuestionBox.Text;
                currAnswer = AnswerTextbox.Text;
                PopUpResetPassword resetpass = new PopUpResetPassword();
                resetpass.currUser = currUsername;
                resetpass.currQuestion = currQuestion;
                resetpass.currAnswer = currAnswer;
                resetpass.Show();
                this.Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }
    }
}
