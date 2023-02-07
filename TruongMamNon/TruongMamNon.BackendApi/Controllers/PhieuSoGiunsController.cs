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
    public class PhieuSoGiunsController : ControllerBase
    {
        private readonly IPhieuSoGiunRepository _phieuSoGiunRepository;
        private readonly IMapper _mapper;

        public PhieuSoGiunsController(IPhieuSoGiunRepository phieuSoGiunRepository, IMapper mapper)
        {
            _phieuSoGiunRepository = phieuSoGiunRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhieuSoGiun([FromBody] AUPhieuSoGiunRequest request)
        {
            var phieuSoGiun = await _phieuSoGiunRepository.AddPhieuSoGiun(_mapper.Map<PhieuSoGiun>(request));
            return CreatedAtAction(nameof(GetPhieuSoGiun), new { maPhieuSoGiun = phieuSoGiun.MaPhieuSoGiun }, _mapper.Map<PhieuSoGiunVm>(phieuSoGiun));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuSoGiuns()
        {
            var phieuSoGiuns = await _phieuSoGiunRepository.GetPhieuSoGiuns();
            return Ok(_mapper.Map<List<PhieuSoGiunVm>>(phieuSoGiuns));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetPhieuSoGiunsByNienHoc(int maNienHoc)
        {
            var phieuSoGiuns = await _phieuSoGiunRepository.GetPhieuSoGiunsByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<PhieuSoGiunVm>>(phieuSoGiuns));
        }

        [HttpGet("{maPhieuSoGiun}"), ActionName("GetPhieuSoGiun")]
        public async Task<IActionResult> GetPhieuSoGiun([FromRoute] int maPhieuSoGiun)
        {
            var phieuSoGiun = await _phieuSoGiunRepository.GetPhieuSoGiun(maPhieuSoGiun);
            if (phieuSoGiun == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhieuSoGiunVm>(phieuSoGiun));
        }

        [HttpPut("{maPhieuSoGiun}")]
        public async Task<IActionResult> UpdatePhieuSoGiun([FromRoute] int maPhieuSoGiun, [FromBody] AUPhieuSoGiunRequest request)
        {
            if (await _phieuSoGiunRepository.Exists(maPhieuSoGiun))
            {
                var phieuSoGiun = await _phieuSoGiunRepository.UpdatePhieuSoGiun(maPhieuSoGiun, _mapper.Map<PhieuSoGiun>(request));
                if (phieuSoGiun != null)
                {
                    return Ok(_mapper.Map<PhieuSoGiunVm>(phieuSoGiun));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuSoGiun}")]
        public async Task<IActionResult> DeletePhieuSoGiun([FromRoute] int maPhieuSoGiun)
        {
            if (await _phieuSoGiunRepository.Exists(maPhieuSoGiun))
            {
                var phieuSoGiun = await _phieuSoGiunRepository.DeletePhieuSoGiun(maPhieuSoGiun);
                return Ok(_mapper.Map<PhieuSoGiunVm>(phieuSoGiun));
            }
            return NotFound();
        }
    }
}