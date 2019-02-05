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
using Bootcamp.Overtime;
using System.Text.RegularExpressions;

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for PasswordDefault.xaml
    /// </summary>
    public partial class PasswordDefault : MetroWindow
    {
        public PasswordDefault()
        {
            InitializeComponent();
        }

        iEmployeeService _employeeService = new EmployeeService();
        EmployeeParam param = new EmployeeParam();

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (PassTextBox.Password.Length < 8 || PassConfirm.Password.Length < 8 || PassConfirm.Password.Length > 16 || PassTextBox.Password.Length > 16)
            {
                MessageBox.Show("At Least 8 - 16 Character");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(OldCombobox.Text) == true || string.IsNullOrWhiteSpace(OldTextbox.Text) == true)
                {
                    MessageBox.Show("Answer Field must not be empty or whitespace");
                }
                else
                {
                    if (PassTextBox.Password == PassConfirm.Password)
                    {
                        int id = Settings.Default.Id;
                        param.password = PassTextBox.Password;
                        param.question = OldCombobox.Text;
                        param.answer = OldTextbox.Text;
                        _employeeService.UpdateBootcamp(id, param);
                        Settings.Default.Password = PassTextBox.Password;
                        Settings.Default.Question = OldCombobox.Text;
                        Settings.Default.Answer = OldTextbox.Text;
                        Settings.Default.Save();
                        MessageBox.Show("Successfully change");

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
                    else
                    {
                        MessageBox.Show("Password and Confirm not match");
                    }

                }
            }
            


        }

        private void PassTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9a-zA-Z]+");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void PassConfirm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9a-zA-Z]+");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}
