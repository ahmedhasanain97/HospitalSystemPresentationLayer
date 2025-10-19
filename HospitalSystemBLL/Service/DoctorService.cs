using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemBLL.Dtos.DoctorDtos;
using HospitalSystemDAL.Repo.DoctorRepo;

namespace HospitalSystemBLL.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepo _doctorRepo;
        public DoctorService(IDoctorRepo doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }
        public async Task<IEnumerable<GetAllDoctorsDto>> GetAllDoctorsAsync()
        {
            var doctors = await _doctorRepo.GetAllDoctorsAsync();
            return doctors.Select(d => new GetAllDoctorsDto
            {
                Id = d.Id,
                Name = d.Name,
                Specialty = d.Specialty,
            });
        }
        public async Task<GetDoctorDto> GetDoctorByIdAsync(int id)
        {
            var doctor = await _doctorRepo.GetDoctorByIdAsync(id);
            if (doctor == null) return null;
            return new GetDoctorDto
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Specialty = doctor.Specialty,
                phoneNumber = doctor.phoneNumber,
                Address = doctor.Address,
                ClinicId = doctor.ClinicId,
                gender = doctor.Gender,
            };
        }
        public async Task AddDoctorAsync(AddDoctorDto doctorDto)
        {
            var doctor = new HospitalSystemDAL.Entites.Doctor
            {
                Name = doctorDto.Name,
                Specialty = doctorDto.Specialty,
                phoneNumber = doctorDto.phoneNumber,
                Gender = doctorDto.Gender,
                Address = doctorDto.Address,
                ClinicId = doctorDto.ClinicId
            };
            await _doctorRepo.AddDoctorAsync(doctor);
        }
        public async Task UpdateDoctorAsync(int id, UpdateDoctorDto doctorDto)
        {
            var existingDoctor = await _doctorRepo.GetDoctorByIdAsync(id);
            if (existingDoctor == null) throw new Exception("Doctor not found");
            existingDoctor.Name = doctorDto.Name;
            existingDoctor.Specialty = doctorDto.Specialty;
            existingDoctor.phoneNumber = doctorDto.phoneNumber;
            existingDoctor.Gender = doctorDto.gender;
            existingDoctor.Address = doctorDto.Address;
            existingDoctor.ClinicId = doctorDto.ClinicId;
            await _doctorRepo.UpdateDoctorAsync(existingDoctor);
        }
        public async Task DeleteDoctorAsync(int id)
        {
            await _doctorRepo.DeleteDoctorAsync(id);
        }

    }
}
