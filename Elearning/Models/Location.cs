//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elearning.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public int LocationID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string BuildingName { get; set; }
        public int Floorlevel { get; set; }
        public string CubeName { get; set; }
        public string MoreDetails { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}