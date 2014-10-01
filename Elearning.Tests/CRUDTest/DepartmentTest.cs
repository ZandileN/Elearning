using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models;
using System.Collections.Generic;
using System.Collections;
using Elearning.Models.DAL.DAOImpl;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class DepartmentTest
    {
        [TestMethod]
        public void TestInsertDepartment()
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
    }
}
