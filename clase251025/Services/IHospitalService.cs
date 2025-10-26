using clase251025.Models;
using clase251025.Models.DTOs;

namespace clase251025.Services
{
    public interface IHospitalService
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task<Hospital> CreateHospital(CreateHospitalDto dto);

       // Task UpdateHospital(Hospital hospital);
        Task DeleteHospital(Guid id);
        Task<IEnumerable<Hospital>> GetAllType1And3();

    }
}
