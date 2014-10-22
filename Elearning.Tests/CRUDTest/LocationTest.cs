using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;
using System.Collections.Generic;
using Elearning.Models;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class LocationTest
    {
        [TestMethod]
        public void TestInsertLocation()
        {


            Employee e = new Employee()
            {

                EmployeeID = 2,
                Firstname = "Radicca",
                Lastname = "Mosia",
                PersonnelNum = 3225,
                DepartmentID = 1,
                PositionID = 111,
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

        [TestMethod]
        public void TestFindByIdLocation()
        {
            using (LocationDAOImpl daoImp = new LocationDAOImpl())
            {

                Location l = daoImp.FindbyId(1);

                Assert.AreEqual(l.BuildingName, "Kwezi");
            }
        }

        [TestMethod]
        public void TestFindAllLocation()
        {
            ICollection<Location> l = new List<Location>();
            using (LocationDAOImpl daoImp = new LocationDAOImpl())
            {
                l = daoImp.FindAll().ToArray();
                Assert.IsNotNull(l);
            }
        }


        [TestMethod]
        public void TestMergeLocation()
        {
            Location s = new Location()
            {
                LocationID = 1,
                //EmployeeID = e.EmployeeID,
                BuildingName = "Kwezi",
                Floorlevel = 1,
                CubeName = "corner office",
                MoreDetails = "next to lift"

            };

            using (LocationDAOImpl daoImp = new LocationDAOImpl())
            {

                bool isPer = daoImp.Merge(s);

                Assert.IsTrue(isPer);
            }

        }

        [TestMethod]
        public void TestRemoveLocation()
        {

            Employee e = new Employee()
            {

                EmployeeID = 3,
                DepartmentID = 88,
                Firstname = "Lola",
                Lastname = "Wadsen",
                PersonnelNum = 3366,
                
                PositionID = 222,
                ExitDate = null,
                HireDate = null,


            };


            Location l = new Location()
            {
                LocationID = 1,
                EmployeeID = e.EmployeeID,
                BuildingName = "Kwezi",
                Floorlevel = 1,
                CubeName = "corner office",
                MoreDetails = "next to lift"
            };

          
         

            using (LocationDAOImpl daoImp = new LocationDAOImpl())
            {

                bool isPer = daoImp.Remove(l);
                Assert.IsTrue(isPer);
            }
        }
    }
}
