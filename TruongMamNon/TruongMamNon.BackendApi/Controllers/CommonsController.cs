using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonsController : ControllerBase
    {
        private readonly ICommonRepository _commonRepository;
        private readonly IMapper _mapper;

        public CommonsController(ICommonRepository commonRepository, IMapper mapper)
        {
            _commonRepository = commonRepository;
            _mapper = mapper;
        }

        [HttpGet("GioiTinhs")]
        public async Task<IActionResult> GetGioiTinhs()
        {
            var gioiTinhs = await _commonRepository.GetGioiTinhs();
            return Ok(_mapper.Map<List<GioiTinhVm>>(gioiTinhs));
        }

        [HttpGet("DanTocs")]
        public async Task<IActionResult> GetDanTocs()
        {
            var danTocs = await _commonRepository.GetDanTocs();
            return Ok(_mapper.Map<List<DanTocVm>>(danTocs));
        }

        [HttpGet("TonGiaos")]
        public async Task<IActionResult> GetTonGiaos()
        {
            var tonGiaos = await _commonRepository.GetTonGiaos();
            return Ok(_mapper.Map<List<TonGiaoVm>>(tonGiaos));
        }

        [HttpGet("QuocGias")]
        public async Task<IActionResult> GetQuocGias()
        {
            var quocGias = await _commonRepository.GetQuocGias();
            return Ok(_mapper.Map<List<QuocGiaVm>>(quocGias));
        }

        [HttpGet("TrangThaiDiemDanhs")]
        public async Task<IActionResult> GetTrangThaiDiemDanhs()
        {
            var trangThaiDiemDanhs = await _commonRepository.GetTrangThaiDiemDanhs();
            return Ok(_mapper.Map<List<TrangThaiDiemDanhVm>>(trangThaiDiemDanhs));
        }

        [HttpGet("TrangThaiHocs")]
        public async Task<IActionResult> GetTrangThaiHocs()
        {
            var trangThaiHocs = await _commonRepository.GetTrangThaiHocs();
            return Ok(_mapper.Map<List<TrangThaiHocVm>>(trangThaiHocs));
        }

        [HttpGet("TrangThaiLamViecs")]
        public async Task<IActionResult> GetTrangThaiLamViecs()
        {
            var trangThaiLamViecs = await _commonRepository.GetTrangThaiLamViecs();
            return Ok(_mapper.Map<List<TrangThaiLamViecVm>>(trangThaiLamViecs));
        }

        [HttpGet("TrangThaiTaiKhoans")]
        public async Task<IActionResult> GetTrangThaiTaiKhoans()
        {
            var trangThaiTaiKhoans = await _commonRepository.GetTrangThaiTaiKhoans();
            return Ok(_mapper.Map<List<TrangThaiTaiKhoanVm>>(trangThaiTaiKhoans));
        }
    }
}