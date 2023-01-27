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
    public class PhongBansController : ControllerBase
    {
        private readonly IPhongBanRepository _phongBanRepository;
        private readonly IMapper _mapper;

        public PhongBansController(IPhongBanRepository phongBanRepository, IMapper mapper)
        {
            _phongBanRepository = phongBanRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhongBan([FromBody] AUPhongBanRequest request)
        {
            var phongBan = await _phongBanRepository.AddPhongBan(_mapper.Map<PhongBan>(request));
            return CreatedAtAction(nameof(GetPhongBan), new { maPhongBan = phongBan.MaPhongBan }, _mapper.Map<PhongBanVm>(phongBan));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhongBans()
        {
            var phongBans = await _phongBanRepository.GetPhongBans();
            return Ok(_mapper.Map<List<PhongBanVm>>(phongBans));
        }

        [HttpGet("{maPhongBan}"), ActionName("GetPhongBan")]
        public async Task<IActionResult> GetPhongBan([FromRoute] int maPhongBan)
        {
            var phongBan = await _phongBanRepository.GetPhongBan(maPhongBan);
            if (phongBan == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhongBanVm>(phongBan));
        }

        [HttpPut("{maPhongBan}")]
        public async Task<IActionResult> UpdatePhongBan([FromRoute] int maPhongBan, [FromBody] AUPhongBanRequest request)
        {
            if (await _phongBanRepository.Exists(maPhongBan))
            {
                var phongBan = await _phongBanRepository.UpdatePhongBan(maPhongBan, _mapper.Map<PhongBan>(request));
                if (phongBan != null)
                {
                    return Ok(_mapper.Map<PhongBanVm>(phongBan));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhongBan}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int maPhongBan)
        {
            if (await _phongBanRepository.Exists(maPhongBan))
            {
                var phongBan = await _phongBanRepository.DeletePhongBan(maPhongBan);
                return Ok(_mapper.Map<PhongBanVm>(phongBan));
            }
            return NotFound();
        }
    }
}