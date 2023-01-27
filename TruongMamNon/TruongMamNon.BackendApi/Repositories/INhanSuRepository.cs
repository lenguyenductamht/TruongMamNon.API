using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface INhanSuRepository
    {
        Task<NhanSu> AddNhanSu(NhanSu request);

        Task<NhanSu> DeleteNhanSu(string maNhanSu);

        Task<bool> Exists(string maNhanSu);

        Task<List<NhanSu>> GetNhanSus();

        Task<NhanSu> GetNhanSu(string maNhanSu);

        Task<NhanSu> UpdateNhanSu(string maNhanSu, NhanSu request);
    }
}