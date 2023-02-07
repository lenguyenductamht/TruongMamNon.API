using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IThucDonRepository
    {
        Task<ThucDon> AddThucDon(ThucDon request);

        Task<ThucDon> DeleteThucDon(int maThucDon);

        Task<bool> Exists(int maThucDon);

        Task<List<ThucDon>> GetThucDons();

        Task<ThucDon> GetThucDon(int maThucDon);

        Task<ThucDon> UpdateThucDon(int maThucDon, ThucDon request);
    }
}