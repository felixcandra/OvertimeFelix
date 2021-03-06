﻿using Overtime.BusinessLogic.Services.Master;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Overtime.BusinessLogic;
using Overtime.DataAccess.Param;
using Overtime.BusinessLogic.Master;
using Overtime.BussinessLogic.Services;
using Overtime.BussinessLogic.Services.Master;
using WPF.Overtime.Properties;
using WPF.Overtime;
using Overtime.BusinessLogic.Services;

namespace Bootcamp.Overtime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        MyContex _context = new MyContex();
        iPositionService _positionService = new PositionService();
        iEmployeeService _employeeService = new EmployeeService();
        IOvertimeService _overtimeService = new OvertimeService();
        EmployeeParam employeeParam = new EmployeeParam();
        OvertimeParam overtimeParam = new OvertimeParam();
        
        ApprovalParam approvalParam = new ApprovalParam();
        IOvertimeService overtimeService = new OvertimeService();
        iApprovalService _approvalService = new ApprovalService();
        public MainWindow()
        {
            // 
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = _positionService.Get();
            EmployeeGrid.ItemsSource = _employeeService.Get();
            OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeAll(Settings.Default.Id);
            
        }

        private void buttonInsertPosition_Click(object sender, RoutedEventArgs e)
        {
            new PopUpInsertPosition().Show();
            this.Hide();
        }
        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            new PopUpInsertEmployee().Show();
            this.Hide();
        }

        private void buttonUpdatePosition_Click(object sender, RoutedEventArgs e)
        {
            PopUpUpdatePosition popUpUpdatepos = new PopUpUpdatePosition();
            object items = dataGrid1.SelectedItem;
            if (items == null)
            {
                MessageBox.Show("No Data selected for updating");
            }
            else
            {
                popUpUpdatepos.idtextBox.Text = (dataGrid1.SelectedCells[0].Column.GetCellContent(items) as TextBlock).Text;
                popUpUpdatepos.textBoxPosition.Text = (dataGrid1.SelectedCells[1].Column.GetCellContent(items) as TextBlock).Text;
                popUpUpdatepos.Show();
                this.Hide();
            }
           
            //new PopUpUpdatePosition().Show();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            PopUpUpdateEmployee popup = new PopUpUpdateEmployee();
            object item = EmployeeGrid.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("No data selected for updating");
            }
            else
            {
                popup.id = (EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                popup.FirstNameTextbox.Text = (EmployeeGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                popup.LastNameTextbox.Text = (EmployeeGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                popup.AddressTextbox.Text = (EmployeeGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                popup.SubDistrictTextbox.Text = (EmployeeGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                popup.DistrictTextbox.Text = (EmployeeGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                popup.ProvinceTextbox.Text = (EmployeeGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                popup.PostalTextbox.Text = (EmployeeGrid.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
                popup.PhoneTextbox.Text = (EmployeeGrid.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
                popup.SalaryTextbox.Text = (EmployeeGrid.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text;
                popup.position = (EmployeeGrid.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text;
                popup.Show();
                this.Hide();
            }

        }

        private void EmployeeGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            //object item = EmployeeGrid.SelectedItem;
            //selectedId = (EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //savedId = Convert.ToInt32(selectedId);
        }

        private void buttonDeletePosition_Click(object sender, RoutedEventArgs e)
        {
            object items = dataGrid1.SelectedItem;

            if (items == null)
            {
                MessageBox.Show("No Data Selected to Delete");
            }
            else
            {

                MessageBoxResult result = MessageBox.Show("Are You Sure to Delete this Position ?", "WARNING", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    int id = Convert.ToInt16((dataGrid1.SelectedCells[0].Column.GetCellContent(items) as TextBlock).Text);
                    _positionService.delete(id);
                    dataGrid1.ItemsSource = _positionService.Get();

                }
            }
         
            //new PopUpDeletePosition().Show();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            object item = EmployeeGrid.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("No data selected to delete");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure want to delete this employee?", "WARNING", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    int id = Convert.ToInt16((EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                    _employeeService.Delete(id);
                    EmployeeGrid.ItemsSource = _employeeService.Get();
                }
            }
        }


        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = _positionService.Search(textBoxSearch.Text, SearchComboBox.Text);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e) //employee search
        {
            EmployeeGrid.ItemsSource = _employeeService.Search(SearchTextBox.Text, SearchcomboBox.Text);
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void LoadGrid()
        {
            dataGrid1.ItemsSource = _positionService.Get();

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeUserPass change = new ChangeUserPass();
            change.Show();
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

        private void SearchButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchBox.Text) == false)
            {
                OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeSearch(Settings.Default.Id, Convert.ToInt16(SeachCombo.Text), Convert.ToInt16(SearchBox.Text));  
            }
            else{
                MessageBox.Show("Search box don't null or whitespace");
            }
           
        }


        private void SearchBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text == "")
            {
                OvertimeEmployeeGrid.ItemsSource = _approvalService.GetOvertimeAll(Settings.Default.Id);
            }
        }

        private void SearchBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
                        if (selisih > 3)
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
    }
}
