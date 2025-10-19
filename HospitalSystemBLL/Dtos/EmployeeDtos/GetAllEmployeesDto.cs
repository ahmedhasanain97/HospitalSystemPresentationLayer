using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.EmployeeDtos
{
    public class GetAllEmployeesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
