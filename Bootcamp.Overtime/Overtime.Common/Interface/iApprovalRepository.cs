using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Common.Interface
{
    public interface iApprovalRepository
    {
        bool insert(ApprovalParam approvalParam);
        bool update(int? id, ApprovalParam approvalParam);
        Approvals Get(int? id);
        List<Approvals> Get();
        List<Approvals> GetTotal(int? id);
        List<Approvals> GetOvertimeAll(int? id);
        List<Approvals> GetOvertimeSearch(int? id, int? bulan, int? tahun);

    }
}
