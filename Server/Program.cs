using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Server;
using Server.Data;

var seed = args.Contains("/seed");
if (seed)
{
    args = args.Except(new[] { "/seed" }).ToArray();

}



var builder = WebApplication.CreateBuilder(args);

var assembly = typeof(Program).Assembly.GetName().Name;
var defaultConnString = builder.Configuration.GetConnectionString("DefaultConnexion");
if (seed)
{
    SeedData.EnsureSeedData(defaultConnString);
}
/// <summary>
/// /IdentityUSer
/// </summary>
builder.Services.AddDbContext<AspNetIdentityDbContext>(options =>
    options.UseNpgsql(defaultConnString, opt => opt.MigrationsAssembly(assembly)));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<AspNetIdentityDbContext>();

/// <summary>
/// IdentityUser
/// </summary>

builder.Services.AddIdentityServer()
    .AddAspNetIdentity<IdentityUser>()
    .AddConfigurationStore(options =>
    {
        options.ConfigureDbContext = b =>
        b.UseNpgsql(defaultConnString, opt => opt.MigrationsAssembly(assembly));
    }).AddOperationalStore(options =>
    {
        options.ConfigureDbContext = b =>
            b.UseNpgsql(defaultConnString, opt => opt.MigrationsAssembly(assembly));
    }).AddDeveloperSigningCredential();
var app = builder.Build();

app.UseIdentityServer();
app.Run();
