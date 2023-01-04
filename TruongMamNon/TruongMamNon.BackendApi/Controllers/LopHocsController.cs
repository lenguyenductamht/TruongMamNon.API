using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocsController : ControllerBase
    {
        private readonly ILopHocRepository _lopHocRepository;
        private readonly IMapper _mapper;

        public LopHocsController(ILopHocRepository lopHocRepository, IMapper mapper)
        {
            _lopHocRepository = lopHocRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddLopHoc([FromBody] AULopHocRequest request)
        {
            var lopHoc = await _lopHocRepository.AddLopHoc(_mapper.Map<LopHoc>(request));
            return CreatedAtAction(nameof(GetLopHocs), new { maLopHoc = lopHoc.MaLop }, _mapper.Map<LopHocVm>(lopHoc));
        }

        [HttpGet]
        public async Task<IActionResult> GetLopHocs()
        {
            var lopHocs = await _lopHocRepository.GetLopHocs();
            return Ok(_mapper.Map<List<LopHocVm>>(lopHocs));
        }

        [HttpGet("NienHoc/{maNienHoc}")]
        public async Task<IActionResult> GetLopHocsByNienHoc(int maNienHoc)
        {
            var lopHocs = await _lopHocRepository.GetLopHocsByNienHoc(maNienHoc);
            return Ok(_mapper.Map<List<LopHocVm>>(lopHocs));
        }

        [HttpGet("NienHoc/{maNienHoc}/KhoiLop/{maKhoiLop}")]
        public async Task<IActionResult> GetLopHocsByNienHocKhoiLop(int maNienHoc, int maKhoiLop)
        {
            var lopHocs = await _lopHocRepository.GetLopHocsByNienHocKhoiLop(maNienHoc, maKhoiLop);
            return Ok(_mapper.Map<List<LopHocVm>>(lopHocs));
        }

        [HttpGet("{maLopHoc}"), ActionName("GetLopHoc")]
        public async Task<IActionResult> GetLopHoc([FromRoute] int maLopHoc)
        {
            var lopHoc = await _lopHocRepository.GetLopHoc(maLopHoc);
            if (lopHoc == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<LopHocVm>(lopHoc));
        }

        [HttpPut("{maLopHoc}")]
        public async Task<IActionResult> UpdateLopHoc([FromRoute] int maLopHoc, [FromBody] AULopHocRequest request)
        {
            if (await _lopHocRepository.Exists(maLopHoc))
            {
                var lopHoc = await _lopHocRepository.UpdateLopHoc(maLopHoc, _mapper.Map<LopHoc>(request));
                if (lopHoc != null)
                {
                    return Ok(_mapper.Map<LopHocVm>(lopHoc));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maLopHoc}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int maLopHoc)
        {
            if (await _lopHocRepository.Exists(maLopHoc))
            {
                var lopHoc = await _lopHocRepository.DeleteLopHoc(maLopHoc);
                return Ok(_mapper.Map<LopHocVm>(lopHoc));
            }
            return NotFound();
        }
    }
}