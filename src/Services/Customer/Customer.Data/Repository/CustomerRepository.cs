using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.Database;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data.Repository
{
    public class CustomerRepository : Repository<Domain.Entities.Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext customerContext) : base(customerContext) { }

        public async Task<Domain.Entities.Customer> GetCustomerByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await CustomerContext.Customer.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
