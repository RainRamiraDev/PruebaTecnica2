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

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ContextDb>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("ConexionDatabase"),
                     new MySqlServerVersion(new Version(8, 0, 39)));
});

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



app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
