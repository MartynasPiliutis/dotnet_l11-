using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagerLibrary;

namespace UserManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestuojameArSurandaEsamusVartotojusSarase()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            //Act
            int findUserID = userRepository.GetUserByID(501).UserID;
            //Assert
            Assert.AreEqual(findUserID, 501);
        }

        [TestMethod]
        public void TestuojameArSukuriaNaujaVartotojaSarase()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            //Act
            userRepository.AddNewUser(001, "Vardas.Pavarde0", 0);
            int findUserID = userRepository.GetUserByID(001).UserID;
            string newUserID = userRepository.GetUserByID(001).UserID +" " + userRepository.GetUserByID(001).UserName;
            //Assert
            Assert.AreEqual(findUserID, 1);
            Assert.AreEqual(newUserID, "1 Vardas.Pavarde0");

        }

        [TestMethod]
        public void TestuojameArIstrinaEsamaVartotojaIsSaraso()
        {
            //Assign
            UserRepository userRepository = new UserRepository();
            //Act
            userRepository.DeleteUserByID(501);
            User deletedUser = userRepository.GetUserByID(501);
            //Assert
            Assert.IsNull(deletedUser);
        }
    }
}
