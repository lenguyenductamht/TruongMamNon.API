using AutoMapper;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.RequestModels;
using TruongMamNon.BackendApi.ViewModels;

namespace TruongMamNon.BackendApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<NienHoc, NienHocVm>().ReverseMap();
            CreateMap<NienHoc, AUNienHocRequest>().ReverseMap();

            CreateMap<HocSinh, HocSinhVm>().ReverseMap();
            CreateMap<HocSinh, AddHocSinhRequest>().ReverseMap();
            CreateMap<HocSinh, UpdateHocSinhRequest>().ReverseMap();

            CreateMap<KhoiLop, KhoiLopVm>().ReverseMap();

            CreateMap<LopHoc, LopHocVm>().ReverseMap();
            CreateMap<LopHoc, AULopHocRequest>().ReverseMap();

            CreateMap<GioiTinh, GioiTinhVm>().ReverseMap();
            CreateMap<DanToc, DanTocVm>().ReverseMap();
            CreateMap<TonGiao, TonGiaoVm>().ReverseMap();
            CreateMap<QuocGia, QuocGiaVm>().ReverseMap();
            CreateMap<TrangThaiHoc, TrangThaiHocVm>().ReverseMap();
            CreateMap<TrangThaiLamViec, TrangThaiLamViecVm>().ReverseMap();
            CreateMap<TrangThaiTaiKhoan, TrangThaiTaiKhoanVm>().ReverseMap();

            CreateMap<DanhMucThucDon, DanhMucThucDonVm>().ReverseMap();

            CreateMap<PhongBan, PhongBanVm>().ReverseMap();
            CreateMap<PhongBan, CreatePhongBanVm>().ReverseMap();

            CreateMap<ChucVu, ChucVuVm>().ReverseMap();
            CreateMap<ChucVu, CreateChucVuVm>().ReverseMap();
        }
    }
}