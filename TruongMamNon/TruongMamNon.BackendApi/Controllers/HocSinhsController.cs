using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.Utilities.Constants;
using TruongMamNon.BackendApi.Utilities.Hash;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhsController : ControllerBase
    {
        private readonly IHocSinhRepository _hocSinhRepository;
        private readonly IMapper _mapper;

        public HocSinhsController(IHocSinhRepository hocSinhRepository, IMapper mapper)
        {
            _hocSinhRepository = hocSinhRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddHocSinh([FromBody] AddHocSinhRequest request)
        {
            if (request.MaLopHoc == 0)
            {
                request.MaLopHoc = null;
            }
            request.MatKhau = MD5Hash.MD5(request.MatKhau);
            if (string.IsNullOrEmpty(request.NamSinhPhuHuynh))
            {
                request.NamSinhPhuHuynh = null;
            }
            var hocSinh = await _hocSinhRepository.AddHocSinh(_mapper.Map<HocSinh>(request));
            return CreatedAtAction(nameof(GetHocSinh), new { maHocSinh = hocSinh.MaHocSinh }, _mapper.Map<HocSinhVm>(hocSinh));
        }

        [HttpGet]
        public async Task<IActionResult> GetHocSinhs()
        {
            var hocSinhs = await _hocSinhRepository.GetHocSinhs();
            return Ok(_mapper.Map<List<HocSinhVm>>(hocSinhs));
        }

        [HttpGet("KhoiLop/{maKhoiLop}")]
        public async Task<IActionResult> GetHocSinhsByKhoiLop(int maKhoiLop)
        {
            var hocSinhs = await _hocSinhRepository.GetHocSinhsByKhoiLop(maKhoiLop);
            return Ok(_mapper.Map<List<HocSinhVm>>(hocSinhs));
        }

        [HttpGet("LopHoc/{maLopHoc}")]
        public async Task<IActionResult> GetHocSinhsByLopHoc(int maLopHoc)
        {
            var hocSinhs = await _hocSinhRepository.GetHocSinhsByLopHoc(maLopHoc);
            return Ok(_mapper.Map<List<HocSinhVm>>(hocSinhs));
        }

        [HttpGet("{maHocSinh}"), ActionName("GetHocSinh")]
        public async Task<IActionResult> GetHocSinh([FromRoute] string maHocSinh)
        {
            var hocSinh = await _hocSinhRepository.GetHocSinh(maHocSinh);
            if (hocSinh == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<HocSinhVm>(hocSinh));
        }

        [HttpPut("{maHocSinh}")]
        public async Task<IActionResult> UpdateHocSinh([FromRoute] string maHocSinh, [FromBody] UpdateHocSinhRequest request)
        {
            if (await _hocSinhRepository.Exists(maHocSinh))
            {
                var hocSinh = await _hocSinhRepository.UpdateHocSinh(maHocSinh, _mapper.Map<HocSinh>(request));
                if (hocSinh != null)
                {
                    return Ok(_mapper.Map<HocSinhVm>(hocSinh));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maHocSinh}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string maHocSinh)
        {
            if (await _hocSinhRepository.Exists(maHocSinh))
            {
                var hocSinh = await _hocSinhRepository.DeleteHocSinh(maHocSinh);
                return Ok(_mapper.Map<HocSinhVm>(hocSinh));
            }
            return NotFound();
        }
    }
}