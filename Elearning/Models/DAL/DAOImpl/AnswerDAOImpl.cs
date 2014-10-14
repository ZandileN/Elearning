using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class AnswerDAOImpl : DAO_Answer, IDisposable
    {
        //public Quiz FindbyId(int id)
        //{
           // Quiz selectedQuiz = null;
            //try
            //{
                //using (ElearningEntities e = new ElearningEntities())
                //{
                    //Quiz q = e.Quizs.First(i => i.QuizID == id);
                    //selectedQuiz = q;
                //}
            //}
            //catch
            //{
                //return selectedQuiz;
            //}
            //return selectedQuiz;
        //}

        public List<Answer> FindAll()
        {
            List<Answer> selectedAnswer = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Answer> a = e.Answers;
                    selectedAnswer = a.ToList();
                }
            }
            catch
            {
                return selectedAnswer;
            }
            return selectedAnswer;
        }

        public bool Persist(Answer entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Answers.Add(entity);
                    e.SaveChanges();
                    isPeristed = true;
                }
            }
            catch
            {
                return isPeristed;
            }
            return isPeristed;
        }

        public bool Merge(Answer entity)
        {

            bool isMerge = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Answer a = e.Answers.First(i => i.AnswerID == entity.AnswerID);
                    a.Option1 = entity.Option1;
                    e.SaveChanges();
                    isMerge = true;
                }
            }
            catch
            {
                return isMerge;
            }
            return isMerge;
        }

        public bool Remove(Answer entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Answer a = e.Answers.First(i => i.AnswerID == entity.AnswerID);
                    e.Answers.Remove(a);
                    e.SaveChanges();
                    isRemoved = true;
                }
            }
            catch
            {
                return isRemoved;
            }
            return isRemoved;
        }

        public void Dispose()
        {

        }
    }
}