using AutoMapper;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Interfaces.MamNon;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Repositories.MamNon
{
    public class DanhMucThucDonRepository : GenericRepository<DanhMucThucDon, DanhMucThucDonVm>, IDanhMucThucDonRepository
    {
        public DanhMucThucDonRepository(TruongMamNonDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}