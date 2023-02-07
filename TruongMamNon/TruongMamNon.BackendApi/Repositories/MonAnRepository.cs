using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class MonAnRepository : IMonAnRepository
    {
        private readonly TruongMamNonDbContext _context;

        public MonAnRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<MonAn> AddMonAn(MonAn request)
        {
            var monAn = await _context.MonAns.AddAsync(request);
            await _context.SaveChangesAsync();
            return monAn.Entity;
        }

        public async Task<MonAn> DeleteMonAn(int maMonAn)
        {
            var monAn = await GetMonAn(maMonAn);
            if (monAn != null)
            {
                _context.MonAns.Remove(monAn);
                await _context.SaveChangesAsync();
                return monAn;
            }
            return null;
        }

        public async Task<bool> Exists(int maMonAn)
        {
            return await _context.MonAns.AnyAsync(x => x.MaMonAn == maMonAn);
        }

        public async Task<MonAn> GetMonAn(int maMonAn)
        {
            return await _context.MonAns.FirstOrDefaultAsync(x => x.MaMonAn == maMonAn);
        }

        public async Task<List<MonAn>> GetMonAns()
        {
            return await _context.MonAns.OrderBy(x => x.TenMonAn).ToListAsync();
        }

        public async Task<MonAn> UpdateMonAn(int maMonAn, MonAn request)
        {
            var monAn = await GetMonAn(maMonAn);
            if (monAn != null)
            {
                monAn.TenMonAn = request.TenMonAn;
                monAn.GhiChu = request.GhiChu;
                await _context.SaveChangesAsync();
                return monAn;
            }
            return null;
        }
    }
}