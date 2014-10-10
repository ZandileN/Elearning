using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.Services.DTO
{
    public class AnswerDTO
    {

        public string CorrectAnswer { set; get; }
        public string AnswerID { set; get; }
        public string SelectedAnswer { set; get; }

        public int QuestionMark { set; get; }

        public int PolicyID { set; get; }

        public int Version { set; get; }
       
    }
}