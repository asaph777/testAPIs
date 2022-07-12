<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FamilyDb>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql"));
});
builder.Services.AddControllers();
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options=>options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddCors();
var app = builder.Build();

app.MapControllers();
app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
app.Run();
=======
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FamilyDb>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql"));
});
builder.Services.AddControllers();
builder.Services.AddCors();
var app = builder.Build();

app.MapControllers();
app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
app.Run();
>>>>>>> 2913a87e4978204e8b72e499b616b9331073ee7b
