using Elearning.Models.DAL.DAOImpl;
using Elearning.Models.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.Services.Impl
{
    public class EmployeeServiceImpl : EmployeeServices
    {
        public Policy FailedPolicy(List<AnswerDTO> ans)
        {
            Policy policy = null;

            using (QuizingServices q = new QuizingServiceImpl())
            {


                int Mark = q.TotalMarkAfterQuiz(ans);
               
                if (Mark < 50)
                {
                    using (PolicyDAOImpl daoImp = new PolicyDAOImpl())
                    {
                        foreach (AnswerDTO a in ans)
                        {
                            policy = daoImp.FindById(a.PolicyID);
                        }
                           
                    }
                }

            }

            return policy;
        }

        public int PolicyMark(int policyID, int version, int empID)
        {
 
                int count = 0;
                int totalMark = 0;

                using (ElearningEntities e = new ElearningEntities())
                {

                    List<Score> scoresOfGivenEmployee = e.Scores.Where(i => i.EmployeeID == empID).ToList();
                    List<Question> questionOfGivenpolicy = e.Questions.Where(i => i.PolicyID == policyID && i.Version == version).ToList();

                    foreach (Score s in scoresOfGivenEmployee)
                    {
                        foreach(Question q in questionOfGivenpolicy)
                        {
                             if(s.QuestionID == q.QuestionID){

                                 count = count + s.Mark;
                                 totalMark = totalMark + totalMark;
                            }
                       }
                   } 
               }
               TotalMark(totalMark);
               return count;
                
        }  
        
        public int TotalMark(int totalMarkOfAllMarks){

            return totalMarkOfAllMarks;
        }


        public void Dispose()
        {

        }
    }
}