using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.PatientDto
{
    public class AddPatientDto
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char? Gender {get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
