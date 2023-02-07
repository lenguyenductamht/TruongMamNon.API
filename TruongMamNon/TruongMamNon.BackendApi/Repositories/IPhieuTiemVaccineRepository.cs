using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuTiemVaccineRepository
    {
        Task<PhieuTiemVaccine> AddPhieuTiemVaccine(PhieuTiemVaccine request);

        Task<PhieuTiemVaccine> DeletePhieuTiemVaccine(long maPhieuTiemVaccine);

        Task<bool> Exists(long maPhieuTiemVaccine);

        Task<List<PhieuTiemVaccine>> GetPhieuTiemVaccines();

        public Task<List<PhieuTiemVaccine>> GetPhieuTiemVaccinesByNienHoc(int maNienHoc);

        Task<PhieuTiemVaccine> GetPhieuTiemVaccine(long maPhieuTiemVaccine);

        Task<PhieuTiemVaccine> UpdatePhieuTiemVaccine(long maPhieuTiemVaccine, PhieuTiemVaccine request);
    }
}