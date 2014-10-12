using Elearning.Models.DAL.DAOImpl;
using Elearning.Models.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.Services.Impl
{
    public class QuizingServiceImpl : QuizingServices
    {
        public List<Question> DisplayQuestions(int policyID, int version)
        {
            List<Question> qs = null;
            using (ElearningEntities e = new ElearningEntities())
            {
                //Statement that selects all policy questions from question where policy id and version are as the given in the arguments.
                qs = e.Questions.Where(i => i.PolicyID == policyID && i.Version == version).ToList();       
            }

            return qs;
        }
        public List<Answer> DisplayAnswer(List<Question> questions)
        {

            //create a new answer type list, loop through policy and save into the new list a elements that have an answerid in allAnswer that is equal to the answerid in Question 
            List<Answer> answerList = null;

            using (ElearningEntities e = new ElearningEntities())
            {  
                foreach (Question q in questions)
                {
                    answerList = e.Answers.Where(i => i.AnswerID == q.AnswerID && i.CorrectAnswer == q.CorrectAnswer).ToList();
                }
            }

            return answerList;

        }

        public int TotalMarkAfterQuiz(List<AnswerDTO> ans)
        {
            int markYouGot = 0;
            int totalNumberOfQuestion = 0;
            bool isPer = false;
            Employee emp = null;
            Progress progressOfCertainPolicy = null;

           
            foreach(AnswerDTO answer in ans){

                totalNumberOfQuestion = totalNumberOfQuestion + 1;  

                if (answer.CorrectAnswer.Equals(answer.SelectedAnswer))
                {
                    markYouGot = answer.QuestionMark + markYouGot;
             
                    using (ElearningEntities e = new ElearningEntities())
                    {
                        using (ScoreDAOImpl daoImp = new ScoreDAOImpl())
                        {
                            Score s = new Score();
                            s.Mark = answer.QuestionMark;
                            s.Date = new DateTime();
                            s.QuestionID = answer.QuestionID;

                            isPer = daoImp.Persist(s);

                            emp = e.Employees.First(i => i.PersonnelNum == answer.personnelNum);
                            progressOfCertainPolicy = e.Progresses.First(i => i.PolicyID == answer.PolicyID && i.Version == answer.Version && i.EmployeeID == emp.EmployeeID);

                         

                        }
                    }
                
                }
                
            }

            using (ElearningEntities e = new ElearningEntities())
            {
                if (isPer)
                {
                    using (ProgressDAOImpl daoImpl = new ProgressDAOImpl())
                    {

                        progressOfCertainPolicy.TotalMark = markYouGot;

                        progressOfCertainPolicy.Average = markYouGot / totalNumberOfQuestion;

                        bool isMer = daoImpl.Merge(progressOfCertainPolicy);
                    }
                }
            }

            return markYouGot;
        }

        public void display()
        {


        }

        public void Dispose()
        {
           
        }
    }

}