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
    
    public partial class TPI_MessagePush
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string CategoryCode { get; set; }
        public int ProjectId { get; set; }
        public int IsUserType { get; set; }
        public System.DateTime Updatetime { get; set; }
        public Nullable<int> Type { get; set; }
        public string Note { get; set; }
    }
}