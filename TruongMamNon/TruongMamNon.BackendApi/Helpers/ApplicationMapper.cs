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
            CreateMap<TrangThaiDiemDanh, TrangThaiDiemDanhVm>().ReverseMap();
            CreateMap<TrangThaiHoc, TrangThaiHocVm>().ReverseMap();
            CreateMap<TrangThaiLamViec, TrangThaiLamViecVm>().ReverseMap();
            CreateMap<TrangThaiTaiKhoan, TrangThaiTaiKhoanVm>().ReverseMap();

            CreateMap<PhongBan, PhongBanVm>().ReverseMap();
            CreateMap<PhongBan, AUPhongBanRequest>().ReverseMap();

            CreateMap<LoaiNhanSu, LoaiNhanSuVm>().ReverseMap();

            CreateMap<NhanSu, NhanSuVm>().ReverseMap();
            CreateMap<NhanSu, AddNhanSuRequest>().ReverseMap();
            CreateMap<NhanSu, UpdateNhanSuRequest>().ReverseMap();

            CreateMap<Vaccine, VaccineVm>().ReverseMap();
            CreateMap<Vaccine, AUVaccineRequest>().ReverseMap();

            CreateMap<DotTiemVaccine, DotTiemVaccineVm>().ReverseMap();
            CreateMap<DotTiemVaccine, AUDotTiemVaccineRequest>().ReverseMap();

            CreateMap<PhieuTiemVaccine, PhieuTiemVaccineVm>().ReverseMap();
            CreateMap<PhieuTiemVaccine, AUPhieuTiemVaccineRequest>().ReverseMap();

            CreateMap<DiemDanh, DiemDanhVm>().ReverseMap();
            CreateMap<DiemDanh, AddDiemDanhRequest>().ReverseMap();
            CreateMap<DiemDanh, UpdateDiemDanhRequest>().ReverseMap();

            CreateMap<DanhMucThucPham, DanhMucThucPhamVm>().ReverseMap();

            CreateMap<ThucPham, ThucPhamVm>().ReverseMap();
            CreateMap<ThucPham, AUThucPhamRequest>().ReverseMap();
            //CreateMap<ThucPham, TangThucPhamRequest>().ReverseMap();

            CreateMap<PhieuNhapThucPham, PhieuNhapThucPhamVm>().ReverseMap();
            CreateMap<PhieuNhapThucPham, AddPhieuNhapThucPhamRequest>().ReverseMap();
            CreateMap<PhieuNhapThucPham, UpdatePhieuNhapThucPhamRequest>().ReverseMap();


            CreateMap<ChucVu, ChucVuVm>().ReverseMap();
            CreateMap<DanhMucThucDon, DanhMucThucDonVm>().ReverseMap();
            CreateMap<ChucVu, CreateChucVuVm>().ReverseMap();
        }
    }
}