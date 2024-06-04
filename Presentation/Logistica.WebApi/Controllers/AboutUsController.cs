using Logistica.Application.Features.CQRS.Commands.AboutUsCommands;
using Logistica.Application.Features.CQRS.Handlers.AboutUsHandlers;
using Logistica.Application.Features.CQRS.Queries.AboutUsQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetAboutUsQueryHandler _getAboutUsQueryHandler;
        private readonly CreateAboutUsCommandHandler _createAboutUsCommandHandler;
        private readonly RemoveAboutUsCommandHandler _removeAboutUsCommandHandler;
        private readonly UpdateAboutUsCommandHandler _updateAboutUsCommandHandler;

        public AboutUsController(GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutUsQueryHandler getAboutUsQueryHandler, CreateAboutUsCommandHandler createAboutUsCommandHandler, RemoveAboutUsCommandHandler removeAboutUsCommandHandler, UpdateAboutUsCommandHandler updateAboutUsCommandHandler)
        {
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutUsQueryHandler = getAboutUsQueryHandler;
            _createAboutUsCommandHandler = createAboutUsCommandHandler;
            _removeAboutUsCommandHandler = removeAboutUsCommandHandler;
            _updateAboutUsCommandHandler = updateAboutUsCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutUsList()
        {
            var values = await _getAboutUsQueryHandler.Handle();
            return Ok(values);  
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutUs(int id)
        {
            var values = await _getAboutByIdQueryHandler.Handle(new GetAboutUsByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutUs(CreateAboutUsCommand command)
        {
            await _createAboutUsCommandHandler.Handle(command);
            return Ok("Hakkımızda Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAboutUs(int id)
        {
            await _removeAboutUsCommandHandler.Handle(new RemoveAboutUsCommand(id));
            return Ok("Hakkımızda Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutUsCommand command)
        {
            await _updateAboutUsCommandHandler.Handle(command);
            return Ok("Hakkımızda Bilgisi Güncellendi");
        }
    }
}
