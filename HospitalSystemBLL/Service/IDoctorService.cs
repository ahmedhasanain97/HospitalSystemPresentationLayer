using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemBLL.Dtos.DoctorDtos;

namespace HospitalSystemBLL.Service
{
    public interface IDoctorService
    {
        Task<IEnumerable<GetAllDoctorsDto>> GetAllDoctorsAsync();
        Task<GetDoctorDto> GetDoctorByIdAsync(int id);
        Task AddDoctorAsync(AddDoctorDto doctorDto);
        Task UpdateDoctorAsync(int id, UpdateDoctorDto doctorDto);
        Task DeleteDoctorAsync(int id);

    }
}
