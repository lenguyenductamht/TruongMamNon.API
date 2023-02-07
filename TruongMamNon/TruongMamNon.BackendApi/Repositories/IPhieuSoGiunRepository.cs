using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuSoGiunRepository
    {
        Task<PhieuSoGiun> AddPhieuSoGiun(PhieuSoGiun request);

        Task<PhieuSoGiun> DeletePhieuSoGiun(long maPhieuSoGiun);

        Task<bool> Exists(long maPhieuSoGiun);

        Task<List<PhieuSoGiun>> GetPhieuSoGiuns();

        public Task<List<PhieuSoGiun>> GetPhieuSoGiunsByNienHoc(int maNienHoc);

        Task<PhieuSoGiun> GetPhieuSoGiun(long maPhieuSoGiun);

        Task<PhieuSoGiun> UpdatePhieuSoGiun(long maPhieuSoGiun, PhieuSoGiun request);
    }
}