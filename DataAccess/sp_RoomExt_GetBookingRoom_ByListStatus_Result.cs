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
    
    public partial class sp_RoomExt_GetBookingRoom_ByListStatus_Result
    {
        public int ID { get; set; }
        public Nullable<int> Bed1 { get; set; }
        public Nullable<int> Bed2 { get; set; }
        public Nullable<decimal> CostRef { get; set; }
        public string Sku { get; set; }
        public Nullable<int> Type { get; set; }
        public string Code { get; set; }
        public Nullable<int> LevelSku { get; set; }
        public Nullable<int> OrderSku { get; set; }
        public Nullable<bool> Disable { get; set; }
        public Nullable<int> IDLang { get; set; }
        public int BookingRooms_ID { get; set; }
        public System.DateTime CheckInActual { get; set; }
        public string Note { get; set; }
        public System.DateTime CheckInPlan { get; set; }
        public System.DateTime CheckOutActual { get; set; }
        public System.DateTime CheckOutPlan { get; set; }
        public Nullable<bool> Color { get; set; }
        public Nullable<int> Customers_ID { get; set; }
        public string Customers_Name { get; set; }
        public string Customers_Tel { get; set; }
        public string Customers_Address { get; set; }
        public string Customers_Nationality { get; set; }
        public Nullable<int> BookingRooms_Status { get; set; }
        public Nullable<int> CustomerGroups_ID { get; set; }
        public string CustomerGroups_Name { get; set; }
        public Nullable<int> BookingRs_ID { get; set; }
        public string BookingRs_Subject { get; set; }
        public Nullable<int> BookingRs_CustomerType { get; set; }
        public Nullable<decimal> BookingRs_BookingMoney { get; set; }
        public Nullable<int> Companies_ID { get; set; }
        public string Companies_Name { get; set; }
    }
}
