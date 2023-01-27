using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucThucPhamsController : ControllerBase
    {
        private readonly IDanhMucThucPhamRepository _danhMucThucPhamRepository;
        private readonly IMapper _mapper;

        public DanhMucThucPhamsController(IDanhMucThucPhamRepository danhMucThucPhamRepository, IMapper mapper)
        {
            _danhMucThucPhamRepository = danhMucThucPhamRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetDanhMucThucPhams()
        {
            var danhMucThucPhams = await _danhMucThucPhamRepository.GetDanhMucThucPhams();
            return Ok(_mapper.Map<List<DanhMucThucPhamVm>>(danhMucThucPhams));
        }
    }
}