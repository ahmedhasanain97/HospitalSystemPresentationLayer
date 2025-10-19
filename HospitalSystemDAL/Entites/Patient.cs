using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Entites
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public char? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }

}
