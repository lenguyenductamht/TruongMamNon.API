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
    public class PhieuXuatThucPhamsController : ControllerBase
    {
        private readonly IPhieuXuatThucPhamRepository _phieuXuatThucPhamRepository;
        private readonly IMapper _mapper;

        public PhieuXuatThucPhamsController(IPhieuXuatThucPhamRepository phieuXuatThucPhamRepository, IMapper mapper)
        {
            _phieuXuatThucPhamRepository = phieuXuatThucPhamRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhieuXuatThucPham([FromBody] AddPhieuXuatThucPhamRequest request)
        {
            var phieuXuatThucPham = await _phieuXuatThucPhamRepository.AddPhieuXuatThucPham(_mapper.Map<PhieuXuatThucPham>(request));
            return CreatedAtAction(nameof(GetPhieuXuatThucPham), new { maPhieuXuatThucPham = phieuXuatThucPham.MaPhieuXuatThucPham }, _mapper.Map<PhieuXuatThucPhamVm>(phieuXuatThucPham));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuXuatThucPhams()
        {
            var phieuXuatThucPhams = await _phieuXuatThucPhamRepository.GetPhieuXuatThucPhams();
            return Ok(_mapper.Map<List<PhieuXuatThucPhamVm>>(phieuXuatThucPhams));
        }

        [HttpGet("{maPhieuXuatThucPham}"), ActionName("GetPhieuXuatThucPham")]
        public async Task<IActionResult> GetPhieuXuatThucPham([FromRoute] int maPhieuXuatThucPham)
        {
            var phieuXuatThucPham = await _phieuXuatThucPhamRepository.GetPhieuXuatThucPham(maPhieuXuatThucPham);
            if (phieuXuatThucPham == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhieuXuatThucPhamVm>(phieuXuatThucPham));
        }

        [HttpPut("{maPhieuXuatThucPham}")]
        public async Task<IActionResult> UpdatePhieuXuatThucPham([FromRoute] int maPhieuXuatThucPham, [FromBody] UpdatePhieuXuatThucPhamRequest request)
        {
            if (await _phieuXuatThucPhamRepository.Exists(maPhieuXuatThucPham))
            {
                var phieuXuatThucPham = await _phieuXuatThucPhamRepository.UpdatePhieuXuatThucPham(maPhieuXuatThucPham, _mapper.Map<PhieuXuatThucPham>(request));
                if (phieuXuatThucPham != null)
                {
                    return Ok(_mapper.Map<PhieuXuatThucPhamVm>(phieuXuatThucPham));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuXuatThucPham}")]
        public async Task<IActionResult> DeletePhieuXuatThucPham([FromRoute] int maPhieuXuatThucPham)
        {
            if (await _phieuXuatThucPhamRepository.Exists(maPhieuXuatThucPham))
            {
                var phieuXuatThucPham = await _phieuXuatThucPhamRepository.DeletePhieuXuatThucPham(maPhieuXuatThucPham);
                return Ok(_mapper.Map<PhieuXuatThucPhamVm>(phieuXuatThucPham));
            }
            return NotFound();
        }
    }
}