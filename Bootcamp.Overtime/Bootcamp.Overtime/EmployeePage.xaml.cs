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
using Overtime.BusinessLogic.Services;
using Overtime.BusinessLogic.Services.Master;

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : MetroWindow
    {
        MyContex _contex = new MyContex();
        int id = Settings.Default.Id;
        OvertimeParam overtimeParam = new OvertimeParam();
        ApprovalParam approvalParam = new ApprovalParam();
        IOvertimeService overtimeService = new OvertimeService();
        iApprovalService _approvalService = new ApprovalService();
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int Id = Settings.Default.Id;
            OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeAll(Id);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Yakin ingin Log out?", "Peringatan", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
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

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchBox.Text) == true)
            {
                MessageBox.Show("Search box don't null or whitespace");
            }
            else
            {
                OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeSearch(id, Convert.ToInt16(SeachCombo.Text), Convert.ToInt16(SearchBox.Text));
            }
            
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text == "")
            {
                OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeAll(id);
            }
        }

        private void SearchBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            int? total = 0;
            bool status = overtimeService.Update(Settings.Default.Id, total, overtimeParam);
            var gettotal = _approvalService.GetTotal(Settings.Default.Id);
            foreach (var hitung in gettotal)
            {
                total = total + hitung.Overtime.difference;
            }

            MessageBoxResult result = MessageBox.Show("Yakin ingin Check Out?", "Peringatan", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                if (status == false)
                {
                    LoginPage login = new LoginPage();
                    login.Show();
                    this.Close();
                }
                else
                {
                    overtimeParam.check_out = DateTimeOffset.Now.LocalDateTime;
                    overtimeService.Update(Settings.Default.Id, total, overtimeParam);
                    int selisih = 0;
                    selisih = DateTime.Now.Hour - 17;
                    var approval = _approvalService.Get(Settings.Default.Id);
                    if (approval == null)
                    {
                        if (selisih > 3 && selisih <= 5)
                        {
                            approvalParam.employee_id = Settings.Default.Id;
                            approvalParam.approval_status = "WAITING";
                            approvalParam.reason = ReasonTextBox.Text;
                            approvalParam.overtime_id = overtimeService.GetId(Settings.Default.Id).Id;
                            _approvalService.insert(approvalParam);
                        }
                        int Id = Settings.Default.Id;
                        OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeAll(Id);
                    }
                    else
                    {
                        MessageBox.Show("Already Check Out For This Day");
                    }

                }
            
        }
            
        }

        private void MetroWindow_Activated(object sender, EventArgs e)
        {
        }
    }
}
