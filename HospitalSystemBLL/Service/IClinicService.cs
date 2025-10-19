using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemBLL.Dtos.ClinicDtos;

namespace HospitalSystemBLL.Service
{
    public interface IClinicService
    {
        Task<IEnumerable<GetAllClinicsDto>> GetAllClinicsAsync();
        Task<GetClinicDto?> GetClinicByIdAsync(int id);
        Task AddClinicAsync(AddClinicDto clinicDto);
        Task UpdateClinicAsync(int clinicId,UpdateClinicDto clinicDto);
        Task DeleteClinicAsync(int id);
    }
}
