using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IMonAnRepository
    {
        Task<MonAn> AddMonAn(MonAn request);

        Task<MonAn> DeleteMonAn(int maMonAn);

        Task<bool> Exists(int maMonAn);

        Task<List<MonAn>> GetMonAns();

        Task<MonAn> GetMonAn(int maMonAn);

        Task<MonAn> UpdateMonAn(int maMonAn, MonAn request);
    }
}