using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.BussinessLogic.Services
{
    public interface IOvertimeService
    {
        List<Overtimes> Get();

        List<Overtimes> Get(int? Id);
        Overtimes GetId(int? Id);
        bool Insert(OvertimeParam overtimeParam);
        bool Update(int? Id,int? total,OvertimeParam overtimeParam);
        List<Overtimes> GetSearch(int? id,string search, string cmb);
    }
}
