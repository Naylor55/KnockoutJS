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
    
    public partial class Sys_Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Telphone { get; set; }
        public string LinkMan { get; set; }
        public string bank { get; set; }
        public string account { get; set; }
        public string complain_hotline { get; set; }
        public string print_title { get; set; }
        public string Province { get; set; }
        public Nullable<int> IsUnable { get; set; }
        public Nullable<int> ProvinceSort { get; set; }
        public Nullable<int> CitySort { get; set; }
        public int IsUseSiteGoods { get; set; }
        public int CityId { get; set; }
        public byte IsNC { get; set; }
    }
}
