﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeadingEntities : DbContext
    {
        public LeadingEntities()
            : base("name=LeadingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Budget> Budget { get; set; }
        public DbSet<BudgetMemberBalance> BudgetMemberBalance { get; set; }
        public DbSet<BuyAdmin> BuyAdmin { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyGCPP> CompanyGCPP { get; set; }
        public DbSet<CompanyType> CompanyType { get; set; }
        public DbSet<ConfirmProcess> ConfirmProcess { get; set; }
        public DbSet<Crm_Complain> Crm_Complain { get; set; }
        public DbSet<Crm_DeliveryLog> Crm_DeliveryLog { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerDiscountRate> CustomerDiscountRate { get; set; }
        public DbSet<CustomerModel> CustomerModel { get; set; }
        public DbSet<CustomerReview> CustomerReview { get; set; }
        public DbSet<CustomerReviewParameter> CustomerReviewParameter { get; set; }
        public DbSet<DeliveryCompanyLine> DeliveryCompanyLine { get; set; }
        public DbSet<DeliveryLine> DeliveryLine { get; set; }
        public DbSet<DeliveryMemberLine> DeliveryMemberLine { get; set; }
        public DbSet<Dept> Dept { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<EmailApply> EmailApply { get; set; }
        public DbSet<EmailCheck> EmailCheck { get; set; }
        public DbSet<EmailServ> EmailServ { get; set; }
        public DbSet<Fav> Fav { get; set; }
        public DbSet<Gift> Gift { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Goods_bak20170926> Goods_bak20170926 { get; set; }
        public DbSet<Goods_bak20170929> Goods_bak20170929 { get; set; }
        public DbSet<GoodsAC> GoodsAC { get; set; }
        public DbSet<GoodsACModify> GoodsACModify { get; set; }
        public DbSet<GoodsBranch> GoodsBranch { get; set; }
        public DbSet<GoodsBrowse> GoodsBrowse { get; set; }
        public DbSet<GoodsComment> GoodsComment { get; set; }
        public DbSet<GoodsGroupDetail> GoodsGroupDetail { get; set; }
        public DbSet<GoodsModel> GoodsModel { get; set; }
        public DbSet<GoodsModelType> GoodsModelType { get; set; }
        public DbSet<GoodsPackage> GoodsPackage { get; set; }
        public DbSet<GoodsPackageLog> GoodsPackageLog { get; set; }
        public DbSet<GoodsParam> GoodsParam { get; set; }
        public DbSet<GoodsPhoto> GoodsPhoto { get; set; }
        public DbSet<GoodsPrice> GoodsPrice { get; set; }
        public DbSet<GoodsShelvesLog> GoodsShelvesLog { get; set; }
        public DbSet<GoodsStandingInventory> GoodsStandingInventory { get; set; }
        public DbSet<GoodsStore> GoodsStore { get; set; }
        public DbSet<GoodsStoreDetail> GoodsStoreDetail { get; set; }
        public DbSet<GoodsStoreLog> GoodsStoreLog { get; set; }
        public DbSet<GoodStoreInventory> GoodStoreInventory { get; set; }
        public DbSet<GoodStoreInventoryDetail> GoodStoreInventoryDetail { get; set; }
        public DbSet<GoodsType> GoodsType { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceMemberInfo> InvoiceMemberInfo { get; set; }
        public DbSet<InvoiceRequire> InvoiceRequire { get; set; }
        public DbSet<InvoiceRequireDetail> InvoiceRequireDetail { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<MemberAddress> MemberAddress { get; set; }
        public DbSet<MemberCart> MemberCart { get; set; }
        public DbSet<MemberInfoCfg> MemberInfoCfg { get; set; }
        public DbSet<MemberRole> MemberRole { get; set; }
        public DbSet<MemberThirdPlat> MemberThirdPlat { get; set; }
        public DbSet<MemberVisit> MemberVisit { get; set; }
        public DbSet<NeedToPurchase> NeedToPurchase { get; set; }
        public DbSet<NeedToPurchaseDetail> NeedToPurchaseDetail { get; set; }
        public DbSet<NeedToPurchaseOrder> NeedToPurchaseOrder { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsType> NewsType { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<NoticeRecord> NoticeRecord { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderBox> OrderBox { get; set; }
        public DbSet<OrderBoxDelivery> OrderBoxDelivery { get; set; }
        public DbSet<OrderBoxDeliveryDetail> OrderBoxDeliveryDetail { get; set; }
        public DbSet<OrderDelivery> OrderDelivery { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<OrderModify> OrderModify { get; set; }
        public DbSet<OrderPhoto> OrderPhoto { get; set; }
        public DbSet<OrderPicking> OrderPicking { get; set; }
        public DbSet<OrderReceiveMoney> OrderReceiveMoney { get; set; }
        public DbSet<OrderStatement> OrderStatement { get; set; }
        public DbSet<OrderStatementDetail> OrderStatementDetail { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderStatusDetail> OrderStatusDetail { get; set; }
        public DbSet<OrderWrittenGoods> OrderWrittenGoods { get; set; }
        public DbSet<PointDetail> PointDetail { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseCashConfirm> PurchaseCashConfirm { get; set; }
        public DbSet<PurchaseCashConfirmDetail> PurchaseCashConfirmDetail { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public DbSet<PurchaseLog> PurchaseLog { get; set; }
        public DbSet<PurchaseModify> PurchaseModify { get; set; }
        public DbSet<PurchasePay> PurchasePay { get; set; }
        public DbSet<PurchaseStatement> PurchaseStatement { get; set; }
        public DbSet<PurchaseStatementDetail> PurchaseStatementDetail { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SalesTarget> SalesTarget { get; set; }
        public DbSet<Sms> Sms { get; set; }
        public DbSet<SmsStore> SmsStore { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<StoreCustomerMeg> StoreCustomerMeg { get; set; }
        public DbSet<StoreDayData> StoreDayData { get; set; }
        public DbSet<StoreDept> StoreDept { get; set; }
        public DbSet<StoreMember> StoreMember { get; set; }
        public DbSet<StoreZone> StoreZone { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<supplier_bak20171018> supplier_bak20171018 { get; set; }
        public DbSet<Sys_Authority> Sys_Authority { get; set; }
        public DbSet<Sys_Branch> Sys_Branch { get; set; }
        public DbSet<Sys_BranchActivity> Sys_BranchActivity { get; set; }
        public DbSet<Sys_BranchDetail> Sys_BranchDetail { get; set; }
        public DbSet<Sys_BranchPhoto> Sys_BranchPhoto { get; set; }
        public DbSet<Sys_Car> Sys_Car { get; set; }
        public DbSet<Sys_CarLog> Sys_CarLog { get; set; }
        public DbSet<Sys_CarUser> Sys_CarUser { get; set; }
        public DbSet<Sys_Dept> Sys_Dept { get; set; }
        public DbSet<Sys_ErrorLog> Sys_ErrorLog { get; set; }
        public DbSet<Sys_Log> Sys_Log { get; set; }
        public DbSet<Sys_Menu> Sys_Menu { get; set; }
        public DbSet<Sys_Role> Sys_Role { get; set; }
        public DbSet<Sys_RoleAuthority> Sys_RoleAuthority { get; set; }
        public DbSet<Sys_RoleMenu> Sys_RoleMenu { get; set; }
        public DbSet<Sys_Updater> Sys_Updater { get; set; }
        public DbSet<Sys_UserRole> Sys_UserRole { get; set; }
        public DbSet<Sys_Users> Sys_Users { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<test_tpi_goods> test_tpi_goods { get; set; }
        public DbSet<TPI_AfterSaleAddress> TPI_AfterSaleAddress { get; set; }
        public DbSet<TPI_Authority> TPI_Authority { get; set; }
        public DbSet<TPI_Category> TPI_Category { get; set; }
        public DbSet<TPI_DSFBrand> TPI_DSFBrand { get; set; }
        public DbSet<TPI_ErrorLog> TPI_ErrorLog { get; set; }
        public DbSet<TPI_Goods> TPI_Goods { get; set; }
        public DbSet<TPI_GoodsCompare> TPI_GoodsCompare { get; set; }
        public DbSet<TPI_GoodsDiscount> TPI_GoodsDiscount { get; set; }
        public DbSet<TPI_GoodsParam> TPI_GoodsParam { get; set; }
        public DbSet<TPI_GoodsPromo> TPI_GoodsPromo { get; set; }
        public DbSet<TPI_GoodsPublic> TPI_GoodsPublic { get; set; }
        public DbSet<TPI_GoodsType> TPI_GoodsType { get; set; }
        public DbSet<TPI_HNSCGoods> TPI_HNSCGoods { get; set; }
        public DbSet<TPI_MessagePush> TPI_MessagePush { get; set; }
        public DbSet<TPI_OperationLog> TPI_OperationLog { get; set; }
        public DbSet<TPI_Order> TPI_Order { get; set; }
        public DbSet<TPI_OrderDetail> TPI_OrderDetail { get; set; }
        public DbSet<TPI_Project> TPI_Project { get; set; }
        public DbSet<TPI_Project4647> TPI_Project4647 { get; set; }
        public DbSet<TPI_Province> TPI_Province { get; set; }
        public DbSet<TPI_Refund> TPI_Refund { get; set; }
        public DbSet<TPI_RefundWaybill> TPI_RefundWaybill { get; set; }
        public DbSet<TPI_SupplierOrder> TPI_SupplierOrder { get; set; }
        public DbSet<TPI_Users> TPI_Users { get; set; }
        public DbSet<TPI_Users4647> TPI_Users4647 { get; set; }
        public DbSet<Transfer> Transfer { get; set; }
        public DbSet<TransferDetail> TransferDetail { get; set; }
        public DbSet<TransferPay> TransferPay { get; set; }
        public DbSet<TransferStatement> TransferStatement { get; set; }
        public DbSet<VIPApply> VIPApply { get; set; }
        public DbSet<VIPApplyDetail> VIPApplyDetail { get; set; }
        public DbSet<VIPApplyModify> VIPApplyModify { get; set; }
        public DbSet<VIPConfiguration> VIPConfiguration { get; set; }
        public DbSet<VIPCounter> VIPCounter { get; set; }
        public DbSet<VIPCounterCompany> VIPCounterCompany { get; set; }
        public DbSet<VIPCounterDetail> VIPCounterDetail { get; set; }
        public DbSet<VIPSiteInfo> VIPSiteInfo { get; set; }
    }
}
