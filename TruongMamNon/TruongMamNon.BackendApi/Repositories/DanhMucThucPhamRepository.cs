using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DanhMucThucPhamRepository : IDanhMucThucPhamRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DanhMucThucPhamRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<List<DanhMucThucPham>> GetDanhMucThucPhams()
        {
            return await _context.DanhMucThucPhams.ToListAsync();
        }
    }
}