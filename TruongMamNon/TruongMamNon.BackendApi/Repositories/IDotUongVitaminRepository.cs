using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDotUongVitaminRepository
    {
        Task<DotUongVitamin> AddDotUongVitamin(DotUongVitamin request);

        Task<DotUongVitamin> DeleteDotUongVitamin(int maDotUongVitamin);

        Task<bool> Exists(int maDotUongVitamin);

        Task<List<DotUongVitamin>> GetDotUongVitamins();

        Task<List<DotUongVitamin>> GetDotUongVitaminsByNienHoc(int maNienHoc);

        Task<DotUongVitamin> GetDotUongVitamin(int maDotUongVitamin);

        Task<DotUongVitamin> UpdateDotUongVitamin(int maDotUongVitamin, DotUongVitamin request);
    }
}