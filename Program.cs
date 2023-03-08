using Microsoft.EntityFrameworkCore;
using Registrar.Models;

var builder = WebApplication.CreateBuilder(args);

/*builder.Services.AddDbContext<RegistrarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RegistrarContext") ?? throw new InvalidOperationException("Connection string 'RegistrarContext' not found.")));*/

builder.Services.AddDbContext<RegistrarContext>(options =>
    options.UseSqlite("Data Source=Registrar.db"));

// Add services to the container.

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
