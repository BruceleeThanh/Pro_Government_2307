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
    
    public partial class vw__ServicesInfo__Services_ServiceGroups
    {
        public int Services_ID { get; set; }
        public string Services_Name { get; set; }
        public Nullable<decimal> Services_CostRef { get; set; }
        public string Services_Unit { get; set; }
        public Nullable<int> Services_Status { get; set; }
        public Nullable<int> Services_Type { get; set; }
        public Nullable<bool> Services_Disable { get; set; }
        public int ServiceGroups_ID { get; set; }
        public string ServiceGroups_Name { get; set; }
        public Nullable<int> ServiceGroups_Type { get; set; }
        public Nullable<bool> ServiceGroups_Disable { get; set; }
    }
}
