using Logistica.Application.Features.Mediator.Queries.BannerQueries;
using Logistica.Application.Features.Mediator.Results.BannerResults;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.Mediator.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler : IRequestHandler<GetBannerQuery, List<GetBannerQueryResult>>
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResult>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x=> new GetBannerQueryResult
            {
                BannerId = x.BannerId,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Title = x.Title

            }).ToList();
        }
    }
}
