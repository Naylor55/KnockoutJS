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
    
    public partial class NewsType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int ParentId { get; set; }
        public int IsNewsOrHelp { get; set; }
    }
}
