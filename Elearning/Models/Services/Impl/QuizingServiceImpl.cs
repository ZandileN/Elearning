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
            int count = 0;

            foreach(AnswerDTO answer in ans){

                if (answer.CorrectAnswer.Equals(answer.SelectedAnswer))
                {
                    count = answer.QuestionMark + count;
                }
                // update mark in the score table with 1;
                using (ScoreDAOImpl daoImp = new ScoreDAOImpl())
                {
                    Score s = new Score();
                    s.Attempt = 1;
                    s.Mark = answer.QuestionMark;

                    bool isPer = daoImp.Merge(s);

                }


            }
            
            return count;
        }

        public void Dispose()
        {
           
        }
    }

}