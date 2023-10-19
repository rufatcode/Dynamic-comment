using Joan_DynamicComment;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var config = builder.Configuration;
builder.Services.Registration(config);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "Areas",
    pattern:"{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"

    );
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();

