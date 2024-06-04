using Logistica.Application.Features.Mediator.Queries.AddressQueries;
using Logistica.Application.Features.Mediator.Results.AddressResults;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.Mediator.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery, GetAddressByIdQueryResult>
    {
        private readonly IRepository<Address> _Repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _Repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _Repository.GetByIdAsync(request.Id);
            return new GetAddressByIdQueryResult
            {
                AddressId = values.AddressId,
                Location = values.Location,
                Call = values.Call,
                Email = values.Email
            };
        }
    }
}
