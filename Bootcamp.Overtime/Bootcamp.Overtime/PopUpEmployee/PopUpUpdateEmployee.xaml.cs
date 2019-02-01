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
using MahApps.Metro.Controls;

namespace Bootcamp.Overtime
{
    /// <summary>
    /// Interaction logic for PopUpUpdateEmployee.xaml
    /// </summary>
    public partial class PopUpUpdateEmployee : MetroWindow
    {
        iEmployeeService _employeeService = new EmployeeService();
        iPositionService _positionService = new PositionService();
        EmployeeParam employeeParam = new EmployeeParam();
        public string position;
        public string id;
        public PopUpUpdateEmployee()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           PositionCombo.ItemsSource = _positionService.Get();
            //PositionCombo.SelectedItem = PositionCombo.SelectedItem.ToString(position);
            PositionCombo.Text = position;
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
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


            if (string.IsNullOrWhiteSpace(firstname) == true)
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
                employeeParam.first_name = firstname;
                employeeParam.last_name = lastname;
                employeeParam.address = address;
                employeeParam.sub_district = subdistrict;
                employeeParam.district = district;
                employeeParam.province = province;
                employeeParam.postal_code = postal;
                employeeParam.salary = salary;
                employeeParam.position_id = position;
                employeeParam.phone = phone;
                employeeParam.Id = Convert.ToInt16(id);
                _employeeService.Update(employeeParam.Id, employeeParam);
                MessageBox.Show("Data Saved");
                this.Close();
            }
            MainWindow main = new MainWindow();
            main.Show();
            main.LoadGrid();
        }

        private void FirstNameTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void LastNameTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void SubDistrict_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }


        private void SubDistrictTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void DistrictTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void ProvinceTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void PostalTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void SalaryTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void PhoneTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void PhoneTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
