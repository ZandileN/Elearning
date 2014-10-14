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
    
    public partial class Question
    {
        public Question()
        {
            this.Scores = new HashSet<Score>();
        }
    
        public int QuestionID { get; set; }
        public string AnswerID { get; set; }
        public string CorrectAnswer { get; set; }
        public Nullable<int> PolicyID { get; set; }
        public Nullable<int> Version { get; set; }
        public string Description { get; set; }
        public Nullable<int> QuestionMark { get; set; }
    
        public virtual Answer Answer { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}