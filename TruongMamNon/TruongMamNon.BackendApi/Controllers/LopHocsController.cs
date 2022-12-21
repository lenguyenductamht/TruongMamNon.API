using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels.HeThong;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public LopHocsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostLopHoc(CreateLopHocVm model)
        {
            var lopHoc = new LopHoc()
            {
                TenLop = model.TenLop,
                MaKhoiLop = model.MaKhoiLop,
                HocPhi = model.HocPhi,
                MaNienHoc = model.MaNienHoc,
            };
            _context.LopHocs.Add(lopHoc);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = lopHoc.MaLop }, model);
            }
            return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetLopHocsByNienHoc(int maNienHoc)
        {
            var lopHocs = _context.LopHocs.Where(x => x.MaNienHoc == maNienHoc).Include(x => x.KhoiLop).Include(x => x.NienHoc).OrderBy(x => x.TenLop);
            var lopHocVms = await lopHocs.Select(x => new LopHocVm()
            {
                MaLop = x.MaLop,
                TenLop = x.TenLop,
                MaKhoiLop = x.MaKhoiLop,
                HocPhi = x.HocPhi,
                MaNienHoc = x.MaNienHoc,
                KhoiLop = x.KhoiLop,
                NienHoc = x.NienHoc,
            }).ToListAsync();
            return Ok(lopHocVms);
        }

        [HttpGet("NienHoc/{maNienHoc}/{maKhoiLop}")]
        public async Task<IActionResult> GetLopHocsByNienHocKhoiLop(int maNienHoc, int maKhoiLop)
        {
            var lopHocs = _context.LopHocs.Where(x => x.MaNienHoc == maNienHoc && x.MaKhoiLop == maKhoiLop).Include(x => x.KhoiLop).Include(x => x.NienHoc).OrderBy(x => x.TenLop);
            var lopHocVms = await lopHocs.Select(x => new LopHocVm()
            {
                MaLop = x.MaLop,
                TenLop = x.TenLop,
                MaKhoiLop = x.MaKhoiLop,
                HocPhi = x.HocPhi,
                MaNienHoc = x.MaNienHoc,
                KhoiLop = x.KhoiLop,
                NienHoc = x.NienHoc,
            }).ToListAsync();
            return Ok(lopHocVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var lopHoc = await _context.LopHocs.FindAsync(ma);
            if (lopHoc == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            LopHocVm lopHocVm = new LopHocVm()
            {
                MaLop = lopHoc.MaLop,
                TenLop = lopHoc.TenLop,
                MaKhoiLop = lopHoc.MaKhoiLop,
                HocPhi = lopHoc.HocPhi,
                MaNienHoc = lopHoc.MaNienHoc
            };
            return Ok(lopHocVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutLopHoc(int ma, CreateLopHocVm model)
        {
            var lopHoc = await _context.LopHocs.FindAsync(ma);
            if (lopHoc == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            lopHoc.TenLop = model.TenLop;
            lopHoc.MaKhoiLop = model.MaKhoiLop;
            lopHoc.HocPhi = model.HocPhi;
            lopHoc.MaNienHoc = model.MaNienHoc;
            _context.LopHocs.Update(lopHoc);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteLopHoc(int ma)
        {
            var lopHoc = await _context.LopHocs.FindAsync(ma);
            if (lopHoc == null)
            {
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            }
            _context.LopHocs.Remove(lopHoc);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                LopHocVm lopHocVm = new LopHocVm()
                {
                    MaLop = lopHoc.MaLop,
                    TenLop = lopHoc.TenLop,
                    MaKhoiLop = lopHoc.MaKhoiLop,
                    HocPhi = lopHoc.HocPhi,
                    MaNienHoc = lopHoc.MaNienHoc,
                };
                return Ok(lopHocVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}