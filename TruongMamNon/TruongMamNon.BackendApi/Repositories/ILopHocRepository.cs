using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface ILopHocRepository
    {
        Task<LopHoc> AddLopHoc(LopHoc request);

        Task<LopHoc> DeleteLopHoc(int maLopHoc);

        Task<bool> Exists(int maLopHoc);

        Task<List<LopHoc>> GetLopHocs();

        Task<List<LopHoc>> GetLopHocsByNienHoc(int maNienHoc);

        Task<List<LopHoc>> GetLopHocsByNienHocKhoiLop(int maNienHoc, int maKhoiLop);

        Task<LopHoc> GetLopHoc(int maLopHoc);

        Task<LopHoc> UpdateLopHoc(int maLopHoc, LopHoc request);
    }
}