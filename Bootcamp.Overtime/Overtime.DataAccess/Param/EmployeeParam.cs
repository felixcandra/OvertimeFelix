using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.DataAccess.Param
{
    public class EmployeeParam
    {
        public int? Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string sub_district { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string postal_code { get; set; }
        public int salary { get; set; }
        public string phone { get; set; }
        public int? position_id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}
