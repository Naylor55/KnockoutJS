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
    
    public partial class GoodsComment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodsId { get; set; }
        public int MemberId { get; set; }
        public int Level { get; set; }
        public string Label { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}
