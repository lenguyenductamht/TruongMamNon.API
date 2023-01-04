using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class NienHocRepository : INienHocRepository
    {
        private readonly TruongMamNonDbContext _context;

        public NienHocRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<NienHoc> AddNienHoc(NienHoc request)
        {
            var nienHoc = await _context.NienHocs.AddAsync(request);
            await _context.SaveChangesAsync();
            return nienHoc.Entity;
        }

        public async Task<NienHoc> DeleteNienHoc(int maNienHoc)
        {
            var nienHoc = await GetNienHoc(maNienHoc);
            if (nienHoc != null)
            {
                _context.NienHocs.Remove(nienHoc);
                await _context.SaveChangesAsync();
                return nienHoc;
            }
            return null;
        }

        public async Task<bool> Exists(int maNienHoc)
        {
            return await _context.NienHocs.AnyAsync(x => x.MaNienHoc == maNienHoc);
        }

        public async Task<NienHoc> GetNienHoc(int maNienHoc)
        {
            return await _context.NienHocs.FirstOrDefaultAsync(x => x.MaNienHoc == maNienHoc);
        }

        public async Task<List<NienHoc>> GetNienHocs()
        {
            return await _context.NienHocs.OrderByDescending(x=>x.TenNienHoc).ToListAsync();
        }

        public async Task<NienHoc> UpdateNienHoc(int maNienHoc, NienHoc request)
        {
            var nienHoc = await GetNienHoc(maNienHoc);
            if (nienHoc != null)
            {
                nienHoc.TenNienHoc = request.TenNienHoc;
                nienHoc.BatDauHK1 = request.BatDauHK1;
                nienHoc.KetThucHK1 = request.KetThucHK1;
                nienHoc.BatDauHK2 = request.BatDauHK2;
                nienHoc.KetThucHK2 = request.KetThucHK2;
                await _context.SaveChangesAsync();
                return nienHoc;
            }
            return null;
        }
    }
}