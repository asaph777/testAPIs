var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FamilyDB>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql"));
});
builder.Services.AddControllers();
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddCors();
var app = builder.Build();

app.MapControllers();
app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
app.Run();
