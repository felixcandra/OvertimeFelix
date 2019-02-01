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
using MahApps.Metro.Controls;

namespace Bootcamp.Overtime
{
    
    public partial class PopUpInsertPosition : MetroWindow
    {
        iPositionService _positionService = new PositionService();
        MyContex _context = new MyContex();
        PositionParam positionParam = new PositionParam();
        public PopUpInsertPosition()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var position = PositionTextbox.Text;
            if (string.IsNullOrWhiteSpace(position) == true)
            {
                MessageBox.Show("Position must not be empty or whitespace");
            }
            else
            {
                positionParam.Name = position;
                _positionService.insert(positionParam);
                MessageBox.Show("Data Saved");
                this.Close();
            }
            MainWindow main = new MainWindow();
            main.Show();
            main.LoadGrid();
                      
        }

        private void PositionTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }
    }
}
