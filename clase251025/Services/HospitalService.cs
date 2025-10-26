using clase251025.Models;
using clase251025.Models.DTOs;

namespace clase251025.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IHospitalRepository _repo;
        public HospitalService(IHospitalService repo)
        {
            _repo = repo;
        }
        public Task<Hospital> CreateHospital(CreateHospitalDto dto)
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
    }
}
