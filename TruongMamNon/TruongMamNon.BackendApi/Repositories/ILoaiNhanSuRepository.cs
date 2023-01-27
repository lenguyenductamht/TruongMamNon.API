using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface ILoaiNhanSuRepository
    {
        Task<List<LoaiNhanSu>> GetLoaiNhanSus();
    }
}