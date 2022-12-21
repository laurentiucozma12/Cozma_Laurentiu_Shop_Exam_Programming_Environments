using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlanteeaShop.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PlanteeaShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PlanteeaShopContext") ?? throw new InvalidOperationException("Connection string 'PlanteeaShopContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
