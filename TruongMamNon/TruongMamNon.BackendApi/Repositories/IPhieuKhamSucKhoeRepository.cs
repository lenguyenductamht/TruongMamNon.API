using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IPhieuKhamSucKhoeRepository
    {
        Task<PhieuKhamSucKhoe> AddPhieuKhamSucKhoe(PhieuKhamSucKhoe request);

        Task<PhieuKhamSucKhoe> DeletePhieuKhamSucKhoe(long maPhieuKhamSucKhoe);

        Task<bool> Exists(long maPhieuKhamSucKhoe);

        Task<List<PhieuKhamSucKhoe>> GetPhieuKhamSucKhoes();

        public Task<List<PhieuKhamSucKhoe>> GetPhieuKhamSucKhoesByNienHoc(int maNienHoc);

        Task<PhieuKhamSucKhoe> GetPhieuKhamSucKhoe(long maPhieuKhamSucKhoe);

        Task<PhieuKhamSucKhoe> UpdatePhieuKhamSucKhoe(long maPhieuKhamSucKhoe, PhieuKhamSucKhoe request);
    }
}