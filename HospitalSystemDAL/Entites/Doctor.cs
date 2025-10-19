using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Entites
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char? Gender {get; set; }
        public string Specialty { get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
        public int? ClinicId { get; set; }
        public Clinic? Clinic { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
