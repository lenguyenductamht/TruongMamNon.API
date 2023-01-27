using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class VaccineRepository : IVaccineRepository
    {
        private readonly TruongMamNonDbContext _context;

        public VaccineRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<Vaccine> AddVaccine(Vaccine request)
        {
            var vaccine = await _context.Vaccines.AddAsync(request);
            await _context.SaveChangesAsync();
            return vaccine.Entity;
        }

        public async Task<Vaccine> DeleteVaccine(int maVaccine)
        {
            var vaccine = await GetVaccine(maVaccine);
            if (vaccine != null)
            {
                _context.Vaccines.Remove(vaccine);
                await _context.SaveChangesAsync();
                return vaccine;
            }
            return null;
        }

        public async Task<bool> Exists(int maVaccine)
        {
            return await _context.Vaccines.AnyAsync(x => x.MaVaccine == maVaccine);
        }

        public async Task<Vaccine> GetVaccine(int maVaccine)
        {
            return await _context.Vaccines.FirstOrDefaultAsync(x => x.MaVaccine == maVaccine);
        }

        public async Task<List<Vaccine>> GetVaccines()
        {
            return await _context.Vaccines.OrderBy(x => x.TenVaccine).ToListAsync();
        }

        public async Task<Vaccine> UpdateVaccine(int maVaccine, Vaccine request)
        {
            var vaccine = await GetVaccine(maVaccine);
            if (vaccine != null)
            {
                vaccine.TenVaccine = request.TenVaccine;
                vaccine.GhiChu = request.GhiChu;
                await _context.SaveChangesAsync();
                return vaccine;
            }
            return null;
        }
    }
}