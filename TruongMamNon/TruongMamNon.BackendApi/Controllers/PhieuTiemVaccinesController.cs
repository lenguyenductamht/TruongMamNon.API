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
    public class PhieuTiemVaccinesController : ControllerBase
    {
        private readonly IPhieuTiemVaccineRepository _phieuTiemVaccineRepository;
        private readonly IMapper _mapper;

        public PhieuTiemVaccinesController(IPhieuTiemVaccineRepository phieuTiemVaccineRepository, IMapper mapper)
        {
            _phieuTiemVaccineRepository = phieuTiemVaccineRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhieuTiemVaccine([FromBody] AUPhieuTiemVaccineRequest request)
        {
            var phieuTiemVaccine = await _phieuTiemVaccineRepository.AddPhieuTiemVaccine(_mapper.Map<PhieuTiemVaccine>(request));
            return CreatedAtAction(nameof(GetPhieuTiemVaccine), new { maPhieuTiemVaccine = phieuTiemVaccine.MaPhieuTiemVaccine }, _mapper.Map<PhieuTiemVaccineVm>(phieuTiemVaccine));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuTiemVaccines()
        {
            var phieuTiemVaccines = await _phieuTiemVaccineRepository.GetPhieuTiemVaccines();
            return Ok(_mapper.Map<List<PhieuTiemVaccineVm>>(phieuTiemVaccines));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetPhieuTiemVaccinesByNienHoc(int maNienHoc)
        {
            var phieuTiemVaccines = await _phieuTiemVaccineRepository.GetPhieuTiemVaccinesByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<PhieuTiemVaccineVm>>(phieuTiemVaccines));
        }

        [HttpGet("{maPhieuTiemVaccine}"), ActionName("GetPhieuTiemVaccine")]
        public async Task<IActionResult> GetPhieuTiemVaccine([FromRoute] int maPhieuTiemVaccine)
        {
            var phieuTiemVaccine = await _phieuTiemVaccineRepository.GetPhieuTiemVaccine(maPhieuTiemVaccine);
            if (phieuTiemVaccine == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhieuTiemVaccineVm>(phieuTiemVaccine));
        }

        [HttpPut("{maPhieuTiemVaccine}")]
        public async Task<IActionResult> UpdatePhieuTiemVaccine([FromRoute] int maPhieuTiemVaccine, [FromBody] AUPhieuTiemVaccineRequest request)
        {
            if (await _phieuTiemVaccineRepository.Exists(maPhieuTiemVaccine))
            {
                var phieuTiemVaccine = await _phieuTiemVaccineRepository.UpdatePhieuTiemVaccine(maPhieuTiemVaccine, _mapper.Map<PhieuTiemVaccine>(request));
                if (phieuTiemVaccine != null)
                {
                    return Ok(_mapper.Map<PhieuTiemVaccineVm>(phieuTiemVaccine));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuTiemVaccine}")]
        public async Task<IActionResult> DeletePhieuTiemVaccine([FromRoute] int maPhieuTiemVaccine)
        {
            if (await _phieuTiemVaccineRepository.Exists(maPhieuTiemVaccine))
            {
                var phieuTiemVaccine = await _phieuTiemVaccineRepository.DeletePhieuTiemVaccine(maPhieuTiemVaccine);
                return Ok(_mapper.Map<PhieuTiemVaccineVm>(phieuTiemVaccine));
            }
            return NotFound();
        }
    }
}