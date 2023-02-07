using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucThucDonsController : ControllerBase
    {
        private readonly IDanhMucThucDonRepository _danhMucThucDonRepository;
        private readonly IMapper _mapper;

        public DanhMucThucDonsController(IDanhMucThucDonRepository danhMucThucDonRepository, IMapper mapper)
        {
            _danhMucThucDonRepository = danhMucThucDonRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddDanhMucThucDon([FromBody] AUDanhMucThucDonRequest request)
        {
            var danhMucThucDon = await _danhMucThucDonRepository.AddDanhMucThucDon(_mapper.Map<DanhMucThucDon>(request));
            return CreatedAtAction(nameof(GetDanhMucThucDon), new { maDanhMucThucDon = danhMucThucDon.MaDanhMuc }, _mapper.Map<DanhMucThucDonVm>(danhMucThucDon));
        }

        [HttpGet]
        public async Task<IActionResult> GetDanhMucThucDons()
        {
            var danhMucThucDons = await _danhMucThucDonRepository.GetDanhMucThucDons();
            return Ok(_mapper.Map<List<DanhMucThucDonVm>>(danhMucThucDons));
        }

        [HttpGet("{maDanhMucThucDon}"), ActionName("GetDanhMucThucDon")]
        public async Task<IActionResult> GetDanhMucThucDon([FromRoute] int maDanhMucThucDon)
        {
            var danhMucThucDon = await _danhMucThucDonRepository.GetDanhMucThucDon(maDanhMucThucDon);
            if (danhMucThucDon == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DanhMucThucDonVm>(danhMucThucDon));
        }

        [HttpPut("{maDanhMucThucDon}")]
        public async Task<IActionResult> UpdateDanhMucThucDon([FromRoute] int maDanhMucThucDon, [FromBody] AUDanhMucThucDonRequest request)
        {
            if (await _danhMucThucDonRepository.Exists(maDanhMucThucDon))
            {
                var danhMucThucDon = await _danhMucThucDonRepository.UpdateDanhMucThucDon(maDanhMucThucDon, _mapper.Map<DanhMucThucDon>(request));
                if (danhMucThucDon != null)
                {
                    return Ok(_mapper.Map<DanhMucThucDonVm>(danhMucThucDon));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maDanhMucThucDon}")]
        public async Task<IActionResult> DeleteDanhMucThucDon([FromRoute] int maDanhMucThucDon)
        {
            if (await _danhMucThucDonRepository.Exists(maDanhMucThucDon))
            {
                var danhMucThucDon = await _danhMucThucDonRepository.DeleteDanhMucThucDon(maDanhMucThucDon);
                return Ok(_mapper.Map<DanhMucThucDonVm>(danhMucThucDon));
            }
            return NotFound();
        }
    }
}