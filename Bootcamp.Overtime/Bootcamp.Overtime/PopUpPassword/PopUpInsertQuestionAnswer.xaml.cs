using Bootcamp.Overtime;
using MahApps.Metro.Controls;
using Overtime.BusinessLogic;
using Overtime.BusinessLogic.Master;
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
using WPF.Overtime.Properties;

namespace WPF.Overtime.PopUpPassword
{
    /// <summary>
    /// Interaction logic for PopUpInsertQuestionAnswer.xaml
    /// </summary>
    public partial class PopUpInsertQuestionAnswer : MetroWindow
    {
        iEmployeeService _employeeService = new EmployeeService();
        EmployeeParam employeeParam = new EmployeeParam();
        MyContex _context = new MyContex();

        public EmployeeParam EmployeeParam
        {
            get
            {
                return employeeParam;
            }

            set
            {
                employeeParam = value;
            }
        }

        public PopUpInsertQuestionAnswer()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var answer = textBoxAnswer.Text;
            var question = comboBoxQuestion.Text;
            int id = Settings.Default.Id;
            if (string.IsNullOrWhiteSpace(answer) == true)
            {
                MessageBox.Show("Answer Field must not be empty or whitespace");
            }
            else
            {
                employeeParam.answer = answer;
                employeeParam.question = question;
                _employeeService.UpdateQuestionAnswer(id, employeeParam);
                MessageBox.Show("Data Saved");
                Settings.Default.Question = comboBoxQuestion.Text;
                Settings.Default.Answer = textBoxAnswer.Text;
                Settings.Default.Save();

                if (Settings.Default.Position == "Admin")
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {
                    EmployeePage emp = new EmployeePage();
                    emp.Show();
                    this.Close();
                }  
            }
            
        }
    }
}
