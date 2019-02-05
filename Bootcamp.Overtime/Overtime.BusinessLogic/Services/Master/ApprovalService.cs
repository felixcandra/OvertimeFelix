using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using Overtime.Common.Interface;
using Overtime.Common.Interface.Master;

namespace Overtime.BusinessLogic.Services.Master
{
    public class ApprovalService : iApprovalService
    {
        iApprovalRepository _approvalRepository = new ApprovalRepository();
        public List<Approvals> Get()
        {
            return _approvalRepository.Get();
        }

        public Approvals Get(int? id)
        {
            return _approvalRepository.Get(id);
        }

        public bool insert(ApprovalParam approvalParam)
        {
            throw new NotImplementedException();
        }

        public bool update(int? id, ApprovalParam approvalParam)
        {
            return _approvalRepository.update(approvalParam.Id, approvalParam);
        }
    }
}
