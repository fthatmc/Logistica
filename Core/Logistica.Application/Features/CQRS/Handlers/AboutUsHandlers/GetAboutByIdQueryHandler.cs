using Logistica.Application.Features.CQRS.Queries.AboutUsQueries;
using Logistica.Application.Features.CQRS.Results.AboutUsResults;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Handlers.AboutUsHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<AboutUs> _repository;
        public GetAboutByIdQueryHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutUsByIdQueryResult> Handle(GetAboutUsByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutUsByIdQueryResult
            {
                AboutUsId = values.AboutUsId,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title
            };
        }
    }
}
