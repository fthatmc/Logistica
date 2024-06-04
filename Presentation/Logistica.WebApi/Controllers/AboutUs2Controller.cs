using Logistica.Application.Features.CQRS.Commands.AboutUs2Commands;
using Logistica.Application.Features.CQRS.Handlers.AboutUs2Handlers;
using Logistica.Application.Features.CQRS.Queries.AboutUs2Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUs2Controller : ControllerBase
    {
        private readonly GetAboutUs2ByIdQueryHandler _getAboutUs2ByIdQueryHandler;
        private readonly GetAboutUs2QueryHandler _getAboutUs2QueryHandler;
        private readonly CreateAboutUs2CommandHandler _createAboutUs2CommandHandler;
        private readonly RemoveAboutUs2CommandHandler _removeAboutUs2CommandHandler;
        private readonly UpdateAboutUs2CommandHandler _updateAboutUs2CommandHandler;

        public AboutUs2Controller(GetAboutUs2ByIdQueryHandler getAboutUs2ByIdQueryHandler, GetAboutUs2QueryHandler getAboutUs2QueryHandler, CreateAboutUs2CommandHandler createAboutUs2CommandHandler, RemoveAboutUs2CommandHandler removeAboutUs2CommandHandler, UpdateAboutUs2CommandHandler updateAboutUs2CommandHandler)
        {
            _getAboutUs2ByIdQueryHandler = getAboutUs2ByIdQueryHandler;
            _getAboutUs2QueryHandler = getAboutUs2QueryHandler;
            _createAboutUs2CommandHandler = createAboutUs2CommandHandler;
            _removeAboutUs2CommandHandler = removeAboutUs2CommandHandler;
            _updateAboutUs2CommandHandler = updateAboutUs2CommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutUs2List()
        {
            var values = await _getAboutUs2QueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutUs2(int id)
        {
            var values = await _getAboutUs2ByIdQueryHandler.Handle(new GetAboutUs2ByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutUs2(CreateAboutUs2Command command)
        {
            await _createAboutUs2CommandHandler.Handle(command);
            return Ok("Hakkımızda Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAboutUs2(int id)
        {
            await _removeAboutUs2CommandHandler.Handle(new RemoveAboutUs2Command(id));
            return Ok("Hakkımızda Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout2(UpdateAboutUs2Command command)
        {
            await _updateAboutUs2CommandHandler.Handle(command);
            return Ok("Hakkımızda Bilgisi Güncellendi");
        }
    }
}
