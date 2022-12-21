using AutoMapper;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.ViewModels.HeThong;
using TruongMamNon.BackendApi.ViewModels.MamNon;
using TruongMamNon.BackendApi.ViewModels.TruongHoc;

namespace TruongMamNon.BackendApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DanhMucThucDon, DanhMucThucDonVm>().ReverseMap();
            CreateMap<NienHoc, NienHocVm>().ReverseMap();
            CreateMap<PhongBan, PhongBanVm>().ReverseMap();
            CreateMap<PhongBan, CreatePhongBanVm>().ReverseMap();

            CreateMap<ChucVu, ChucVuVm>().ReverseMap();
            CreateMap<ChucVu, CreateChucVuVm>().ReverseMap();
        }
    }
}