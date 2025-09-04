using GBSPlans.Domain.Entities;

namespace GBSPlans.Application.Interface.Persistence
{
    public interface ICustomerRepository: IGenericRepository<Customer>
    {
        Task<int> CountAsync();
        Task<IEnumerable<Customer>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
    }
}
