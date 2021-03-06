//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    
    public partial class sp_PaymentExt_GetAllData_Ext_Result
    {
        public int BookingRs_ID { get; set; }
        public Nullable<int> ObjectID { get; set; }
        public string ObjectType { get; set; }
        public string SkuObject { get; set; }
        public Nullable<decimal> FeeObjectNotTax { get; set; }
        public Nullable<double> FeeObjectWithTax { get; set; }
        public Nullable<int> IDBookingService { get; set; }
        public Nullable<int> IDService { get; set; }
        public string Services_Name { get; set; }
        public Nullable<System.DateTime> Service_DateUse { get; set; }
        public Nullable<double> FeeServiceNotTax { get; set; }
        public Nullable<double> FeeServiceWithTax { get; set; }
        public Nullable<int> Service_PaymentStatus { get; set; }
        public Nullable<int> Object_PaymentStatus { get; set; }
        public Nullable<int> BillH_PaymentStatus { get; set; }
        public Nullable<int> BillR_PaymentStatus { get; set; }
        public Nullable<int> Services_SubPayment { get; set; }
        public Nullable<int> Object_SubPayment { get; set; }
        public string Object_InvoiceNumber { get; set; }
        public Nullable<System.DateTime> Object_InvoiceDate { get; set; }
        public Nullable<System.DateTime> Object_AcceptDate { get; set; }
        public Nullable<System.DateTime> Time1 { get; set; }
        public Nullable<System.DateTime> Time2 { get; set; }
        public string BookingRs_Subject { get; set; }
        public string BookingHs_Subject { get; set; }
    }
}
