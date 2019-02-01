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
    /// Interaction logic for PopUpUpdatePosition.xaml
    /// </summary>
    public partial class PopUpUpdatePosition : MetroWindow
    {
        PositionParam positionParam = new PositionParam();
        iPositionService _positionService = new PositionService();
        public PopUpUpdatePosition()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var name = textBoxPosition.Text;
            if (string.IsNullOrWhiteSpace(name) == true)
            {
                MessageBox.Show("Position must not be empty or white space");
            }
            else
            {
                positionParam.Name = name;
                positionParam.Id = Convert.ToInt16(idtextBox.Text);
                _positionService.update(positionParam.Id, positionParam);
                MessageBox.Show("Data Saved");
                this.Close();
            }
            MainWindow main = new MainWindow();
            main.Show();
            main.LoadGrid();
        }

        private void textBoxPosition_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
            main.LoadGrid();
        }
    }
}
