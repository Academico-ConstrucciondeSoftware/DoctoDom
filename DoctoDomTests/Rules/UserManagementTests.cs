using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoctoDom.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctoDom.Models;

namespace DoctoDom.Rules.Tests
{
    [TestClass()]
    public class UserManagementTests
    {
        [TestMethod()]
        public void GetUserTest()
        {
            int Id = '2';
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.GetUser(Id);
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
            string Nickname = "Marcos";
            string Password = "12345";
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.GetUser(Nickname, Password);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void NewUserTest()
        {
            User user = new User(2, "marcosrrg9813", "40215414805");
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.NewUser(user);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void UpdateUserTest()
        {
            User user = new User(2, "marcosrrg9813", "40215414805");
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.UpdateUser(user);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void DeleteUserTest()
        {
            User user = new User(2, "marcosrrg9813", "40215414805");
            UserManagement UM = new UserManagement();
            bool DBResponse = UM.DeleteUser(user);
            Assert.AreEqual(true, DBResponse);
        }
    }
}