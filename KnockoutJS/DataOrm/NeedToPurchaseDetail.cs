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
    
    public partial class NeedToPurchaseDetail
    {
        public int Id { get; set; }
        public int NeedToPurchaseId { get; set; }
        public int GoodsId { get; set; }
        public string Model { get; set; }
        public int Num { get; set; }
        public int LackNum { get; set; }
        public string PurchaseType { get; set; }
        public string PurchaseMemo { get; set; }
        public string CreditCard { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int Emergency { get; set; }
        public int SupplierId { get; set; }
        public string GoodsMemo { get; set; }
        public int OldGoodsId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<decimal> InPrice { get; set; }
        public string SprInvoiceType { get; set; }
        public double SprTaxRate { get; set; }
    }
}