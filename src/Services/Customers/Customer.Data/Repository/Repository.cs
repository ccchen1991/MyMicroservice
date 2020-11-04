using Customer.Data.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly CustomerContext CustomerContext;

        public Repository(CustomerContext customerContext)
        {
            CustomerContext = customerContext;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
