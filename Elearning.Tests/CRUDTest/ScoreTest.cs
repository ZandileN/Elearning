﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elearning.Models.DAL.DAOImpl;

namespace Elearning.Tests.CRUDTest
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void TestInsertScore()
        {

            Employee e = new Employee()
            {

                EmployeeID = 3,
                Firstname = "Lola",
                Lastname = "Wadsen",
                PersonnelNum = 3366,
                JobTitle = "IS Infrustruture Manager",
                Position = "Finance Services Manager",
                ExitDate = null,
                HireDate = null,


            };

            using (EmployeeDAOImpl daoImpl = new EmployeeDAOImpl())
            {
                bool isPer = daoImpl.Persist(e);

                Assert.IsTrue(isPer);

            }



            Answer a = new Answer()
            {
                AnswerID = "a",
                Option1 = "2",
                Option2 = "3",
                Option3 = "9",
                Option4 = "21",

            };

            using (AnswerDAOImpl daoImpl = new AnswerDAOImpl())
            {
                bool isPer = daoImpl.Persist(a);

                Assert.IsTrue(isPer);

            }


            Policy policy = new Policy()
            {
                PolicyID = 2,
                Version = 1,
                PolicyName = "Leave",
                Description = "The Policy about Leave",
                DocumentBlob = "www/intranet/petrosa/policies/Leave",


            };

            using (PolicyDAOImpl daoImpl = new PolicyDAOImpl())
            {
                bool isPer = daoImpl.Persist(policy);

                Assert.IsTrue(isPer);

            }



            Question question = new Question()
            {
                QuestionID = 1,
                PolicyID = policy.PolicyID,
                Version = policy.Version,
                Description = "how many companies are you allowes to have ouside petrosa",

            };

            using (QuestionDAOImpl daoImpl = new QuestionDAOImpl())
            {
                bool isPer = daoImpl.Persist(question);

                Assert.IsTrue(isPer);

            }
            

            Score s = new Score()
            {

                ScoreID = 1,
                EmployeeID = e.EmployeeID,
                QuestionID = question.QuestionID,
                Mark = 70,
                Date = new DateTime(),
                Status = "Not Certified",
                Page = 20,
                Attempt = 2,


            };



            using (ScoreDAOImpl daoImpl = new ScoreDAOImpl())
            {
                bool isPer = daoImpl.Persist(s);

                Assert.IsTrue(isPer);

            }

        }
    }
}
