using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using TesteGestranApi.ContextEntity;
using TesteGestranApi.Interfaces.Repositories;
using TesteGestranApi.Interfaces.Service;
using TesteGestranApi.Repositories;
using TesteGestranApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(j => j.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
builder.Services.AddScoped<IRepositoryApiProvider, RepositoryApiProvider>();
builder.Services.AddScoped<IRepositoryApiAdress, RepositoryApiAdress>();
builder.Services.AddScoped<IServiceApiAdress, ServiceApiAdress>();
builder.Services.AddScoped<IServiceApiProvider,ServiceApiProvider>();
builder.Services.AddDbContext<ContextEntityFrame>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddScoped<ContextEntityFrame>();


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
