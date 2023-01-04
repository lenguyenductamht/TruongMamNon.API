using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class KhoiLopRepository : IKhoiLopRepository
    {
        private readonly TruongMamNonDbContext _context;

        public KhoiLopRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<List<KhoiLop>> GetKhoiLops()
        {
            return await _context.KhoiLops.ToListAsync();
        }
    }
}