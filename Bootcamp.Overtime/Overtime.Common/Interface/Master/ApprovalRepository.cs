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
        Approvals approval = new Approvals();
        bool status = false;

        public bool insert(ApprovalParam approvalParam)
        {
            var result = 0;
            approval.employee_id = approvalParam.employee_id;
            approval.overtime_id = approvalParam.overtime_id;
            approval.reason = approvalParam.reason;
            approval.approval_status = approvalParam.approval_status;
            approval.isDelete = false;
            _context.Approvals1.Add(approval);
            result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
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
            var get = _context.Approvals1.FirstOrDefault(x => x.employee_id == id && x.Overtime.createDate.Value.Year == DateTime.Now.Year && x.Overtime.createDate.Value.Month == DateTime.Now.Month && x.Overtime.createDate.Value.Day == DateTime.Now.Day);
            return get;
        }

        public List<Approvals> GetOvertimeAll(int? Id)
        {
            return _context.Approvals1.Where(x => x.employee_id == Id && x.Overtime.difference >= 3).ToList();
        }

        public List<Approvals> GetOvertimeSearch(int? id, int? bulan, int? tahun)
        {
            var searchOver = _context.Approvals1.Where(x => x.employee_id == id && x.Overtime.createDate.Value.Month == bulan && x.Overtime.difference >= 3 && x.Overtime.createDate.Value.Year == tahun).ToList();
            return searchOver;
        }

        public List<Approvals> GetTotal(int? id)
        {
            var gettotal = _context.Approvals1.Where(x => x.isDelete == false && x.employee_id == id && x.approval_status == "ACCEPTED" && x.Overtime.createDate.Value.Month == DateTime.Now.Month).ToList();
                return gettotal;
        }
    }
}
