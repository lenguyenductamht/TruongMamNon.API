using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IDotKhamSucKhoeRepository
    {
        Task<DotKhamSucKhoe> AddDotKhamSucKhoe(DotKhamSucKhoe request);

        Task<DotKhamSucKhoe> DeleteDotKhamSucKhoe(int maDotKhamSucKhoe);

        Task<bool> Exists(int maDotKhamSucKhoe);

        Task<List<DotKhamSucKhoe>> GetDotKhamSucKhoes();

        Task<List<DotKhamSucKhoe>> GetDotKhamSucKhoesByNienHoc(int maNienHoc);

        Task<DotKhamSucKhoe> GetDotKhamSucKhoe(int maDotKhamSucKhoe);

        Task<DotKhamSucKhoe> UpdateDotKhamSucKhoe(int maDotKhamSucKhoe, DotKhamSucKhoe request);
    }
}