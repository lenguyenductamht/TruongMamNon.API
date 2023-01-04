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
    public class VaccinesController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public VaccinesController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostVaccine(CreateVaccineVm model)
        {
            var vaccine = new Vaccine()
            {
                TenVaccine = model.TenVaccine,
                GhiChu = model.GhiChu,
            };
            _context.Vaccines.Add(vaccine);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = vaccine.MaVaccine }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetVaccines()
        {
            var vaccines = _context.Vaccines;
            var vaccineVms = await vaccines.Select(x => new VaccineVm()
            {
                MaVaccine = x.MaVaccine,
                TenVaccine = x.TenVaccine,
                GhiChu = x.GhiChu,
            }).ToListAsync();
            return Ok(vaccineVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var vaccine = await _context.Vaccines.FindAsync(ma);
            if (vaccine == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            VaccineVm vaccineVm = new VaccineVm()
            {
                MaVaccine = vaccine.MaVaccine,
                TenVaccine = vaccine.TenVaccine,
                GhiChu = vaccine.GhiChu,
            };

            return Ok(vaccineVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutVaccine(int ma, [FromBody] CreateVaccineVm model)
        {
            var vaccine = await _context.Vaccines.FindAsync(ma);
            if (vaccine == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            vaccine.TenVaccine = model.TenVaccine;
            vaccine.GhiChu = model.GhiChu;

            _context.Vaccines.Update(vaccine);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteVaccine(int ma)
        {
            var vaccine = await _context.Vaccines.FindAsync(ma);
            if (vaccine == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            _context.Vaccines.Remove(vaccine);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                VaccineVm vaccineVm = new VaccineVm()
                {
                    MaVaccine = vaccine.MaVaccine,
                    TenVaccine = vaccine.TenVaccine,
                    GhiChu = vaccine.GhiChu,
                };
                return Ok(vaccineVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}