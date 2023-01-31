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
    public class VaccinesController : ControllerBase
    {
        private readonly IVaccineRepository _vaccineRepository;
        private readonly IMapper _mapper;

        public VaccinesController(IVaccineRepository vaccineRepository, IMapper mapper)
        {
            _vaccineRepository = vaccineRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddVaccine([FromBody] AUVaccineRequest request)
        {
            var vaccine = await _vaccineRepository.AddVaccine(_mapper.Map<Vaccine>(request));
            return CreatedAtAction(nameof(GetVaccine), new { maVaccine = vaccine.MaVaccine }, _mapper.Map<VaccineVm>(vaccine));
        }

        [HttpGet]
        public async Task<IActionResult> GetVaccines()
        {
            var vaccines = await _vaccineRepository.GetVaccines();
            return Ok(_mapper.Map<List<VaccineVm>>(vaccines));
        }

        [HttpGet("{maVaccine}"), ActionName("GetVaccine")]
        public async Task<IActionResult> GetVaccine([FromRoute] int maVaccine)
        {
            var vaccine = await _vaccineRepository.GetVaccine(maVaccine);
            if (vaccine == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VaccineVm>(vaccine));
        }

        [HttpPut("{maVaccine}")]
        public async Task<IActionResult> UpdateVaccine([FromRoute] int maVaccine, [FromBody] AUVaccineRequest request)
        {
            if (await _vaccineRepository.Exists(maVaccine))
            {
                var vaccine = await _vaccineRepository.UpdateVaccine(maVaccine, _mapper.Map<Vaccine>(request));
                if (vaccine != null)
                {
                    return Ok(_mapper.Map<VaccineVm>(vaccine));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maVaccine}")]
        public async Task<IActionResult> DeleteVaccine([FromRoute] int maVaccine)
        {
            if (await _vaccineRepository.Exists(maVaccine))
            {
                var vaccine = await _vaccineRepository.DeleteVaccine(maVaccine);
                return Ok(_mapper.Map<VaccineVm>(vaccine));
            }
            return NotFound();
        }
    }
}