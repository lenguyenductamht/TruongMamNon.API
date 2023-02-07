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
    public class MonAnsController : ControllerBase
    {
        private readonly IMonAnRepository _monAnRepository;
        private readonly IMapper _mapper;

        public MonAnsController(IMonAnRepository monAnRepository, IMapper mapper)
        {
            _monAnRepository = monAnRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddMonAn([FromBody] AddMonAnRequest request)
        {
            var monAn = await _monAnRepository.AddMonAn(_mapper.Map<MonAn>(request));
            return CreatedAtAction(nameof(GetMonAn), new { maMonAn = monAn.MaMonAn }, _mapper.Map<MonAnVm>(monAn));
        }

        [HttpGet]
        public async Task<IActionResult> GetMonAns()
        {
            var monAns = await _monAnRepository.GetMonAns();
            return Ok(_mapper.Map<List<MonAnVm>>(monAns));
        }

        [HttpGet("{maMonAn}"), ActionName("GetMonAn")]
        public async Task<IActionResult> GetMonAn([FromRoute] int maMonAn)
        {
            var monAn = await _monAnRepository.GetMonAn(maMonAn);
            if (monAn == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MonAnVm>(monAn));
        }

        [HttpPut("{maMonAn}")]
        public async Task<IActionResult> UpdateMonAn([FromRoute] int maMonAn, [FromBody] UpdateMonAnRequest request)
        {
            if (await _monAnRepository.Exists(maMonAn))
            {
                var monAn = await _monAnRepository.UpdateMonAn(maMonAn, _mapper.Map<MonAn>(request));
                if (monAn != null)
                {
                    return Ok(_mapper.Map<MonAnVm>(monAn));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maMonAn}")]
        public async Task<IActionResult> DeleteMonAn([FromRoute] int maMonAn)
        {
            if (await _monAnRepository.Exists(maMonAn))
            {
                var monAn = await _monAnRepository.DeleteMonAn(maMonAn);
                return Ok(_mapper.Map<MonAnVm>(monAn));
            }
            return NotFound();
        }
    }
}