using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System.Windows.Forms;

namespace Overtime.Common.Interfaces.Master
{
    public class OvertimeRepository : IOvertimeRepository
    {
        MyContex _context = new MyContex();
        Overtimes overtime = new Overtimes();
        bool status = false;
        public List<Overtimes> Get()
        {
            return _context.Overtimes.Where(x=>x.createDate.Value.Month == DateTime.Now.Month && x.difference >=3 ).ToList();
        }

        public List<Overtimes> Get(int? Id)
        {
            return _context.Overtimes.Where(x => x.employee_id == Id && x.createDate.Value.Month == DateTime.Now.Month && x.difference >=3).ToList();
        }


        public bool Insert(OvertimeParam overtimeParam)
        {
            var result = 0;
            overtime.createDate = DateTimeOffset.Now.LocalDateTime;
            overtime.check_in = overtimeParam.check_in;
            overtime.employee_id = overtimeParam.employee_id;
            _context.Overtimes.Add(overtime);
            result = _context.SaveChanges();

            if (result > 0)
            {
                status = true;
                MessageBox.Show("Login Successfully");
            }
            return status;

        }

        public bool Update(int? Id,OvertimeParam overtimeParam)
        {
            var result = 0;
            var overtimes = GetId(Id);
            if (overtimes != null)
            {
                //Jam 17 ubah ke setting
                int selisih = overtimeParam.check_out.Hour - 17;
                double overtime_salary;

                if (selisih >= 3 && selisih<=5)
                {
                    overtime_salary = (1 * 1.5 * (1.0 / 173.0) * Convert.ToDouble(overtimes.Employees.salary)) + ((selisih - 1) * 2 * (1.0 / 173.0) * Convert.ToDouble(overtimes.Employees.salary));
                }
                else if (selisih>5)
                {
                    selisih = 5;
                    overtime_salary = (1 * 1.5 * (1.0 / 173.0) * Convert.ToDouble(overtimes.Employees.salary)) + ((selisih - 1) * 2 * (1.0 / 173.0) * Convert.ToDouble(overtimes.Employees.salary));
                }
                else
                {
                    overtime_salary = 0;
                }
                //Selisih ubah ke setting

                overtimes.check_out = overtimeParam.check_out;
                    overtimes.difference = selisih;
                    overtimes.overtime_salary = Convert.ToInt32(overtime_salary);
                    result = _context.SaveChanges();
                    if (result > 0)
                    {
                        status = true;
                    }
            }
            
            return status;
        }

        public Overtimes GetId(int? Id)
        {
            var get = _context.Overtimes.FirstOrDefault(x => x.employee_id == Id && x.createDate.Value.Year == DateTime.Now.Year && x.createDate.Value.Month == DateTime.Now.Month && x.createDate.Value.Day == DateTime.Now.Day);
            return get;
        }
    }
}
