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
    public class PhieuNhapThucPhamsController : ControllerBase
    {
        private readonly IPhieuNhapThucPhamRepository _phieuNhapThucPhamRepository;
        private readonly IMapper _mapper;

        public PhieuNhapThucPhamsController(IPhieuNhapThucPhamRepository phieuNhapThucPhamRepository, IMapper mapper)
        {
            _phieuNhapThucPhamRepository = phieuNhapThucPhamRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhieuNhapThucPham([FromBody] AddPhieuNhapThucPhamRequest request)
        {
            var phieuNhapThucPham = await _phieuNhapThucPhamRepository.AddPhieuNhapThucPham(_mapper.Map<PhieuNhapThucPham>(request));
            return CreatedAtAction(nameof(GetPhieuNhapThucPham), new { maPhieuNhapThucPham = phieuNhapThucPham.MaPhieuNhapThucPham }, _mapper.Map<PhieuNhapThucPhamVm>(phieuNhapThucPham));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuNhapThucPhams()
        {
            var phieuNhapThucPhams = await _phieuNhapThucPhamRepository.GetPhieuNhapThucPhams();
            return Ok(_mapper.Map<List<PhieuNhapThucPhamVm>>(phieuNhapThucPhams));
        }

        [HttpGet("{maPhieuNhapThucPham}"), ActionName("GetPhieuNhapThucPham")]
        public async Task<IActionResult> GetPhieuNhapThucPham([FromRoute] int maPhieuNhapThucPham)
        {
            var phieuNhapThucPham = await _phieuNhapThucPhamRepository.GetPhieuNhapThucPham(maPhieuNhapThucPham);
            if (phieuNhapThucPham == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhieuNhapThucPhamVm>(phieuNhapThucPham));
        }

        [HttpPut("{maPhieuNhapThucPham}")]
        public async Task<IActionResult> UpdatePhieuNhapThucPham([FromRoute] int maPhieuNhapThucPham, [FromBody] UpdatePhieuNhapThucPhamRequest request)
        {
            if (await _phieuNhapThucPhamRepository.Exists(maPhieuNhapThucPham))
            {
                var phieuNhapThucPham = await _phieuNhapThucPhamRepository.UpdatePhieuNhapThucPham(maPhieuNhapThucPham, _mapper.Map<PhieuNhapThucPham>(request));
                if (phieuNhapThucPham != null)
                {
                    return Ok(_mapper.Map<PhieuNhapThucPhamVm>(phieuNhapThucPham));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuNhapThucPham}")]
        public async Task<IActionResult> DeletePhieuNhapThucPham([FromRoute] int maPhieuNhapThucPham)
        {
            if (await _phieuNhapThucPhamRepository.Exists(maPhieuNhapThucPham))
            {
                var phieuNhapThucPham = await _phieuNhapThucPhamRepository.DeletePhieuNhapThucPham(maPhieuNhapThucPham);
                return Ok(_mapper.Map<PhieuNhapThucPhamVm>(phieuNhapThucPham));
            }
            return NotFound();
        }
    }
}