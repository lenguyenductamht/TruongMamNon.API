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
    public class VitaminsController : ControllerBase
    {
        private readonly IVitaminRepository _vitaminRepository;
        private readonly IMapper _mapper;

        public VitaminsController(IVitaminRepository vitaminRepository, IMapper mapper)
        {
            _vitaminRepository = vitaminRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddVitamin([FromBody] AUVitaminRequest request)
        {
            var vitamin = await _vitaminRepository.AddVitamin(_mapper.Map<Vitamin>(request));
            return CreatedAtAction(nameof(GetVitamin), new { maVitamin = vitamin.MaVitamin }, _mapper.Map<VitaminVm>(vitamin));
        }

        [HttpGet]
        public async Task<IActionResult> GetVitamins()
        {
            var vitamins = await _vitaminRepository.GetVitamins();
            return Ok(_mapper.Map<List<VitaminVm>>(vitamins));
        }

        [HttpGet("{maVitamin}"), ActionName("GetVitamin")]
        public async Task<IActionResult> GetVitamin([FromRoute] int maVitamin)
        {
            var vitamin = await _vitaminRepository.GetVitamin(maVitamin);
            if (vitamin == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VitaminVm>(vitamin));
        }

        [HttpPut("{maVitamin}")]
        public async Task<IActionResult> UpdateVitamin([FromRoute] int maVitamin, [FromBody] AUVitaminRequest request)
        {
            if (await _vitaminRepository.Exists(maVitamin))
            {
                var vitamin = await _vitaminRepository.UpdateVitamin(maVitamin, _mapper.Map<Vitamin>(request));
                if (vitamin != null)
                {
                    return Ok(_mapper.Map<VitaminVm>(vitamin));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maVitamin}")]
        public async Task<IActionResult> DeleteVitamin([FromRoute] int maVitamin)
        {
            if (await _vitaminRepository.Exists(maVitamin))
            {
                var vitamin = await _vitaminRepository.DeleteVitamin(maVitamin);
                return Ok(_mapper.Map<VitaminVm>(vitamin));
            }
            return NotFound();
        }
    }
}