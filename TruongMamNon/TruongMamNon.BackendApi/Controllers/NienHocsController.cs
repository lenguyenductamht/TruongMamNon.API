using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels;
using TruongMamNon.BackendApi.ViewModels.HeThong;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NienHocsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public NienHocsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostNienHoc(NienHocVm model)
        {
            var nienHoc = new NienHoc()
            {
                TenNienHoc = model.TenNienHoc,
                BatDauHK1 = model.BatDauHK1,
                KetThucHK1 = model.KetThucHK1,
                BatDauHK2 = model.BatDauHK2,
                KetThucHK2 = model.KetThucHK2
            };
            _context.NienHocs.Add(nienHoc);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return CreatedAtAction(nameof(GetByMa), new { ma = nienHoc.MaNienHoc }, model);
            }
            else
            {
                return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetNienHocs()
        {
            var nienHocs = _context.NienHocs.OrderByDescending(x => x.TenNienHoc);
            var nienHocVms = await nienHocs.Select(x => new NienHocVm()
            {
                MaNienHoc = x.MaNienHoc,
                TenNienHoc = x.TenNienHoc,
                BatDauHK1 = x.BatDauHK1,
                KetThucHK1 = x.KetThucHK1,
                BatDauHK2 = x.BatDauHK2,
                KetThucHK2 = x.KetThucHK2
            }).ToListAsync();
            return Ok(nienHocVms);
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            var nienHoc = await _context.NienHocs.FindAsync(ma);
            if (nienHoc == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            NienHocVm nienHocVm = new NienHocVm()
            {
                MaNienHoc = nienHoc.MaNienHoc,
                TenNienHoc = nienHoc.TenNienHoc,
                BatDauHK1 = nienHoc.BatDauHK1,
                KetThucHK1 = nienHoc.KetThucHK1,
                BatDauHK2 = nienHoc.BatDauHK2,
                KetThucHK2 = nienHoc.KetThucHK2
            };

            return Ok(nienHocVm);
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> PutNienHoc(int ma, [FromBody] NienHocVm model)
        {
            var nienHoc = await _context.NienHocs.FindAsync(ma);
            if (nienHoc == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
            nienHoc.MaNienHoc = model.MaNienHoc;
            nienHoc.TenNienHoc = model.TenNienHoc;
            nienHoc.BatDauHK1 = model.BatDauHK1;
            nienHoc.KetThucHK1 = model.KetThucHK1;
            nienHoc.BatDauHK2 = model.BatDauHK2;
            nienHoc.KetThucHK2 = model.KetThucHK2;

            _context.NienHocs.Update(nienHoc);
            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return NoContent();
            }
            return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> DeleteNienHoc(int ma)
        {
            var nienHoc = await _context.NienHocs.FindAsync(ma);
            if (nienHoc == null)
                return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));

            _context.NienHocs.Remove(nienHoc);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                NienHocVm nienHocVm = new NienHocVm()
                {
                    MaNienHoc = nienHoc.MaNienHoc,
                    TenNienHoc = nienHoc.TenNienHoc,
                    BatDauHK1 = nienHoc.BatDauHK1,
                    KetThucHK1 = nienHoc.KetThucHK1,
                    BatDauHK2 = nienHoc.BatDauHK2,
                    KetThucHK2 = nienHoc.KetThucHK2
                };
                return Ok(nienHocVm);
            }
            return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        }
    }
}