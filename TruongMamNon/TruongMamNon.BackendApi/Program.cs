using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
    .AddFluentValidation(c => c.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddFluentValidation(conf =>
//{
//    conf.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
//    conf.AutomaticValidationEnabled = false;
//});

builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy =>
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddDbContext<TruongMamNonDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TruongMamNonConnection")));

builder.Services.AddScoped<INienHocRepository, NienHocRepository>();
builder.Services.AddScoped<IHocSinhRepository, HocSinhRepository>();
builder.Services.AddScoped<IKhoiLopRepository, KhoiLopRepository>();
builder.Services.AddScoped<ILopHocRepository, LopHocRepository>();
builder.Services.AddScoped<ICommonRepository, CommonRepository>();
builder.Services.AddScoped<ILoaiNhanSuRepository, LoaiNhanSuRepository>();
builder.Services.AddScoped<IPhongBanRepository, PhongBanRepository>();
builder.Services.AddScoped<INhanSuRepository, NhanSuRepository>();
builder.Services.AddScoped<IVaccineRepository, VaccineRepository>();
builder.Services.AddScoped<IDotTiemVaccineRepository, DotTiemVaccineRepository>();
builder.Services.AddScoped<IPhieuTiemVaccineRepository, PhieuTiemVaccineRepository>();
builder.Services.AddScoped<IDiemDanhRepository, DiemDanhRepository>();
builder.Services.AddScoped<IDanhMucThucPhamRepository, DanhMucThucPhamRepository>();
builder.Services.AddScoped<IThucPhamRepository, ThucPhamRepository>();
builder.Services.AddScoped<IPhieuNhapThucPhamRepository, PhieuNhapThucPhamRepository>();
builder.Services.AddScoped<IChiTietPhieuNhapThucPhamRepository, ChiTietPhieuNhapThucPhamRepository>();
builder.Services.AddScoped<IPhieuXuatThucPhamRepository, PhieuXuatThucPhamRepository>();
builder.Services.AddScoped<IChiTietPhieuXuatThucPhamRepository, ChiTietPhieuXuatThucPhamRepository>();
builder.Services.AddScoped<IChucVuRepository, ChucVuRepository>();

builder.Services.AddScoped<IThuocSoGiunRepository, ThuocSoGiunRepository>();
builder.Services.AddScoped<IVitaminRepository, VitaminRepository>();
builder.Services.AddScoped<IDotSoGiunRepository, DotSoGiunRepository>();
builder.Services.AddScoped<IDotUongVitaminRepository, DotUongVitaminRepository>();
builder.Services.AddScoped<IDotKhamSucKhoeRepository, DotKhamSucKhoeRepository>();
builder.Services.AddScoped<IPhieuSoGiunRepository, PhieuSoGiunRepository>();
builder.Services.AddScoped<IPhieuUongVitaminRepository, PhieuUongVitaminRepository>();
builder.Services.AddScoped<IPhieuKhamSucKhoeRepository, PhieuKhamSucKhoeRepository>();
builder.Services.AddScoped<IDanhMucThucDonRepository, DanhMucThucDonRepository>();
builder.Services.AddScoped<IMonAnRepository, MonAnRepository>();
builder.Services.AddScoped<IMonAnThucPhamRepository, MonAnThucPhamRepository>();
builder.Services.AddScoped<IThucDonRepository, ThucDonRepository>();
builder.Services.AddScoped<IThucDonMonAnRepository, ThucDonMonAnRepository>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();