//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataOrm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Budget
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int DeptId { get; set; }
        public int MemberId { get; set; }
        public int IsDept { get; set; }
        public int IsPersonal { get; set; }
        public decimal Budget1 { get; set; }
        public decimal MonthBudget { get; set; }
        public int MaxOrderNum { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
