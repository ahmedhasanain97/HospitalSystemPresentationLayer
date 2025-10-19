using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char? Gender { get; set; }
        public string? Position { get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
        public double? Salary { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
