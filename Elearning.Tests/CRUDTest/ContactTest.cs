using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;

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
    }
}
