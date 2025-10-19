using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.EmployeeDtos
{
    public class AddEmployeeDto
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public char gender { get; set; }
        public string? phoneNumber { get; set; }
        public string? Address { get; set; }
        public double? Salary { get; set; }

    }
}
