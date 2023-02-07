using FluentValidation;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;

namespace TruongMamNon.BackendApi.Validators
{
    public class AddNhanSuRequestValidator : AbstractValidator<AddNhanSuRequest>
    {
        public AddNhanSuRequestValidator(ICommonRepository commonRepository, IPhongBanRepository phongBanRepository, ILoaiNhanSuRepository loaiNhanSuRepository)
        {
            RuleFor(x => x.Ho).NotEmpty().MaximumLength(200);

            RuleFor(x => x.Ten).NotEmpty().MaximumLength(200);

            RuleFor(x => x.MaGioiTinh).NotEmpty().Must(ma =>
            {
                var gioiTinh = commonRepository.GetGioiTinhs().Result.ToList().FirstOrDefault(x => x.MaGioiTinh == ma);
                if (gioiTinh != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn giới tính hợp lệ");

            RuleFor(x => x.NgaySinh).NotEmpty().LessThan(DateTime.Now);

            RuleFor(x => x.NoiSinh).MaximumLength(200);

            RuleFor(x => x.CMND).NotEmpty().MaximumLength(12);

            RuleFor(x => x.NgayCap).LessThan(DateTime.Now);

            RuleFor(x => x.MaDanToc).Must(ma =>
            {
                var danToc = commonRepository.GetDanTocs().Result.ToList().FirstOrDefault(x => x.MaDanToc == ma);
                if (danToc != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn dân tộc hợp lệ");

            RuleFor(x => x.MaTonGiao).Must(ma =>
            {
                var tonGiao = commonRepository.GetTonGiaos().Result.ToList().FirstOrDefault(x => x.MaTonGiao == ma);
                if (tonGiao != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn tôn giáo hợp lệ");

            RuleFor(x => x.MaQuocTich).Must(ma =>
            {
                var quocGia = commonRepository.GetQuocGias().Result.ToList().FirstOrDefault(x => x.MaQuocGia == ma);
                if (quocGia != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn quốc tịch hợp lệ");

            RuleFor(x => x.NgayVaoTruong).NotEmpty();

            RuleFor(x => x.MaPhongBan).Must(ma =>
            {
                var phongBan = phongBanRepository.GetPhongBans().Result.ToList().FirstOrDefault(x => x.MaPhongBan == ma);
                if (phongBan != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn phòng ban hợp lệ");

            RuleFor(x => x.MaTrangThaiLamViec).Must(ma =>
            {
                var trangThaiLamViec = commonRepository.GetTrangThaiLamViecs().Result.ToList().FirstOrDefault(x => x.MaTrangThai == ma);
                if (trangThaiLamViec != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn trạng thái làm việc hợp lệ");

            RuleFor(x => x.LyDoThoiViec).MaximumLength(200);

            RuleFor(x => x.NgayCap).NotEmpty();

            RuleFor(x => x.MaLoaiNhanSu).NotEmpty().Must(ma =>
            {
                var loaiNhanSu = loaiNhanSuRepository.GetLoaiNhanSus().Result.ToList().FirstOrDefault(x => x.MaLoaiNhanSu == ma);
                if (loaiNhanSu != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn loại nhân sự hợp lệ");

            RuleFor(x => x.SoDienThoai).MaximumLength(15);

            RuleFor(x => x.Email).EmailAddress().MaximumLength(200);

            RuleFor(x => x.HoKhau).MaximumLength(200);

            RuleFor(x => x.DiaChi).MaximumLength(200);

            RuleFor(x => x.MatKhau).Length(6, 32);

            RuleFor(x => x.MaTrangThaiTaiKhoan).NotEmpty().Must(ma =>
            {
                var trangThaiTaiKhoan = commonRepository.GetTrangThaiTaiKhoans().Result.ToList().FirstOrDefault(x => x.MaTrangThai == ma);
                if (trangThaiTaiKhoan != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn trạng thái tài khoản hợp lệ");
        }
    }
}