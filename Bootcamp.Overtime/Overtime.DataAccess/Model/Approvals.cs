//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Overtime.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Approvals
    {
        public int Id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> overtime_id { get; set; }
        public string reason { get; set; }
        public string approval_status { get; set; }
        public Nullable<bool> isDelete { get; set; }
    
        public virtual Employees Employee { get; set; }
        public virtual Overtimes Overtime { get; set; }
    }
}
