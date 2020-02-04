using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagerLibrary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ReportGeneratorTests
    {
        [TestMethod]
        public void TestuojameArVisoSarasoReportasSugeneruojaTeisingaVartotojuKieki()
        {
            //assign
            UserRepository userRepository = new UserRepository();
            List<User> UsersList = userRepository.GetUsersList();
            ReportGenerator reportGenerator = new ReportGenerator(UsersList);
            //act
            List<ReportItem> reportList = reportGenerator.GenerateAllUsersList();
            int reportListCont = reportList.Count;
            int userListCount = UsersList.Count;
            //assert
            Assert.AreEqual(userListCount, reportListCont);
        }

        [TestMethod]
        public void TestuojameArVisoSarasoReportasSugeneruojaTeisingaVartotojuKiekiPagalRightId()
        {
            //assign
            UserRepository userRepository = new UserRepository();
            List<User> UsersList = userRepository.GetUsersList();
            ReportGenerator reportGenerator = new ReportGenerator(UsersList);
            //act
            List<ReportItem> reportList = reportGenerator.GenerateUsersListByRightCode(0);
            int reportListCont = reportList.Count;
            //assert
            Assert.AreEqual(reportListCont, 4);
        }
    }
}
