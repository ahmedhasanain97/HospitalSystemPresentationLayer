using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemDAL.Entites;
using HospitalSystemDAL.Context;
using Microsoft.EntityFrameworkCore;

namespace HospitalSystemDAL.Repo.ReservationRepo
{
    public class ReservationRepo
    {
        private readonly AppDbContext _context;
        public ReservationRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync()
        {
            return await _context.Reservations.ToListAsync();
        }
        public async Task<Reservation?> GetReservationByIdAsync(int id)
        {
            return await _context.Reservations.FirstOrDefaultAsync(r => r.Id==id);
        }
        public async Task AddReservationAsync(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await  _context.SaveChangesAsync();
        }
        public async Task UpdateReservationAsync(Reservation reservation)
        {
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteReservationAsync(int id)
        {
           var reservation = await GetReservationByIdAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }
    }
}
