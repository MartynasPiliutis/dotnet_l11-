using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagerLibrary;

namespace UserManagerTests
{
    [TestClass]
    public class RightsTests
    {
        [TestMethod]
        public void PatikrinameArPateikusUserRighIDYra2GausimeFullAccessRights()
        {
            //Assing
            Rights rights = new Rights(2);
            //Act
            string rightCode = rights.RightsCode;
            //Assert
            Assert.AreEqual(rightCode, "FULL_RIGHTS");
        }

        [TestMethod]
        public void PatikrinameArPateikusUserRighIDYraBetKoksSimbolisGausimeReadOnlyAccess()
        {
            //Assing
            Rights rights = new Rights(5);
            //Act
            string rightCode = rights.RightsCode;
            //Assert
            Assert.AreEqual(rightCode, "READ_ONLY");
        }
    }

}
