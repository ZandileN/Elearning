//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elearning
{
    using System;
    using System.Collections.Generic;
    
    public partial class Policy
    {
        public Policy()
        {
            this.Positions = new HashSet<Position>();
            this.Questions = new HashSet<Question>();
        }
    
        public int PolicyID { get; set; }
        public int Version { get; set; }
        public int DepartmentID { get; set; }
        public string PolicyName { get; set; }
        public string Description { get; set; }
        public string DocumentBlob { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
