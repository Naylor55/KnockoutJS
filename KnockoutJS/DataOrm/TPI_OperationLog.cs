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
    
    public partial class TPI_OperationLog
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Url { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string Operation { get; set; }
        public string PushState { get; set; }
        public string ReturnMsg { get; set; }
        public string ObjectId { get; set; }
        public string UserId { get; set; }
    }
}