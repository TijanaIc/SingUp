using Microsoft.EntityFrameworkCore;
using SchoolDemo;
using SchoolDemo.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<LoginDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("LoginDatabase")));
builder.Services.AddScoped<IUserService, UserService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
