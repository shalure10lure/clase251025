using clase251025.Models;

namespace clase251025.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAddress(string emailAddress);
        Task AddAsync(User user);
    }
}
