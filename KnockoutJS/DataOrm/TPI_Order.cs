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
    
    public partial class TPI_Order
    {
        public int Id { get; set; }
        public string ThirdPartyOrderId { get; set; }
        public int ProjectId { get; set; }
        public string RealName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }
        public string InvoiceTitle { get; set; }
        public int InvoiceState { get; set; }
        public int InvoiceType { get; set; }
        public int InvoiceContent { get; set; }
        public decimal Amount { get; set; }
        public int Freight { get; set; }
        public string Payment { get; set; }
        public int ReviewId { get; set; }
        public string OrderStatus { get; set; }
        public int IsTransformation { get; set; }
        public Nullable<System.DateTime> OrderTime { get; set; }
        public int RowNum { get; set; }
        public string Town { get; set; }
        public string DeliveryCode { get; set; }
        public int ItemDeliveryId { get; set; }
        public string PrId { get; set; }
        public string enterpriseTaxpayer { get; set; }
        public Nullable<int> PromoMode { get; set; }
        public string OutboundStatus { get; set; }
        public string DeliveredStatus { get; set; }
    }
}
