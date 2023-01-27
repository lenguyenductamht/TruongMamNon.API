using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhongBanRepository
    {
        Task<PhongBan> AddPhongBan(PhongBan request);

        Task<PhongBan> DeletePhongBan(int maPhongBan);

        Task<bool> Exists(int maPhongBan);

        Task<List<PhongBan>> GetPhongBans();

        Task<PhongBan> GetPhongBan(int maPhongBan);

        Task<PhongBan> UpdatePhongBan(int maPhongBan, PhongBan request);
    }
}