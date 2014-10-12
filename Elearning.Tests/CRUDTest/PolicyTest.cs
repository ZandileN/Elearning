using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models;
using System.Collections.Generic;
using System.Collections;
using Elearning.Models.DAL.DAOImpl;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class PolicyTest
    {
        [TestMethod]
        public void TestInsertPolicy()
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

            Policy policy = new Policy()
            {
                PolicyID = 1,
                Version = 1,
                DepartmentID = d.DepartmentID, 
                PolicyName = "MoonLight",
                Description = "The Policy about having business outside PetroSA",
                DocumentBlob = "www/intranet/petrosa/policies/veri",


            };

            using (PolicyDAOImpl daoImpl = new PolicyDAOImpl())
            {
                bool isPer = daoImpl.Persist(policy);

                Assert.IsTrue(isPer);

            }
        }

        [TestMethod]
        public void TestFindByIdPolicy()
        {
            using (PolicyDAOImpl daoImp = new PolicyDAOImpl())
            {

                Policy p = daoImp.FindById(1);

                Assert.AreEqual(p.PolicyName, "MoonLight");
            }
        }

        [TestMethod]
        public void TestFindAllPolicy()
        {
            List<Policy> p = new List<Policy>();
            using (PolicyDAOImpl daoImp = new PolicyDAOImpl())
            {
                p = daoImp.FindAll();
                Assert.IsNotNull(p);
            }
        }


        [TestMethod]
        public void TestMergePolicy()
        {
            Policy p = new Policy()
            {
                PolicyID = 1,
                Version = 1,
               // DepartmentID = d.DepartmentID,
                PolicyName = "MoonLight",
                Description = "The Policy about having business outside PetroSA",
                DocumentBlob = "www/intranet/petrosa/policies/MoonLight",

            };

            using (PolicyDAOImpl daoImp = new PolicyDAOImpl())
            {

                bool isPer = daoImp.Merge(p);

                Assert.IsTrue(isPer);
            }

        }

        [TestMethod]
        public void TestRemovePolicy()
        {

            Policy p = new Policy()
            {

                PolicyID = 1,
                Version = 1,
                //DepartmentID = d.DepartmentID,
                PolicyName = "MoonLight",
                Description = "The Policy about having business outside PetroSA",
                DocumentBlob = "www/intranet/petrosa/policies/veri",

            };

            using (PolicyDAOImpl daoImp = new PolicyDAOImpl())
            {
                bool isPer = daoImp.Remove(p);
                Assert.IsTrue(isPer);
            }
        }
    }
}
