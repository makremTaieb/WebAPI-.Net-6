using Microsoft.EntityFrameworkCore;
using WebAPI.Digital.API2.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<WebAPIDbContext>(options => options.UseSqlServer(
     builder.Configuration.GetConnectionString("defaultConnection"), sqlOptions => { })
 );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler("/error-development");

}
else
{
    app.UseExceptionHandler("/error");
}


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();



app.UseAuthorization();
app.MapControllers();

app.Run();
