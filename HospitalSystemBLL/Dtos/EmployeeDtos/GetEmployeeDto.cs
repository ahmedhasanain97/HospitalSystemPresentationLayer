using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.EmployeeDtos
{
    public class GetEmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public char Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public double? Salary { get; set; }

    }
}
