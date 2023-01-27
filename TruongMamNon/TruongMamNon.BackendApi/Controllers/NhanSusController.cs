using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.Utilities.Constants;
using TruongMamNon.BackendApi.Utilities.Hash;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanSusController : ControllerBase
    {
        private readonly INhanSuRepository _nhanSuRepository;
        private readonly IMapper _mapper;

        public NhanSusController(INhanSuRepository nhanSuRepository, IMapper mapper)
        {
            _nhanSuRepository = nhanSuRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddNhanSu([FromBody] AddNhanSuRequest request)
        {
            if (request.MaChucVu == 0)
            {
                request.MaChucVu = null;
            }
            if (request.MaKhoiLop == 0)
            {
                request.MaKhoiLop = null;
            }
            request.MatKhau = MD5Hash.MD5(request.MatKhau);
            var nhanSu = await _nhanSuRepository.AddNhanSu(_mapper.Map<NhanSu>(request));
            return CreatedAtAction(nameof(GetNhanSu), new { maNhanSu = nhanSu.MaNhanSu }, _mapper.Map<NhanSuVm>(nhanSu));
        }

        [HttpGet]
        public async Task<IActionResult> GetNhanSus()
        {
            var nhanSus = await _nhanSuRepository.GetNhanSus();
            return Ok(_mapper.Map<List<NhanSuVm>>(nhanSus));
        }

        [HttpGet("{maNhanSu}"), ActionName("GetNhanSu")]
        public async Task<IActionResult> GetNhanSu([FromRoute] string maNhanSu)
        {
            var nhanSu = await _nhanSuRepository.GetNhanSu(maNhanSu);
            if (nhanSu == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<NhanSuVm>(nhanSu));
        }

        [HttpPut("{maNhanSu}")]
        public async Task<IActionResult> UpdateNhanSu([FromRoute] string maNhanSu, [FromBody] UpdateNhanSuRequest request)
        {
            if (await _nhanSuRepository.Exists(maNhanSu))
            {
                var nhanSu = await _nhanSuRepository.UpdateNhanSu(maNhanSu, _mapper.Map<NhanSu>(request));
                if (nhanSu != null)
                {
                    return Ok(_mapper.Map<NhanSuVm>(nhanSu));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maNhanSu}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string maNhanSu)
        {
            if (await _nhanSuRepository.Exists(maNhanSu))
            {
                var nhanSu = await _nhanSuRepository.DeleteNhanSu(maNhanSu);
                return Ok(_mapper.Map<NhanSuVm>(nhanSu));
            }
            return NotFound();
        }
    }
}