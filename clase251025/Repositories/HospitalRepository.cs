using clase251025.Data;
using clase251025.Models;

namespace clase251025.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly AppDbContext _db;
        public HospitalRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task Add(Hospital hospital)
        {
            await _db.Hospitals.AddAsync(hospital);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            return await _db.Hospitals.ToListAsync();
        }

        public async Task<Hospital> GetOne(Guid id)
        {
            return await _db.Hospitals.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
