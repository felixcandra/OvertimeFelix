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
using MahApps.Metro.Controls;

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for ChangeUserPass.xaml
    /// </summary>
    public partial class ChangeUserPass : MetroWindow
    {
        iEmployeeService _employeeService = new EmployeeService();
        EmployeeParam EmpParam = new EmployeeParam();
        public ChangeUserPass()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (PassTextBox.Password.Length<8 || PassConfirm.Password.Length<8)
            {
                MessageBox.Show("At Least 8 Character");
            }
            else
            {
                if(PassTextBox.Password == Settings.Default.Password)
                {
                    EmpParam.password = PassConfirm.Password;
                    _employeeService.UpdatePass(Settings.Default.Id, EmpParam);
                    MessageBox.Show("Change Successfully");
                    Settings.Default.Password = PassConfirm.Password;
                    Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Old Password not match");
                }
                
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveQuestion_Click(object sender, RoutedEventArgs e)
        {

                if (OldTextbox.Text == Settings.Default.Answer && OldCombobox.Text==Settings.Default.Question)
                {
                    EmpParam.question = NewCombobox.Text;
                    EmpParam.answer = NewTextbox.Text;
                    _employeeService.UpdatePass(Settings.Default.Id, EmpParam);
                    MessageBox.Show("Change Successfully");
                    Settings.Default.Question = NewCombobox.Text;
                    Settings.Default.Answer = NewTextbox.Text;
                    Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Old Question and Answer not match");
                }

        }

        private void PassConfirm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void PassTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }
    }
}
