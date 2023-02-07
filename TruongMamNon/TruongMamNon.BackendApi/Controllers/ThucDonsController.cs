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
    public class ThucDonsController : ControllerBase
    {
        private readonly IThucDonRepository _thucDonRepository;
        private readonly IMapper _mapper;

        public ThucDonsController(IThucDonRepository thucDonRepository, IMapper mapper)
        {
            _thucDonRepository = thucDonRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddThucDon([FromBody] AddThucDonRequest request)
        {
            var thucDon = await _thucDonRepository.AddThucDon(_mapper.Map<ThucDon>(request));
            return CreatedAtAction(nameof(GetThucDon), new { maThucDon = thucDon.MaThucDon }, _mapper.Map<ThucDonVm>(thucDon));
        }

        [HttpGet]
        public async Task<IActionResult> GetThucDons()
        {
            var thucDons = await _thucDonRepository.GetThucDons();
            return Ok(_mapper.Map<List<ThucDonVm>>(thucDons));
        }

        [HttpGet("{maThucDon}"), ActionName("GetThucDon")]
        public async Task<IActionResult> GetThucDon([FromRoute] int maThucDon)
        {
            var thucDon = await _thucDonRepository.GetThucDon(maThucDon);
            if (thucDon == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ThucDonVm>(thucDon));
        }

        [HttpPut("{maThucDon}")]
        public async Task<IActionResult> UpdateThucDon([FromRoute] int maThucDon, [FromBody] UpdateThucDonRequest request)
        {
            if (await _thucDonRepository.Exists(maThucDon))
            {
                var thucDon = await _thucDonRepository.UpdateThucDon(maThucDon, _mapper.Map<ThucDon>(request));
                if (thucDon != null)
                {
                    return Ok(_mapper.Map<ThucDonVm>(thucDon));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maThucDon}")]
        public async Task<IActionResult> DeleteThucDon([FromRoute] int maThucDon)
        {
            if (await _thucDonRepository.Exists(maThucDon))
            {
                var thucDon = await _thucDonRepository.DeleteThucDon(maThucDon);
                return Ok(_mapper.Map<ThucDonVm>(thucDon));
            }
            return NotFound();
        }
    }
}