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
    public class GetAboutUsQueryHandler
    {
        private readonly IRepository<AboutUs> _repository;

        public GetAboutUsQueryHandler(IRepository<AboutUs> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAboutUsQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutUsQueryResult
            {
                AboutUsId = x.AboutUsId,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
