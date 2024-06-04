using Logistica.Application.Features.CQRS.Commands.AboutUsCommands;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Handlers.AboutUsHandlers
{
    public class RemoveAboutUsCommandHandler
    {
        public readonly IRepository<AboutUs> _repository;

        public RemoveAboutUsCommandHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutUsCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
