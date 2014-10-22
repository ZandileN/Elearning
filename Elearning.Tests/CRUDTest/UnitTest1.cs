using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models;
using Elearning.Models.DAL.DAOImpl;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
