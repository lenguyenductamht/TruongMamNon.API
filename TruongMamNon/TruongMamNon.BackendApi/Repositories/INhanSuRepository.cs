using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface INhanSuRepository
    {
        Task<NhanSu> AddNhanSu(NhanSu request);

        Task<NhanSu> DeleteNhanSu(long maNhanSu);

        Task<bool> Exists(long maNhanSu);

        Task<List<NhanSu>> GetNhanSus();

        Task<NhanSu> GetNhanSu(long maNhanSu);

        Task<NhanSu> UpdateNhanSu(long maNhanSu, NhanSu request);
    }
}