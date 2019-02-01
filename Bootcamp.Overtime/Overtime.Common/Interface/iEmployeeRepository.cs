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
<<<<<<< HEAD
        bool UpdateBootcamp(int? id, EmployeeParam employeeParam);
        bool UpdateQuestion(int? id, EmployeeParam employeeParam);
=======
        bool UpdateQuestionAnswer(int? id, EmployeeParam employeeParam);
>>>>>>> ca724af08c94c12a47b98e0b48e52a6a4e2381b5
        bool Delete(int? id);
        List<Employees> Get();
        Employees Get(int? id);
        List<Employees> Search(string search, string cmb);
        Employees Login(string username, string password);
    }
}
