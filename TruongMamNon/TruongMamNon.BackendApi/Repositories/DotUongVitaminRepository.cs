using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DotUongVitaminRepository : IDotUongVitaminRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DotUongVitaminRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<DotUongVitamin> AddDotUongVitamin(DotUongVitamin request)
        {
            var dotUongVitamin = await _context.DotUongVitamins.AddAsync(request);
            await _context.SaveChangesAsync();
            return dotUongVitamin.Entity;
        }

        public async Task<DotUongVitamin> DeleteDotUongVitamin(int maDotUongVitamin)
        {
            var dotUongVitamin = await GetDotUongVitamin(maDotUongVitamin);
            if (dotUongVitamin != null)
            {
                _context.DotUongVitamins.Remove(dotUongVitamin);
                await _context.SaveChangesAsync();
                return dotUongVitamin;
            }
            return null;
        }

        public async Task<bool> Exists(int maDotUongVitamin)
        {
            return await _context.DotUongVitamins.AnyAsync(x => x.MaDotUongVitamin == maDotUongVitamin);
        }

        public async Task<DotUongVitamin> GetDotUongVitamin(int maDotUongVitamin)
        {
            return await _context.DotUongVitamins.FirstOrDefaultAsync(x => x.MaDotUongVitamin == maDotUongVitamin);
        }

        public async Task<List<DotUongVitamin>> GetDotUongVitamins()
        {
            return await _context.DotUongVitamins.Include(x => x.Vitamin).Include(x => x.NienHoc).OrderBy(x => x.TenDotUongVitamin).ToListAsync();
        }

        public async Task<List<DotUongVitamin>> GetDotUongVitaminsByNienHoc(int maNienHoc)
        {
            return await _context.DotUongVitamins.Where(x => x.MaNienHoc == maNienHoc).Include(x => x.Vitamin).Include(x => x.NienHoc).OrderBy(x => x.TenDotUongVitamin).ToListAsync();
        }

        public async Task<DotUongVitamin> UpdateDotUongVitamin(int maDotUongVitamin, DotUongVitamin request)
        {
            var dotUongVitamin = await GetDotUongVitamin(maDotUongVitamin);
            if (dotUongVitamin != null)
            {
                dotUongVitamin.TenDotUongVitamin = request.TenDotUongVitamin;
                dotUongVitamin.NgayUongVitamin = request.NgayUongVitamin;
                dotUongVitamin.MaVitamin = request.MaVitamin;
                dotUongVitamin.MaNienHoc = request.MaNienHoc;
                await _context.SaveChangesAsync();
                return dotUongVitamin;
            }
            return null;
        }
    }
}