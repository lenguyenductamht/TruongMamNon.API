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
    public class DotUongVitaminsController : ControllerBase
    {
        private readonly IDotUongVitaminRepository _dotUongVitaminRepository;
        private readonly IMapper _mapper;

        public DotUongVitaminsController(IDotUongVitaminRepository dotUongVitaminRepository, IMapper mapper)
        {
            _dotUongVitaminRepository = dotUongVitaminRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddDotUongVitamin([FromBody] AUDotUongVitaminRequest request)
        {
            var dotUongVitamin = await _dotUongVitaminRepository.AddDotUongVitamin(_mapper.Map<DotUongVitamin>(request));
            return CreatedAtAction(nameof(GetDotUongVitamin), new { maDotUongVitamin = dotUongVitamin.MaDotUongVitamin }, _mapper.Map<DotUongVitaminVm>(dotUongVitamin));
        }

        [HttpGet]
        public async Task<IActionResult> GetDotUongVitamins()
        {
            var dotUongVitamins = await _dotUongVitaminRepository.GetDotUongVitamins();
            return Ok(_mapper.Map<List<DotUongVitaminVm>>(dotUongVitamins));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetDotUongVitaminsByNienHoc(int maNienHoc)
        {
            var dotUongVitamins = await _dotUongVitaminRepository.GetDotUongVitaminsByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<DotUongVitaminVm>>(dotUongVitamins));
        }

        [HttpGet("{maDotUongVitamin}"), ActionName("GetDotUongVitamin")]
        public async Task<IActionResult> GetDotUongVitamin([FromRoute] int maDotUongVitamin)
        {
            var dotUongVitamin = await _dotUongVitaminRepository.GetDotUongVitamin(maDotUongVitamin);
            if (dotUongVitamin == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DotUongVitaminVm>(dotUongVitamin));
        }

        [HttpPut("{maDotUongVitamin}")]
        public async Task<IActionResult> UpdateDotUongVitamin([FromRoute] int maDotUongVitamin, [FromBody] AUDotUongVitaminRequest request)
        {
            if (await _dotUongVitaminRepository.Exists(maDotUongVitamin))
            {
                var dotUongVitamin = await _dotUongVitaminRepository.UpdateDotUongVitamin(maDotUongVitamin, _mapper.Map<DotUongVitamin>(request));
                if (dotUongVitamin != null)
                {
                    return Ok(_mapper.Map<DotUongVitaminVm>(dotUongVitamin));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maDotUongVitamin}")]
        public async Task<IActionResult> DeleteDotUongVitamin([FromRoute] int maDotUongVitamin)
        {
            if (await _dotUongVitaminRepository.Exists(maDotUongVitamin))
            {
                var dotUongVitamin = await _dotUongVitaminRepository.DeleteDotUongVitamin(maDotUongVitamin);
                return Ok(_mapper.Map<DotUongVitaminVm>(dotUongVitamin));
            }
            return NotFound();
        }
    }
}