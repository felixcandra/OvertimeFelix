using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Common.Interfaces
{
    public interface IOvertimeRepository
    {
        List<Overtimes> Get();

        List<Overtimes> Get(int? Id);
        List<Overtimes> GetSearch(int? id,int? bulan, int? tahun);
        Overtimes GetId(int? Id);

        bool Insert(OvertimeParam overtimeParam);
        bool Update(int? Id,OvertimeParam overtimeParam);
    }
}
