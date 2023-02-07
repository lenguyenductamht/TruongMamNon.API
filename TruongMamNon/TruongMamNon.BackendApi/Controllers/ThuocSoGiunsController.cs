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
    public class ThuocSoGiunsController : ControllerBase
    {
        private readonly IThuocSoGiunRepository _thuocSoGiunRepository;
        private readonly IMapper _mapper;

        public ThuocSoGiunsController(IThuocSoGiunRepository thuocSoGiunRepository, IMapper mapper)
        {
            _thuocSoGiunRepository = thuocSoGiunRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddThuocSoGiun([FromBody] AUThuocSoGiunRequest request)
        {
            var thuocSoGiun = await _thuocSoGiunRepository.AddThuocSoGiun(_mapper.Map<ThuocSoGiun>(request));
            return CreatedAtAction(nameof(GetThuocSoGiun), new { maThuocSoGiun = thuocSoGiun.MaThuocSoGiun }, _mapper.Map<ThuocSoGiunVm>(thuocSoGiun));
        }

        [HttpGet]
        public async Task<IActionResult> GetThuocSoGiuns()
        {
            var thuocSoGiuns = await _thuocSoGiunRepository.GetThuocSoGiuns();
            return Ok(_mapper.Map<List<ThuocSoGiunVm>>(thuocSoGiuns));
        }

        [HttpGet("{maThuocSoGiun}"), ActionName("GetThuocSoGiun")]
        public async Task<IActionResult> GetThuocSoGiun([FromRoute] int maThuocSoGiun)
        {
            var thuocSoGiun = await _thuocSoGiunRepository.GetThuocSoGiun(maThuocSoGiun);
            if (thuocSoGiun == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ThuocSoGiunVm>(thuocSoGiun));
        }

        [HttpPut("{maThuocSoGiun}")]
        public async Task<IActionResult> UpdateThuocSoGiun([FromRoute] int maThuocSoGiun, [FromBody] AUThuocSoGiunRequest request)
        {
            if (await _thuocSoGiunRepository.Exists(maThuocSoGiun))
            {
                var thuocSoGiun = await _thuocSoGiunRepository.UpdateThuocSoGiun(maThuocSoGiun, _mapper.Map<ThuocSoGiun>(request));
                if (thuocSoGiun != null)
                {
                    return Ok(_mapper.Map<ThuocSoGiunVm>(thuocSoGiun));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maThuocSoGiun}")]
        public async Task<IActionResult> DeleteThuocSoGiun([FromRoute] int maThuocSoGiun)
        {
            if (await _thuocSoGiunRepository.Exists(maThuocSoGiun))
            {
                var thuocSoGiun = await _thuocSoGiunRepository.DeleteThuocSoGiun(maThuocSoGiun);
                return Ok(_mapper.Map<ThuocSoGiunVm>(thuocSoGiun));
            }
            return NotFound();
        }
    }
}