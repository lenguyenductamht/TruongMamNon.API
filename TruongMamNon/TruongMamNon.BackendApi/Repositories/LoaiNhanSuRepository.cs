using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class LoaiNhanSuRepository : ILoaiNhanSuRepository
    {
        private readonly TruongMamNonDbContext _context;

        public LoaiNhanSuRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<List<LoaiNhanSu>> GetLoaiNhanSus()
        {
            return await _context.LoaiNhanSus.ToListAsync();
        }
    }
}