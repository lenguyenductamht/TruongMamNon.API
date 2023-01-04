using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        private readonly TruongMamNonDbContext _context;

        public CommonRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<List<DanToc>> GetDanTocs()
        {
            return await _context.DanTocs.ToListAsync();
        }

        public async Task<List<GioiTinh>> GetGioiTinhs()
        {
            return await _context.GioiTinhs.ToListAsync();
        }

        public async Task<List<QuocGia>> GetQuocGias()
        {
            return await _context.QuocGias.ToListAsync();
        }

        public async Task<List<TonGiao>> GetTonGiaos()
        {
            return await _context.TonGiaos.ToListAsync();
        }

        public async Task<List<TrangThaiHoc>> GetTrangThaiHocs()
        {
            return await _context.TrangThaiHocs.ToListAsync();
        }

        public async Task<List<TrangThaiLamViec>> GetTrangThaiLamViecs()
        {
            return await _context.TrangThaiLamViecs.ToListAsync();
        }

        public async Task<List<TrangThaiTaiKhoan>> GetTrangThaiTaiKhoans()
        {
            return await _context.TrangThaiTaiKhoans.ToListAsync();
        }
    }
}