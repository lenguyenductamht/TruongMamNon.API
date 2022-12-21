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
    public class PhieuTiemVaccinesController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuTiemVaccinesController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostPhieuTiemVaccine(CreatePhieuTiemVaccineVm model)
        {
            var phieuTiemVaccine = new PhieuTiemVaccine()
            {
                MaVaccine = model.MaVaccine,
                MaHocSinh = model.MaHocSinh,
                NgayTiem = model.NgayTiem
            };
            _context.PhieuTiemVaccines.Add(phieuTiemVaccine);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = phieuTiemVaccine.MaVaccine, phieuTiemVaccine.MaHocSinh, phieuTiemVaccine.NgayTiem }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuTiemVaccines()
        {
            var phieuTiemVaccines = _context.PhieuTiemVaccines;
            var phieuTiemVaccineVms = await phieuTiemVaccines.Select(x => new PhieuTiemVaccineVm()
            {
                MaVaccine = x.MaVaccine,
                MaHocSinh = x.MaHocSinh,
                NgayTiem = x.NgayTiem,
                Vaccine = x.Vaccine,
                HocSinh = x.HocSinh,
            }).ToListAsync();
            return Ok(phieuTiemVaccineVms);
        }

        [HttpGet("{maVaccine}/{maHocSinh}/{ngayTiem}")]
        public async Task<IActionResult> GetByMa(int maVaccine, string maHocSinh, DateTime ngayTiem)
        {
            var phieuTiemVaccine = await _context.PhieuTiemVaccines.FirstOrDefaultAsync(x =>
                    x.MaVaccine == maVaccine && x.MaHocSinh == maHocSinh && x.NgayTiem == ngayTiem);
            if (phieuTiemVaccine == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {maVaccine} - {maHocSinh} - {ngayTiem}"));

            PhieuTiemVaccineVm phieuTiemVaccineVm = new PhieuTiemVaccineVm()
            {
                MaVaccine = phieuTiemVaccine.MaVaccine,
                MaHocSinh = phieuTiemVaccine.MaHocSinh,
                NgayTiem = phieuTiemVaccine.NgayTiem,
                Vaccine = phieuTiemVaccine.Vaccine,
                HocSinh = phieuTiemVaccine.HocSinh,
            };

            return Ok(phieuTiemVaccineVm);
        }

        [HttpPut("{maVaccine}/{maHocSinh}/{ngayTiem}")]
        public async Task<IActionResult> PutPhieuTiemVaccine(int maVaccine, string maHocSinh, DateTime ngayTiem, CreatePhieuTiemVaccineVm model)
        {
            var phieuTiemVaccine = await _context.PhieuTiemVaccines.FirstOrDefaultAsync(x =>
                    x.MaVaccine == maVaccine && x.MaHocSinh == maHocSinh && x.NgayTiem == ngayTiem);
            if (phieuTiemVaccine == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {maVaccine} - {maHocSinh} - {ngayTiem}"));
            phieuTiemVaccine.MaVaccine = model.MaVaccine;
            phieuTiemVaccine.MaHocSinh = model.MaHocSinh;
            phieuTiemVaccine.NgayTiem = model.NgayTiem;

            _context.PhieuTiemVaccines.Update(phieuTiemVaccine);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{maVaccine}/{maHocSinh}/{ngayTiem}")]
        public async Task<IActionResult> DeletePhieuTiemVaccine(int maVaccine, string maHocSinh, DateTime ngayTiem)
        {
            var phieuTiemVaccine = await _context.PhieuTiemVaccines.FirstOrDefaultAsync(x =>
                   x.MaVaccine == maVaccine && x.MaHocSinh == maHocSinh && x.NgayTiem == ngayTiem);

            if (phieuTiemVaccine == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {maVaccine} - {maHocSinh} - {ngayTiem}"));

            _context.PhieuTiemVaccines.Remove(phieuTiemVaccine);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                PhieuTiemVaccineVm phieuTiemVaccineVm = new PhieuTiemVaccineVm()
                {
                    MaVaccine = phieuTiemVaccine.MaVaccine,
                    MaHocSinh = phieuTiemVaccine.MaHocSinh,
                    NgayTiem = phieuTiemVaccine.NgayTiem,
                };
                return Ok(phieuTiemVaccineVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}