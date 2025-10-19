using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.DoctorDtos
{
    public class AddDoctorDto
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public char? Gender { get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
        public int? ClinicId { get; set; }

    }
}
