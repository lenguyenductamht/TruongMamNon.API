using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ThucDonMonAnRepository : IThucDonMonAnRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ThucDonMonAnRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ThucDonMonAn> AddThucDonMonAn(ThucDonMonAn request)
        {
            var thucDonMonAn = await _context.ThucDonMonAns.AddAsync(request);
            await _context.SaveChangesAsync();
            return thucDonMonAn.Entity;
        }

        public async Task<ThucDonMonAn> DeleteThucDonMonAn(int maThucDon, int maMonAn)
        {
            var thucDonMonAn = await GetThucDonMonAn(maThucDon, maMonAn);
            if (thucDonMonAn != null)
            {
                _context.ThucDonMonAns.Remove(thucDonMonAn);
                await _context.SaveChangesAsync();
                return thucDonMonAn;
            }
            return null;
        }

        public async Task<bool> Exists(int maThucDon, int maMonAn)
        {
            return await _context.ThucDonMonAns.AnyAsync(x => x.MaThucDon == maThucDon && x.MaMonAn == maMonAn);
        }

        public async Task<ThucDonMonAn> GetThucDonMonAn(int maThucDon, int maMonAn)
        {
            return await _context.ThucDonMonAns.FirstOrDefaultAsync(x => x.MaThucDon == maThucDon && x.MaMonAn == maMonAn);
        }

        public async Task<List<ThucDonMonAn>> GetThucDonMonAnsByThucDon(int maThucDon)
        {
            return await _context.ThucDonMonAns.AsNoTracking().Where(x => x.MaThucDon == maThucDon).Include(x => x.MonAn).ToListAsync();
        }

        public async Task<ThucDonMonAn> UpdateThucDonMonAn(int maThucDon, int maMonAn, ThucDonMonAn request)
        {
            var thucDonMonAn = await GetThucDonMonAn(maThucDon, maMonAn);
            if (thucDonMonAn != null)
            {
                thucDonMonAn.SoLuong = request.SoLuong;
                await _context.SaveChangesAsync();
                return thucDonMonAn;
            }
            return null;
        }
    }
}