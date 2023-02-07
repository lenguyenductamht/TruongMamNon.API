using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ThucDonRepository : IThucDonRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ThucDonRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ThucDon> AddThucDon(ThucDon request)
        {
            var thucDon = await _context.ThucDons.AddAsync(request);
            await _context.SaveChangesAsync();
            return thucDon.Entity;
        }

        public async Task<ThucDon> DeleteThucDon(int maThucDon)
        {
            var thucDon = await GetThucDon(maThucDon);
            if (thucDon != null)
            {
                _context.ThucDons.Remove(thucDon);
                await _context.SaveChangesAsync();
                return thucDon;
            }
            return null;
        }

        public async Task<bool> Exists(int maThucDon)
        {
            return await _context.ThucDons.AnyAsync(x => x.MaThucDon == maThucDon);
        }

        public async Task<ThucDon> GetThucDon(int maThucDon)
        {
            return await _context.ThucDons.FirstOrDefaultAsync(x => x.MaThucDon == maThucDon);
        }

        public async Task<List<ThucDon>> GetThucDons()
        {
            return await _context.ThucDons.AsNoTracking().Include(x => x.DanhMucThucDon).OrderByDescending(x => x.NgayApDung).ToListAsync();
        }

        public async Task<ThucDon> UpdateThucDon(int maThucDon, ThucDon request)
        {
            var thucDon = await GetThucDon(maThucDon);
            if (thucDon != null)
            {
                thucDon.NgayApDung = request.NgayApDung;
                thucDon.MaDanhMuc = request.MaDanhMuc;
                await _context.SaveChangesAsync();
                return thucDon;
            }
            return null;
        }
    }
}