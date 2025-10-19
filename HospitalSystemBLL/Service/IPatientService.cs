using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemBLL.Dtos.PatientDto;

namespace HospitalSystemBLL.Service
{
    public interface IPatientService 
    {
        Task<IEnumerable<GetAllPatientsDto>> GetAllPatientsAsync();
        Task<GetPatientDto?> GetPatientByIdAsync(int id);
        Task AddPatientAsync(AddPatientDto patientDto);
        Task UpdatePatientAsync(int id, UpdatePatientDto patientDto);
        Task DeletePatientAsync(int id);
    }
}
