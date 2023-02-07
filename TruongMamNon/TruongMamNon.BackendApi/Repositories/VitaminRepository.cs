using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class VitaminRepository : IVitaminRepository
    {
        private readonly TruongMamNonDbContext _context;

        public VitaminRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<Vitamin> AddVitamin(Vitamin request)
        {
            var vitamin = await _context.Vitamins.AddAsync(request);
            await _context.SaveChangesAsync();
            return vitamin.Entity;
        }

        public async Task<Vitamin> DeleteVitamin(int maVitamin)
        {
            var vitamin = await GetVitamin(maVitamin);
            if (vitamin != null)
            {
                _context.Vitamins.Remove(vitamin);
                await _context.SaveChangesAsync();
                return vitamin;
            }
            return null;
        }

        public async Task<bool> Exists(int maVitamin)
        {
            return await _context.Vitamins.AnyAsync(x => x.MaVitamin == maVitamin);
        }

        public async Task<Vitamin> GetVitamin(int maVitamin)
        {
            return await _context.Vitamins.FirstOrDefaultAsync(x => x.MaVitamin == maVitamin);
        }

        public async Task<List<Vitamin>> GetVitamins()
        {
            return await _context.Vitamins.OrderBy(x => x.TenVitamin).ToListAsync();
        }

        public async Task<Vitamin> UpdateVitamin(int maVitamin, Vitamin request)
        {
            var vitamin = await GetVitamin(maVitamin);
            if (vitamin != null)
            {
                vitamin.TenVitamin = request.TenVitamin;
                vitamin.GhiChu = request.GhiChu;
                await _context.SaveChangesAsync();
                return vitamin;
            }
            return null;
        }
    }
}