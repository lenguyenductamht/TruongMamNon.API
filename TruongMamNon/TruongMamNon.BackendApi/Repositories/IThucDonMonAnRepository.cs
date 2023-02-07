using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IThucDonMonAnRepository
    {
        Task<ThucDonMonAn> AddThucDonMonAn(ThucDonMonAn request);

        Task<ThucDonMonAn> DeleteThucDonMonAn(int maThucDon, int maMonAn);

        Task<bool> Exists(int maThucDon, int maMonAn);

        Task<List<ThucDonMonAn>> GetThucDonMonAnsByThucDon(int maThucDon);

        Task<ThucDonMonAn> GetThucDonMonAn(int maThucDon, int maMonAn);

        Task<ThucDonMonAn> UpdateThucDonMonAn(int maThucDon, int maMonAn, ThucDonMonAn request);
    }
}