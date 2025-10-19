using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.DoctorDtos
{
    public interface UpdateDoctorDto
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public char? gender { get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
        public int? ClinicId { get; set; }
    }
}
