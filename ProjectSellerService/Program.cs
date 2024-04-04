using Microsoft.EntityFrameworkCore;
using ProjectSellerService.Data;
using ProjectSellerService.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<ProjectSellerServiceContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("ProjectSellerServiceContext"),
            ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ProjectSellerServiceContext")),
            builder => builder.MigrationsAssembly("ProjectSellerService")));


        builder.Services.AddScoped<SeedingService>();

        builder.Services.AddScoped<SellerService>();
        // Add services to the container.
        builder.Services.AddControllersWithViews();



        var app = builder.Build();

        //app.Services.GetRequiredService<SeedingService>().Seed();
        //app.Services.CreateScope().ServiceProvider.GetService<SeedingService>().Seed();
        //populando o db
        app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();
        app.Services.CreateScope().ServiceProvider.GetRequiredService<SellerService>();



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
    }
}