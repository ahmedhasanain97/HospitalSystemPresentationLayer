using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.DoctorDtos
{
    public class GetAllDoctorsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
    }
}
