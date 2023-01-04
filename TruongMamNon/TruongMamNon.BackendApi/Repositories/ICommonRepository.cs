using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface ICommonRepository
    {
        Task<List<GioiTinh>> GetGioiTinhs();

        Task<List<DanToc>> GetDanTocs();

        Task<List<TonGiao>> GetTonGiaos();

        Task<List<QuocGia>> GetQuocGias();

        Task<List<TrangThaiHoc>> GetTrangThaiHocs();

        Task<List<TrangThaiLamViec>> GetTrangThaiLamViecs();

        Task<List<TrangThaiTaiKhoan>> GetTrangThaiTaiKhoans();
    }
}