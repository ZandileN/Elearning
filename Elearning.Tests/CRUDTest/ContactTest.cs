using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;
using System.Collections.Generic;
using Elearning.Models;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void TestInsertContact()
        {
            Employee e = new Employee()
            {

                EmployeeID = 1,
                Firstname = "Noma",
                Lastname = "Mhlophe",
                PersonnelNum = 3335,
                JobTitle = "IS Operations Manager",
                Position = "Finance Services Manager",
                ExitDate = null,
                HireDate = null,


            };

            using (EmployeeDAOImpl daoImpl = new EmployeeDAOImpl())
            {
                bool isPer = daoImpl.Persist(e);

                Assert.IsTrue(isPer);

            }

            Contact c = new Contact()
            {
                ContactID = 1,
                EmployeeID = e.EmployeeID,
                CellNumber = "0768923715",
                TellphoneNumber = "0219399999",
                Email = "noma.mhlophe@petrosa.co.za"

            };

            using (ContactDAOImpl daoImpl = new ContactDAOImpl())
            {
                bool isPer = daoImpl.Persist(c);

                Assert.IsTrue(isPer);

            }
         }

        [TestMethod]
        public void TestFindByIdContact()
        {
            using (ContactDAOImpl daoImp = new ContactDAOImpl())
            {

                Contact c = daoImp.FindByID("Kunne.Mhlaba@Petrosa.co.za");

                Assert.AreEqual(c.ContactID, 2);
            }
        }

        [TestMethod]
        public void TestFindAllContact()
        {
            List<Contact> c = new List<Contact>();
            using (ContactDAOImpl daoImp = new ContactDAOImpl())
            {
                c = daoImp.FindAll();
                Assert.IsNotNull(c);
            }
        }


        [TestMethod]
        public void TestMergeContact()
        {
            Contact c = new Contact()
            {
                ContactID = 3,
                CellNumber = "0768923745",
                TellphoneNumber = "0219399900",
                Email = "Nomzamo.Mnambithi@Petrosa.co.za"

            };

            using (ContactDAOImpl daoImp = new ContactDAOImpl())
            {

                bool isPer = daoImp.Merge(c);

                Assert.IsTrue(isPer);
            }

        }

        [TestMethod]
        public void TestRemoveContact()
        {
            Contact c = new Contact()
            {
                ContactID = 3,
                CellNumber = "0768923745",
                TellphoneNumber = "0219399900",
                Email = "Nomzamo.Mnabithi@Petrosa.co.za"

            };

            using (ContactDAOImpl daoImp = new ContactDAOImpl())
            {

                bool isPer = daoImp.Remove(c);
                Assert.IsTrue(isPer);
           }
        }
    }
}
