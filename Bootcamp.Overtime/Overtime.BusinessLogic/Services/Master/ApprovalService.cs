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

        public List<Approvals> GetOvertimeAll(int? id)
        {
            return _approvalRepository.GetOvertimeAll(id);
        }

        public List<Approvals> GetOvertimeSearch(int? id, int? bulan, int? tahun)
        {
            return _approvalRepository.GetOvertimeSearch(id, bulan, tahun);
        }

        public List<Approvals> GetTotal(int? id)
        {
            return _approvalRepository.GetTotal(id);
        }

        public bool insert(ApprovalParam approvalParam)
        {
            return _approvalRepository.insert(approvalParam);
        }

        public bool update(int? id, ApprovalParam approvalParam)
        {
            return _approvalRepository.update(approvalParam.Id, approvalParam);
        }
    }
}
