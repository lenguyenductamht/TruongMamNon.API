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
    public class ThucDonMonAnsController : ControllerBase
    {
        private readonly IThucDonMonAnRepository _thucDonMonAnRepository;
        private readonly IMapper _mapper;

        public ThucDonMonAnsController(IThucDonMonAnRepository thucDonMonAnRepository, IMapper mapper)
        {
            _thucDonMonAnRepository = thucDonMonAnRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddThucDonMonAn([FromBody] AddThucDonMonAnRequest request)
        {
            var thucDonMonAn = await _thucDonMonAnRepository.AddThucDonMonAn(_mapper.Map<ThucDonMonAn>(request));
            return CreatedAtAction(nameof(GetThucDonMonAn), new { maThucDon = thucDonMonAn.MaThucDon, maMonAn = thucDonMonAn.MaMonAn }, _mapper.Map<ThucDonMonAnVm>(thucDonMonAn));
        }

        [HttpGet("{maThucDon}")]
        public async Task<IActionResult> GetThucDonMonAnsByThucDon(int maThucDon)
        {
            var thucDonMonAns = await _thucDonMonAnRepository.GetThucDonMonAnsByThucDon(maThucDon);
            return Ok(_mapper.Map<List<ThucDonMonAnVm>>(thucDonMonAns));
        }

        [HttpGet("{maThucDon}/{maMonAn}"), ActionName("GetThucDonMonAn")]
        public async Task<IActionResult> GetThucDonMonAn([FromRoute] int maThucDon, int maMonAn)
        {
            var thucDonMonAn = await _thucDonMonAnRepository.GetThucDonMonAn(maThucDon, maMonAn);
            if (thucDonMonAn == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ThucDonMonAnVm>(thucDonMonAn));
        }

        [HttpPut("{maThucDon}/{maMonAn}")]
        public async Task<IActionResult> UpdateThucDonMonAn([FromRoute] int maThucDon, int maMonAn, [FromBody] UpdateThucDonMonAnRequest request)
        {
            if (await _thucDonMonAnRepository.Exists(maThucDon, maMonAn))
            {
                var thucDonMonAn = await _thucDonMonAnRepository.UpdateThucDonMonAn(maThucDon, maMonAn, _mapper.Map<ThucDonMonAn>(request));
                if (thucDonMonAn != null)
                {
                    return Ok(_mapper.Map<ThucDonMonAnVm>(thucDonMonAn));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maThucDon}/{maMonAn}")]
        public async Task<IActionResult> DeleteThucDonMonAn([FromRoute] int maThucDon, int maMonAn)
        {
            if (await _thucDonMonAnRepository.Exists(maThucDon, maMonAn))
            {
                var thucDonMonAn = await _thucDonMonAnRepository.DeleteThucDonMonAn(maThucDon, maMonAn);
                return Ok(_mapper.Map<ThucDonMonAnVm>(thucDonMonAn));
            }
            return NotFound();
        }
    }
}