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
app.Run();