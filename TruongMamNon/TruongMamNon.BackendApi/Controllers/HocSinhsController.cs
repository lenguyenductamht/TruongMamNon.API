using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Security.Cryptography;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Utilities.Constants;
using TruongMamNon.BackendApi.Utilities.Hash;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public HocSinhsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostHocSinh(CreateHocSinhVm model)
        {
            if (model.MaLopHoc == 0)
            {
                model.MaLopHoc = null;
            }
            var hocSinh = new HocSinh()
            {
                Id = 0,
                MaHocSinh = "a",
                Ho = model.Ho,
                Ten = model.Ten,
                GioiTinh = model.GioiTinh,
                MaKhoiLop = model.MaKhoiLop,
                MaLopHoc = model.MaLopHoc,
                NgayNhapHoc = model.NgayNhapHoc,
                TrangThaiHoc = model.TrangThaiHoc,
                LyDoNghiHoc = model.LyDoNghiHoc,
                NgayCapNhat = model.NgayCapNhat,
                NgaySinh = model.NgaySinh,
                NoiSinh = model.NoiSinh,
                DanToc = model.DanToc,
                TonGiao = model.TonGiao,
                QuocTich = model.QuocTich,
                GhiChu = model.GhiChu,
                HoKhau = model.HoKhau,
                DiaChi = model.DiaChi,
                HinhAnh = model.HinhAnh,
                MatKhau = MD5Hash.MD5(SystemConstant.dfHocSinhPassword),
                TrangThaiTaiKhoan = "Kích hoạt",
                HoTenPhuHuynh = model.HoTenPhuHuynh,
                NamSinhPhuHuynh = model.NamSinhPhuHuynh,
                CMNDPhuHuynh = model.CMNDPhuHuynh,
                SDTPhuHuynh = model.SDTPhuHuynh,
                NgheNghiepPhuHuynh = model.NgheNghiepPhuHuynh,
                EmailPhuHuynh = model.EmailPhuHuynh,
                DiaChiPhuHuynh = model.DiaChiPhuHuynh
            };
            _context.HocSinhs.Add(hocSinh);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = hocSinh.MaHocSinh }, model);
            }
            return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
        }

        [HttpGet]
        public async Task<IActionResult> GetHocSinhs()
        {
            var hocSinhs = _context.HocSinhs.Include(x => x.KhoiLop).Include(x => x.LopHoc);
            var hocSinhVms = await hocSinhs.Select(x => new HocSinhVm()
            {
                MaHocSinh = x.MaHocSinh,
                Ho = x.Ho,
                Ten = x.Ten,
                GioiTinh = x.GioiTinh,
                MaLopHoc = x.MaLopHoc,
                NgayNhapHoc = x.NgayNhapHoc,
                TrangThaiHoc = x.TrangThaiHoc,
                LyDoNghiHoc = x.LyDoNghiHoc,
                NgayCapNhat = x.NgayCapNhat,
                NgaySinh = x.NgaySinh,
                NoiSinh = x.NoiSinh,
                DanToc = x.DanToc,
                TonGiao = x.TonGiao,
                QuocTich = x.QuocTich,
                GhiChu = x.GhiChu,
                HoKhau = x.HoKhau,
                DiaChi = x.DiaChi,
                HinhAnh = x.HinhAnh,
                HoTenPhuHuynh = x.HoTenPhuHuynh,
                NamSinhPhuHuynh = x.NamSinhPhuHuynh,
                CMNDPhuHuynh = x.CMNDPhuHuynh,
                SDTPhuHuynh = x.SDTPhuHuynh,
                NgheNghiepPhuHuynh = x.NgheNghiepPhuHuynh,
                EmailPhuHuynh = x.EmailPhuHuynh,
                DiaChiPhuHuynh = x.DiaChiPhuHuynh,
                KhoiLop = x.KhoiLop,
                LopHoc = x.LopHoc,
            }).ToListAsync();
            return Ok(hocSinhVms);
        }

        [HttpGet("KhoiLop/{maKhoiLop}")]
        public async Task<IActionResult> GetHocSinhsByKhoiLop(int maKhoiLop)
        {
            var hocSinhs = _context.HocSinhs.Where(x => x.MaKhoiLop == maKhoiLop).Include(x => x.KhoiLop).Include(x => x.LopHoc);
            var hocSinhVms = await hocSinhs.Select(x => new HocSinhVm()
            {
                MaHocSinh = x.MaHocSinh,
                Ho = x.Ho,
                Ten = x.Ten,
                GioiTinh = x.GioiTinh,
                MaLopHoc = x.MaLopHoc,
                NgayNhapHoc = x.NgayNhapHoc,
                TrangThaiHoc = x.TrangThaiHoc,
                LyDoNghiHoc = x.LyDoNghiHoc,
                NgayCapNhat = x.NgayCapNhat,
                NgaySinh = x.NgaySinh,
                NoiSinh = x.NoiSinh,
                DanToc = x.DanToc,
                TonGiao = x.TonGiao,
                QuocTich = x.QuocTich,
                GhiChu = x.GhiChu,
                HoKhau = x.HoKhau,
                DiaChi = x.DiaChi,
                HinhAnh = x.HinhAnh,
                HoTenPhuHuynh = x.HoTenPhuHuynh,
                NamSinhPhuHuynh = x.NamSinhPhuHuynh,
                CMNDPhuHuynh = x.CMNDPhuHuynh,
                SDTPhuHuynh = x.SDTPhuHuynh,
                NgheNghiepPhuHuynh = x.NgheNghiepPhuHuynh,
                EmailPhuHuynh = x.EmailPhuHuynh,
                DiaChiPhuHuynh = x.DiaChiPhuHuynh,
                KhoiLop = x.KhoiLop,
                LopHoc = x.LopHoc,
            }).ToListAsync();
            return Ok(hocSinhVms);
        }

        [HttpGet("LopHoc/{maLopHoc}")]
        public async Task<IActionResult> GetHocSinhsByLopHoc(int maLopHoc)
        {
            var hocSinhs = _context.HocSinhs.Where(x => x.MaLopHoc == maLopHoc).Include(x => x.KhoiLop).Include(x => x.LopHoc);
            var hocSinhVms = await hocSinhs.Select(x => new HocSinhVm()
            {
                MaHocSinh = x.MaHocSinh,
                Ho = x.Ho,
                Ten = x.Ten,
                GioiTinh = x.GioiTinh,
                MaLopHoc = x.MaLopHoc,
                NgayNhapHoc = x.NgayNhapHoc,
                TrangThaiHoc = x.TrangThaiHoc,
                LyDoNghiHoc = x.LyDoNghiHoc,
                NgayCapNhat = x.NgayCapNhat,
                NgaySinh = x.NgaySinh,
                NoiSinh = x.NoiSinh,
                DanToc = x.DanToc,
                TonGiao = x.TonGiao,
                QuocTich = x.QuocTich,
                GhiChu = x.GhiChu,
                HoKhau = x.HoKhau,
                DiaChi = x.DiaChi,
                HinhAnh = x.HinhAnh,
                HoTenPhuHuynh = x.HoTenPhuHuynh,
                NamSinhPhuHuynh = x.NamSinhPhuHuynh,
                CMNDPhuHuynh = x.CMNDPhuHuynh,
                SDTPhuHuynh = x.SDTPhuHuynh,
                NgheNghiepPhuHuynh = x.NgheNghiepPhuHuynh,
                EmailPhuHuynh = x.EmailPhuHuynh,
                DiaChiPhuHuynh = x.DiaChiPhuHuynh,
                KhoiLop = x.KhoiLop,
                LopHoc = x.LopHoc,
            }).ToListAsync();
            return Ok(hocSinhVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var hocSinh = await _context.HocSinhs.FindAsync(ma);
            if (hocSinh == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            HocSinhVm hocSinhVm = new HocSinhVm()
            {
                MaHocSinh = hocSinh.MaHocSinh,
                Ho = hocSinh.Ho,
                Ten = hocSinh.Ten,
                GioiTinh = hocSinh.GioiTinh,
                MaLopHoc = hocSinh.MaLopHoc,
                NgayNhapHoc = hocSinh.NgayNhapHoc,
                TrangThaiHoc = hocSinh.TrangThaiHoc,
                LyDoNghiHoc = hocSinh.LyDoNghiHoc,
                NgayCapNhat = hocSinh.NgayCapNhat,
                NgaySinh = hocSinh.NgaySinh,
                NoiSinh = hocSinh.NoiSinh,
                DanToc = hocSinh.DanToc,
                TonGiao = hocSinh.TonGiao,
                QuocTich = hocSinh.QuocTich,
                GhiChu = hocSinh.GhiChu,
                HoKhau = hocSinh.HoKhau,
                DiaChi = hocSinh.DiaChi,
                HinhAnh = hocSinh.HinhAnh,
                HoTenPhuHuynh = hocSinh.HoTenPhuHuynh,
                NamSinhPhuHuynh = hocSinh.NamSinhPhuHuynh,
                CMNDPhuHuynh = hocSinh.CMNDPhuHuynh,
                SDTPhuHuynh = hocSinh.SDTPhuHuynh,
                NgheNghiepPhuHuynh = hocSinh.NgheNghiepPhuHuynh,
                EmailPhuHuynh = hocSinh.EmailPhuHuynh,
                DiaChiPhuHuynh = hocSinh.DiaChiPhuHuynh,
                KhoiLop = hocSinh.KhoiLop,
                LopHoc = hocSinh.LopHoc,
            };
            return Ok(hocSinhVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutHocSinh(int ma, CreateHocSinhVm model)
        {
            var hocSinh = await _context.HocSinhs.FindAsync(ma);
            if (hocSinh == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            hocSinh.Ho = model.Ho;
            hocSinh.Ten = model.Ten;
            hocSinh.GioiTinh = model.GioiTinh;
            hocSinh.MaLopHoc = model.MaLopHoc;
            hocSinh.NgayNhapHoc = model.NgayNhapHoc;
            hocSinh.TrangThaiHoc = model.TrangThaiHoc;
            hocSinh.LyDoNghiHoc = model.LyDoNghiHoc;
            hocSinh.NgayCapNhat = model.NgayCapNhat;
            hocSinh.NgaySinh = model.NgaySinh;
            hocSinh.NoiSinh = model.NoiSinh;
            hocSinh.DanToc = model.DanToc;
            hocSinh.TonGiao = model.TonGiao;
            hocSinh.QuocTich = model.QuocTich;
            hocSinh.GhiChu = model.GhiChu;
            hocSinh.HoKhau = model.HoKhau;
            hocSinh.DiaChi = model.DiaChi;
            hocSinh.HinhAnh = model.HinhAnh;
            hocSinh.HoTenPhuHuynh = model.HoTenPhuHuynh;
            hocSinh.NamSinhPhuHuynh = model.NamSinhPhuHuynh;
            hocSinh.CMNDPhuHuynh = model.CMNDPhuHuynh;
            hocSinh.SDTPhuHuynh = model.SDTPhuHuynh;
            hocSinh.NgheNghiepPhuHuynh = model.NgheNghiepPhuHuynh;
            hocSinh.EmailPhuHuynh = model.EmailPhuHuynh;
            hocSinh.DiaChiPhuHuynh = model.DiaChiPhuHuynh;
            _context.HocSinhs.Update(hocSinh);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteHocSinh(string ma)
        {
            var hocSinh = await _context.HocSinhs.FindAsync(ma);
            if (hocSinh == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            _context.HocSinhs.Remove(hocSinh);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                HocSinhVm hocSinhVm = new HocSinhVm()
                {
                    Id = hocSinh.Id,
                    MaHocSinh = hocSinh.MaHocSinh,
                    Ho = hocSinh.Ho,
                    Ten = hocSinh.Ten,
                    GioiTinh = hocSinh.GioiTinh,
                    MaLopHoc = hocSinh.MaLopHoc,
                    NgayNhapHoc = hocSinh.NgayNhapHoc,
                    TrangThaiHoc = hocSinh.TrangThaiHoc,
                    LyDoNghiHoc = hocSinh.LyDoNghiHoc,
                    NgayCapNhat = hocSinh.NgayCapNhat,
                    NgaySinh = hocSinh.NgaySinh,
                    NoiSinh = hocSinh.NoiSinh,
                    DanToc = hocSinh.DanToc,
                    TonGiao = hocSinh.TonGiao,
                    QuocTich = hocSinh.QuocTich,
                    GhiChu = hocSinh.GhiChu,
                    HoKhau = hocSinh.HoKhau,
                    DiaChi = hocSinh.DiaChi,
                    HinhAnh = hocSinh.HinhAnh,
                    HoTenPhuHuynh = hocSinh.HoTenPhuHuynh,
                    NamSinhPhuHuynh = hocSinh.NamSinhPhuHuynh,
                    CMNDPhuHuynh = hocSinh.CMNDPhuHuynh,
                    SDTPhuHuynh = hocSinh.SDTPhuHuynh,
                    NgheNghiepPhuHuynh = hocSinh.NgheNghiepPhuHuynh,
                    EmailPhuHuynh = hocSinh.EmailPhuHuynh,
                    DiaChiPhuHuynh = hocSinh.DiaChiPhuHuynh,
                };
                return Ok(hocSinhVm);
            }

            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}