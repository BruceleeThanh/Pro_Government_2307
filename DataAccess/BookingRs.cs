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
    using System.Collections.Generic;
    
    public partial class BookingRs
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CustomerType { get; set; }
        public Nullable<int> BookingType { get; set; }
        public string Note { get; set; }
        public int IDCustomer { get; set; }
        public int IDSystemUser { get; set; }
        public Nullable<int> PayMenthod { get; set; }
        public Nullable<int> StatusPay { get; set; }
        public Nullable<decimal> BookingMoney { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<bool> Disable { get; set; }
        public int Level { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public System.DateTime DatePay { get; set; }
        public System.DateTime DateEdit { get; set; }
        public int IDCustomerGroup { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> AcceptDate { get; set; }
    }
}
