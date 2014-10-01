using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Elearning.Models.DAL.DAOImpl;

namespace Elearning.Tests
{
    [TestClass]
    public class ContactUnitTest
    {
        [TestMethod]
        public void TestPersistContact()
        {
            
            
                Contact c = new Contact()
                {
                    ContactID = 5,
                    CellNumber = "0768992895",
                    TellphoneNumber = "0219399999",
                    Email = "Musa.Radebe@Petrosa.co.za"

                };
               using (ContactDAOImpl daoImpl = new ContactDAOImpl()){

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
