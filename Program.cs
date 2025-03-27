using BlazorCrud.Components;
using BlazorCrud.Data;
using BlazorCrud.Models;
using BlazorCrud.Services;
using Humanizer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region DI
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services
    .AddDbContextFactory<AppDbContext>(x => x.UseInMemoryDatabase("usersCrud"));
builder.Services
    .AddQuickGridEntityFrameworkAdapter();
builder.Services.AddSingleton<AuthService>(auth =>
{
    var _auth = new AuthService();
    _auth.Authentication = new Users()
    {
        IsAuthenticated = false
    };
    return _auth;
});
builder.Services.AddScoped<HttpClientRequest>();
#endregion

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
var db = app.Services.GetRequiredService<IDbContextFactory<AppDbContext>>();
using var context = db.CreateDbContext();
context.Users.Add(new Users
{
    Id = 1,
    Name = "Lucas Mathews",
    SirName = "Farias Marreiros",
    Email = "lucas@mecontratapf.com",
    Password = "123",
});
await context.SaveChangesAsync();
await app.RunAsync();
