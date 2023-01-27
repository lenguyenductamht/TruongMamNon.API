using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhieuTiemVaccineRepository : IPhieuTiemVaccineRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuTiemVaccineRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhieuTiemVaccine> AddPhieuTiemVaccine(PhieuTiemVaccine request)
        {
            var phieuTiemVaccine = await _context.PhieuTiemVaccines.AddAsync(request);
            await _context.SaveChangesAsync();
            return phieuTiemVaccine.Entity;
        }

        public async Task<PhieuTiemVaccine> DeletePhieuTiemVaccine(int maPhieuTiemVaccine)
        {
            var phieuTiemVaccine = await GetPhieuTiemVaccine(maPhieuTiemVaccine);
            if (phieuTiemVaccine != null)
            {
                _context.PhieuTiemVaccines.Remove(phieuTiemVaccine);
                await _context.SaveChangesAsync();
                return phieuTiemVaccine;
            }
            return null;
        }

        public async Task<bool> Exists(int maPhieuTiemVaccine)
        {
            return await _context.PhieuTiemVaccines.AnyAsync(x => x.MaPhieuTiemVaccine == maPhieuTiemVaccine);
        }

        public async Task<PhieuTiemVaccine> GetPhieuTiemVaccine(int maPhieuTiemVaccine)
        {
            return await _context.PhieuTiemVaccines.FirstOrDefaultAsync(x => x.MaPhieuTiemVaccine == maPhieuTiemVaccine);
        }

        public async Task<List<PhieuTiemVaccine>> GetPhieuTiemVaccines()
        {
            return await _context.PhieuTiemVaccines.Include(x=>x.DotTiemVaccine).Include(nameof(HocSinh)).OrderByDescending(x => x.MaPhieuTiemVaccine).ToListAsync();
        }

        public async Task<List<PhieuTiemVaccine>> GetPhieuTiemVaccinesByNienHoc(int maNienHoc)
        {
            return await _context.PhieuTiemVaccines.Where(x => x.DotTiemVaccine.MaNienHoc == maNienHoc).Include(nameof(DotTiemVaccine)).Include(nameof(HocSinh)).OrderByDescending(x => x.MaPhieuTiemVaccine).ToListAsync();
        }

        public async Task<PhieuTiemVaccine> UpdatePhieuTiemVaccine(int maPhieuTiemVaccine, PhieuTiemVaccine request)
        {
            var phieuTiemVaccine = await GetPhieuTiemVaccine(maPhieuTiemVaccine);
            if (phieuTiemVaccine != null)
            {
                phieuTiemVaccine.MaDotTiemVaccine = request.MaDotTiemVaccine;
                phieuTiemVaccine.MaHocSinh = request.MaHocSinh;
                phieuTiemVaccine.TrangThai = request.TrangThai;
                await _context.SaveChangesAsync();
                return phieuTiemVaccine;
            }
            return null;
        }
    }
}