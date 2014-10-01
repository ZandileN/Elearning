using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class LocationTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            Employee e = new Employee()
            {

                EmployeeID = 2,
                Firstname = "Radicca",
                Lastname = "Mosia",
                PersonnelNum = 3225,
                JobTitle = "IS Operations Developer",
                Position = "SAP Module A Specialist",
                ExitDate = null,
                HireDate = null,


            };

            using (EmployeeDAOImpl daoImpl = new EmployeeDAOImpl())
            {
                bool isPer = daoImpl.Persist(e);

                Assert.IsTrue(isPer);

            }
            Location l = new Location()
            {

                LocationID = 1,
                EmployeeID = e.EmployeeID,
                BuildingName = "Kwezi",
                Floorlevel = 1,
                CubeName = "corner office",
                MoreDetails = "next to lift"

            };

            using (LocationDAOImpl daoImpl = new LocationDAOImpl())
            {
                bool isPer = daoImpl.Persist(l);

                Assert.IsTrue(isPer);

            }
        }
    }
}
