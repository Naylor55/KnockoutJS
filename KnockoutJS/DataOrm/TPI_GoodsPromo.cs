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
    
    public partial class TPI_GoodsPromo
    {
        public int Id { get; set; }
        public byte Type { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public int GoodsId { get; set; }
        public decimal PromoDiscount { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> TotalNum { get; set; }
        public Nullable<int> MaxPurchasing { get; set; }
        public Nullable<int> MinPurchasing { get; set; }
    }
}