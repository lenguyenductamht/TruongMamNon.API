using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDiemDanhRepository
    {
        Task<DiemDanh> AddDiemDanh(DiemDanh request);

        Task<DiemDanh> DeleteDiemDanh(int maDiemDanh);

        Task<bool> Exists(int maDiemDanh);

        //Task<List<DiemDanh>> GetDiemDanhs();

        //Task<List<DiemDanh>> GetDiemDanhsByDate(DateTime from, DateTime to);

        Task<List<DiemDanh>> GetDiemDanhsByDateLopHoc(DateTime from, DateTime to, int maLopHoc);

        Task<DiemDanh> GetDiemDanh(int maDiemDanh);

        Task<DiemDanh> UpdateDiemDanh(int maDiemDanh, DiemDanh request);
    }
}