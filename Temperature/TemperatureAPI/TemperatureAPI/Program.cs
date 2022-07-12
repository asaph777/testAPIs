<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CityDb>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql"));
});
builder.Services.AddCors();
var app = builder.Build();

app.MapGet("/temp/{name}", async (string name, CityDb db) =>
     await db.City.Where(c => c.Name == name).ToListAsync());

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
=======
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CityDb>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql"));
});
builder.Services.AddCors();
var app = builder.Build();

app.MapGet("/temp/{name}", async (string name, CityDb db) =>
     await db.City.Where(c => c.Name == name).ToListAsync());

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
>>>>>>> 2913a87e4978204e8b72e499b616b9331073ee7b
app.Run();