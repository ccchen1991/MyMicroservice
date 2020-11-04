using System;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Data.Repository
{
    public interface ICustomerRepository : IRepository<Domain.Entities.Customer>
    {
        Task<Domain.Entities.Customer> GetCustomerByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
