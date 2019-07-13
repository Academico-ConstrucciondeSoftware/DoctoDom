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
    public class AppointmentsManagementTests
    {
        [TestMethod()]
        public void GetAppointmentsTest()
        {
            AppointmentsManagement AP = new AppointmentsManagement();
            int Id = 3;
            bool DBResponse = AP.GetAppointments(Id);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetAppointmentsDoctorTest()
        {
            int UserId = 3;
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetAppointmentsDoctor(UserId);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetDetailtAppointmentsTest()
        {
            int UserId = 3;
            int CitaId = 2;
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetDetailtAppointments(UserId, CitaId);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void GetDetailtAppointmentsDoctorTest()
        {
            int UserId = 3;
            int CitaId = 2;
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.GetDetailtAppointmentsDoctor(UserId, CitaId);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void NewAppointmentTest()
        {
            Quotes quote = new Quotes("Dolor de cabeza", 2,2);
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.NewAppointment(quote);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void EditAppointmentTest()
        {
            Quotes quote = new Quotes("Dolor de cabeza", 2, 2);
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.EditAppointment(quote);
            Assert.AreEqual(true, DBResponse);
        }

        [TestMethod()]
        public void DeleteAppointmentsTest()
        {
            Quotes quote = new Quotes("Dolor de cabeza", 2, 2);
            AppointmentsManagement AP = new AppointmentsManagement();
            bool DBResponse = AP.DeleteAppointments(quote);
            Assert.AreEqual(true, DBResponse);
        }
    }
}