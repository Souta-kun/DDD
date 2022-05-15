using Panaderia.ApplicationCore.Interfaces;
using Panaderia.ApplicationCore.Services;
using Panaderia.Infrastructure.Database;
using Panaderia.Infrastructure.Repository;
using Panaderia.WebApi.Filters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PanaderiaDb");

// Add services to the container.
// Exceptions
builder.Services.AddControllers(
    options => options.Filters.Add(new CustomFilterException())
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database Context
builder.Services.AddDbContext<PanaderiaContext>(
    opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Dependency Injection
builder.Services.AddScoped<PanaderiaContext>();
builder.Services.AddScoped<IPanService, PanService>();
builder.Services.AddScoped<IPanRepository, PanRepository>();

// CORS
builder.Services.AddCors(p => p.AddPolicy("CorsApp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Registering AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// CORS
app.UseCors("CorsApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
