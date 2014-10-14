using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class LocationDAOImpl : DAO_Location, IDisposable
    {

        public Location FindbyId(int id)
        {
            
            Location l = null;
            try{

                using (ElearningEntities e = new ElearningEntities())
                {

                l = e.Locations.First(i => i.LocationID == id);
                
                }
           
            }
            catch
            {

                return l;
            }
           
            return l;
        }

        public List<Location> FindAll()
        {
            List<Location> allSpaces = null;
            try
            {

                using (ElearningEntities e = new ElearningEntities())
                {

                    IEnumerable<Location> loc = e.Locations;
                    allSpaces = loc.ToList();
                }

            }
            catch
            {
                return allSpaces;
            }
            return allSpaces;
        }

        public bool Persist(Location entity)
        {
            bool isPersisted = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Locations.Add(entity);
                    e.SaveChanges();
                    isPersisted = true;
                }

            }
            catch
            {
                return isPersisted;
            }
           
            return isPersisted;
        }

        public bool Merge(Location entity)
        {
            bool isMerged = false;

            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Location c = e.Locations.First(i => i.LocationID == entity.LocationID);
                    c.CubeName = entity.CubeName;
                    c.MoreDetails = entity.MoreDetails;
                    e.SaveChanges();
                    isMerged = true;

                }
            }
            catch
            {
                return isMerged;
            }
            return isMerged;
        }

        public bool Remove(Location entity)
        {
            bool isRemoved = false;

            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Location c = e.Locations.First(i => i.LocationID == entity.LocationID);
                    e.Locations.Remove(c);
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