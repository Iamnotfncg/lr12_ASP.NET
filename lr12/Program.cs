using lr12;
using lr12.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddDbContext<CompanyDbContext>(options =>
{
    options.UseSqlServer(ConnectionString.Value);
});
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();