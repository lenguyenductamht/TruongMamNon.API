using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhieuUongVitaminRepository : IPhieuUongVitaminRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuUongVitaminRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhieuUongVitamin> AddPhieuUongVitamin(PhieuUongVitamin request)
        {
            var phieuUongVitamin = await _context.PhieuUongVitamins.AddAsync(request);
            await _context.SaveChangesAsync();
            return phieuUongVitamin.Entity;
        }

        public async Task<PhieuUongVitamin> DeletePhieuUongVitamin(long maPhieuUongVitamin)
        {
            var phieuUongVitamin = await GetPhieuUongVitamin(maPhieuUongVitamin);
            if (phieuUongVitamin != null)
            {
                _context.PhieuUongVitamins.Remove(phieuUongVitamin);
                await _context.SaveChangesAsync();
                return phieuUongVitamin;
            }
            return null;
        }

        public async Task<bool> Exists(long maPhieuUongVitamin)
        {
            return await _context.PhieuUongVitamins.AnyAsync(x => x.MaPhieuUongVitamin == maPhieuUongVitamin);
        }

        public async Task<PhieuUongVitamin> GetPhieuUongVitamin(long maPhieuUongVitamin)
        {
            return await _context.PhieuUongVitamins.FirstOrDefaultAsync(x => x.MaPhieuUongVitamin == maPhieuUongVitamin);
        }

        public async Task<List<PhieuUongVitamin>> GetPhieuUongVitamins()
        {
            return await _context.PhieuUongVitamins.Include(x => x.DotUongVitamin).Include(x => x.HocSinh).OrderByDescending(x => x.MaPhieuUongVitamin).ToListAsync();
        }

        public async Task<List<PhieuUongVitamin>> GetPhieuUongVitaminsByNienHoc(int maNienHoc)
        {
            return await _context.PhieuUongVitamins.Where(x => x.DotUongVitamin.MaNienHoc == maNienHoc).Include(x => x.DotUongVitamin).Include(x => x.HocSinh).OrderByDescending(x => x.MaPhieuUongVitamin).ToListAsync();
        }

        public async Task<PhieuUongVitamin> UpdatePhieuUongVitamin(long maPhieuUongVitamin, PhieuUongVitamin request)
        {
            var phieuUongVitamin = await GetPhieuUongVitamin(maPhieuUongVitamin);
            if (phieuUongVitamin != null)
            {
                phieuUongVitamin.MaDotUongVitamin = request.MaDotUongVitamin;
                phieuUongVitamin.MaHocSinh = request.MaHocSinh;
                phieuUongVitamin.TrangThai = request.TrangThai;
                await _context.SaveChangesAsync();
                return phieuUongVitamin;
            }
            return null;
        }
    }
}