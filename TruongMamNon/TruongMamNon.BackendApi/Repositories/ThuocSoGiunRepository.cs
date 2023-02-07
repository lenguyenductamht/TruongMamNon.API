using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ThuocSoGiunRepository : IThuocSoGiunRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ThuocSoGiunRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ThuocSoGiun> AddThuocSoGiun(ThuocSoGiun request)
        {
            var thuocSoGiun = await _context.ThuocSoGiuns.AddAsync(request);
            await _context.SaveChangesAsync();
            return thuocSoGiun.Entity;
        }

        public async Task<ThuocSoGiun> DeleteThuocSoGiun(int maThuocSoGiun)
        {
            var thuocSoGiun = await GetThuocSoGiun(maThuocSoGiun);
            if (thuocSoGiun != null)
            {
                _context.ThuocSoGiuns.Remove(thuocSoGiun);
                await _context.SaveChangesAsync();
                return thuocSoGiun;
            }
            return null;
        }

        public async Task<bool> Exists(int maThuocSoGiun)
        {
            return await _context.ThuocSoGiuns.AnyAsync(x => x.MaThuocSoGiun == maThuocSoGiun);
        }

        public async Task<ThuocSoGiun> GetThuocSoGiun(int maThuocSoGiun)
        {
            return await _context.ThuocSoGiuns.FirstOrDefaultAsync(x => x.MaThuocSoGiun == maThuocSoGiun);
        }

        public async Task<List<ThuocSoGiun>> GetThuocSoGiuns()
        {
            return await _context.ThuocSoGiuns.OrderBy(x => x.TenThuocSoGiun).ToListAsync();
        }

        public async Task<ThuocSoGiun> UpdateThuocSoGiun(int maThuocSoGiun, ThuocSoGiun request)
        {
            var thuocSoGiun = await GetThuocSoGiun(maThuocSoGiun);
            if (thuocSoGiun != null)
            {
                thuocSoGiun.TenThuocSoGiun = request.TenThuocSoGiun;
                thuocSoGiun.GhiChu = request.GhiChu;
                await _context.SaveChangesAsync();
                return thuocSoGiun;
            }
            return null;
        }
    }
}