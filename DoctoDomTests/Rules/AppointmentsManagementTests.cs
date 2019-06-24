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
    public class AppointmentsManagementTests
    {
        [TestMethod()]
        public void GetAppointmentsTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetAppointments();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetAppointmentsDoctorTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetAppointmentsDoctor();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetDetailtAppointmentsTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetDetailtAppointments();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetDetailtAppointmentsDoctorTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetDetailtAppointmentsDoctor();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void NewAppointmentTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.NewAppointment();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void EditAppointmentTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.EditAppointment();
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void DeleteAppointmentsTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.DeleteAppointments();
            Assert.AreEqual(true, DBResponse);
        }
    }
}