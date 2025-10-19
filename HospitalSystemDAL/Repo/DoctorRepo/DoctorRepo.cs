using HospitalSystemDAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Repo.DoctorRepo
{
    public class DoctorRepo
    {
        private readonly AppDbContext _context;
        public DoctorRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Entites.Doctor>> GetAllDoctorsAsync()
        {
            return await _context.Doctors.ToListAsync();
        }
        public async Task<Entites.Doctor?> GetDoctorByIdAsync(int id)
        {
            return await _context.Doctors.FirstOrDefaultAsync(d => d.Id==id);
        }
        public async Task AddDoctorAsync(Entites.Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
            await  _context.SaveChangesAsync();
        }
        public async Task UpdateDoctorAsync(Entites.Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteDoctorAsync(int id)
        {
           var doctor = await GetDoctorByIdAsync(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
