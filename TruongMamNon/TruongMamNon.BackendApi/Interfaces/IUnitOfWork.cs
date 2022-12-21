using TruongMamNon.BackendApi.Interfaces.MamNon;

namespace TruongMamNon.BackendApi.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDanhMucThucDonRepository DanhMucThucDon { get; }
    }
}