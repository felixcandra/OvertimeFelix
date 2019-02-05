using Overtime.BusinessLogic.Services;
using Overtime.BusinessLogic.Services.Master;
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

namespace WPF.Overtime
{
    /// <summary>
    /// Interaction logic for ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Window
    {
        iApprovalService _approvalService = new ApprovalService();
        ApprovalParam approvalParam = new ApprovalParam();
        MyContex _context = new MyContex();
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            object item = ApprovalGrid.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("No data selected to approve");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure want to approve this overtime?", "Confirmation", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    approvalParam.Id = Convert.ToInt16((ApprovalGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                    approvalParam.approval_status = "Approved";
                    _approvalService.update(approvalParam.Id, approvalParam);
                    MessageBox.Show("Overtime Approved");
                    ApprovalGrid.ItemsSource = _approvalService.Get();
                }
            }
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            object item = ApprovalGrid.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("No data selected to reject");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure want to reject this overtime?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    approvalParam.Id = Convert.ToInt16((ApprovalGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                    approvalParam.approval_status = "Rejected";
                    _approvalService.update(approvalParam.Id, approvalParam);
                    MessageBox.Show("Overtime Rejected");
                    ApprovalGrid.ItemsSource = _approvalService.Get();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ApprovalGrid.ItemsSource = _approvalService.Get();
        }
    }
}
