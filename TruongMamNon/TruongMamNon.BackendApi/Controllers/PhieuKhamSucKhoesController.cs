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
    public class PhieuKhamSucKhoesController : ControllerBase
    {
        private readonly IPhieuKhamSucKhoeRepository _phieuKhamSucKhoeRepository;
        private readonly IMapper _mapper;

        public PhieuKhamSucKhoesController(IPhieuKhamSucKhoeRepository phieuKhamSucKhoeRepository, IMapper mapper)
        {
            _phieuKhamSucKhoeRepository = phieuKhamSucKhoeRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddPhieuKhamSucKhoe([FromBody] AUPhieuKhamSucKhoeRequest request)
        {
            var phieuKhamSucKhoe = await _phieuKhamSucKhoeRepository.AddPhieuKhamSucKhoe(_mapper.Map<PhieuKhamSucKhoe>(request));
            return CreatedAtAction(nameof(GetPhieuKhamSucKhoe), new { maPhieuKhamSucKhoe = phieuKhamSucKhoe.MaPhieuKhamSucKhoe }, _mapper.Map<PhieuKhamSucKhoeVm>(phieuKhamSucKhoe));
        }

        [HttpGet]
        public async Task<IActionResult> GetPhieuKhamSucKhoes()
        {
            var phieuKhamSucKhoes = await _phieuKhamSucKhoeRepository.GetPhieuKhamSucKhoes();
            return Ok(_mapper.Map<List<PhieuKhamSucKhoeVm>>(phieuKhamSucKhoes));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetPhieuKhamSucKhoesByNienHoc(int maNienHoc)
        {
            var phieuKhamSucKhoes = await _phieuKhamSucKhoeRepository.GetPhieuKhamSucKhoesByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<PhieuKhamSucKhoeVm>>(phieuKhamSucKhoes));
        }

        [HttpGet("{maPhieuKhamSucKhoe}"), ActionName("GetPhieuKhamSucKhoe")]
        public async Task<IActionResult> GetPhieuKhamSucKhoe([FromRoute] int maPhieuKhamSucKhoe)
        {
            var phieuKhamSucKhoe = await _phieuKhamSucKhoeRepository.GetPhieuKhamSucKhoe(maPhieuKhamSucKhoe);
            if (phieuKhamSucKhoe == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PhieuKhamSucKhoeVm>(phieuKhamSucKhoe));
        }

        [HttpPut("{maPhieuKhamSucKhoe}")]
        public async Task<IActionResult> UpdatePhieuKhamSucKhoe([FromRoute] int maPhieuKhamSucKhoe, [FromBody] AUPhieuKhamSucKhoeRequest request)
        {
            if (await _phieuKhamSucKhoeRepository.Exists(maPhieuKhamSucKhoe))
            {
                var phieuKhamSucKhoe = await _phieuKhamSucKhoeRepository.UpdatePhieuKhamSucKhoe(maPhieuKhamSucKhoe, _mapper.Map<PhieuKhamSucKhoe>(request));
                if (phieuKhamSucKhoe != null)
                {
                    return Ok(_mapper.Map<PhieuKhamSucKhoeVm>(phieuKhamSucKhoe));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maPhieuKhamSucKhoe}")]
        public async Task<IActionResult> DeletePhieuKhamSucKhoe([FromRoute] int maPhieuKhamSucKhoe)
        {
            if (await _phieuKhamSucKhoeRepository.Exists(maPhieuKhamSucKhoe))
            {
                var phieuKhamSucKhoe = await _phieuKhamSucKhoeRepository.DeletePhieuKhamSucKhoe(maPhieuKhamSucKhoe);
                return Ok(_mapper.Map<PhieuKhamSucKhoeVm>(phieuKhamSucKhoe));
            }
            return NotFound();
        }
    }
}