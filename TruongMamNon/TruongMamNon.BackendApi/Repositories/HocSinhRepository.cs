using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Utilities.Hash;

namespace TruongMamNon.BackendApi.Repositories
{
    public class HocSinhRepository : IHocSinhRepository
    {
        private readonly TruongMamNonDbContext _context;

        public HocSinhRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<HocSinh> AddHocSinh(HocSinh request)
        {
            //request.MatKhau = MD5Hash.MD5(request.MatKhau);
            var hocSinh = await _context.HocSinhs.AddAsync(request);
            await _context.SaveChangesAsync();
            return hocSinh.Entity;
        }

        public async Task<HocSinh> DeleteHocSinh(long maHocSinh)
        {
            var hocSinh = await GetHocSinh(maHocSinh);
            if (hocSinh != null)
            {
                _context.HocSinhs.Remove(hocSinh);
                await _context.SaveChangesAsync();
                return hocSinh;
            }
            return null;
        }

        public async Task<bool> Exists(long maHocSinh)
        {
            return await _context.HocSinhs.AnyAsync(x => x.MaHocSinh == maHocSinh);
        }

        public async Task<HocSinh> GetHocSinh(long maHocSinh)
        {
            return await _context.HocSinhs.FirstOrDefaultAsync(x => x.MaHocSinh == maHocSinh);
        }

        public async Task<List<HocSinh>> GetHocSinhs()
        {
            return await _context.HocSinhs.Include(x => x.GioiTinh).Include(x => x.KhoiLop).Include(x => x.LopHoc).Include(x => x.DanToc).Include(x => x.TonGiao).Include(x => x.QuocTich).Include(x => x.TrangThaiHoc).OrderBy(x => x.Ten).ThenBy(x => x.Ho).ToListAsync();
        }

        public async Task<List<HocSinh>> GetHocSinhsByKhoiLop(int maKhoiLop)
        {
            return await _context.HocSinhs.Where(x => x.MaKhoiLop == maKhoiLop).Include(x => x.GioiTinh).Include(x => x.KhoiLop).Include(x => x.LopHoc).Include(x => x.TrangThaiHoc).OrderBy(x => x.Ten).ThenBy(x => x.Ho).ToListAsync();
        }

        public async Task<List<HocSinh>> GetHocSinhsByLopHoc(int maLopHoc)
        {
            return await _context.HocSinhs.Where(x => x.MaLopHoc == maLopHoc).Include(x => x.GioiTinh).Include(x => x.KhoiLop).Include(x => x.LopHoc).Include(x => x.TrangThaiHoc).OrderBy(x => x.Ten).ThenBy(x => x.Ho).ToListAsync();
        }

        public async Task<HocSinh> UpdateHocSinh(long maHocSinh, HocSinh request)
        {
            var hocSinh = await GetHocSinh(maHocSinh);
            if (hocSinh != null)
            {
                hocSinh.Ho = request.Ho;
                hocSinh.Ten = request.Ten;
                hocSinh.MaGioiTinh = request.MaGioiTinh;
                hocSinh.MaKhoiLop = request.MaKhoiLop;
                hocSinh.MaLopHoc = request.MaLopHoc;
                hocSinh.NgayNhapHoc = request.NgayNhapHoc;
                hocSinh.MaTrangThaiHoc = request.MaTrangThaiHoc;
                hocSinh.LyDoNghiHoc = request.LyDoNghiHoc;
                hocSinh.NgayCapNhat = request.NgayCapNhat;
                hocSinh.NgaySinh = request.NgaySinh;
                hocSinh.NoiSinh = request.NoiSinh;
                hocSinh.MaDanToc = request.MaDanToc;
                hocSinh.MaTonGiao = request.MaTonGiao;
                hocSinh.MaQuocTich = request.MaQuocTich;
                hocSinh.GhiChu = request.GhiChu;
                hocSinh.HoKhau = request.HoKhau;
                hocSinh.DiaChi = request.DiaChi;
                hocSinh.HoTenPhuHuynh = request.HoTenPhuHuynh;
                hocSinh.NamSinhPhuHuynh = request.NamSinhPhuHuynh;
                hocSinh.CMNDPhuHuynh = request.CMNDPhuHuynh;
                hocSinh.SDTPhuHuynh = request.SDTPhuHuynh;
                hocSinh.NgheNghiepPhuHuynh = request.NgheNghiepPhuHuynh;
                hocSinh.EmailPhuHuynh = request.EmailPhuHuynh;
                hocSinh.DiaChiPhuHuynh = request.DiaChiPhuHuynh;
                await _context.SaveChangesAsync();
                return hocSinh;
            }
            return null;
        }
    }
}