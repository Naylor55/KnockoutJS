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
    
    public partial class GoodsStandingInventory
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int StoreId { get; set; }
        public int GoodsId { get; set; }
        public string Model { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string Memo { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
        public int OldGoodsId { get; set; }
    }
}
