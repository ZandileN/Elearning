using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elearning.Models.DAL.DAOImpl
{
    public class EmployeeDAOImpl : DAO_Employee, IDisposable
    {
        public Employee FindById(string firstname, string lastname)
        {
            Employee selectedEmployee = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Employee emp = e.Employees.First(i => i.Firstname == firstname);
                    selectedEmployee = emp;
                }
            }
            catch
            {
                return selectedEmployee;
            }
            return selectedEmployee;
        }

        public List<Employee> FindAll()
        {
            List<Employee> selectedEmployee = null;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    IEnumerable<Employee> emp = e.Employees;
                    selectedEmployee = emp.ToList();
                }
            }
            catch
            {
                return selectedEmployee;
            }
            return selectedEmployee;
        }

        public bool Persist(Employee entity)
        {
            bool isPeristed = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    e.Employees.Add(entity);
                    e.SaveChanges();
                    isPeristed = true;
                }
            }
            catch
            {
                return isPeristed;
                //Console.Write(e.ToString());

            }
            return isPeristed;
        }

        public bool Merge(Employee entity)
        {
            bool isMerge = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Employee emp = e.Employees.First(i => i.EmployeeID == entity.EmployeeID);
                    emp.JobTitle = entity.JobTitle;
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

        public bool Remove(Employee entity)
        {
            bool isRemoved = false;
            try
            {
                using (ElearningEntities e = new ElearningEntities())
                {
                    Employee d = e.Employees.First(i => i.EmployeeID == entity.EmployeeID);
                    e.Employees.Remove(d);
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