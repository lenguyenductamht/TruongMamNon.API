using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DotSoGiunsController : ControllerBase
    {
        private readonly IDotSoGiunRepository _dotSoGiunRepository;
        private readonly IMapper _mapper;

        public DotSoGiunsController(IDotSoGiunRepository dotSoGiunRepository, IMapper mapper)
        {
            _dotSoGiunRepository = dotSoGiunRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddDotSoGiun([FromBody] AUDotSoGiunRequest request)
        {
            var dotSoGiun = await _dotSoGiunRepository.AddDotSoGiun(_mapper.Map<DotSoGiun>(request));
            return CreatedAtAction(nameof(GetDotSoGiun), new { maDotSoGiun = dotSoGiun.MaDotSoGiun }, _mapper.Map<DotSoGiunVm>(dotSoGiun));
        }

        [HttpGet]
        public async Task<IActionResult> GetDotSoGiuns()
        {
            var dotSoGiuns = await _dotSoGiunRepository.GetDotSoGiuns();
            return Ok(_mapper.Map<List<DotSoGiunVm>>(dotSoGiuns));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetDotSoGiunsByNienHoc(int maNienHoc)
        {
            var dotSoGiuns = await _dotSoGiunRepository.GetDotSoGiunsByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<DotSoGiunVm>>(dotSoGiuns));
        }

        [HttpGet("{maDotSoGiun}"), ActionName("GetDotSoGiun")]
        public async Task<IActionResult> GetDotSoGiun([FromRoute] int maDotSoGiun)
        {
            var dotSoGiun = await _dotSoGiunRepository.GetDotSoGiun(maDotSoGiun);
            if (dotSoGiun == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DotSoGiunVm>(dotSoGiun));
        }

        [HttpPut("{maDotSoGiun}")]
        public async Task<IActionResult> UpdateDotSoGiun([FromRoute] int maDotSoGiun, [FromBody] AUDotSoGiunRequest request)
        {
            if (await _dotSoGiunRepository.Exists(maDotSoGiun))
            {
                var dotSoGiun = await _dotSoGiunRepository.UpdateDotSoGiun(maDotSoGiun, _mapper.Map<DotSoGiun>(request));
                if (dotSoGiun != null)
                {
                    return Ok(_mapper.Map<DotSoGiunVm>(dotSoGiun));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maDotSoGiun}")]
        public async Task<IActionResult> DeleteDotSoGiun([FromRoute] int maDotSoGiun)
        {
            if (await _dotSoGiunRepository.Exists(maDotSoGiun))
            {
                var dotSoGiun = await _dotSoGiunRepository.DeleteDotSoGiun(maDotSoGiun);
                return Ok(_mapper.Map<DotSoGiunVm>(dotSoGiun));
            }
            return NotFound();
        }
    }
}