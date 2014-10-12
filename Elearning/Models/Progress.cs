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
    
    public partial class Progress
    {
        public Progress()
        {
            this.Scores = new HashSet<Score>();
        }
    
        public int ProgressID { get; set; }
        public Nullable<int> PolicyID { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> Page { get; set; }
        public string Status { get; set; }
        public Nullable<int> TotalMark { get; set; }
        public Nullable<int> Average { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}