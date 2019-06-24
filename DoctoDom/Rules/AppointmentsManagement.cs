using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctoDom.Models;

namespace DoctoDom.Rules
{
   public class AppointmentsManagement
    {
        public bool GetAppointments(int Id)
        {
            return true;
        }

        public bool GetAppointmentsDoctor(int UserId)
        {
            return true;
        }


        public bool GetDetailtAppointments(int UserId, int CitaId)
        {
            return true;
        }

        public bool GetDetailtAppointmentsDoctor(int UserId, int CitaId)
        {
            return true;
        }

        public bool NewAppointment(Quotes appoinment)
        {
            return true;

        }

        public bool EditAppointment(Quotes appoinment)
        {
            return true;
        }


        public bool DeleteAppointments(Quotes appoinment)
        {
            return true;
        }

    }
}
