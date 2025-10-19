using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Repo.PatientRepo
{
    public class PatientRepo
    {
        private readonly Context.AppDbContext _context;
        public PatientRepo(Context.AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Entites.Patient>> GetAllPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }
        public async Task<Entites.Patient?> GetPatientByIdAsync(int id)
        {
            return await _context.Patients.FirstOrDefaultAsync(p => p.PatientId == id);
        }
        public async Task AddPatientAsync(Entites.Patient patient)
        {
            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();
        }
        public async Task UpdatePatientAsync(Entites.Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
        }
        public async Task DeletePatientAsync(int id)
        {
            var patient = await GetPatientByIdAsync(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
