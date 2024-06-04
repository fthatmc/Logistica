using Logistica.Application.Features.CQRS.Handlers.AboutUs2Handlers;
using Logistica.Application.Features.CQRS.Handlers.AboutUsHandlers;
using Logistica.Application.Interfaces;
using Logistica.Persistence.Context;
using Logistica.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<LogisticaContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


builder.Services.AddScoped<GetAboutUsQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutUsCommandHandler>();
builder.Services.AddScoped<UpdateAboutUsCommandHandler>();
builder.Services.AddScoped<RemoveAboutUsCommandHandler>();

builder.Services.AddScoped<GetAboutUs2QueryHandler>();
builder.Services.AddScoped<GetAboutUs2ByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutUs2CommandHandler>();
builder.Services.AddScoped<UpdateAboutUs2CommandHandler>();
builder.Services.AddScoped<RemoveAboutUs2CommandHandler>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
