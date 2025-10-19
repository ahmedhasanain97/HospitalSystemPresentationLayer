using HospitalSystemDAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemDAL.Entites;
using Microsoft.EntityFrameworkCore;

namespace HospitalSystemDAL.Repo.ClinicRepo
{
    public class ClinicRepo : IClinicRepo
    {
        private readonly AppDbContext _context;
        public ClinicRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Clinic>> GetAllClinicsAsync()
        {
            return await _context.Clinics.ToListAsync();
        }
        public async Task<Clinic?> GetClinicByIdAsync(int id)
        {
            return await _context.Clinics.FirstOrDefaultAsync(c => c.Id==id);
        }
        public async Task AddClinicAsync(Clinic clinic)
        {
            await _context.Clinics.AddAsync(clinic);
            await  _context.SaveChangesAsync();
        }
        public async Task UpdateClinicAsync(Clinic clinic)
        {
            _context.Clinics.Update(clinic);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteClinicAsync(int id)
        {
           var clinic = await GetClinicByIdAsync(id);
            if (clinic != null)
            {
                _context.Clinics.Remove(clinic);
                await _context.SaveChangesAsync();
            }
        }
    }
}
