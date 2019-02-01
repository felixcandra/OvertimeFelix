using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.BusinessLogic.Services.Master
{
    public interface iPositionService
    {
        bool insert(PositionParam positionParam);
        bool update(int? id, PositionParam positionParam);
        bool delete(int? id);
        List<Position> Get();
        Position Get(int? id);
        List<Position> Search(string search, string cmb);
    }
}
