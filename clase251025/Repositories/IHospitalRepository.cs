using clase251025.Models;

namespace clase251025.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task Add(Hospital hospital);

        Task Update(Hospital hospital);
        Task Delete(Guid id);
        Task<IEnumerable<Hospital>> GetAllByType(int type);
    }
}
