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
    public class ChiTietPhieuXuatThucPhamsController : ControllerBase
    {
        private readonly IChiTietPhieuXuatThucPhamRepository _chiTietPhieuXuatThucPhamRepository;
        private readonly IMapper _mapper;

        public ChiTietPhieuXuatThucPhamsController(IChiTietPhieuXuatThucPhamRepository chiTietPhieuXuatThucPhamRepository, IMapper mapper)
        {
            _chiTietPhieuXuatThucPhamRepository = chiTietPhieuXuatThucPhamRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddChiTietPhieuXuatThucPham([FromBody] AddChiTietPhieuXuatThucPhamRequest request)
        {
            var chiTietPhieuXuatThucPham = await _chiTietPhieuXuatThucPhamRepository.AddChiTietPhieuXuatThucPham(_mapper.Map<ChiTietPhieuXuatThucPham>(request));
            return CreatedAtAction(nameof(GetChiTietPhieuXuatThucPham), new { maPhieuXuatThucPham = chiTietPhieuXuatThucPham.MaPhieuXuatThucPham, maThucPham = chiTietPhieuXuatThucPham.MaThucPham }, _mapper.Map<ChiTietPhieuXuatThucPhamVm>(chiTietPhieuXuatThucPham));
        }

        [HttpGet("{maPhieuXuatThucPham}")]
        public async Task<IActionResult> GetChiTietPhieuXuatThucPhamsByMaPhieuXuatThucPham(long maPhieuXuatThucPham)
        {
            var chiTietPhieuXuatThucPhams = await _chiTietPhieuXuatThucPhamRepository.GetChiTietPhieuXuatThucPhamsByMaPhieuXuatThucPham(maPhieuXuatThucPham);
            return Ok(_mapper.Map<List<ChiTietPhieuXuatThucPhamVm>>(chiTietPhieuXuatThucPhams));
        }

        [HttpGet("{maPhieuXuatThucPham}/{maThucPham}"), ActionName("GetChiTietPhieuXuatThucPham")]
        public async Task<IActionResult> GetChiTietPhieuXuatThucPham([FromRoute] long maPhieuXuatThucPham, int maThucPham)
        {
            var chiTietPhieuXuatThucPham = await _chiTietPhieuXuatThucPhamRepository.GetChiTietPhieuXuatThucPham(maPhieuXuatThucPham, maThucPham);
            if (chiTietPhieuXuatThucPham == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ChiTietPhieuXuatThucPhamVm>(chiTietPhieuXuatThucPham));
        }

        [HttpPut("{maPhieuXuatThucPham}/{maThucPham}")]
        public async Task<IActionResult> UpdateChiTietPhieuXuatThucPham([FromRoute] long maPhieuXuatThucPham, int maThucPham, [FromBody] UpdateChiTietPhieuXuatThucPhamRequest request)
        {
            if (await _chiTietPhieuXuatThucPhamRepository.Exists(maPhieuXuatThucPham, maThucPham))
            {
                var chiTietPhieuXuatThucPham = await _chiTietPhieuXuatThucPhamRepository.UpdateChiTietPhieuXuatThucPham(maPhieuXuatThucPham, maThucPham, _mapper.Map<ChiTietPhieuXuatThucPham>(request));
                if (chiTietPhieuXuatThucPham != null)
                {
                    return Ok(_mapper.Map<ChiTietPhieuXuatThucPhamVm>(chiTietPhieuXuatThucPham));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuXuatThucPham}/{maThucPham}")]
        public async Task<IActionResult> DeleteChiTietPhieuXuatThucPham([FromRoute] long maPhieuXuatThucPham, int maThucPham)
        {
            if (await _chiTietPhieuXuatThucPhamRepository.Exists(maPhieuXuatThucPham, maThucPham))
            {
                var chiTietPhieuXuatThucPham = await _chiTietPhieuXuatThucPhamRepository.DeleteChiTietPhieuXuatThucPham(maPhieuXuatThucPham, maThucPham);
                return Ok(_mapper.Map<ChiTietPhieuXuatThucPhamVm>(chiTietPhieuXuatThucPham));
            }
            return NotFound();
        }
    }
}