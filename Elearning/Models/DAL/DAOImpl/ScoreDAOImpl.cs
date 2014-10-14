using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class ScoreDAOImpl : DAO_Score, IDisposable
    {

        public Score FindById(int id)
        {
            Score selectedScore = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Score s = e.Scores.First(i => i.ScoreID == id);
                    selectedScore = s;
                }
            }
            catch
            {
                return selectedScore;
            }
            return selectedScore;
        }

        public List<Score> FindAll()
        {
            List<Score> selectedScore = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Score> s = e.Scores;
                    selectedScore = s.ToList();
                }
            }
            catch
            {
                return selectedScore;
            }
            return selectedScore;
        }

        public bool Persist(Score entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Scores.Add(entity);
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

        public bool Merge(Score entity)
        {
            bool isMerge = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Score s = e.Scores.First(i => i.ScoreID == entity.ScoreID);
                    s.Attempt = entity.Attempt;
                    s.Mark = entity.Mark;
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

        public bool Remove(Score entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Score s = e.Scores.First(i => i.ScoreID == entity.ScoreID);
                    e.Scores.Remove(s);
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