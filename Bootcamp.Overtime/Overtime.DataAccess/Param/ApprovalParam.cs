using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.DataAccess.Param
{
    public class ApprovalParam
    {
        public int? Id { get; set; }
        public int? employee_id { get; set; }
        public int? overtime_id { get; set; }
        public string reason { get; set; }
        public int? manager_id { get; set; }
        public string approval_status { get; set; }
    }
}
