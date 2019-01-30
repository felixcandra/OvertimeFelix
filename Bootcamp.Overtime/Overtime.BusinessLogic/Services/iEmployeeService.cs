using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.BusinessLogic
{
    public interface iEmployeeService
    {
        bool Insert(EmployeeParam employeeParam);
        bool Update(int? id, EmployeeParam employeeParam);
        bool Delete(int? id);
        List<Employees> Get();
        Employees Get(int? id);
        List<Employees> Search(string search, string cmb);
    }
}
