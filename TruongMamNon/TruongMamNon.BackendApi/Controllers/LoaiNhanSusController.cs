using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiNhanSusController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public LoaiNhanSusController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostLoaiNhanSu(LoaiNhanSuVm model)
        {
            var loaiNhanSu = new LoaiNhanSu()
            {
                TenLoaiNhanSu = model.TenLoaiNhanSu,
                GhiChu = model.GhiChu,
            };
            _context.LoaiNhanSus.Add(loaiNhanSu);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = loaiNhanSu.MaLoaiNhanSu }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetLoaiNhanSus()
        {
            var loaiNhanSus = _context.LoaiNhanSus;
            var loaiNhanSuVms = await loaiNhanSus.Select(x => new LoaiNhanSuVm()
            {
                MaLoaiNhanSu = x.MaLoaiNhanSu,
                TenLoaiNhanSu = x.TenLoaiNhanSu,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            return Ok(loaiNhanSuVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var loaiNhanSu = await _context.LoaiNhanSus.FindAsync(ma);
            if (loaiNhanSu == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            LoaiNhanSuVm loaiNhanSuVm = new LoaiNhanSuVm()
            {
                MaLoaiNhanSu = loaiNhanSu.MaLoaiNhanSu,
                TenLoaiNhanSu = loaiNhanSu.TenLoaiNhanSu,
                GhiChu = loaiNhanSu.GhiChu,
            };

            return Ok(loaiNhanSuVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutLoaiNhanSu(int ma, [FromBody] LoaiNhanSuVm model)
        {
            var loaiNhanSu = await _context.LoaiNhanSus.FindAsync(ma);
            if (loaiNhanSu == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            loaiNhanSu.TenLoaiNhanSu = model.TenLoaiNhanSu;
            loaiNhanSu.GhiChu = model.GhiChu;

            _context.LoaiNhanSus.Update(loaiNhanSu);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteLoaiNhanSu(int ma)
        {
            var loaiNhanSu = await _context.LoaiNhanSus.FindAsync(ma);
            if (loaiNhanSu == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            _context.LoaiNhanSus.Remove(loaiNhanSu);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                LoaiNhanSuVm loaiNhanSuVm = new LoaiNhanSuVm()
                {
                    MaLoaiNhanSu = loaiNhanSu.MaLoaiNhanSu,
                    TenLoaiNhanSu = loaiNhanSu.TenLoaiNhanSu,
                    GhiChu = loaiNhanSu.GhiChu,
                };
                return Ok(loaiNhanSuVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}