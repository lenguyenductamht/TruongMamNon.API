using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class NhanSuRepository : INhanSuRepository
    {
        private readonly TruongMamNonDbContext _context;

        public NhanSuRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<NhanSu> AddNhanSu(NhanSu request)
        {
            var nhanSu = await _context.NhanSus.AddAsync(request);
            await _context.SaveChangesAsync();
            return nhanSu.Entity;
        }

        public async Task<NhanSu> DeleteNhanSu(long maNhanSu)
        {
            var nhanSu = await GetNhanSu(maNhanSu);
            if (nhanSu != null)
            {
                _context.NhanSus.Remove(nhanSu);
                await _context.SaveChangesAsync();
                return nhanSu;
            }
            return null;
        }

        public async Task<bool> Exists(long maNhanSu)
        {
            return await _context.NhanSus.AnyAsync(x => x.MaNhanSu == maNhanSu);
        }

        public async Task<NhanSu> GetNhanSu(long maNhanSu)
        {
            return await _context.NhanSus.FirstOrDefaultAsync(x => x.MaNhanSu == maNhanSu);
        }

        public async Task<List<NhanSu>> GetNhanSus()
        {
            return await _context.NhanSus.Include(nameof(GioiTinh)).Include(nameof(KhoiLop)).Include(nameof(LoaiNhanSu)).Include(nameof(PhongBan)).Include(nameof(ChucVu)).Include(nameof(DanToc)).Include(nameof(TonGiao)).Include(x => x.QuocTich).Include(nameof(TrangThaiLamViec)).OrderBy(x => x.Ten).ThenBy(x => x.Ho).ToListAsync();
        }

        public async Task<NhanSu> UpdateNhanSu(long maNhanSu, NhanSu request)
        {
            var nhanSu = await GetNhanSu(maNhanSu);
            if (nhanSu != null)
            {
                nhanSu.Ho = request.Ho;
                nhanSu.Ten = request.Ten;
                nhanSu.MaGioiTinh = request.MaGioiTinh;
                nhanSu.NgaySinh = request.NgaySinh;
                nhanSu.NoiSinh = request.NoiSinh;
                nhanSu.CMND = request.CMND;
                nhanSu.NgayCap = request.NgayCap;
                nhanSu.MaDanToc = request.MaDanToc;
                nhanSu.MaTonGiao = request.MaTonGiao;
                nhanSu.MaQuocTich = request.MaQuocTich;
                nhanSu.NgayVaoTruong = request.NgayVaoTruong;
                nhanSu.MaPhongBan = request.MaPhongBan;
                nhanSu.MaTrangThaiLamViec = request.MaTrangThaiLamViec;
                nhanSu.LyDoThoiViec = request.LyDoThoiViec;
                nhanSu.NgayCapNhat = request.NgayCapNhat;
                nhanSu.MaLoaiNhanSu = request.MaLoaiNhanSu;
                nhanSu.MaChucVu = request.MaChucVu;
                nhanSu.MaKhoiLop = request.MaKhoiLop;
                nhanSu.SoDienThoai = request.SoDienThoai;
                nhanSu.Email = request.Email;
                nhanSu.HoKhau = request.HoKhau;
                nhanSu.DiaChi = request.DiaChi;

                await _context.SaveChangesAsync();
                return nhanSu;
            }
            return null;
        }
    }
}