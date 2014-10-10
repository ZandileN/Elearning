using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;
using System.Collections.Generic;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void TestInsertPosition()
        {

            Policy policy = new Policy()
            {
                PolicyID = 2,
                Version = 1,
                PolicyName = "Time",
                Description = "The Policy about PetroSA's Time schedule",
                DocumentBlob = "www/intranet/petrosa/policies/Time",


            };

            using (PolicyDAOImpl daoImpl = new PolicyDAOImpl())
            {
                bool isPer = daoImpl.Persist(policy);

                Assert.IsTrue(isPer);

            }

            Position pos = new Position()
            {

                PositionID = 1,
                PolicyID = policy.PolicyID,
                Version = policy.Version,
                PositionName = "Finance Services Manager",
                Description = "Takes care of Money",

            };

            using (PositionDAOImpl daoImpl = new PositionDAOImpl())
            {
                bool isPer = daoImpl.Persist(pos);

                Assert.IsTrue(isPer);

            }


        }

        public void TestFindByIdPosition()
        {
            using (PositionDAOImpl daoImp = new PositionDAOImpl())
            {

                Position p = daoImp.FindById(880);

                Assert.AreEqual(p.Description, "Operation Manager");
            }
        }

        [TestMethod]
        public void TestFindAllPosition()
        {
            List<Position> p = new List<Position>();
            using (PositionDAOImpl daoImp = new PositionDAOImpl())
            {
                p = daoImp.FindAll();
                Assert.IsNotNull(p);
            }
        }
    }
}
