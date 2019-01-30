using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Common.Interface
{
    public interface iOvertimeRepository
    {
        List<Overtimes> Get();
        List<Overtimes> Get(int? Id);
        bool Insert(OvertimeParam overtimeParam);
        bool Update(OvertimeParam overtimeParam);
    }
}
