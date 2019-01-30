using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.Common.Interface;
using Overtime.Common.Interface.Master;
using Overtime.Common.Interfaces;
using Overtime.Common.Interfaces.Master;

namespace Overtime.BussinessLogic.Services.Master
{
    public class OvertimeService : IOvertimeService
    {
        iOvertimeRepository _overtimeRepository = new OvertimeRepository();
        public List<Overtimes> Get()
        {
            return _overtimeRepository.Get();
        }

        public List<Overtimes> Get(int? Id)
        {
            return _overtimeRepository.Get(Id);
        }
    }
}
