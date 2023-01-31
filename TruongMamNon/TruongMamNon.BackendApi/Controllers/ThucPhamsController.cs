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
    public class ThucPhamsController : ControllerBase
    {
        private readonly IThucPhamRepository _thucPhamRepository;
        private readonly IMapper _mapper;

        public ThucPhamsController(IThucPhamRepository thucPhamRepository, IMapper mapper)
        {
            _thucPhamRepository = thucPhamRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddThucPham([FromBody] AUThucPhamRequest request)
        {
            var thucPham = await _thucPhamRepository.AddThucPham(_mapper.Map<ThucPham>(request));
            return CreatedAtAction(nameof(GetThucPham), new { maThucPham = thucPham.MaThucPham }, _mapper.Map<ThucPhamVm>(thucPham));
        }

        [HttpGet]
        public async Task<IActionResult> GetThucPhams()
        {
            var thucPhams = await _thucPhamRepository.GetThucPhams();
            return Ok(_mapper.Map<List<ThucPhamVm>>(thucPhams));
        }

        [HttpGet("{maThucPham}"), ActionName("GetThucPham")]
        public async Task<IActionResult> GetThucPham([FromRoute] int maThucPham)
        {
            var thucPham = await _thucPhamRepository.GetThucPham(maThucPham);
            if (thucPham == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ThucPhamVm>(thucPham));
        }

        [HttpPut("{maThucPham}")]
        public async Task<IActionResult> UpdateThucPham([FromRoute] int maThucPham, [FromBody] AUThucPhamRequest request)
        {
            if (await _thucPhamRepository.Exists(maThucPham))
            {
                var thucPham = await _thucPhamRepository.UpdateThucPham(maThucPham, _mapper.Map<ThucPham>(request));
                if (thucPham != null)
                {
                    return Ok(_mapper.Map<ThucPhamVm>(thucPham));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maThucPham}")]
        public async Task<IActionResult> DeleteThucPham([FromRoute] int maThucPham)
        {
            if (await _thucPhamRepository.Exists(maThucPham))
            {
                var thucPham = await _thucPhamRepository.DeleteThucPham(maThucPham);
                return Ok(_mapper.Map<ThucPhamVm>(thucPham));
            }
            return NotFound();
        }

        [HttpPut("{maThucPham}/TangSoLuong/{soLuongTang}")]
        public async Task<IActionResult> TangSoLuong(int maThucPham, double soLuongTang)
        {
            if (await _thucPhamRepository.Exists(maThucPham))
            {
                var thucPham = await _thucPhamRepository.TangSoLuong(maThucPham, soLuongTang);
                if (thucPham != null)
                {
                    return Ok(_mapper.Map<ThucPhamVm>(thucPham));
                }
            }
            return NotFound();
        }

        [HttpPut("{maThucPham}/GiamSoLuong/{soLuongGiam}")]
        public async Task<IActionResult> GiamSoLuong(int maThucPham, double soLuongGiam)
        {
            if (await _thucPhamRepository.Exists(maThucPham))
            {
                var thucPham = await _thucPhamRepository.GiamSoLuong(maThucPham, soLuongGiam);
                if (thucPham != null)
                {
                    return Ok(_mapper.Map<ThucPhamVm>(thucPham));
                }
            }
            return NotFound();
        }
    }
}