using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ChucVuRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ChucVu> AddChucVu(ChucVu request)
        {
            var chucVu = await _context.ChucVus.AddAsync(request);
            await _context.SaveChangesAsync();
            return chucVu.Entity;
        }

        public async Task<ChucVu> DeleteChucVu(int maChucVu)
        {
            var chucVu = await GetChucVu(maChucVu);
            if (chucVu != null)
            {
                _context.ChucVus.Remove(chucVu);
                await _context.SaveChangesAsync();
                return chucVu;
            }
            return null;
        }

        public async Task<bool> Exists(int maChucVu)
        {
            return await _context.ChucVus.AnyAsync(x => x.MaChucVu == maChucVu);
        }

        public async Task<ChucVu> GetChucVu(int maChucVu)
        {
            return await _context.ChucVus.FirstOrDefaultAsync(x => x.MaChucVu == maChucVu);
        }

        public async Task<List<ChucVu>> GetChucVus()
        {
            return await _context.ChucVus.Include(x=>x.LoaiNhanSu).OrderBy(x => x.TenChucVu).ToListAsync();
        }

        public async Task<List<ChucVu>> GetChucVusByLoaiNhanSu(int maLoaiNhanSu)
        {
            return await _context.ChucVus.Where(x => x.MaLoaiNhanSu == maLoaiNhanSu).Include(x=>x.LoaiNhanSu).OrderBy(x => x.TenChucVu).ToListAsync();
        }

        public async Task<ChucVu> UpdateChucVu(int maChucVu, ChucVu request)
        {
            var chucVu = await GetChucVu(maChucVu);
            if (chucVu != null)
            {
                chucVu.TenChucVu = request.TenChucVu;
                chucVu.GhiChu = request.GhiChu;
                chucVu.MaLoaiNhanSu = request.MaLoaiNhanSu;
                await _context.SaveChangesAsync();
                return chucVu;
            }
            return null;
        }
    }
}