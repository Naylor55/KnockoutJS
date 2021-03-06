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
    
    public partial class Purchase
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int StoreId { get; set; }
        public int SupplierId { get; set; }
        public string PurchaseType { get; set; }
        public decimal SumMoney { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public int PurchaseUserId { get; set; }
        public int IsPaid { get; set; }
        public int IsTax { get; set; }
        public string Memo { get; set; }
        public int IsConfirm { get; set; }
        public int IsCashConfirm { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int UserId { get; set; }
        public string PurchaseStatus { get; set; }
        public Nullable<int> NeedToPurchaseId { get; set; }
        public int ReceiptUserId { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public decimal Tax { get; set; }
        public double TaxRate { get; set; }
        public Nullable<System.DateTime> EstimatedStoreDate { get; set; }
        public Nullable<System.DateTime> ActualStoreDate { get; set; }
    }
}
