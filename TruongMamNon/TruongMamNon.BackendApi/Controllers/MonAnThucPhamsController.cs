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
    public class MonAnThucPhamsController : ControllerBase
    {
        private readonly IMonAnThucPhamRepository _monAnThucPhamRepository;
        private readonly IMapper _mapper;

        public MonAnThucPhamsController(IMonAnThucPhamRepository monAnThucPhamRepository, IMapper mapper)
        {
            _monAnThucPhamRepository = monAnThucPhamRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddMonAnThucPham([FromBody] AddMonAnThucPhamRequest request)
        {
            var monAnThucPham = await _monAnThucPhamRepository.AddMonAnThucPham(_mapper.Map<MonAnThucPham>(request));
            return CreatedAtAction(nameof(GetMonAnThucPham), new { maMonAn = monAnThucPham.MaMonAn, maThucPham = monAnThucPham.MaThucPham }, _mapper.Map<MonAnThucPhamVm>(monAnThucPham));
        }

        [HttpGet("{maMonAn}")]
        public async Task<IActionResult> GetMonAnThucPhamsByMaPhieuNhapThucPham(int maMonAn)
        {
            var monAnThucPhams = await _monAnThucPhamRepository.GetMonAnThucPhamsByMonAn(maMonAn);
            return Ok(_mapper.Map<List<MonAnThucPhamVm>>(monAnThucPhams));
        }

        [HttpGet("{maMonAn}/{maThucPham}"), ActionName("GetMonAnThucPham")]
        public async Task<IActionResult> GetMonAnThucPham([FromRoute] int maMonAn, int maThucPham)
        {
            var monAnThucPham = await _monAnThucPhamRepository.GetMonAnThucPham(maMonAn, maThucPham);
            if (monAnThucPham == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<MonAnThucPhamVm>(monAnThucPham));
        }

        [HttpPut("{maMonAn}/{maThucPham}")]
        public async Task<IActionResult> UpdateMonAnThucPham([FromRoute] int maMonAn, int maThucPham, [FromBody] UpdateMonAnThucPhamRequest request)
        {
            if (await _monAnThucPhamRepository.Exists(maMonAn, maThucPham))
            {
                var monAnThucPham = await _monAnThucPhamRepository.UpdateMonAnThucPham(maMonAn, maThucPham, _mapper.Map<MonAnThucPham>(request));
                if (monAnThucPham != null)
                {
                    return Ok(_mapper.Map<MonAnThucPhamVm>(monAnThucPham));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maMonAn}/{maThucPham}")]
        public async Task<IActionResult> DeleteMonAnThucPham([FromRoute] int maMonAn, int maThucPham)
        {
            if (await _monAnThucPhamRepository.Exists(maMonAn, maThucPham))
            {
                var monAnThucPham = await _monAnThucPhamRepository.DeleteMonAnThucPham(maMonAn, maThucPham);
                return Ok(_mapper.Map<MonAnThucPhamVm>(monAnThucPham));
            }
            return NotFound();
        }
    }
}