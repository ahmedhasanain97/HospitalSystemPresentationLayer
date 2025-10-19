using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemBLL.Dtos.PatientDto;
using HospitalSystemDAL.Repo.PatientRepo;

namespace HospitalSystemBLL.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepo _patientRepo;
        public PatientService(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }
        public async Task<IEnumerable<GetAllPatientsDto>> GetAllPatientsAsync()
        {
            var patients = await _patientRepo.GetAllPatientsAsync();
            return patients.Select(p => new GetAllPatientsDto
            {
                Id = p.PatientId,
                Name = p.Name,
                DateOfBirth = p.DateOfBirth,

            });
        }
        public async Task<GetPatientDto> GetPatientByIdAsync(int id)
        {
            var patient = await _patientRepo.GetPatientByIdAsync(id);
            if (patient == null) return null;
            return new GetPatientDto
            {
                Id = patient.PatientId,
                Name = patient.Name,
                DateOfBirth = patient.DateOfBirth,
                Address = patient.Address,
                phoneNumber = patient.phoneNumber,
                Gender= patient.Gender,
            };
        }
        public async Task AddPatientAsync(AddPatientDto patientDto)
        {
            var patient = new HospitalSystemDAL.Entites.Patient
            {
                Name = patientDto.Name,
                DateOfBirth = patientDto.DateOfBirth,
                Address = patientDto.Address,
                phoneNumber = patientDto.phoneNumber,
                Gender = patientDto.Gender,
            };
            await _patientRepo.AddPatientAsync(patient);
        }
        public async Task UpdatePatientAsync(int id, UpdatePatientDto patientDto)
        {
            var patient = await _patientRepo.GetPatientByIdAsync(id);
            if (patient == null) return;
            patient.Name = patientDto.Name;
            patient.DateOfBirth = patientDto.DateOfBirth;
            patient.Address = patientDto.Address;
            patient.phoneNumber = patientDto.phoneNumber;
            await _patientRepo.UpdatePatientAsync(patient);
        }
           
        public async Task DeletePatientAsync(int id)
        {
            await _patientRepo.DeletePatientAsync(id);
        }
    }
}
