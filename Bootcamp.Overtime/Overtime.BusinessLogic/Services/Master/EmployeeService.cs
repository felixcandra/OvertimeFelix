using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using Overtime.Common.Interface.Master;

namespace Overtime.BusinessLogic.Master
{
    public class EmployeeService : iEmployeeService
    {
        iEmployeeRepository _employeeRepository = new EmployeeRepository();
        public bool Delete(int? id)
        {
            return _employeeRepository.Delete(id);
        }

        public List<Employees> Get()
        {
            return _employeeRepository.Get();
        }

        public Employees Get(int? id)
        {
            return _employeeRepository.Get(id);
        }

        public bool Insert(EmployeeParam employeeParam)
        {
            return _employeeRepository.Insert(employeeParam);
        }

        public Employees Login(string username, string password)
        {
            return _employeeRepository.Login(username, password);
        }

        public List<Employees> Search(string search, string cmb)
        {
            return _employeeRepository.Search(search, cmb);
        }

        public bool Update(int? id, EmployeeParam employeeParam)
        {
            return _employeeRepository.Update(employeeParam.Id, employeeParam);
        }

        public bool UpdateBootcamp(int? id, EmployeeParam employeeParam)
        {
            return _employeeRepository.UpdateBootcamp(id, employeeParam);
        }

        public bool UpdatePass(int? id, EmployeeParam employeeParam)
        {
            return _employeeRepository.UpdatePass(id, employeeParam);
        }

<<<<<<< HEAD
        public bool UpdateQuestion(int? id, EmployeeParam employeeParam)
        {
            return _employeeRepository.UpdateQuestion(id, employeeParam);
=======
        public bool UpdateQuestionAnswer(int? id, EmployeeParam employeeParam)
        {
            return _employeeRepository.UpdateQuestionAnswer(id, employeeParam);
>>>>>>> ca724af08c94c12a47b98e0b48e52a6a4e2381b5
        }
    }
}
