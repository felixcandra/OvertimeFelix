using Overtime.BusinessLogic;
using Overtime.BusinessLogic.Master;
using Overtime.BusinessLogic.Services.Master;
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

namespace Bootcamp.Overtime
{
    /// <summary>
    /// Interaction logic for PopUpUpdateEmployee.xaml
    /// </summary>
    public partial class PopUpUpdateEmployee : Window
    {
        iEmployeeService _employeeService = new EmployeeService();
        iPositionService _positionService = new PositionService();
        EmployeeParam employeeParam = new EmployeeParam();
        public PopUpUpdateEmployee()
        {
            InitializeComponent();
        }



        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            {
                var username = UsernameTextbox.Text;
                var password = PasswordTextbox.Text;
                var firstname = FirstNameTextbox.Text;
                var lastname = LastNameTextbox.Text;
                var address = AddressTextbox.Text;
                var subdistrict = SubDistrictTextbox.Text;
                var district = DistrictTextbox.Text;
                var province = ProvinceTextbox.Text;
                var postal = PostalTextbox.Text;
                var salary = Convert.ToInt32(SalaryTextbox.Text);
                var phone = PhoneTextbox.Text;
                var position = Convert.ToInt16(PositionCombo.SelectedValue);

                if (string.IsNullOrWhiteSpace(username) == true)
                {
                    MessageBox.Show("Username Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(password) == true)
                {
                    MessageBox.Show("Password Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(firstname) == true)
                {
                    MessageBox.Show("First Name Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(lastname) == true)
                {
                    MessageBox.Show("Last Name Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(address) == true)
                {
                    MessageBox.Show("Address Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(subdistrict) == true)
                {
                    MessageBox.Show("Sub District Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(district) == true)
                {
                    MessageBox.Show("District Field must not be empty or whitespace");
                }
                else if (string.IsNullOrWhiteSpace(province) == true)
                {
                    MessageBox.Show("Province Field must not be empty or whitespace");
                }
                else
                {
                    employeeParam.username = username;
                    employeeParam.password = password;
                    employeeParam.first_name = firstname;
                    employeeParam.last_name = lastname;
                    employeeParam.address = address;
                    employeeParam.sub_district = subdistrict;
                    employeeParam.district = district;
                    employeeParam.province = province;
                    employeeParam.postal_code = postal;
                    employeeParam.salary = salary;
                    employeeParam.position_id = position;
                    _employeeService.Update(Convert.ToInt16(IdTextbox.Text), employeeParam);
                }

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PositionCombo.ItemsSource = _positionService.Get();
        }
    }
}
