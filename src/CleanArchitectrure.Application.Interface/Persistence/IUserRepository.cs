using GBSPlans.Domain.Entities;

namespace GBSPlans.Application.Interface.Persistence
{
    public interface IUserRepository
    {
        Task<User> GetAync(string client);
        Task<bool> InsertAync(User user);
    }
}
