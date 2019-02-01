using Overtime.BusinessLogic.Services.Master;
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
        public MainWindow()
        {
            // 
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = _positionService.Get();
            EmployeeGrid.ItemsSource = _employeeService.Get();
            OvertimeEmployeeGrid.ItemsSource = _overtimeService.Get();
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

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {

            dataGrid1.ItemsSource = _context.Position.Where(x => x.isDelete == false).ToList();
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
            OvertimeParam overtimeParam = new OvertimeParam();
            MessageBoxResult result = MessageBox.Show("Yakin ingin Log out?", "Peringatan", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                overtimeParam.check_out = DateTimeOffset.Now.LocalDateTime;
                _overtimeService.Update(Settings.Default.Id, overtimeParam);
                LoginPage login = new LoginPage();
                login.Show();
                this.Close();
            }
        }
    }
}
