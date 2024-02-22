using Microsoft.EntityFrameworkCore;
using SchoolDemo;
using SchoolDemo.DataBase;

var corsPolicyName = "whatever";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<LoginDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("LoginDatabase")));
builder.Services.AddScoped<IUserService, MockUserService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(option =>
{
    option.AddPolicy(corsPolicyName, builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});
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
app.UseCors(corsPolicyName);
app.MapControllers();

app.Run();
