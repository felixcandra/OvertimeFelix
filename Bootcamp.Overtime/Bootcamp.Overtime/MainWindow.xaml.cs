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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bootcamp.Overtime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        iEmployeeService _employeeService = new EmployeeService();
        EmployeeParam employeeParam = new EmployeeParam();
        
        public int? savedId = 0;

        public object SubDistrictTextbox { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            new PopUpInsertEmployee().Show();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //using(PopUpUpdateEmployee popupdate = new PopUpUpdateEmployee())
            //{
            //    if(popupdate.ShowDialog() == DialogResult.OK)
            //    {
            //        employeeParam.Id = savedId;
            //    }
            //}
            //new PopUpUpdateEmployee().ShowDialog();
            PopUpUpdateEmployee popup = new PopUpUpdateEmployee();
            object item = EmployeeGrid.SelectedItem;
            popup.IdTextbox.Text = (EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            popup.UsernameTextbox.Text = (EmployeeGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            popup.PasswordTextbox.Text = (EmployeeGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; 
            popup.FirstNameTextbox.Text = (EmployeeGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; 
            popup.LastNameTextbox.Text = (EmployeeGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; 
            popup.AddressTextbox.Text = (EmployeeGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; 
            popup.SubDistrictTextbox.Text = (EmployeeGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; 
            popup.DistrictTextbox.Text = (EmployeeGrid.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; 
            popup.ProvinceTextbox.Text = (EmployeeGrid.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; 
            popup.PostalTextbox.Text = (EmployeeGrid.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; 
            popup.PhoneTextbox.Text = (EmployeeGrid.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; 
            popup.SalaryTextbox.Text = (EmployeeGrid.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; 
            popup.PositionCombo.SelectedValue = (EmployeeGrid.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text; 
            popup.Show();
        }

        private void EmployeeGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            //object item = EmployeeGrid.SelectedItem;
            //selectedId = (EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //savedId = Convert.ToInt32(selectedId);
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = _employeeService.Get();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Yakin ingin hapus?","Peringatan", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                object item = EmployeeGrid.SelectedItem;
                int id = Convert.ToInt16((EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                _employeeService.Delete(id);
                EmployeeGrid.ItemsSource = _employeeService.Get();
            }   
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = _employeeService.Search(SearchTextBox.Text, SearchcomboBox.Text);
        }
    }
}
