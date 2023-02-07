using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IThuocSoGiunRepository
    {
        Task<ThuocSoGiun> AddThuocSoGiun(ThuocSoGiun request);

        Task<ThuocSoGiun> DeleteThuocSoGiun(int maThuocSoGiun);

        Task<bool> Exists(int maThuocSoGiun);

        Task<List<ThuocSoGiun>> GetThuocSoGiuns();

        Task<ThuocSoGiun> GetThuocSoGiun(int maThuocSoGiun);

        Task<ThuocSoGiun> UpdateThuocSoGiun(int maThuocSoGiun, ThuocSoGiun request);
    }
}