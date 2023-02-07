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

            CreateMap<PhieuNhapThucPham, PhieuNhapThucPhamVm>().ReverseMap();
            CreateMap<PhieuNhapThucPham, AddPhieuNhapThucPhamRequest>().ReverseMap();
            CreateMap<PhieuNhapThucPham, UpdatePhieuNhapThucPhamRequest>().ReverseMap();

            CreateMap<ChiTietPhieuNhapThucPham, ChiTietPhieuNhapThucPhamVm>().ReverseMap();
            CreateMap<ChiTietPhieuNhapThucPham, AddChiTietPhieuNhapThucPhamRequest>().ReverseMap();
            CreateMap<ChiTietPhieuNhapThucPham, UpdateChiTietPhieuNhapThucPhamRequest>().ReverseMap();

            CreateMap<PhieuXuatThucPham, PhieuXuatThucPhamVm>().ReverseMap();
            CreateMap<PhieuXuatThucPham, AddPhieuXuatThucPhamRequest>().ReverseMap();
            CreateMap<PhieuXuatThucPham, UpdatePhieuXuatThucPhamRequest>().ReverseMap();

            CreateMap<ChiTietPhieuXuatThucPham, ChiTietPhieuXuatThucPhamVm>().ReverseMap();
            CreateMap<ChiTietPhieuXuatThucPham, AddChiTietPhieuXuatThucPhamRequest>().ReverseMap();
            CreateMap<ChiTietPhieuXuatThucPham, UpdateChiTietPhieuXuatThucPhamRequest>().ReverseMap();

            CreateMap<ChucVu, ChucVuVm>().ReverseMap();
            CreateMap<ChucVu, AUChucVuRequest>().ReverseMap();

            CreateMap<Vitamin, VitaminVm>().ReverseMap();
            CreateMap<Vitamin, AUVitaminRequest>().ReverseMap();

            CreateMap<ThuocSoGiun, ThuocSoGiunVm>().ReverseMap();
            CreateMap<ThuocSoGiun, AUThuocSoGiunRequest>().ReverseMap();

            CreateMap<DotKhamSucKhoe, DotKhamSucKhoeVm>().ReverseMap();
            CreateMap<DotKhamSucKhoe, AUDotKhamSucKhoeRequest>().ReverseMap();

            CreateMap<DotSoGiun, DotSoGiunVm>().ReverseMap();
            CreateMap<DotSoGiun, AUDotSoGiunRequest>().ReverseMap();

            CreateMap<DotUongVitamin, DotUongVitaminVm>().ReverseMap();
            CreateMap<DotUongVitamin, AUDotUongVitaminRequest>().ReverseMap();

            CreateMap<PhieuKhamSucKhoe, PhieuKhamSucKhoeVm>().ReverseMap();
            CreateMap<PhieuKhamSucKhoe, AUPhieuKhamSucKhoeRequest>().ReverseMap();

            CreateMap<PhieuSoGiun, PhieuSoGiunVm>().ReverseMap();
            CreateMap<PhieuSoGiun, AUPhieuSoGiunRequest>().ReverseMap();

            CreateMap<PhieuUongVitamin, PhieuUongVitaminVm>().ReverseMap();
            CreateMap<PhieuUongVitamin, AUPhieuUongVitaminRequest>().ReverseMap();

            CreateMap<DanhMucThucDon, DanhMucThucDonVm>().ReverseMap();
            CreateMap<DanhMucThucDon, AUDanhMucThucDonRequest>().ReverseMap();

            CreateMap<MonAn, MonAnVm>().ReverseMap();
            CreateMap<MonAn, AddMonAnRequest>().ReverseMap();
            CreateMap<MonAn, UpdateMonAnRequest>().ReverseMap();

            CreateMap<MonAnThucPham, MonAnThucPhamVm>().ReverseMap();
            CreateMap<MonAnThucPham, AddMonAnThucPhamRequest>().ReverseMap();
            CreateMap<MonAnThucPham, UpdateMonAnThucPhamRequest>().ReverseMap();

            CreateMap<ThucDon, ThucDonVm>().ReverseMap();
            CreateMap<ThucDon, AddThucDonRequest>().ReverseMap();
            CreateMap<ThucDon, UpdateThucDonRequest>().ReverseMap();

            CreateMap<ThucDonMonAn, ThucDonMonAnVm>().ReverseMap();
            CreateMap<ThucDonMonAn, AddThucDonMonAnRequest>().ReverseMap();
            CreateMap<ThucDonMonAn, UpdateThucDonMonAnRequest>().ReverseMap();
        }
    }
}