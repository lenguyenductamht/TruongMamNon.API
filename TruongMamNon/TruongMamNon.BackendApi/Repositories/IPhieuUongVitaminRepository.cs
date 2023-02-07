using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuUongVitaminRepository
    {
        Task<PhieuUongVitamin> AddPhieuUongVitamin(PhieuUongVitamin request);

        Task<PhieuUongVitamin> DeletePhieuUongVitamin(long maPhieuUongVitamin);

        Task<bool> Exists(long maPhieuUongVitamin);

        Task<List<PhieuUongVitamin>> GetPhieuUongVitamins();

        public Task<List<PhieuUongVitamin>> GetPhieuUongVitaminsByNienHoc(int maNienHoc);

        Task<PhieuUongVitamin> GetPhieuUongVitamin(long maPhieuUongVitamin);

        Task<PhieuUongVitamin> UpdatePhieuUongVitamin(long maPhieuUongVitamin, PhieuUongVitamin request);
    }
}