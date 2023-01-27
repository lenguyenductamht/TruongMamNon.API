using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuTiemVaccineRepository
    {
        Task<PhieuTiemVaccine> AddPhieuTiemVaccine(PhieuTiemVaccine request);

        Task<PhieuTiemVaccine> DeletePhieuTiemVaccine(int maPhieuTiemVaccine);

        Task<bool> Exists(int maPhieuTiemVaccine);

        Task<List<PhieuTiemVaccine>> GetPhieuTiemVaccines();
        public Task<List<PhieuTiemVaccine>> GetPhieuTiemVaccinesByNienHoc(int maNienHoc);

        Task<PhieuTiemVaccine> GetPhieuTiemVaccine(int maPhieuTiemVaccine);

        Task<PhieuTiemVaccine> UpdatePhieuTiemVaccine(int maPhieuTiemVaccine, PhieuTiemVaccine request);
    }
}