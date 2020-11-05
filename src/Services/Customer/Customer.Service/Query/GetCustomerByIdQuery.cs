using System;
using MediatR;

namespace Customer.Service.Query
{
    public class GetCustomerByIdQuery : IRequest<Domain.Entities.Customer>
    {
        public Guid Id { get; set; }
    }
}
