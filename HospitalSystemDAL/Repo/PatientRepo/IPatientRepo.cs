using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemDAL.Repo.PatientRepo
{
    public interface IPatientRepo
    {
        Task<IEnumerable<Entites.Patient>> GetAllPatientsAsync();
        Task<Entites.Patient?> GetPatientByIdAsync(int id);
        Task AddPatientAsync(Entites.Patient patient);
        Task UpdatePatientAsync(Entites.Patient patient);
        Task DeletePatientAsync(int id);
    }
}
