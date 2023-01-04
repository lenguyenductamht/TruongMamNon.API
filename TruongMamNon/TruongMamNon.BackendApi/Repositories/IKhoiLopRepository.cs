using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IKhoiLopRepository
    {
        Task<List<KhoiLop>> GetKhoiLops();
    }
}