using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhieuSoGiunRepository : IPhieuSoGiunRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuSoGiunRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhieuSoGiun> AddPhieuSoGiun(PhieuSoGiun request)
        {
            var phieuSoGiun = await _context.PhieuSoGiuns.AddAsync(request);
            await _context.SaveChangesAsync();
            return phieuSoGiun.Entity;
        }

        public async Task<PhieuSoGiun> DeletePhieuSoGiun(long maPhieuSoGiun)
        {
            var phieuSoGiun = await GetPhieuSoGiun(maPhieuSoGiun);
            if (phieuSoGiun != null)
            {
                _context.PhieuSoGiuns.Remove(phieuSoGiun);
                await _context.SaveChangesAsync();
                return phieuSoGiun;
            }
            return null;
        }

        public async Task<bool> Exists(long maPhieuSoGiun)
        {
            return await _context.PhieuSoGiuns.AnyAsync(x => x.MaPhieuSoGiun == maPhieuSoGiun);
        }

        public async Task<PhieuSoGiun> GetPhieuSoGiun(long maPhieuSoGiun)
        {
            return await _context.PhieuSoGiuns.FirstOrDefaultAsync(x => x.MaPhieuSoGiun == maPhieuSoGiun);
        }

        public async Task<List<PhieuSoGiun>> GetPhieuSoGiuns()
        {
            return await _context.PhieuSoGiuns.Include(x => x.DotSoGiun).Include(x => x.HocSinh).OrderByDescending(x => x.MaPhieuSoGiun).ToListAsync();
        }

        public async Task<List<PhieuSoGiun>> GetPhieuSoGiunsByNienHoc(int maNienHoc)
        {
            return await _context.PhieuSoGiuns.Where(x => x.DotSoGiun.MaNienHoc == maNienHoc).Include(x => x.DotSoGiun).Include(x => x.HocSinh).OrderByDescending(x => x.MaPhieuSoGiun).ToListAsync();
        }

        public async Task<PhieuSoGiun> UpdatePhieuSoGiun(long maPhieuSoGiun, PhieuSoGiun request)
        {
            var phieuSoGiun = await GetPhieuSoGiun(maPhieuSoGiun);
            if (phieuSoGiun != null)
            {
                phieuSoGiun.MaDotSoGiun = request.MaDotSoGiun;
                phieuSoGiun.MaHocSinh = request.MaHocSinh;
                phieuSoGiun.TrangThai = request.TrangThai;
                await _context.SaveChangesAsync();
                return phieuSoGiun;
            }
            return null;
        }
    }
}