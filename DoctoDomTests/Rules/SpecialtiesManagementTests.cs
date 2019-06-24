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
    public class SpecialtiesManagementTests
    {
        [TestMethod()]
        public void GetSpecialtiesTest()
        {
            SpecialtiesManagement SM = new SpecialtiesManagement();
            bool DBResponse = SM.GetSpecialties();
            Assert.AreEqual(true, DBResponse);
        }
    }
}