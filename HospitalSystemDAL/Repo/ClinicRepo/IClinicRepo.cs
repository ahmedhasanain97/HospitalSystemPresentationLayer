using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemDAL.Entites;

namespace HospitalSystemDAL.Repo.ClinicRepo
{
    public interface IClinicRepo
    {
        Task<IEnumerable<Clinic>> GetAllClinicsAsync();
        Task<Clinic?> GetClinicByIdAsync(int id);
        Task AddClinicAsync(Clinic clinic);
        Task UpdateClinicAsync(Clinic clinic);
        Task DeleteClinicAsync(int id);
    }
}
