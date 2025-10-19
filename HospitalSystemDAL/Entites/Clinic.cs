using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Entites
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? openingHours { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }

    }
}
