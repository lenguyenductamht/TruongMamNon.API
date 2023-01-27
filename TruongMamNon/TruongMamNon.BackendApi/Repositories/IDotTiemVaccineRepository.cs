using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDotTiemVaccineRepository
    {
        Task<DotTiemVaccine> AddDotTiemVaccine(DotTiemVaccine request);

        Task<DotTiemVaccine> DeleteDotTiemVaccine(int maDotTiemVaccine);

        Task<bool> Exists(int maDotTiemVaccine);

        Task<List<DotTiemVaccine>> GetDotTiemVaccines();

        Task<List<DotTiemVaccine>> GetDotTiemVaccinesByNienHoc(int maNienHoc);

        Task<DotTiemVaccine> GetDotTiemVaccine(int maDotTiemVaccine);

        Task<DotTiemVaccine> UpdateDotTiemVaccine(int maDotTiemVaccine, DotTiemVaccine request);
    }
}