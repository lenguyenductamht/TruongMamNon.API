using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class LopHocRepository : ILopHocRepository
    {
        private readonly TruongMamNonDbContext _context;

        public LopHocRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<LopHoc> AddLopHoc(LopHoc request)
        {
            var lopHoc = await _context.LopHocs.AddAsync(request);
            await _context.SaveChangesAsync();
            return lopHoc.Entity;
        }

        public async Task<LopHoc> DeleteLopHoc(int maLopHoc)
        {
            var lopHoc = await GetLopHoc(maLopHoc);
            if (lopHoc != null)
            {
                _context.LopHocs.Remove(lopHoc);
                await _context.SaveChangesAsync();
                return lopHoc;
            }
            return null;
        }

        public async Task<bool> Exists(int maLopHoc)
        {
            return await _context.LopHocs.AnyAsync(x => x.MaLop == maLopHoc);
        }

        public async Task<LopHoc> GetLopHoc(int maLopHoc)
        {
            return await _context.LopHocs.FirstOrDefaultAsync(x => x.MaLop == maLopHoc);
        }

        public async Task<List<LopHoc>> GetLopHocs()
        {
            return await _context.LopHocs.ToListAsync();
        }

        public async Task<List<LopHoc>> GetLopHocsByNienHoc(int maNienHoc)
        {
            return await _context.LopHocs.Where(x => x.MaNienHoc == maNienHoc).ToListAsync();
        }

        public async Task<List<LopHoc>> GetLopHocsByNienHocKhoiLop(int maNienHoc, int maKhoiLop)
        {
            return await _context.LopHocs.Where(x => x.MaNienHoc == maNienHoc && x.MaKhoiLop == maKhoiLop).ToListAsync();
        }

        public async Task<LopHoc> UpdateLopHoc(int maLopHoc, LopHoc request)
        {
            var lopHoc = await GetLopHoc(maLopHoc);
            if (lopHoc != null)
            {
                lopHoc.TenLop = request.TenLop;
                lopHoc.MaKhoiLop = request.MaKhoiLop;
                lopHoc.HocPhi = request.HocPhi;
                lopHoc.SiSoToiDa = request.SiSoToiDa;
                lopHoc.MaNienHoc = request.MaNienHoc;
                await _context.SaveChangesAsync();
                return lopHoc;
            }
            return null;
        }
    }
}