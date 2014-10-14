using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class QuestionDAOImpl : DAO_Questioner, IDisposable
    {
        public List<Question> FindAll()
        {
            List<Question> selectedQuestioner = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Question> q = e.Questions;
                    selectedQuestioner = q.ToList();
                }
            }
            catch
            {
                return selectedQuestioner;
            }
            return selectedQuestioner;
        }

        public bool Persist(Question entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Questions.Add(entity);
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

        public bool Merge(Question entity)
        {
            bool isMerge = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Question q = e.Questions.First(i => i.QuestionID == entity.QuestionID);
                    q.Description = entity.Description;
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

        public bool Remove(Question entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Question q= e.Questions.First(i => i.QuestionID == entity.QuestionID);
                    e.Questions.Remove(q);
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