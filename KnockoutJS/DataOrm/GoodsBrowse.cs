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
    
    public partial class GoodsBrowse
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string LoginName { get; set; }
        public string Company { get; set; }
        public Nullable<int> IsIntheCart { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string BrowseType { get; set; }
        public string ClientMark { get; set; }
        public string Guid { get; set; }
        public System.DateTime UpdateTime { get; set; }
    }
}