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
    public class KhoiLopsController : ControllerBase
    {
        private readonly IKhoiLopRepository _khoiLopRepository;
        private readonly IMapper _mapper;

        public KhoiLopsController(IKhoiLopRepository khoiLopRepository, IMapper mapper)
        {
            _khoiLopRepository = khoiLopRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetKhoiLops()
        {
            var khoiLops = await _khoiLopRepository.GetKhoiLops();
            return Ok(_mapper.Map<List<KhoiLopVm>>(khoiLops));
        }
    }
}