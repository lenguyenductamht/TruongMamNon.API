using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Interfaces;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucThucDonsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DanhMucThucDonsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var entities = await _unitOfWork.DanhMucThucDon.GetAll();
                return new JsonResult(entities);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{ma}")]
        public async Task<IActionResult> GetByMa(int ma)
        {
            try
            {
                var entity = await _unitOfWork.DanhMucThucDon.GetById(ma);
                if (entity != null)
                {
                    return Ok(entity);
                }
                return NotFound(entity);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(DanhMucThucDonVm model)
        {
            try
            {
                var result = await _unitOfWork.DanhMucThucDon.Post(model);
                if (result)
                {
                    return Ok(result);
                }
                return NotFound(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{ma}")]
        public async Task<IActionResult> Put(int ma, DanhMucThucDonVm model)
        {
            try
            {
                if (ma != model.MaDanhMuc)
                {
                    return BadRequest();
                }
                var result = await _unitOfWork.DanhMucThucDon.Put(ma, model);
                if (result)
                {
                    return Ok(result);
                }
                return NotFound(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{ma}")]
        public async Task<IActionResult> Delete(int ma)
        {
            try
            {
                var result = await _unitOfWork.DanhMucThucDon.Delete(ma);
                if (result)
                {
                    return Ok(result);
                }
                return NotFound(result);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}