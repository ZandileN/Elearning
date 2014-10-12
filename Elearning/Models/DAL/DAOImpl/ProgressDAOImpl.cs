using Elearning.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class ProgressDAOImpl : DAO_Progress, IDisposable
    {
        
        public List<Progress> FindAll()
        {
            List<Progress> selectedAnswer = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Progress> a = e.Progresses;
                    selectedAnswer = a.ToList();
                }
            }
            catch
            {
                return selectedAnswer;
            }
            return selectedAnswer;
        }

        public bool Persist(Progress entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Progresses.Add(entity);
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

        public bool Merge(Progress entity)
        {
            bool isMerge = false;
      
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Progress p = e.Progresses.First(i => i.ProgressID == entity.ProgressID);
                    p.Page = entity.Page;
                    p.Status = entity.Status;
                    p.TotalMark = entity.TotalMark;
                    p.Average = entity.Average;
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

        public bool Remove(Progress entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Progress p = e.Progresses.First(i => i.ProgressID== entity.ProgressID);
                    e.Progresses.Remove(p);
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