using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDotSoGiunRepository
    {
        Task<DotSoGiun> AddDotSoGiun(DotSoGiun request);

        Task<DotSoGiun> DeleteDotSoGiun(int maDotSoGiun);

        Task<bool> Exists(int maDotSoGiun);

        Task<List<DotSoGiun>> GetDotSoGiuns();

        Task<List<DotSoGiun>> GetDotSoGiunsByNienHoc(int maNienHoc);

        Task<DotSoGiun> GetDotSoGiun(int maDotSoGiun);

        Task<DotSoGiun> UpdateDotSoGiun(int maDotSoGiun, DotSoGiun request);
    }
}