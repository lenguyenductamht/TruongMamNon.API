using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class ThucPhamRepository : IThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public ThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<ThucPham> AddThucPham(ThucPham request)
        {
            var thucPham = await _context.ThucPhams.AddAsync(request);
            await _context.SaveChangesAsync();
            return thucPham.Entity;
        }

        public async Task<ThucPham> DeleteThucPham(int maThucPham)
        {
            var thucPham = await GetThucPham(maThucPham);
            if (thucPham != null)
            {
                _context.ThucPhams.Remove(thucPham);
                await _context.SaveChangesAsync();
                return thucPham;
            }
            return null;
        }

        public async Task<bool> Exists(int maThucPham)
        {
            return await _context.ThucPhams.AnyAsync(x => x.MaThucPham == maThucPham);
        }

        public async Task<ThucPham> GetThucPham(int maThucPham)
        {
            return await _context.ThucPhams.FirstOrDefaultAsync(x => x.MaThucPham == maThucPham);
        }

        public async Task<List<ThucPham>> GetThucPhams()
        {
            return await _context.ThucPhams.Include(x => x.DanhMucThucPham).OrderBy(x => x.TenThucPham).ToListAsync();
        }

        public async Task<ThucPham> TangSoLuong(int maThucPham, double soLuongTang)
        {
            var thucPham = await GetThucPham(maThucPham);
            if (thucPham != null)
            {
                thucPham.TonKho += soLuongTang;
                await _context.SaveChangesAsync();
                return thucPham;
            }
            return null;
        }

        public async Task<ThucPham> GiamSoLuong(int maThucPham, double soLuongGiam)
        {
            var thucPham = await GetThucPham(maThucPham);
            if (thucPham != null)
            {
                thucPham.TonKho -= soLuongGiam;
                await _context.SaveChangesAsync();
                return thucPham;
            }
            return null;
        }

        public async Task<ThucPham> UpdateThucPham(int maThucPham, ThucPham request)
        {
            var thucPham = await GetThucPham(maThucPham);
            if (thucPham != null)
            {
                thucPham.TenThucPham = request.TenThucPham;
                thucPham.DonViTinh = request.DonViTinh;
                thucPham.TonKho = request.TonKho;
                thucPham.MaDanhMuc = request.MaDanhMuc;
                await _context.SaveChangesAsync();
                return thucPham;
            }
            return null;
        }
    }
}