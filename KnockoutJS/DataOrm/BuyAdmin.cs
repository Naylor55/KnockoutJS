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
    
    public partial class BuyAdmin
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int ChooseDeptId { get; set; }
        public string ChooseDeptName { get; set; }
    }
}
