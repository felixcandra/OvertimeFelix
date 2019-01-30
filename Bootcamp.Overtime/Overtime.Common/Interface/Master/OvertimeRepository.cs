using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using Overtime.Common.Interface;

namespace Overtime.Common.Interfaces.Master
{
    public class OvertimeRepository : iOvertimeRepository
    {
        MyContex _context = new MyContex();
        Overtimes overtime = new Overtimes();
        bool status = false;
        public List<Overtimes> Get()
        {
            return _context.Overtimes.ToList();
        }

        public List<Overtimes> Get(int? Id)
        {
            return _context.Overtimes.Where(x => x.Id == Id).ToList();
        }

        public bool Insert(OvertimeParam overtimeParam)
        {
            var result = 0;
            overtime.createDate = DateTimeOffset.Now.LocalDateTime;
            overtime.check_in = overtimeParam.check_in;
            overtime.check_out = overtimeParam.check_out;
            overtime.difference = overtimeParam.difference;
            overtime.employee_id = overtimeParam.employee_id;
            _context.Overtimes.Add(overtime);
            result = _context.SaveChanges();

            if (result > 0)
            {
                status = true;
                //MessageBox.Show("Insert Successfully");
            }
            return status;

        }

        public bool Update(OvertimeParam overtimeParam)
        {
            throw new NotImplementedException();
        }
    }
}
