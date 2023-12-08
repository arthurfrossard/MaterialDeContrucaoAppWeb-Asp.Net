using MaterialDeContrucaoAppWeb.Data;
using MaterialDeContrucaoAppWeb.Services;
using MaterialDeContrucaoAppWeb.Services.Data;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options => {
                                options.Conventions.AuthorizeFolder("/Marcas");
                                options.Conventions.AuthorizeFolder("/Categorias");
                                })
                                 .AddNToastNotifyToastr(new ToastrOptions()
                                 {
                                    TimeOut = 10000,
                                    ProgressBar = false,
                                    PositionClass = ToastPositions.TopRight
                                 });

builder.Services.AddTransient<IServiceProduto, ServiceProduto>();
builder.Services.AddDbContext<MatConstDBContext>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<MatConstDBContext>();

builder.Services.Configure<IdentityOptions>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;

    // Lockout settings
    options.Lockout.MaxFailedAccessAttempts = 30;
    options.Lockout.AllowedForNewUsers = true;

    // User settings
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var context = new MatConstDBContext();
context.Database.Migrate();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseNToastNotify();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
