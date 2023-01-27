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
    public class DotTiemVaccinesController : ControllerBase
    {
        private readonly IDotTiemVaccineRepository _dotTiemVaccineRepository;
        private readonly IMapper _mapper;

        public DotTiemVaccinesController(IDotTiemVaccineRepository dotTiemVaccineRepository, IMapper mapper)
        {
            _dotTiemVaccineRepository = dotTiemVaccineRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddDotTiemVaccine([FromBody] AUDotTiemVaccineRequest request)
        {
            var dotTiemVaccine = await _dotTiemVaccineRepository.AddDotTiemVaccine(_mapper.Map<DotTiemVaccine>(request));
            return CreatedAtAction(nameof(GetDotTiemVaccine), new { maDotTiemVaccine = dotTiemVaccine.MaDotTiemVaccine }, _mapper.Map<DotTiemVaccineVm>(dotTiemVaccine));
        }

        [HttpGet]
        public async Task<IActionResult> GetDotTiemVaccines()
        {
            var dotTiemVaccines = await _dotTiemVaccineRepository.GetDotTiemVaccines();
            return Ok(_mapper.Map<List<DotTiemVaccineVm>>(dotTiemVaccines));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetDotTiemVaccinesByNienHoc(int maNienHoc)
        {
            var dotTiemVaccines = await _dotTiemVaccineRepository.GetDotTiemVaccinesByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<DotTiemVaccineVm>>(dotTiemVaccines));
        }

        [HttpGet("{maDotTiemVaccine}"), ActionName("GetDotTiemVaccine")]
        public async Task<IActionResult> GetDotTiemVaccine([FromRoute] int maDotTiemVaccine)
        {
            var dotTiemVaccine = await _dotTiemVaccineRepository.GetDotTiemVaccine(maDotTiemVaccine);
            if (dotTiemVaccine == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DotTiemVaccineVm>(dotTiemVaccine));
        }

        [HttpPut("{maDotTiemVaccine}")]
        public async Task<IActionResult> UpdateDotTiemVaccine([FromRoute] int maDotTiemVaccine, [FromBody] AUDotTiemVaccineRequest request)
        {
            if (await _dotTiemVaccineRepository.Exists(maDotTiemVaccine))
            {
                var dotTiemVaccine = await _dotTiemVaccineRepository.UpdateDotTiemVaccine(maDotTiemVaccine, _mapper.Map<DotTiemVaccine>(request));
                if (dotTiemVaccine != null)
                {
                    return Ok(_mapper.Map<DotTiemVaccineVm>(dotTiemVaccine));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maDotTiemVaccine}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int maDotTiemVaccine)
        {
            if (await _dotTiemVaccineRepository.Exists(maDotTiemVaccine))
            {
                var dotTiemVaccine = await _dotTiemVaccineRepository.DeleteDotTiemVaccine(maDotTiemVaccine);
                return Ok(_mapper.Map<DotTiemVaccineVm>(dotTiemVaccine));
            }
            return NotFound();
        }
    }
}