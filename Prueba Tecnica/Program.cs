using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using Microsoft.AspNetCore.Hosting;
using PruebaTecnica.Mapping;
using PruebaTecnica.Interfaces.Repository;
using PruebaTecnica.Repository;
using PruebaTecnica.Interfaces.Services;
using PruebaTecnica.Service;
using FluentValidation;
using FluentValidation.AspNetCore;
using PruebaTecnica.Dto.Validations;

var builder = WebApplication.CreateBuilder(args);




var dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "user";
var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "pruebatecnica"; // Default to your DB name
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "1234"; // Default to your DB password
var dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "3306"; // Cambiar a 3306

var connectionString = $"Server=db;Database={dbName};User={dbUser};Password={dbPassword};Port={dbPort};";

builder.Services.AddDbContext<ContextDb>(options =>
{
    options.UseMySql(connectionString,
        new MySqlServerVersion(new Version(8, 0, 39)),
        mysqlOptions => mysqlOptions.EnableRetryOnFailure());
});


// Inclusion de  FluentValidation
builder.Services.AddControllers()
    .AddFluentValidation(fv =>
    {
        fv.RegisterValidatorsFromAssemblyContaining<UserDbAlterDtoValidator>();
    });


// Inclusion de Repository y Service
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



//app.UseCors(options =>
//{
//    options.AllowAnyHeader();
//    options.AllowAnyMethod();
//    options.AllowAnyOrigin();
//});


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
