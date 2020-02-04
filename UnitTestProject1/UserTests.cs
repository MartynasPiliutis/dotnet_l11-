using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagerLibrary;

namespace UserManagerTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TikrinameArTeisingaiSukuriamasNaujasVartotojas()
        {
            //Assign
            User newUser1 = new User(001,"Vardas_Pavarde", new Right(1));
            //Act
            int testuserid = newUser1.UserID;
            string testusername = newUser1.UserName;
            string testuserrights = newUser1.GetUserRightsCode();
            //Assert
            Assert.AreEqual(testuserid, 001);
            Assert.AreEqual(testusername, "Vardas_Pavarde");
            Assert.AreEqual(testuserrights, "APPROVE_REJECT");
        }
        [TestMethod]
        public void TikrinameArTeisingaiPakeiciamosVartotojoTeises()
        {
            //Assign
            User newUser2 = new User(001, "Vardas_Pavarde", new Right(1));
            //Act
            newUser2.ChangeUserRights(new Right(0));
            string testuserrights = newUser2.GetUserRightsCode();
            //Assert
            Assert.AreEqual(testuserrights, "READ_ONLY");
        }
    }
}
