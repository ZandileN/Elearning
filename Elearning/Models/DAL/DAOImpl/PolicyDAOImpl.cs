using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class PolicyDAOImpl : DAO_Policy, IDisposable
    {
        public Policy FindById(int reference)
        {
            Policy selectedPolicy = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Policy p = e.Policies.First(i => i.PolicyID == reference);
                    selectedPolicy = p;
                }
            }
            catch
            {
                return selectedPolicy;
            }
            return selectedPolicy;
        }

        public List<Policy> FindAll()
        {
            List<Policy> selectedPolicy = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Policy> p = e.Policies;
                    selectedPolicy = p.ToList();
                }
            }
            catch
            {
                return selectedPolicy;
            }
            return selectedPolicy;
        }

        public bool Persist(Policy entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Policies.Add(entity);
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

        public bool Merge(Policy entity)
        {
            bool isMerge = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Policy p = e.Policies.First(i => i.PolicyID == entity.PolicyID);
                    p.PolicyName = entity.PolicyName;
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

        public bool Remove(Policy entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {

                    Policy p = e.Policies.First(i => i.PolicyID == entity.PolicyID);
                    e.Policies.Remove(p);
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