using FluentValidation;
using TruongMamNon.BackendApi.Repositories;
using TruongMamNon.BackendApi.RequestModels;

namespace TruongMamNon.BackendApi.Validators
{
    public class AddHocSinhRequestValidator : AbstractValidator<AddHocSinhRequest>
    {
        public AddHocSinhRequestValidator(ICommonRepository commonRepository, IKhoiLopRepository khoiLopRepository, ILopHocRepository lopHocRepository)
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

            RuleFor(x => x.MaKhoiLop).NotEmpty().Must(ma =>
            {
                var khoiLop = khoiLopRepository.GetKhoiLops().Result.ToList().FirstOrDefault(x => x.MaKhoiLop == ma);
                if (khoiLop != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn khối lớp hợp lệ");

            //RuleFor(x => x.MaLopHoc).Must(ma =>
            //{
            //    var lopHoc = lopHocRepository.GetLopHocs().Result.ToList().FirstOrDefault(x => x.MaLop == ma);
            //    if (lopHoc != null)
            //    {
            //        return true;
            //    }
            //    return false;
            //}).WithMessage("Vui lòng chọn lớp học hợp lệ");

            RuleFor(x => x.NgayNhapHoc).NotEmpty();

            RuleFor(x => x.MaTrangThaiHoc).NotEmpty().Must(ma =>
            {
                var trangThaiHoc = commonRepository.GetTrangThaiHocs().Result.ToList().FirstOrDefault(x => x.MaTrangThai == ma);
                if (trangThaiHoc != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Vui lòng chọn trạng thái học hợp lệ");

            RuleFor(x => x.LyDoNghiHoc).MaximumLength(200);

            RuleFor(x => x.NgaySinh).NotEmpty().LessThan(DateTime.Now);

            RuleFor(x => x.NoiSinh).MaximumLength(200);

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

            RuleFor(x => x.HoTenPhuHuynh).NotEmpty().MaximumLength(200);

            RuleFor(x => x.NamSinhPhuHuynh).MaximumLength(4);

            RuleFor(x => x.SDTPhuHuynh).MaximumLength(15);

            RuleFor(x => x.NgheNghiepPhuHuynh).MaximumLength(200);

            //RuleFor(x => x.EmailPhuHuynh).EmailAddress().MaximumLength(200);

            RuleFor(x => x.DiaChiPhuHuynh).MaximumLength(200);
        }
    }
}