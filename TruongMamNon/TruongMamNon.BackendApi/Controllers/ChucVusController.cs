using AutoMapper;
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
    public class ChucVusController : ControllerBase
    {
        //private readonly TruongMamNonDbContext _context;
        //private readonly IMapper _mapper;

        //public ChucVusController(TruongMamNonDbContext context, IMapper mapper)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //}

        //[HttpPost]
        //public async Task<IActionResult> PostChucVu(CreateChucVuVm model)
        //{
        //    var chucVu = new ChucVu()
        //    {
        //        TenChucVu = model.TenChucVu,
        //        GhiChu = model.GhiChu,
        //    };
        //    _context.ChucVus.Add(chucVu);
        //    var result = await _context.SaveChangesAsync();

        //    if (result > 0)
        //    {
        //        return CreatedAtAction(nameof(GetByMa), new { ma = chucVu.MaChucVu }, model);
        //    }
        //    else
        //    {
        //        return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
        //    }
        //}

        //[HttpGet("LoaiNhanSu/{maLoaiNhanSu}")]
        //public async Task<IActionResult> GetChucVus(int maLoaiNhanSu)
        //{
        //    var chucVus = _context.ChucVus.Include(x => x.LoaiNhanSu).Where(x => x.MaLoaiNhanSu == maLoaiNhanSu).OrderBy(x => x.TenChucVu);
        //    var chucVuVms = await chucVus.Select(x => new ChucVuVm()
        //    {
        //        MaChucVu = x.MaChucVu,
        //        TenChucVu = x.TenChucVu,
        //        GhiChu = x.GhiChu,
        //    }).ToListAsync();
        //    return Ok(chucVuVms);
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAllChucVus()
        //{
        //    var chucVus = _context.ChucVus.Include(x => x.LoaiNhanSu).OrderBy(x => x.TenChucVu);
        //    var chucVuVms = await chucVus.Select(x => new ChucVuVm()
        //    {
        //        MaChucVu = x.MaChucVu,
        //        TenChucVu = x.TenChucVu,
        //        GhiChu = x.GhiChu,
        //    }).ToListAsync();
        //    return Ok(chucVuVms);
        //}

        //[HttpGet("{ma}")]
        //public async Task<IActionResult> GetByMa(int ma)
        //{
        //    var chucVu = await _context.ChucVus.FindAsync(ma);
        //    if (chucVu == null)
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    ChucVuVm chucVuVm = new ChucVuVm()
        //    {
        //        MaChucVu = chucVu.MaChucVu,
        //        TenChucVu = chucVu.TenChucVu,
        //        GhiChu = chucVu.GhiChu,
        //    };
        //    return Ok(chucVuVm);
        //}

        //[HttpPut("{ma}")]
        //public async Task<IActionResult> PutChucVu(int ma, CreateChucVuVm model)
        //{
        //    var chucVu = await _context.ChucVus.FindAsync(ma);
        //    if (chucVu == null)
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    chucVu.TenChucVu = model.TenChucVu;
        //    chucVu.MaLoaiNhanSu = model.MaLoaiNhanSu;
        //    chucVu.GhiChu = model.GhiChu;
        //    _context.ChucVus.Update(chucVu);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //        return NoContent();
        //    return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        //}

        //[HttpDelete("{ma}")]
        //public async Task<IActionResult> DeleteChucVu(int ma)
        //{
        //    var chucVu = await _context.ChucVus.FindAsync(ma);
        //    if (chucVu == null)
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    _context.ChucVus.Remove(chucVu);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        ChucVuVm chucVuVm = new ChucVuVm()
        //        {
        //            MaChucVu = chucVu.MaChucVu,
        //            TenChucVu = chucVu.TenChucVu,
        //            GhiChu = chucVu.GhiChu,
        //        };
        //        return Ok(chucVuVm);
        //    }
        //    return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        //}
    }
}