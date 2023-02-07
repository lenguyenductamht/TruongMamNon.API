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
    public class DotKhamSucKhoesController : ControllerBase
    {
        private readonly IDotKhamSucKhoeRepository _dotKhamSucKhoeRepository;
        private readonly IMapper _mapper;

        public DotKhamSucKhoesController(IDotKhamSucKhoeRepository dotKhamSucKhoeRepository, IMapper mapper)
        {
            _dotKhamSucKhoeRepository = dotKhamSucKhoeRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddDotKhamSucKhoe([FromBody] AUDotKhamSucKhoeRequest request)
        {
            var dotKhamSucKhoe = await _dotKhamSucKhoeRepository.AddDotKhamSucKhoe(_mapper.Map<DotKhamSucKhoe>(request));
            return CreatedAtAction(nameof(GetDotKhamSucKhoe), new { maDotKhamSucKhoe = dotKhamSucKhoe.MaDotKhamSucKhoe }, _mapper.Map<DotKhamSucKhoeVm>(dotKhamSucKhoe));
        }

        [HttpGet]
        public async Task<IActionResult> GetDotKhamSucKhoes()
        {
            var dotKhamSucKhoes = await _dotKhamSucKhoeRepository.GetDotKhamSucKhoes();
            return Ok(_mapper.Map<List<DotKhamSucKhoeVm>>(dotKhamSucKhoes));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetDotKhamSucKhoesByNienHoc(int maNienHoc)
        {
            var dotKhamSucKhoes = await _dotKhamSucKhoeRepository.GetDotKhamSucKhoesByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<DotKhamSucKhoeVm>>(dotKhamSucKhoes));
        }

        [HttpGet("{maDotKhamSucKhoe}"), ActionName("GetDotKhamSucKhoe")]
        public async Task<IActionResult> GetDotKhamSucKhoe([FromRoute] int maDotKhamSucKhoe)
        {
            var dotKhamSucKhoe = await _dotKhamSucKhoeRepository.GetDotKhamSucKhoe(maDotKhamSucKhoe);
            if (dotKhamSucKhoe == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DotKhamSucKhoeVm>(dotKhamSucKhoe));
        }

        [HttpPut("{maDotKhamSucKhoe}")]
        public async Task<IActionResult> UpdateDotKhamSucKhoe([FromRoute] int maDotKhamSucKhoe, [FromBody] AUDotKhamSucKhoeRequest request)
        {
            if (await _dotKhamSucKhoeRepository.Exists(maDotKhamSucKhoe))
            {
                var dotKhamSucKhoe = await _dotKhamSucKhoeRepository.UpdateDotKhamSucKhoe(maDotKhamSucKhoe, _mapper.Map<DotKhamSucKhoe>(request));
                if (dotKhamSucKhoe != null)
                {
                    return Ok(_mapper.Map<DotKhamSucKhoeVm>(dotKhamSucKhoe));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maDotKhamSucKhoe}")]
        public async Task<IActionResult> DeleteDotKhamSucKhoe([FromRoute] int maDotKhamSucKhoe)
        {
            if (await _dotKhamSucKhoeRepository.Exists(maDotKhamSucKhoe))
            {
                var dotKhamSucKhoe = await _dotKhamSucKhoeRepository.DeleteDotKhamSucKhoe(maDotKhamSucKhoe);
                return Ok(_mapper.Map<DotKhamSucKhoeVm>(dotKhamSucKhoe));
            }
            return NotFound();
        }
    }
}