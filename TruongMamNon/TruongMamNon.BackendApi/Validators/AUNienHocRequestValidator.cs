using FluentValidation;
using TruongMamNon.BackendApi.RequestModels;

namespace TruongMamNon.BackendApi.Validators
{
    public class AUNienHocRequestValidator : AbstractValidator<AUNienHocRequest>
    {
        public AUNienHocRequestValidator()
        {
            RuleFor(x => x.TenNienHoc)
                .NotEmpty()
                .WithMessage("Vui lòng nhập tên niên học")
                .MaximumLength(200)
                .WithMessage("Tên niên không được học vượt quá 200 ký tự");

            RuleFor(x => x.BatDauHK1).NotNull().NotEmpty().WithMessage("Vui lòng nhập bắt đầu học kỳ 1");
            RuleFor(x => x.KetThucHK1).NotNull().NotEmpty().WithMessage("Vui lòng nhập kết thúc học kỳ 1");
            RuleFor(x => x.BatDauHK2).NotNull().NotEmpty().WithMessage("Vui lòng nhập bắt đầu học kỳ 2");
            RuleFor(x => x.KetThucHK2).NotNull().NotEmpty().WithMessage("Vui lòng nhập kết thúc học kỳ 2");
        }
    }
}