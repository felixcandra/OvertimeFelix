using Overtime.BussinessLogic.Services;
using Overtime.BussinessLogic.Services.Master;
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
using System.Windows.Shapes;

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Window
    {
        MyContex _contex = new MyContex();
        IOvertimeService overtimeService = new OvertimeService();
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //int Id = Settings.Default.id;
            OvertimeEmployeeGrid.ItemsSource = overtimeService.Get();
        }
    }
}
