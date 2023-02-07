using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruongMamNon.BackendApi.Data.Migrations
{
    public partial class UpdateNangLuong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChatBeo",
                table: "ThucPhams");

            migrationBuilder.DropColumn(
                name: "ChatBot",
                table: "ThucPhams");

            migrationBuilder.DropColumn(
                name: "ChatDam",
                table: "ThucPhams");

            migrationBuilder.DropColumn(
                name: "NangLuong",
                table: "ThucPhams");

            migrationBuilder.DropColumn(
                name: "ChatBeo",
                table: "MonAns");

            migrationBuilder.DropColumn(
                name: "ChatBot",
                table: "MonAns");

            migrationBuilder.DropColumn(
                name: "ChatDam",
                table: "MonAns");

            migrationBuilder.DropColumn(
                name: "NangLuong",
                table: "MonAns");

            migrationBuilder.DropColumn(
                name: "ChatBeo",
                table: "DanhMucThucDons");

            migrationBuilder.DropColumn(
                name: "ChatBot",
                table: "DanhMucThucDons");

            migrationBuilder.DropColumn(
                name: "ChatDam",
                table: "DanhMucThucDons");

            migrationBuilder.DropColumn(
                name: "NangLuong",
                table: "DanhMucThucDons");

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: 1L,
                column: "NgayCapNhat",
                value: new DateTime(2023, 2, 6, 11, 50, 56, 529, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: 1L,
                column: "NgayCapNhat",
                value: new DateTime(2023, 2, 6, 11, 50, 56, 529, DateTimeKind.Local).AddTicks(2305));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ChatBeo",
                table: "ThucPhams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatBot",
                table: "ThucPhams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatDam",
                table: "ThucPhams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NangLuong",
                table: "ThucPhams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatBeo",
                table: "MonAns",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatBot",
                table: "MonAns",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatDam",
                table: "MonAns",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NangLuong",
                table: "MonAns",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatBeo",
                table: "DanhMucThucDons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatBot",
                table: "DanhMucThucDons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ChatDam",
                table: "DanhMucThucDons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NangLuong",
                table: "DanhMucThucDons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "DanhMucThucDons",
                keyColumn: "MaDanhMuc",
                keyValue: 1,
                columns: new[] { "ChatBeo", "ChatBot", "ChatDam", "NangLuong" },
                values: new object[] { 10.0, 30.0, 20.0, 100.0 });

            migrationBuilder.UpdateData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: 1L,
                column: "NgayCapNhat",
                value: new DateTime(2023, 2, 2, 9, 47, 20, 373, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: 1L,
                column: "NgayCapNhat",
                value: new DateTime(2023, 2, 2, 9, 47, 20, 373, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 1,
                columns: new[] { "ChatBot", "ChatDam", "NangLuong" },
                values: new object[] { 16400.0, 1500.0, 72000.0 });

            migrationBuilder.UpdateData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 2,
                columns: new[] { "ChatBeo", "ChatBot", "ChatDam", "NangLuong" },
                values: new object[] { 1000.0, 11000.0, 5000.0, 73000.0 });

            migrationBuilder.UpdateData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 3,
                columns: new[] { "ChatBeo", "ChatDam", "NangLuong" },
                values: new object[] { 7000.0, 19000.0, 139000.0 });

            migrationBuilder.UpdateData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 4,
                columns: new[] { "ChatBot", "ChatDam", "NangLuong" },
                values: new object[] { 11000.0, 900.0, 48000.0 });
        }
    }
}
