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
            return _context.Overtimes.Where(x=>x.check_out != null).ToList();
        }

        public List<Overtimes> Get(int? Id)
        {
            return _context.Overtimes.Where(x => x.employee_id == Id && x.difference >=3).ToList();
        }


        public bool Insert(OvertimeParam overtimeParam)
        {
            try
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
            }
            catch(Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            
            return status;

        }

        public bool Update(int? Id,int? total,OvertimeParam overtimeParam)
        {
            var result = 0;
            int selisih=0;
            selisih = overtimeParam.check_out.Hour - 17;
            int? kuota = total + selisih;
            var overtimes = GetId(Id);
            if (overtimes != null)
            {
                //Jam 17 ubah ke setting
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
                    selisih = 0;
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
            else if(kuota>40){
                MessageBox.Show("Your Overtime Hours Reach Limit");
                
            }
            else
            {
                status = false;
            }
            
            return status;
        }

        public Overtimes GetId(int? Id)
        {
            var get = _context.Overtimes.FirstOrDefault(x => x.employee_id == Id && x.createDate.Value.Year == DateTime.Now.Year && x.createDate.Value.Month == DateTime.Now.Month && x.createDate.Value.Day == DateTime.Now.Day);
            return get;
        }

        public List<Overtimes> GetSearch(int? id,string search, string cmb)
        {
            if (cmb == "Id")
            {
                return _context.Overtimes.Where(x => x.check_out != null && x.employee_id.ToString().Contains(id.ToString())).ToList();
            }
            else if(cmb=="First Name")
            {
                return _context.Overtimes.Where(x => x.check_out != null && x.Employees.first_name.Contains(search)).ToList();
            }
            else
            {
                return _context.Overtimes.Where(x => x.check_out != null && x.Employees.last_name.Contains(search)).ToList();
            }

        }

        
    }
}
