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
    public class VitaminsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public VitaminsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostVitamin(CreateVitaminVm model)
        {
            var vitamin = new Vitamin()
            {
                TenVitamin = model.TenVitamin,
                GhiChu = model.GhiChu,
            };
            _context.Vitamins.Add(vitamin);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = vitamin.MaVitamin }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetVitamins()
        {
            var vitamins = _context.Vitamins;
            var vitaminVms = await vitamins.Select(x => new VitaminVm()
            {
                MaVitamin = x.MaVitamin,
                TenVitamin = x.TenVitamin,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            return Ok(vitaminVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var vitamin = await _context.Vitamins.FindAsync(ma);
            if (vitamin == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            VitaminVm vitaminVm = new VitaminVm()
            {
                MaVitamin = vitamin.MaVitamin,
                TenVitamin = vitamin.TenVitamin,
                GhiChu = vitamin.GhiChu,
            };

            return Ok(vitaminVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutVitamin(int ma, [FromBody] CreateVitaminVm model)
        {
            var vitamin = await _context.Vitamins.FindAsync(ma);
            if (vitamin == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            vitamin.TenVitamin = model.TenVitamin;
            vitamin.GhiChu = model.GhiChu;

            _context.Vitamins.Update(vitamin);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteVitamin(int ma)
        {
            var vitamin = await _context.Vitamins.FindAsync(ma);
            if (vitamin == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            _context.Vitamins.Remove(vitamin);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                VitaminVm vitaminVm = new VitaminVm()
                {
                    MaVitamin = vitamin.MaVitamin,
                    TenVitamin = vitamin.TenVitamin,
                    GhiChu = vitamin.GhiChu,
                };
                return Ok(vitaminVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}