using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using Overtime.Common.Interface.Master;
using Overtime.Common.Interface;

namespace Overtime.BusinessLogic.Services.Master
{
    public class PositionService : iPositionService
    {
        iPositionRepository _positionRepository = new PositionRepository();
        public bool delete(int? id)
        {
            return _positionRepository.delete(id);
        }

        public List<Position> Get()
        {
            return _positionRepository.Get();
        }

        public Position Get(int? id)
        {
            return _positionRepository.Get(id);
        }

        public bool insert(PositionParam positionParam)
        {
            return _positionRepository.insert(positionParam);
        }

        public List<Position> Search(string search, string cmb)
        {
            return _positionRepository.Search(search, cmb);
        }

        public bool update(int? id, PositionParam positionParam)
        {
            return _positionRepository.update(positionParam.Id, positionParam);
        }
    }
}
