using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.ClinicDtos
{
    public class AddClinicDto
    {
        public string Name { get; set; }
        public string? openingHours { get; set; }
    }
}
