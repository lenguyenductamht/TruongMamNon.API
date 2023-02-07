using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DotSoGiunRepository : IDotSoGiunRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DotSoGiunRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<DotSoGiun> AddDotSoGiun(DotSoGiun request)
        {
            var dotSoGiun = await _context.DotSoGiuns.AddAsync(request);
            await _context.SaveChangesAsync();
            return dotSoGiun.Entity;
        }

        public async Task<DotSoGiun> DeleteDotSoGiun(int maDotSoGiun)
        {
            var dotSoGiun = await GetDotSoGiun(maDotSoGiun);
            if (dotSoGiun != null)
            {
                _context.DotSoGiuns.Remove(dotSoGiun);
                await _context.SaveChangesAsync();
                return dotSoGiun;
            }
            return null;
        }

        public async Task<bool> Exists(int maDotSoGiun)
        {
            return await _context.DotSoGiuns.AnyAsync(x => x.MaDotSoGiun == maDotSoGiun);
        }

        public async Task<DotSoGiun> GetDotSoGiun(int maDotSoGiun)
        {
            return await _context.DotSoGiuns.FirstOrDefaultAsync(x => x.MaDotSoGiun == maDotSoGiun);
        }

        public async Task<List<DotSoGiun>> GetDotSoGiuns()
        {
            return await _context.DotSoGiuns.Include(x => x.ThuocSoGiun).Include(x => x.NienHoc).OrderBy(x => x.TenDotSoGiun).ToListAsync();
        }

        public async Task<List<DotSoGiun>> GetDotSoGiunsByNienHoc(int maNienHoc)
        {
            return await _context.DotSoGiuns.Where(x => x.MaNienHoc == maNienHoc).Include(x => x.ThuocSoGiun).Include(x => x.NienHoc).OrderBy(x => x.TenDotSoGiun).ToListAsync();
        }

        public async Task<DotSoGiun> UpdateDotSoGiun(int maDotSoGiun, DotSoGiun request)
        {
            var dotSoGiun = await GetDotSoGiun(maDotSoGiun);
            if (dotSoGiun != null)
            {
                dotSoGiun.TenDotSoGiun = request.TenDotSoGiun;
                dotSoGiun.NgaySoGiun = request.NgaySoGiun;
                dotSoGiun.MaThuocSoGiun = request.MaThuocSoGiun;
                dotSoGiun.MaNienHoc = request.MaNienHoc;
                await _context.SaveChangesAsync();
                return dotSoGiun;
            }
            return null;
        }
    }
}