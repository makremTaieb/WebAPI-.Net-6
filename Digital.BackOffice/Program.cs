using Digital.BackOffice.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DigitalDbContext>(option => option.UseOracle(
    builder.Configuration.GetConnectionString("defaultConnection")
    ));
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
