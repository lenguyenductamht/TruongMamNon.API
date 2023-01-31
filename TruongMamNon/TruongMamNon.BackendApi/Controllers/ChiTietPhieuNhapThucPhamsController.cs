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
    public class ChiTietPhieuNhapThucPhamsController : ControllerBase
    {
        private readonly IChiTietPhieuNhapThucPhamRepository _chiTietPhieuNhapThucPhamRepository;
        private readonly IMapper _mapper;

        public ChiTietPhieuNhapThucPhamsController(IChiTietPhieuNhapThucPhamRepository chiTietPhieuNhapThucPhamRepository, IMapper mapper)
        {
            _chiTietPhieuNhapThucPhamRepository = chiTietPhieuNhapThucPhamRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddChiTietPhieuNhapThucPham([FromBody] AddChiTietPhieuNhapThucPhamRequest request)
        {
            var chiTietPhieuNhapThucPham = await _chiTietPhieuNhapThucPhamRepository.AddChiTietPhieuNhapThucPham(_mapper.Map<ChiTietPhieuNhapThucPham>(request));
            return CreatedAtAction(nameof(GetChiTietPhieuNhapThucPham), new { maPhieuNhapThucPham = chiTietPhieuNhapThucPham.MaPhieuNhapThucPham, maThucPham = chiTietPhieuNhapThucPham.MaThucPham }, _mapper.Map<ChiTietPhieuNhapThucPhamVm>(chiTietPhieuNhapThucPham));
        }

        [HttpGet("{maPhieuNhapThucPham}")]
        public async Task<IActionResult> GetChiTietPhieuNhapThucPhamsByMaPhieuNhapThucPham(long maPhieuNhapThucPham)
        {
            var chiTietPhieuNhapThucPhams = await _chiTietPhieuNhapThucPhamRepository.GetChiTietPhieuNhapThucPhamsByMaPhieuNhapThucPham(maPhieuNhapThucPham);
            return Ok(_mapper.Map<List<ChiTietPhieuNhapThucPhamVm>>(chiTietPhieuNhapThucPhams));
        }

        [HttpGet("{maPhieuNhapThucPham}/{maThucPham}"), ActionName("GetChiTietPhieuNhapThucPham")]
        public async Task<IActionResult> GetChiTietPhieuNhapThucPham([FromRoute] long maPhieuNhapThucPham, int maThucPham)
        {
            var chiTietPhieuNhapThucPham = await _chiTietPhieuNhapThucPhamRepository.GetChiTietPhieuNhapThucPham(maPhieuNhapThucPham, maThucPham);
            if (chiTietPhieuNhapThucPham == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ChiTietPhieuNhapThucPhamVm>(chiTietPhieuNhapThucPham));
        }

        [HttpPut("{maPhieuNhapThucPham}/{maThucPham}")]
        public async Task<IActionResult> UpdateChiTietPhieuNhapThucPham([FromRoute] long maPhieuNhapThucPham, int maThucPham, [FromBody] UpdateChiTietPhieuNhapThucPhamRequest request)
        {
            if (await _chiTietPhieuNhapThucPhamRepository.Exists(maPhieuNhapThucPham, maThucPham))
            {
                var chiTietPhieuNhapThucPham = await _chiTietPhieuNhapThucPhamRepository.UpdateChiTietPhieuNhapThucPham(maPhieuNhapThucPham, maThucPham, _mapper.Map<ChiTietPhieuNhapThucPham>(request));
                if (chiTietPhieuNhapThucPham != null)
                {
                    return Ok(_mapper.Map<ChiTietPhieuNhapThucPhamVm>(chiTietPhieuNhapThucPham));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuNhapThucPham}/{maThucPham}")]
        public async Task<IActionResult> DeleteChiTietPhieuNhapThucPham([FromRoute] long maPhieuNhapThucPham, int maThucPham)
        {
            if (await _chiTietPhieuNhapThucPhamRepository.Exists(maPhieuNhapThucPham, maThucPham))
            {
                var chiTietPhieuNhapThucPham = await _chiTietPhieuNhapThucPhamRepository.DeleteChiTietPhieuNhapThucPham(maPhieuNhapThucPham, maThucPham);
                return Ok(_mapper.Map<ChiTietPhieuNhapThucPhamVm>(chiTietPhieuNhapThucPham));
            }
            return NotFound();
        }
    }
}