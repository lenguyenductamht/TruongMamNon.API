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
    public class NienHocsController : ControllerBase
    {
        private readonly INienHocRepository _nienHocRepository;
        private readonly IMapper _mapper;

        public NienHocsController(INienHocRepository nienHocRepository, IMapper mapper)
        {
            _nienHocRepository = nienHocRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddNienHoc([FromBody] AUNienHocRequest request)
        {
            var nienHoc = await _nienHocRepository.AddNienHoc(_mapper.Map<NienHoc>(request));
            return CreatedAtAction(nameof(GetNienHoc), new { maNienHoc = nienHoc.MaNienHoc }, _mapper.Map<NienHocVm>(nienHoc));
        }

        [HttpGet]
        public async Task<IActionResult> GetNienHocs()
        {
            var nienHocs = await _nienHocRepository.GetNienHocs();
            return Ok(_mapper.Map<List<NienHocVm>>(nienHocs));
        }

        [HttpGet("{maNienHoc}"), ActionName("GetNienHoc")]
        public async Task<IActionResult> GetNienHoc([FromRoute] int maNienHoc)
        {
            var nienHoc = await _nienHocRepository.GetNienHoc(maNienHoc);
            if (nienHoc == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<NienHocVm>(nienHoc));
        }

        [HttpPut("{maNienHoc}")]
        public async Task<IActionResult> UpdateNienHoc([FromRoute] int maNienHoc, [FromBody] AUNienHocRequest request)
        {
            if (await _nienHocRepository.Exists(maNienHoc))
            {
                var nienHoc = await _nienHocRepository.UpdateNienHoc(maNienHoc, _mapper.Map<NienHoc>(request));
                if (nienHoc != null)
                {
                    return Ok(_mapper.Map<NienHocVm>(nienHoc));
                }
            }
            return NotFound();
        }

        [HttpDelete("{maNienHoc}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int maNienHoc)
        {
            if (await _nienHocRepository.Exists(maNienHoc))
            {
                var nienHoc = await _nienHocRepository.DeleteNienHoc(maNienHoc);
                return Ok(_mapper.Map<NienHocVm>(nienHoc));
            }
            return NotFound();
        }
    }
}