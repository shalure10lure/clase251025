using clase251025.Models;
using clase251025.Models.DTOs;
using clase251025.Repositories;

namespace clase251025.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IHospitalRepository _repo;
        public HospitalService(IHospitalRepository repo)
        {
            _repo = repo;
        }
        public async Task<Hospital> CreateHospital(CreateHospitalDto dto)
        {
            var hospital = new Hospital
            {
                Id = dto.Id,
                Name = dto.Name,
                Address = dto.Address,
                Type = dto.Type
            };
            await _repo.Add(hospital);
            return hospital;
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            return await _repo.GetAll();
        }

        public Task<Hospital> GetOne(Guid id)
        {
            return _repo.GetOne(id);
        }

        public async Task DeleteHospital(Guid id)
        {
            await _repo.Delete(id);
        }

        public async Task<IEnumerable<Hospital>> GetAllType1And3()
        {
            var type1 = await _repo.GetAllByType(1);
            var type3 = await _repo.GetAllByType(3);

            return type1.Concat(type3);
        }
    }
}
