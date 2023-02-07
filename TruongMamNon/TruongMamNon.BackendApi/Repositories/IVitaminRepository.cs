using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IVitaminRepository
    {
        Task<Vitamin> AddVitamin(Vitamin request);

        Task<Vitamin> DeleteVitamin(int maVitamin);

        Task<bool> Exists(int maVitamin);

        Task<List<Vitamin>> GetVitamins();

        Task<Vitamin> GetVitamin(int maVitamin);

        Task<Vitamin> UpdateVitamin(int maVitamin, Vitamin request);
    }
}