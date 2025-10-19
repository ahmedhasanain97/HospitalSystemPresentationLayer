using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemBLL.Dtos.ReservationDtos
{
    public class AddReservationDto
    {
        public DateTime ReservationDate { get; set; }
        public int? PatientId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DoctorId { get; set; }
        public int? ClinicId { get; set; }
    }
}
