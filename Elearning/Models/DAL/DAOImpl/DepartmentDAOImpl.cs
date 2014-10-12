using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class DepartmentDAOImpl : DAO_Department, IDisposable
    {
        public List<Department> FindById(string name)
        {
            List<Department> selectedDep = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Department> dep = e.Departments.Where(i => i.DepartmentName == name);
                    selectedDep = dep.ToList();
                }

            }
            catch
            {
                return selectedDep;
            }
            return selectedDep;
        }

        public List<Department> FindAll()
        {
            List<Department> selectedDep = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Department> dep = e.Departments;
                    selectedDep = dep.ToList();
                }
             }
             catch
             {
                 return selectedDep;
             }
            return selectedDep;
        }
       

        public bool Persist(Department entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Departments.Add(entity);
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

        public bool Merge(Department entity)
        {
             bool isMerge = false;
             try
             {
                 using (ElearningEntities e = new ElearningEntities())
                 {
                     Department d = e.Departments.First(i => i.DepartmentName == entity.DepartmentName);
                     d.Description = entity.Description;
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

        public bool Remove(Department entity)
        {
             bool isRemoved = false;
             try
             {
                 using (ElearningEntities e = new ElearningEntities())
                 {
                     Department d = e.Departments.First(i => i.DepartmentID == entity.DepartmentID);
                     e.Departments.Remove(d);
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