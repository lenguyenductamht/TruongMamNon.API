using AutoMapper;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Interfaces.HeThong;
using TruongMamNon.BackendApi.ViewModels.HeThong;

namespace TruongMamNon.BackendApi.Repositories.HeThong
{
    public class NienHocRepository : GenericRepository<NienHoc, NienHocVm>, INienHocRepository
    {
        public NienHocRepository(TruongMamNonDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}