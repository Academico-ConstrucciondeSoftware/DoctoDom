using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoDom.Models
{
    public class Quotes
    {
        public int Id { get; set; }
        public string QuotesDescription { get; set; }
        public DateTime QuotesDate { get; set; }
        public int UserId { get; set; }
        public int Specialties { get; set; }
        public int DoctorId { get; set; }


        public Quotes(string QuotesDescription, int Specialties, int UserID)
        {
            QuotesDescription = this.QuotesDescription;
            Specialties = this.Specialties;
            UserID = this.UserId;
        }
    }
}
