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
    
    public partial class CustomerReview
    {
        public int Id { get; set; }
        public Nullable<int> FK_CustomerId { get; set; }
        public Nullable<int> FK_UsersId { get; set; }
        public string Contents { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdatePerson { get; set; }
        public Nullable<System.DateTime> NextTime { get; set; }
        public string ReviewPerson { get; set; }
        public string ReviewPhone { get; set; }
    }
}
