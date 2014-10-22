using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models;
using Elearning.Models.DAL.DAOImpl;
using System.Collections.Generic;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class DepartmentTest
    {
        [TestMethod]
        public void PersistDepTest()
        {

            Department d = new Department()
            {

                DepartmentID = 1,
                DepartmentName = "IS",
                Description = "Information Technology"


            };

            using (DepartmentDAOImpl daoImpl = new DepartmentDAOImpl())
            {
                bool isPer = daoImpl.Persist(d);

                Assert.IsTrue(isPer);

            }

        }

        [TestMethod]
        public void TestFindByIdDepartment(string name)
        {
            using (DepartmentDAOImpl daoImp = new DepartmentDAOImpl())
            {

                Department d = daoImp.FindById(name);

                Assert.AreEqual(d, "IS");
            }
        }

        [TestMethod]
        public void TestFindAllDepartment()
        {
            List<Department> c = new List<Department>();
            using (DepartmentDAOImpl daoImp = new DepartmentDAOImpl())
            {
                c = daoImp.FindAll();
                Assert.IsNotNull(c);
            }
        }


        [TestMethod]
        public void TestMergeDepartment()
        {
            Department d = new Department()
            {
                DepartmentID = 1,
                DepartmentName = "HR",
                Description = "Human Resource"

            };

            using (DepartmentDAOImpl daoImp = new DepartmentDAOImpl())
            {

                bool isPer = daoImp.Merge(d);

                Assert.IsTrue(isPer);
            }

        }

        [TestMethod]
        public void TestRemoveDepartment()
        {
            Department d = new Department()
            {
                DepartmentID = 1,
                DepartmentName = "HR",
                Description = "Human Resource"
            };

            using (DepartmentDAOImpl daoImp = new DepartmentDAOImpl())
            {
                bool isPer = daoImp.Remove(d);
                Assert.IsTrue(isPer);
            }
        }
    }
}
