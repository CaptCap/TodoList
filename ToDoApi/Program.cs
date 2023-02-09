using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.Extensions.DependencyInjection;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var _conString = @"Data Source=localhost;Port=1433;Initial Catalog=TestDB;Integrated Security=False;Persist Security Info=False;
User ID=sa;Password=SA_Passw0rd";
builder.Services.AddDbContext<TodoContext>(options => options.UseSqlServer(_conString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
   
   
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();