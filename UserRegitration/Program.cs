using Microsoft.EntityFrameworkCore;
using UserRegitration.Application.Interfaces;
using UserRegitration.Application.Services;
using UserRegitration.Infrastructure.Context;
using UserRegitration.Infrastructure.Interfaces;
using UserRegitration.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<UserRegistrationContext>(options =>
{
    options.UseSqlite("Data Source=D:\\Jovem Programador\\DataBase2.db");
});



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
