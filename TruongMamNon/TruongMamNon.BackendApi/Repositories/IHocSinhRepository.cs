﻿using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IHocSinhRepository
    {
        Task<HocSinh> AddHocSinh(HocSinh request);

        Task<HocSinh> DeleteHocSinh(string maHocSinh);

        Task<bool> Exists(string maHocSinh);

        Task<List<HocSinh>> GetHocSinhs();

        Task<List<HocSinh>> GetHocSinhsByKhoiLop(int maKhoiLop);

        Task<List<HocSinh>> GetHocSinhsByLopHoc(int maLopHoc);

        Task<HocSinh> GetHocSinh(string maHocSinh);

        Task<HocSinh> UpdateHocSinh(string maHocSinh, HocSinh request);
    }
}