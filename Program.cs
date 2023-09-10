using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bsnsNiche.Data;
using bsnsNiche.Models;

var builder = WebApplication.CreateBuilder(args);
//Scaffolding generated the following code in Program.cs:
builder.Services.AddDbContext<bsnsNicheContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("bsnsNicheContext") ?? throw new InvalidOperationException("Connection string 'bsnsNicheContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();



//Replace the contents of Program.cs with the following code (after seeding)
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
