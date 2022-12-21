using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels.YTeHocDuong;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThuocSoGiunsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public ThuocSoGiunsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostThuocSoGiun(CreateThuocSoGiunVm model)
        {
            var thuocSoGiun = new ThuocSoGiun()
            {
                TenThuocSoGiun = model.TenThuocSoGiun,
                GhiChu = model.GhiChu,
            };
            _context.ThuocSoGiuns.Add(thuocSoGiun);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = thuocSoGiun.MaThuocSoGiun }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetThuocSoGiuns()
        {
            var thuocSoGiuns = _context.ThuocSoGiuns;
            var thuocSoGiunVms = await thuocSoGiuns.Select(x => new ThuocSoGiunVm()
            {
                MaThuocSoGiun = x.MaThuocSoGiun,
                TenThuocSoGiun = x.TenThuocSoGiun,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            return Ok(thuocSoGiunVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var thuocSoGiun = await _context.ThuocSoGiuns.FindAsync(ma);
            if (thuocSoGiun == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            ThuocSoGiunVm thuocSoGiunVm = new ThuocSoGiunVm()
            {
                MaThuocSoGiun = thuocSoGiun.MaThuocSoGiun,
                TenThuocSoGiun = thuocSoGiun.TenThuocSoGiun,
                GhiChu = thuocSoGiun.GhiChu,
            };

            return Ok(thuocSoGiunVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutThuocSoGiun(int ma, [FromBody] CreateThuocSoGiunVm model)
        {
            var thuocSoGiun = await _context.ThuocSoGiuns.FindAsync(ma);
            if (thuocSoGiun == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            thuocSoGiun.TenThuocSoGiun = model.TenThuocSoGiun;
            thuocSoGiun.GhiChu = model.GhiChu;

            _context.ThuocSoGiuns.Update(thuocSoGiun);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteThuocSoGiun(int ma)
        {
            var thuocSoGiun = await _context.ThuocSoGiuns.FindAsync(ma);
            if (thuocSoGiun == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            _context.ThuocSoGiuns.Remove(thuocSoGiun);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                ThuocSoGiunVm thuocSoGiunVm = new ThuocSoGiunVm()
                {
                    MaThuocSoGiun = thuocSoGiun.MaThuocSoGiun,
                    TenThuocSoGiun = thuocSoGiun.TenThuocSoGiun,
                    GhiChu = thuocSoGiun.GhiChu,
                };
                return Ok(thuocSoGiunVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}