using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruongMamNon.BackendApi.Data.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TonGiao",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuocTich",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoiSinh",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "NhanSus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DanToc",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "1",
                column: "NgayCapNhat",
                value: new DateTime(2022, 12, 8, 18, 51, 59, 443, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "1",
                column: "NgayCapNhat",
                value: new DateTime(2022, 12, 8, 18, 51, 59, 443, DateTimeKind.Local).AddTicks(1326));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TonGiao",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "QuocTich",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "NoiSinh",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayCapNhat",
                table: "NhanSus",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DanToc",
                table: "NhanSus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "1",
                column: "NgayCapNhat",
                value: new DateTime(2022, 12, 8, 18, 22, 36, 424, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "1",
                column: "NgayCapNhat",
                value: new DateTime(2022, 12, 8, 18, 22, 36, 424, DateTimeKind.Local).AddTicks(9013));
        }
    }
}
