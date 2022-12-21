using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels.MamNon;
using TruongMamNon.BackendApi.ViewModels.TruongHoc;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongBansController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;
        private readonly IMapper _mapper;

        public PhongBansController(TruongMamNonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostPhongBan(CreatePhongBanVm model)
        {
            var phongBan = new PhongBan()
            {
                TenPhongBan = model.TenPhongBan,
                GhiChu = model.GhiChu,
            };
            _context.PhongBans.Add(phongBan);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
                return CreatedAtAction(nameof(GetPhongBanByMa), new { ma = phongBan.MaPhongBan }, model);
            return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhongBans()
        {
            var phongBans = _context.PhongBans;
            var phongBanVms = await phongBans.Select(x => new PhongBanVm()
            {
                MaPhongBan = x.MaPhongBan,
                TenPhongBan = x.TenPhongBan,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            return Ok(phongBanVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetPhongBanByMa(int ma)
        {
            var phongBan = await _context.PhongBans.FindAsync(ma);
            if (phongBan == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            PhongBanVm phongBanVm = new PhongBanVm()
            {
                MaPhongBan = phongBan.MaPhongBan,
                TenPhongBan = phongBan.TenPhongBan,
                GhiChu = phongBan.GhiChu,
            };
            return Ok(phongBanVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutPhongBan(int ma, CreatePhongBanVm model)
        {
            var phongBan = await _context.PhongBans.FindAsync(ma);
            if (phongBan == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            phongBan.TenPhongBan = model.TenPhongBan;
            phongBan.GhiChu = model.GhiChu;
            _context.PhongBans.Update(phongBan);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
                return NoContent();
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeletePhongBan(int ma)
        {
            var phongBan = await _context.PhongBans.FindAsync(ma);
            if (phongBan == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            _context.PhongBans.Remove(phongBan);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                PhongBanVm phongBanVm = new PhongBanVm()
                {
                    MaPhongBan = phongBan.MaPhongBan,
                    TenPhongBan = phongBan.TenPhongBan,
                    GhiChu = phongBan.GhiChu,
                };
                return Ok(phongBanVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}