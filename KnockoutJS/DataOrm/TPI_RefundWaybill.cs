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
    
    public partial class TPI_RefundWaybill
    {
        public int id { get; set; }
        public int projectId { get; set; }
        public System.DateTime createTime { get; set; }
        public Nullable<int> tpi_refundId { get; set; }
        public string deliveryMerchantId { get; set; }
        public Nullable<byte> deliveryMerchantType { get; set; }
        public string deliveryId { get; set; }
        public Nullable<decimal> freightMoney { get; set; }
    }
}
