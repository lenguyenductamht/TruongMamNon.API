using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public class PhieuKhamSucKhoeRepository : IPhieuKhamSucKhoeRepository
    {
        private readonly TruongMamNonDbContext _context;

        public PhieuKhamSucKhoeRepository(TruongMamNonDbContext context)
        {
            _context = context;
        }

        public async Task<PhieuKhamSucKhoe> AddPhieuKhamSucKhoe(PhieuKhamSucKhoe request)
        {
            var phieuKhamSucKhoe = await _context.PhieuKhamSucKhoes.AddAsync(request);
            await _context.SaveChangesAsync();
            return phieuKhamSucKhoe.Entity;
        }

        public async Task<PhieuKhamSucKhoe> DeletePhieuKhamSucKhoe(long maPhieuKhamSucKhoe)
        {
            var phieuKhamSucKhoe = await GetPhieuKhamSucKhoe(maPhieuKhamSucKhoe);
            if (phieuKhamSucKhoe != null)
            {
                _context.PhieuKhamSucKhoes.Remove(phieuKhamSucKhoe);
                await _context.SaveChangesAsync();
                return phieuKhamSucKhoe;
            }
            return null;
        }

        public async Task<bool> Exists(long maPhieuKhamSucKhoe)
        {
            return await _context.PhieuKhamSucKhoes.AnyAsync(x => x.MaPhieuKhamSucKhoe == maPhieuKhamSucKhoe);
        }

        public async Task<PhieuKhamSucKhoe> GetPhieuKhamSucKhoe(long maPhieuKhamSucKhoe)
        {
            return await _context.PhieuKhamSucKhoes.FirstOrDefaultAsync(x => x.MaPhieuKhamSucKhoe == maPhieuKhamSucKhoe);
        }

        public async Task<List<PhieuKhamSucKhoe>> GetPhieuKhamSucKhoes()
        {
            return await _context.PhieuKhamSucKhoes.Include(x => x.DotKhamSucKhoe).Include(x => x.HocSinh).OrderByDescending(x => x.MaPhieuKhamSucKhoe).ToListAsync();
        }

        public async Task<List<PhieuKhamSucKhoe>> GetPhieuKhamSucKhoesByNienHoc(int maNienHoc)
        {
            return await _context.PhieuKhamSucKhoes.Where(x => x.DotKhamSucKhoe.MaNienHoc == maNienHoc).Include(x => x.DotKhamSucKhoe).Include(x => x.HocSinh).OrderByDescending(x => x.MaPhieuKhamSucKhoe).ToListAsync();
        }

        public async Task<PhieuKhamSucKhoe> UpdatePhieuKhamSucKhoe(long maPhieuKhamSucKhoe, PhieuKhamSucKhoe request)
        {
            var phieuKhamSucKhoe = await GetPhieuKhamSucKhoe(maPhieuKhamSucKhoe);
            if (phieuKhamSucKhoe != null)
            {
                phieuKhamSucKhoe.MaDotKhamSucKhoe = request.MaDotKhamSucKhoe;
                phieuKhamSucKhoe.MaHocSinh = request.MaHocSinh;
                phieuKhamSucKhoe.KetLuan = request.KetLuan;

                phieuKhamSucKhoe.ChieuCao = request.ChieuCao;
                phieuKhamSucKhoe.CanNang = request.CanNang;
                phieuKhamSucKhoe.BMI = request.BMI;
                phieuKhamSucKhoe.NhipTim = request.NhipTim;
                phieuKhamSucKhoe.TamThu = request.TamThu;
                phieuKhamSucKhoe.TamTruong = request.TamTruong;
                phieuKhamSucKhoe.LoaiTheLuc = request.LoaiTheLuc;

                phieuKhamSucKhoe.TuanHoan = request.TuanHoan;
                phieuKhamSucKhoe.HoHap = request.HoHap;
                phieuKhamSucKhoe.TieuHoa = request.TieuHoa;
                phieuKhamSucKhoe.ThanTietNieu = request.ThanTietNieu;
                phieuKhamSucKhoe.ThanKinhTamThan = request.ThanKinhTamThan;
                phieuKhamSucKhoe.LamSangKhac = request.LamSangKhac;

                phieuKhamSucKhoe.MatPhaiKhongKinh = request.MatPhaiKhongKinh;
                phieuKhamSucKhoe.MatTraiKhongKinh = request.MatTraiKhongKinh;
                phieuKhamSucKhoe.MatPhaiCoKinh = request.MatPhaiCoKinh;
                phieuKhamSucKhoe.MatTraiCoKinh = request.MatTraiCoKinh;
                phieuKhamSucKhoe.CacBenhVeMat = request.CacBenhVeMat;

                phieuKhamSucKhoe.TaiTraiNoiThuong = request.TaiTraiNoiThuong;
                phieuKhamSucKhoe.TaiTraiNoiTham = request.TaiTraiNoiTham;
                phieuKhamSucKhoe.TaiPhaiNoiThuong = request.TaiPhaiNoiThuong;
                phieuKhamSucKhoe.TaiPhaiNoiTham = request.TaiPhaiNoiTham;
                phieuKhamSucKhoe.CacBenhTaiMuiHong = request.CacBenhTaiMuiHong;

                phieuKhamSucKhoe.HamTren = request.HamTren;
                phieuKhamSucKhoe.HamDuoi = request.HamDuoi;
                phieuKhamSucKhoe.CacBenhRangHamMat = request.CacBenhRangHamMat;

                await _context.SaveChangesAsync();
                return phieuKhamSucKhoe;
            }
            return null;
        }
    }
}