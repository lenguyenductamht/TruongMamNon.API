using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiNhanSusController : ControllerBase
    {
        private readonly ILoaiNhanSuRepository _loaiNhanSuRepository;
        private readonly IMapper _mapper;

        public LoaiNhanSusController(ILoaiNhanSuRepository loaiNhanSuRepository, IMapper mapper)
        {
            _loaiNhanSuRepository = loaiNhanSuRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetLoaiNhanSus()
        {
            var loaiNhanSu = await _loaiNhanSuRepository.GetLoaiNhanSus();
            return Ok(_mapper.Map<List<LoaiNhanSuVm>>(loaiNhanSu));
        }
    }
}