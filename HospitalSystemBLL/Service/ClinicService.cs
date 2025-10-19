using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemBLL.Dtos.ClinicDtos;
using HospitalSystemDAL.Repo;
using HospitalSystemDAL.Repo.ClinicRepo;

namespace HospitalSystemBLL.Service
{
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepo _clinicRepo;
        public ClinicService(IClinicRepo clinicRepo)
        {
            _clinicRepo = clinicRepo;
        }
        public async Task<IEnumerable<GetAllClinicsDto>> GetAllClinicsAsync()
        {
            var clinics = await _clinicRepo.GetAllClinicsAsync();
            return clinics.Select(c => new GetAllClinicsDto
            {
                Id = c.Id,
                Name = c.Name,
            });
        }

        public async Task<GetClinicDto?> GetClinicByIdAsync(int id)
        {
            var clinic = await _clinicRepo.GetClinicByIdAsync(id);
            if (clinic == null) return null;
            return new GetClinicDto
            {
                Id = clinic.Id,
                Name = clinic.Name,
                openingHours=clinic.openingHours,
            };
        }
        public async Task AddClinicAsync(AddClinicDto clinicDto)
        {
            var clinic = new HospitalSystemDAL.Entites.Clinic
            {
                Name = clinicDto.Name,
                openingHours=clinicDto.openingHours,
            };
            await _clinicRepo.AddClinicAsync(clinic);
        }
        public async Task UpdateClinicAsync(int clinicId, UpdateClinicDto clinicDto)
        {

            var clinic = await _clinicRepo.GetClinicByIdAsync(clinicId);
            if (clinic != null) { 
            clinic.Name = clinicDto.Name;
            clinic.openingHours = clinicDto.openingHours;
            await _clinicRepo.UpdateClinicAsync(clinic);
            }
        }
        public async Task DeleteClinicAsync(int id)
        {
            await _clinicRepo.DeleteClinicAsync(id);
        }
    }
}
