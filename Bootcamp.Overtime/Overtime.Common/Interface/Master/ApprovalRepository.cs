using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Param;
using Overtime.DataAccess.Model;

namespace Overtime.Common.Interface.Master
{
    public class ApprovalRepository : iApprovalRepository
    {
        ApprovalParam approvalParam = new ApprovalParam();
        MyContex _context = new MyContex();
        bool status = false;

        public bool insert(ApprovalParam approvalParam)
        {
            throw new NotImplementedException();
        }

        public bool update(int? id, ApprovalParam approvalParam)
        {
            var result = 0;
            Approvals approval = Get(id);
            approval.approval_status = approvalParam.approval_status;
            result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Approvals> Get()
        {
            var getAll = _context.Approvals1.Where(x => x.isDelete == false).ToList();
            return getAll;
        }

        public Approvals Get(int? id)
        {
            var get = _context.Approvals1.Find(id);
            return get;
        }
    }
}
