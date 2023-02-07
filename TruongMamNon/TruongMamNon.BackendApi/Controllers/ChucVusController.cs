using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVusController : ControllerBase
    {
        private readonly IChucVuRepository _chucVuRepository;
        private readonly IMapper _mapper;

        public ChucVusController(IChucVuRepository chucVuRepository, IMapper mapper)
        {
            _chucVuRepository = chucVuRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddChucVu([FromBody] AUChucVuRequest request)
        {
            var chucVu = await _chucVuRepository.AddChucVu(_mapper.Map<ChucVu>(request));
            return CreatedAtAction(nameof(GetChucVu), new { maChucVu = chucVu.MaChucVu }, _mapper.Map<ChucVuVm>(chucVu));
        }

        [HttpGet]
        public async Task<IActionResult> GetChucVus()
        {
            var chucVus = await _chucVuRepository.GetChucVus();
            return Ok(_mapper.Map<List<ChucVuVm>>(chucVus));
        }

        [HttpGet("LoaiNhanSu/{maLoaiNhanSu}")]
        public async Task<IActionResult> GetChucVusByLoaiNhanSu(int maLoaiNhanSu)
        {
            var chucVus = await _chucVuRepository.GetChucVusByLoaiNhanSu(maLoaiNhanSu);
            return Ok(_mapper.Map<List<ChucVuVm>>(chucVus));
        }

        [HttpGet("{maChucVu}"), ActionName("GetChucVu")]
        public async Task<IActionResult> GetChucVu([FromRoute] int maChucVu)
        {
            var chucVu = await _chucVuRepository.GetChucVu(maChucVu);
            if (chucVu == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ChucVuVm>(chucVu));
        }

        [HttpPut("{maChucVu}")]
        public async Task<IActionResult> UpdateChucVu([FromRoute] int maChucVu, [FromBody] AUChucVuRequest request)
        {
            if (await _chucVuRepository.Exists(maChucVu))
            {
                var chucVu = await _chucVuRepository.UpdateChucVu(maChucVu, _mapper.Map<ChucVu>(request));
                if (chucVu != null)
                {
                    return Ok(_mapper.Map<ChucVuVm>(chucVu));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maChucVu}")]
        public async Task<IActionResult> DeleteChucVu([FromRoute] int maChucVu)
        {
            if (await _chucVuRepository.Exists(maChucVu))
            {
                var chucVu = await _chucVuRepository.DeleteChucVu(maChucVu);
                return Ok(_mapper.Map<ChucVuVm>(chucVu));
            }
            return NotFound();
        }
    }
}