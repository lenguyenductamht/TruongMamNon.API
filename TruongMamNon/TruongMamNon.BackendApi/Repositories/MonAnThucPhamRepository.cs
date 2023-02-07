using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using XAct;

namespace TruongMamNon.BackendApi.Repositories
{
    public class MonAnThucPhamRepository : IMonAnThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public MonAnThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<MonAnThucPham> AddMonAnThucPham(MonAnThucPham request)
        {
            var monAnThucPham = await _context.MonAnThucPhams.AddAsync(request);
            await _context.SaveChangesAsync();
            return monAnThucPham.Entity;
        }

        public async Task<MonAnThucPham> DeleteMonAnThucPham(int maMonAn, int maThucPham)
        {
            var monAnThucPham = await GetMonAnThucPham(maMonAn, maThucPham);
            if (monAnThucPham != null)
            {
                _context.MonAnThucPhams.Remove(monAnThucPham);
                await _context.SaveChangesAsync();
                return monAnThucPham;
            }
            return null;
        }

        public async Task<bool> Exists(int maMonAn, int maThucPham)
        {
            return await _context.MonAnThucPhams.AnyAsync(x => x.MaMonAn == maMonAn && x.MaThucPham == maThucPham);
        }

        public async Task<MonAnThucPham> GetMonAnThucPham(int maMonAn, int maThucPham)
        {
            return await _context.MonAnThucPhams.FirstOrDefaultAsync(x => x.MaMonAn == maMonAn);
        }

        public async Task<List<MonAnThucPham>> GetMonAnThucPhamsByMonAn(int maMonAn)
        {
            return await _context.MonAnThucPhams.Where(x => x.MaMonAn == maMonAn).Include(x => x.ThucPham).ToListAsync();
        }

        public async Task<MonAnThucPham> UpdateMonAnThucPham(int maMonAn, int maThucPham, MonAnThucPham request)
        {
            var monAnThucPham = await GetMonAnThucPham(maMonAn, maThucPham);
            if (monAnThucPham != null)
            {
                monAnThucPham.SoLuong = request.SoLuong;
                await _context.SaveChangesAsync();
                return monAnThucPham;
            }
            return null;
        }
    }
}