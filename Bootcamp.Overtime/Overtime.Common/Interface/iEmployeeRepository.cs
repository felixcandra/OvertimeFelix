using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Common.Interface.Master
{
    public interface iEmployeeRepository
    {
        bool Insert(EmployeeParam employeeParam);
        bool Update(int? id, EmployeeParam employeeParam);
        bool UpdatePass(int? id, EmployeeParam employeeParam);

        bool UpdateBootcamp(int? id, EmployeeParam employeeParam);
        bool UpdateQuestion(int? id, EmployeeParam employeeParam);

        bool UpdateQuestionAnswer(int? id, EmployeeParam employeeParam);

        bool Delete(int? id);
        List<Employees> Get();
        Employees Get(int? id);
        List<Employees> Search(string search, string cmb);
        Employees Login(string username, string password);
        Employees getUser(string username, string question, string answer);
        bool ResetPass(string username, string question, string answer, EmployeeParam employeeParam);
    }
}
