using etickets.Data;
using Microsoft.EntityFrameworkCore;
using etickets.Data.Services;
using etickets.Models;

var builder = WebApplication.CreateBuilder(args);

//Service configuration
builder.Services.AddMemoryCache();
builder.Services.AddSession();

// Add services to the container

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IActorsService, ActorsService>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShoppingCart.GetCart(sp));
/*builder.Services.AddScoped<IShoppingCart, ShoppingCart>();*/
    


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
    
});


var app = builder.Build();
//IActorsService service = app.Services.GetRequiredService<IActorsService>();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Seed Database
AppDbInitializer.Seed(app);

app.Run();


