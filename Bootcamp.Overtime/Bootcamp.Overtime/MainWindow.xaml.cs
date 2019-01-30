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
        string selectedId;
        public int? savedId = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

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
            popup.IdTextbox.Text = savedId.ToString();
            popup.Show();
        }

        private void EmployeeGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = EmployeeGrid.SelectedItem;
            selectedId = (EmployeeGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            savedId = Convert.ToInt32(selectedId);
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            EmployeeGrid.ItemsSource = _employeeService.Get();
        }
    }
}
