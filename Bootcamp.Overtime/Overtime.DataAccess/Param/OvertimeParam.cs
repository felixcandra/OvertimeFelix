using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.DataAccess.Param
{
    public class OvertimeParam
    {
        public int Id { get; set; }
        public DateTimeOffset check_in { get; set; }
        public DateTimeOffset check_out { get; set; }
        public DateTimeOffset createDate { get; set; }
        public int overtime_salary { get; set; }
        public int difference { get; set; }
        public int employee_id { get; set; }

    }
}
