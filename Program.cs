var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{option?}");



app.MapControllerRoute(
    name: "listeArmes",
    pattern: "liste-armes",
    defaults: new { controller = "Arme", action = "Index" }
    );

app.MapControllerRoute(
    name: "armes",
    pattern: "{id}",
    defaults: new { controller = "Arme", action = "TrouverArme" }
    );

app.Run();
