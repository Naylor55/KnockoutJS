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
    
    public partial class VIPApplyDetail
    {
        public int Id { get; set; }
        public int ApplyId { get; set; }
        public int GoodsId { get; set; }
        public string Model { get; set; }
        public int Num { get; set; }
        public decimal VIPPrice { get; set; }
        public int OldGoodsId { get; set; }
    }
}