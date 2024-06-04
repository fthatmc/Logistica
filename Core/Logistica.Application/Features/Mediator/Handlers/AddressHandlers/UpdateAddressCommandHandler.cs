using Logistica.Application.Features.Mediator.Commands.AddressCommands;
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
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
           var values = await _repository.GetByIdAsync(request.AddressId);
            values.Location=request.Location;
            values.Call = request.Call;
            values.Email = request.Email;
            await _repository.UpdateAsync(values);
        }
    }
}
