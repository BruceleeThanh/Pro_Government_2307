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
    
    public partial class CheckPoints
    {
        public int ID { get; set; }
        public System.TimeSpan From { get; set; }
        public System.TimeSpan To { get; set; }
        public double AddTime { get; set; }
        public int Type { get; set; }
        public Nullable<int> Status { get; set; }
        public bool Disable { get; set; }
    }
}
