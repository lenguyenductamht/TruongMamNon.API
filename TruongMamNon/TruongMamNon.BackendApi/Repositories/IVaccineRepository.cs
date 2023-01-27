using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Repositories
{
    public interface IVaccineRepository
    {
        Task<Vaccine> AddVaccine(Vaccine request);

        Task<Vaccine> DeleteVaccine(int maVaccine);

        Task<bool> Exists(int maVaccine);

        Task<List<Vaccine>> GetVaccines();

        Task<Vaccine> GetVaccine(int maVaccine);

        Task<Vaccine> UpdateVaccine(int maVaccine, Vaccine request);
    }
}