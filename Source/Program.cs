using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing.Constraints;
using Source.ExtendMethods;
using Source.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<RazorViewEngineOptions>(options => {
    /*
     * Add view path
     * 
     * Example:
     * /Views/<Controller>/<Action>.cshtml
     * /MyViews/<Controller>/<Action>.cshtml
     * 
     * {0} -> action name
     * {1} -> controller name
     * {2} -> area name
     */
    options.ViewLocationFormats.Add("/MyViews/{1}/{0}" + RazorViewEngine.ViewExtension);
});
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<PlanetService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Custom response from 400 to 599
app.AddStatusCodePages();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "product",
    pattern: "{url}/{id?}",
    defaults: new {
        controller = "SubHome",
        action = "Product",
    },
    constraints: new {
        url = "product-detail",
        id = new RangeRouteConstraint(1, 4)
    });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
