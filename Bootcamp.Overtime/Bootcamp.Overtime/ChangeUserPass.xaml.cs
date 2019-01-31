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
            
            if (PassTextBox.Password.Length<8 || PassCConfirm.Password.Length<8)
            {
                MessageBox.Show("At Least Min 8 Character");
            }
            else
            {
                if(PassTextBox.Password == PassCConfirm.Password)
                {
                    EmpParam.password = PassTextBox.Password;
                    _employeeService.UpdatePass(Settings.Default.Id, EmpParam);
                    MessageBox.Show("Change Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Confirm Password not match");
                }
                
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PassTextBox.Password = Settings.Default.Password;
        }
    }
}
