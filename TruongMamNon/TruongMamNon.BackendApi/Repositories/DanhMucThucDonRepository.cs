using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DanhMucThucDonRepository : IDanhMucThucDonRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DanhMucThucDonRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<DanhMucThucDon> AddDanhMucThucDon(DanhMucThucDon request)
        {
            var danhMucThucDon = await _context.DanhMucThucDons.AddAsync(request);
            await _context.SaveChangesAsync();
            return danhMucThucDon.Entity;
        }

        public async Task<DanhMucThucDon> DeleteDanhMucThucDon(int maDanhMucThucDon)
        {
            var danhMucThucDon = await GetDanhMucThucDon(maDanhMucThucDon);
            if (danhMucThucDon != null)
            {
                _context.DanhMucThucDons.Remove(danhMucThucDon);
                await _context.SaveChangesAsync();
                return danhMucThucDon;
            }
            return null;
        }

        public async Task<bool> Exists(int maDanhMucThucDon)
        {
            return await _context.DanhMucThucDons.AnyAsync(x => x.MaDanhMuc == maDanhMucThucDon);
        }

        public async Task<DanhMucThucDon> GetDanhMucThucDon(int maDanhMucThucDon)
        {
            return await _context.DanhMucThucDons.FirstOrDefaultAsync(x => x.MaDanhMuc == maDanhMucThucDon);
        }

        public async Task<List<DanhMucThucDon>> GetDanhMucThucDons()
        {
            return await _context.DanhMucThucDons.OrderBy(x => x.TenDanhMuc).ToListAsync();
        }

        public async Task<DanhMucThucDon> UpdateDanhMucThucDon(int maDanhMucThucDon, DanhMucThucDon request)
        {
            var danhMucThucDon = await GetDanhMucThucDon(maDanhMucThucDon);
            if (danhMucThucDon != null)
            {
                danhMucThucDon.TenDanhMuc = request.TenDanhMuc;
                danhMucThucDon.GhiChu = request.GhiChu;
                danhMucThucDon.ThoiGian = request.ThoiGian;
                await _context.SaveChangesAsync();
                return danhMucThucDon;
            }
            return null;
        }
    }
}