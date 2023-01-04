using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface INienHocRepository
    {
        Task<NienHoc> AddNienHoc(NienHoc request);

        Task<NienHoc> DeleteNienHoc(int maNienHoc);

        Task<bool> Exists(int maNienHoc);

        Task<List<NienHoc>> GetNienHocs();

        Task<NienHoc> GetNienHoc(int maNienHoc);

        Task<NienHoc> UpdateNienHoc(int maNienHoc, NienHoc request);
    }
}