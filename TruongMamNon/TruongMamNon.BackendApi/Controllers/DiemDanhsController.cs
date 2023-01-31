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
    public class DiemDanhsController : ControllerBase
    {
        private readonly IDiemDanhRepository _diemDanhRepository;
        private readonly IMapper _mapper;

        public DiemDanhsController(IDiemDanhRepository diemDanhRepository, IMapper mapper)
        {
            _diemDanhRepository = diemDanhRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddDiemDanh([FromBody] AddDiemDanhRequest request)
        {
            var diemDanh = await _diemDanhRepository.AddDiemDanh(_mapper.Map<DiemDanh>(request));
            return CreatedAtAction(nameof(GetDiemDanh), new { maDiemDanh = diemDanh.MaDiemDanh }, _mapper.Map<DiemDanhVm>(diemDanh));
        }

        //[HttpGet]
        //public async Task<IActionResult> GetDiemDanhs()
        //{
        //    var diemDanhs = await _diemDanhRepository.GetDiemDanhs();
        //    return Ok(_mapper.Map<List<DiemDanhVm>>(diemDanhs));
        //}

        //[HttpGet("from/{from}/to/{to}")]
        //public async Task<IActionResult> GetDiemDanhsByDate(DateTime from, DateTime to)
        //{
        //    var diemDanhs = await _diemDanhRepository.GetDiemDanhsByDate(from, to);
        //    return Ok(_mapper.Map<List<DiemDanhVm>>(diemDanhs));
        //}

        [HttpGet("LopHoc/{maLopHoc}/from/{from}/to/{to}")]
        public async Task<IActionResult> GetDiemDanhsByDateLopHoc(DateTime from, DateTime to, int maLopHoc)
        {
            var diemDanhs = await _diemDanhRepository.GetDiemDanhsByDateLopHoc(from, to, maLopHoc);
            return Ok(_mapper.Map<List<DiemDanhVm>>(diemDanhs));
        }

        [HttpGet("{maDiemDanh}"), ActionName("GetDiemDanh")]
        public async Task<IActionResult> GetDiemDanh([FromRoute] int maDiemDanh)
        {
            var diemDanh = await _diemDanhRepository.GetDiemDanh(maDiemDanh);
            if (diemDanh == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DiemDanhVm>(diemDanh));
        }

        [HttpPut("{maDiemDanh}")]
        public async Task<IActionResult> UpdateDiemDanh([FromRoute] int maDiemDanh, [FromBody] UpdateDiemDanhRequest request)
        {
            if (await _diemDanhRepository.Exists(maDiemDanh))
            {
                var diemDanh = await _diemDanhRepository.UpdateDiemDanh(maDiemDanh, _mapper.Map<DiemDanh>(request));
                if (diemDanh != null)
                {
                    return Ok(_mapper.Map<DiemDanhVm>(diemDanh));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maDiemDanh}")]
        public async Task<IActionResult> DeleteDiemDanh([FromRoute] int maDiemDanh)
        {
            if (await _diemDanhRepository.Exists(maDiemDanh))
            {
                var diemDanh = await _diemDanhRepository.DeleteDiemDanh(maDiemDanh);
                return Ok(_mapper.Map<DiemDanhVm>(diemDanh));
            }
            return NotFound();
        }
    }
}