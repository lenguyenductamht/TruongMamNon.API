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
    public class PhieuUongVitaminsController : ControllerBase
    {
        private readonly IPhieuUongVitaminRepository _phieuUongVitaminRepository;
        private readonly IMapper _mapper;

        public PhieuUongVitaminsController(IPhieuUongVitaminRepository phieuUongVitaminRepository, IMapper mapper)
        {
            _phieuUongVitaminRepository = phieuUongVitaminRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhieuUongVitamin([FromBody] AUPhieuUongVitaminRequest request)
        {
            var phieuUongVitamin = await _phieuUongVitaminRepository.AddPhieuUongVitamin(_mapper.Map<PhieuUongVitamin>(request));
            return CreatedAtAction(nameof(GetPhieuUongVitamin), new { maPhieuUongVitamin = phieuUongVitamin.MaPhieuUongVitamin }, _mapper.Map<PhieuUongVitaminVm>(phieuUongVitamin));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuUongVitamins()
        {
            var phieuUongVitamins = await _phieuUongVitaminRepository.GetPhieuUongVitamins();
            return Ok(_mapper.Map<List<PhieuUongVitaminVm>>(phieuUongVitamins));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetPhieuUongVitaminsByNienHoc(int maNienHoc)
        {
            var phieuUongVitamins = await _phieuUongVitaminRepository.GetPhieuUongVitaminsByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<PhieuUongVitaminVm>>(phieuUongVitamins));
        }

        [HttpGet("{maPhieuUongVitamin}"), ActionName("GetPhieuUongVitamin")]
        public async Task<IActionResult> GetPhieuUongVitamin([FromRoute] int maPhieuUongVitamin)
        {
            var phieuUongVitamin = await _phieuUongVitaminRepository.GetPhieuUongVitamin(maPhieuUongVitamin);
            if (phieuUongVitamin == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhieuUongVitaminVm>(phieuUongVitamin));
        }

        [HttpPut("{maPhieuUongVitamin}")]
        public async Task<IActionResult> UpdatePhieuUongVitamin([FromRoute] int maPhieuUongVitamin, [FromBody] AUPhieuUongVitaminRequest request)
        {
            if (await _phieuUongVitaminRepository.Exists(maPhieuUongVitamin))
            {
                var phieuUongVitamin = await _phieuUongVitaminRepository.UpdatePhieuUongVitamin(maPhieuUongVitamin, _mapper.Map<PhieuUongVitamin>(request));
                if (phieuUongVitamin != null)
                {
                    return Ok(_mapper.Map<PhieuUongVitaminVm>(phieuUongVitamin));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuUongVitamin}")]
        public async Task<IActionResult> DeletePhieuUongVitamin([FromRoute] int maPhieuUongVitamin)
        {
            if (await _phieuUongVitaminRepository.Exists(maPhieuUongVitamin))
            {
                var phieuUongVitamin = await _phieuUongVitaminRepository.DeletePhieuUongVitamin(maPhieuUongVitamin);
                return Ok(_mapper.Map<PhieuUongVitaminVm>(phieuUongVitamin));
            }
            return NotFound();
        }
    }
}