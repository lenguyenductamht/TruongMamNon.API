using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhongBanRepository : IPhongBanRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhongBanRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhongBan> AddPhongBan(PhongBan request)
        {
            var phongBan = await _context.PhongBans.AddAsync(request);
            await _context.SaveChangesAsync();
            return phongBan.Entity;
        }

        public async Task<PhongBan> DeletePhongBan(int maPhongBan)
        {
            var phongBan = await GetPhongBan(maPhongBan);
            if (phongBan != null)
            {
                _context.PhongBans.Remove(phongBan);
                await _context.SaveChangesAsync();
                return phongBan;
            }
            return null;
        }

        public async Task<bool> Exists(int maPhongBan)
        {
            return await _context.PhongBans.AnyAsync(x => x.MaPhongBan == maPhongBan);
        }

        public async Task<PhongBan> GetPhongBan(int maPhongBan)
        {
            return await _context.PhongBans.FirstOrDefaultAsync(x => x.MaPhongBan == maPhongBan);
        }

        public async Task<List<PhongBan>> GetPhongBans()
        {
            return await _context.PhongBans.OrderByDescending(x => x.TenPhongBan).ToListAsync();
        }

        public async Task<PhongBan> UpdatePhongBan(int maPhongBan, PhongBan request)
        {
            var phongBan = await GetPhongBan(maPhongBan);
            if (phongBan != null)
            {
                phongBan.TenPhongBan = request.TenPhongBan;
                phongBan.GhiChu = request.GhiChu;
                await _context.SaveChangesAsync();
                return phongBan;
            }
            return null;
        }
    }
}