using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class PositionDAOImpl : DAO_Position, IDisposable
    {

        public Position FindById(int id)
        {
            Position selectedProgress = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Position p = e.Positions.First(i => i.PositionID == id);
                    selectedProgress = p;
                }
            }
            catch
            {
                return selectedProgress;
            }
            return selectedProgress;
        }

        public List<Position> FindAll()
        {
            List<Position> selectedProgress = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Position> p = e.Positions;
                    selectedProgress = p.ToList();
                }
            }
            catch
            {
                return selectedProgress;
            }
            return selectedProgress;
        }

        public bool Persist(Position entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Positions.Add(entity);
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

        public bool Merge(Position entity)
        {
            bool isMerge = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Position p = e.Positions.First(i => i.PositionID == entity.PositionID);
                    p.PositionName = entity.PositionName;
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

        public bool Remove(Position entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Position p = e.Positions.First(i => i.PositionID == entity.PositionID);
                    e.Positions.Remove(p);
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