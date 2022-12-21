using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels.HeThong;
using TruongMamNon.BackendApi.ViewModels.MamNon;
using XAct;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoiLopsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public KhoiLopsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostKhoiLop(KhoiLopVm model)
        {
            var khoiLop = new KhoiLop()
            {
                TenKhoiLop = model.TenKhoiLop,
                GhiChu = model.GhiChu,
            };
            _context.KhoiLops.Add(khoiLop);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = khoiLop.MaKhoiLop }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetKhoiLops()
        {
            var khoiLops = _context.KhoiLops;
            var khoiLopVms = await khoiLops.Select(x => new KhoiLopVm()
            {
                MaKhoiLop = x.MaKhoiLop,
                TenKhoiLop = x.TenKhoiLop,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            return Ok(khoiLopVms);
        }

        [HttpGet("LopHoc/{maNienHoc}")]
        public async Task<IActionResult> GetKhoiLopsLopHocs(int maNienHoc)
        {
            var khoiLops = _context.KhoiLops;
            var khoiLopVms = await khoiLops.Select(x => new KhoiLopVm()
            {
                MaKhoiLop = x.MaKhoiLop,
                TenKhoiLop = x.TenKhoiLop,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            foreach (KhoiLopVm khoiLop in khoiLopVms)
            {
                var lopHocs = await _context.LopHocs
                    .AsNoTracking()
                    .Where(x => x.KhoiLop.MaKhoiLop == khoiLop.MaKhoiLop && x.MaNienHoc == maNienHoc)
                    .Include(x => x.KhoiLop)
                    .Include(x => x.NienHoc)
                    .ToListAsync();
                if (lopHocs != null && lopHocs.Count > 0)
                {
                    foreach (LopHoc lopHoc in lopHocs)
                    {
                        LopHocVm lopHocVm = new LopHocVm()
                        {
                            MaLop = lopHoc.MaLop,
                            TenLop = lopHoc.TenLop,
                            MaKhoiLop = lopHoc.MaKhoiLop,
                            MaNienHoc = lopHoc.MaNienHoc,
                            HocPhi = lopHoc.HocPhi,
                            KhoiLop = lopHoc.KhoiLop,
                            NienHoc = lopHoc.NienHoc,
                        };
                        khoiLop.LopHocVms.Add(lopHocVm);
                    }
                }
            }
            return Ok(khoiLopVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var khoiLop = await _context.KhoiLops.FindAsync(ma);
            if (khoiLop == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            KhoiLopVm khoiLopVm = new KhoiLopVm()
            {
                MaKhoiLop = khoiLop.MaKhoiLop,
                TenKhoiLop = khoiLop.TenKhoiLop,
                GhiChu = khoiLop.GhiChu,
            };
            return Ok(khoiLopVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutKhoiLop(int ma, KhoiLopVm model)
        {
            var khoiLop = await _context.KhoiLops.FindAsync(ma);
            if (khoiLop == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            khoiLop.MaKhoiLop = model.MaKhoiLop;
            khoiLop.TenKhoiLop = model.TenKhoiLop;
            khoiLop.GhiChu = model.GhiChu;
            _context.KhoiLops.Update(khoiLop);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteKhoiLop(int ma)
        {
            var khoiLop = await _context.KhoiLops.FindAsync(ma);
            if (khoiLop == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            _context.KhoiLops.Remove(khoiLop);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                KhoiLopVm khoiLopVm = new KhoiLopVm()
                {
                    MaKhoiLop = khoiLop.MaKhoiLop,
                    TenKhoiLop = khoiLop.TenKhoiLop,
                    GhiChu = khoiLop.GhiChu,
                };
                return Ok(khoiLopVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}