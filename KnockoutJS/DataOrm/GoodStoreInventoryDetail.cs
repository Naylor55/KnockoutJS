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
    
    public partial class GoodStoreInventoryDetail
    {
        public int ID { get; set; }
        public int FK_GSDetail_ID { get; set; }
        public int FK_Goods_ID { get; set; }
        public int FK_Store_ID { get; set; }
        public Nullable<int> OldNum { get; set; }
        public Nullable<int> NewNum { get; set; }
        public Nullable<decimal> AC { get; set; }
        public Nullable<int> CreateUser { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public decimal OldSumMoney { get; set; }
        public decimal NewSumMoney { get; set; }
        public Nullable<int> FK_GSInventory_ID { get; set; }
    }
}