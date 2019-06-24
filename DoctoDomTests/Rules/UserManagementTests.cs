using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoctoDom.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoDom.Rules.Tests
{
    [TestClass()]
    public class UserManagementTests
    {
        [TestMethod()]
        public void GetUserTest()
        {
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.GetUser();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetDoctorTest()
        {
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.GetDoctor();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetUser1Test()
        {
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.GetUser();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void NewUserTest()
        {
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.NewUser();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void UpdateUserTest()
        {
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.UpdateUser();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.DeleteUser();
            Assert.AreEqual(true, DBResponse);
        }
    }
}