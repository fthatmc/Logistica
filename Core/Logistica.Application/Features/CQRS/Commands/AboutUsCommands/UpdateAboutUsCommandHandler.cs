using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Commands.AboutUsCommands
{
    public class UpdateAboutUsCommandHandler
    {
        private readonly IRepository<AboutUs> _repository;

        public UpdateAboutUsCommandHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutUsCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AboutUsId);
            values.Description = command.Description;
            values.Title = command.Title;
            values.ImageUrl = command.ImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
