using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DotKhamSucKhoeRepository : IDotKhamSucKhoeRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DotKhamSucKhoeRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<DotKhamSucKhoe> AddDotKhamSucKhoe(DotKhamSucKhoe request)
        {
            var dotKhamSucKhoe = await _context.DotKhamSucKhoes.AddAsync(request);
            await _context.SaveChangesAsync();
            return dotKhamSucKhoe.Entity;
        }

        public async Task<DotKhamSucKhoe> DeleteDotKhamSucKhoe(int maDotKhamSucKhoe)
        {
            var dotKhamSucKhoe = await GetDotKhamSucKhoe(maDotKhamSucKhoe);
            if (dotKhamSucKhoe != null)
            {
                _context.DotKhamSucKhoes.Remove(dotKhamSucKhoe);
                await _context.SaveChangesAsync();
                return dotKhamSucKhoe;
            }
            return null;
        }

        public async Task<bool> Exists(int maDotKhamSucKhoe)
        {
            return await _context.DotKhamSucKhoes.AnyAsync(x => x.MaDotKhamSucKhoe == maDotKhamSucKhoe);
        }

        public async Task<DotKhamSucKhoe> GetDotKhamSucKhoe(int maDotKhamSucKhoe)
        {
            return await _context.DotKhamSucKhoes.FirstOrDefaultAsync(x => x.MaDotKhamSucKhoe == maDotKhamSucKhoe);
        }

        public async Task<List<DotKhamSucKhoe>> GetDotKhamSucKhoes()
        {
            return await _context.DotKhamSucKhoes.Include(x => x.NienHoc).OrderBy(x => x.TenDotKhamSucKhoe).ToListAsync();
        }

        public async Task<List<DotKhamSucKhoe>> GetDotKhamSucKhoesByNienHoc(int maNienHoc)
        {
            return await _context.DotKhamSucKhoes.Where(x => x.MaNienHoc == maNienHoc).Include(x => x.NienHoc).OrderBy(x => x.TenDotKhamSucKhoe).ToListAsync();
        }

        public async Task<DotKhamSucKhoe> UpdateDotKhamSucKhoe(int maDotKhamSucKhoe, DotKhamSucKhoe request)
        {
            var dotKhamSucKhoe = await GetDotKhamSucKhoe(maDotKhamSucKhoe);
            if (dotKhamSucKhoe != null)
            {
                dotKhamSucKhoe.TenDotKhamSucKhoe = request.TenDotKhamSucKhoe;
                dotKhamSucKhoe.NgayKhamSucKhoe = request.NgayKhamSucKhoe;
                dotKhamSucKhoe.MaNienHoc = request.MaNienHoc;
                await _context.SaveChangesAsync();
                return dotKhamSucKhoe;
            }
            return null;
        }
    }
}