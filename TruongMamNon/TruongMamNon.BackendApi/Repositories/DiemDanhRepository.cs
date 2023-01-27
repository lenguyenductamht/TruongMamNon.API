using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DiemDanhRepository : IDiemDanhRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DiemDanhRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<DiemDanh> AddDiemDanh(DiemDanh request)
        {
            var diemDanh = await _context.DiemDanhs.AddAsync(request);
            await _context.SaveChangesAsync();
            return diemDanh.Entity;
        }

        public async Task<DiemDanh> DeleteDiemDanh(int maDiemDanh)
        {
            var diemDanh = await GetDiemDanh(maDiemDanh);
            if (diemDanh != null)
            {
                _context.DiemDanhs.Remove(diemDanh);
                await _context.SaveChangesAsync();
                return diemDanh;
            }
            return null;
        }

        public async Task<bool> Exists(int maDiemDanh)
        {
            return await _context.DiemDanhs.AnyAsync(x => x.MaDiemDanh == maDiemDanh);
        }

        public async Task<DiemDanh> GetDiemDanh(int maDiemDanh)
        {
            return await _context.DiemDanhs.FirstOrDefaultAsync(x => x.MaDiemDanh == maDiemDanh);
        }

        //public async Task<List<DiemDanh>> GetDiemDanhs()
        //{
        //    return await _context.DiemDanhs.Include(x => x.HocSinh).Include(x => x.TrangThaiDiemDanh).OrderByDescending(x => x.NgayDiemDanh).ToListAsync();
        //}

        //public async Task<List<DiemDanh>> GetDiemDanhsByDate(DateTime from, DateTime to)
        //{
        //    return await _context.DiemDanhs.Where(x=>x.NgayDiemDanh>=from&&x.NgayDiemDanh<=to).Include(x => x.HocSinh).Include(x => x.TrangThaiDiemDanh).OrderByDescending(x => x.NgayDiemDanh).ToListAsync();
        //}

        public async Task<List<DiemDanh>> GetDiemDanhsByDateLopHoc(DateTime from, DateTime to, int maLopHoc)
        {
            return await _context.DiemDanhs.Where(x => x.NgayDiemDanh >= from && x.NgayDiemDanh <= to&&x.HocSinh.MaLopHoc==maLopHoc).Include(x => x.HocSinh).Include(x => x.TrangThaiDiemDanh).OrderByDescending(x => x.NgayDiemDanh).ToListAsync();

        }

        public async Task<DiemDanh> UpdateDiemDanh(int maDiemDanh, DiemDanh request)
        {
            var diemDanh = await GetDiemDanh(maDiemDanh);
            if (diemDanh != null)
            {
                diemDanh.MaTrangThaiDiemDanh = request.MaTrangThaiDiemDanh;
                await _context.SaveChangesAsync();
                return diemDanh;
            }
            return null;
        }
    }
}