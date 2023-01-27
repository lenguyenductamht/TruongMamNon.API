using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class DotTiemVaccineRepository : IDotTiemVaccineRepository
    {
        private readonly TruongMamNonDbContext _context;

        public DotTiemVaccineRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<DotTiemVaccine> AddDotTiemVaccine(DotTiemVaccine request)
        {
            var dotTiemVaccine = await _context.DotTiemVaccines.AddAsync(request);
            await _context.SaveChangesAsync();
            return dotTiemVaccine.Entity;
        }

        public async Task<DotTiemVaccine> DeleteDotTiemVaccine(int maDotTiemVaccine)
        {
            var dotTiemVaccine = await GetDotTiemVaccine(maDotTiemVaccine);
            if (dotTiemVaccine != null)
            {
                _context.DotTiemVaccines.Remove(dotTiemVaccine);
                await _context.SaveChangesAsync();
                return dotTiemVaccine;
            }
            return null;
        }

        public async Task<bool> Exists(int maDotTiemVaccine)
        {
            return await _context.DotTiemVaccines.AnyAsync(x => x.MaDotTiemVaccine == maDotTiemVaccine);
        }

        public async Task<DotTiemVaccine> GetDotTiemVaccine(int maDotTiemVaccine)
        {
            return await _context.DotTiemVaccines.FirstOrDefaultAsync(x => x.MaDotTiemVaccine == maDotTiemVaccine);
        }

        public async Task<List<DotTiemVaccine>> GetDotTiemVaccines()
        {
            return await _context.DotTiemVaccines.Include(nameof(Vaccine)).Include(nameof(NienHoc)).OrderBy(x => x.TenDotTiemVaccine).ToListAsync();
        }

        public async Task<List<DotTiemVaccine>> GetDotTiemVaccinesByNienHoc(int maNienHoc)
        {
            return await _context.DotTiemVaccines.Where(x=>x.MaNienHoc==maNienHoc).Include(nameof(Vaccine)).Include(nameof(NienHoc)).OrderBy(x => x.TenDotTiemVaccine).ToListAsync();
        }

        public async Task<DotTiemVaccine> UpdateDotTiemVaccine(int maDotTiemVaccine, DotTiemVaccine request)
        {
            var dotTiemVaccine = await GetDotTiemVaccine(maDotTiemVaccine);
            if (dotTiemVaccine != null)
            {
                dotTiemVaccine.TenDotTiemVaccine = request.TenDotTiemVaccine;
                dotTiemVaccine.NgayTiemVaccine = request.NgayTiemVaccine;
                dotTiemVaccine.MaVaccine = request.MaVaccine;
                dotTiemVaccine.MaNienHoc = request.MaNienHoc;
                await _context.SaveChangesAsync();
                return dotTiemVaccine;
            }
            return null;
        }
    }
}