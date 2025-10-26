using clase251025.Models;

namespace clase251025.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task Add(Hospital hospital);
    }
}
