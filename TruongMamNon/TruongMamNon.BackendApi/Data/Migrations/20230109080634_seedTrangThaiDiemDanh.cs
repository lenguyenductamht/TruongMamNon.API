using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruongMamNon.BackendApi.Data.Migrations
{
    public partial class seedTrangThaiDiemDanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "2020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 15, 6, 33, 80, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "1020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 15, 6, 33, 81, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.InsertData(
                table: "TrangThaiDiemDanhs",
                columns: new[] { "MaTrangThai", "TenTrangThai" },
                values: new object[,]
                {
                    { "1", "Vắng sáng có phép" },
                    { "2", "Vắng sáng không phép" },
                    { "3", "Vắng chiều có phép" },
                    { "4", "Vắng chiều không phép" },
                    { "5", "Vắng cả ngày có phép" },
                    { "6", "Vắng cả ngày không phép" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrangThaiDiemDanhs",
                keyColumn: "MaTrangThai",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "TrangThaiDiemDanhs",
                keyColumn: "MaTrangThai",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "TrangThaiDiemDanhs",
                keyColumn: "MaTrangThai",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "TrangThaiDiemDanhs",
                keyColumn: "MaTrangThai",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "TrangThaiDiemDanhs",
                keyColumn: "MaTrangThai",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "TrangThaiDiemDanhs",
                keyColumn: "MaTrangThai",
                keyValue: "6");

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "2020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 14, 56, 50, 319, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "1020210001",
                column: "NgayCapNhat",
                value: new DateTime(2023, 1, 9, 14, 56, 50, 319, DateTimeKind.Local).AddTicks(7259));
        }
    }
}
