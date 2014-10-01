using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;

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
    }
}
