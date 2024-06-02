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
    public class CreateAboutUsCommandHandler
    {
        public readonly IRepository<AboutUs> _repository;

        public CreateAboutUsCommandHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutUsCommand command)
        {
            await _repository.CreateAsync(new AboutUs
            {
                Title = command.Title,
                Description = command.Description,
                ImageUrl = command.ImageUrl
            });
        }
    }
}
