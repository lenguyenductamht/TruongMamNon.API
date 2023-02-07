using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IChucVuRepository
    {
        Task<ChucVu> AddChucVu(ChucVu request);

        Task<ChucVu> DeleteChucVu(int maChucVu);

        Task<bool> Exists(int maChucVu);

        Task<List<ChucVu>> GetChucVus();
        Task<List<ChucVu>> GetChucVusByLoaiNhanSu(int maLoaiNhanSu);

        Task<ChucVu> GetChucVu(int maChucVu);

        Task<ChucVu> UpdateChucVu(int maChucVu, ChucVu request);
    }
}