using MaterialDeContrucaoAppWeb.Data;
using MaterialDeContrucaoAppWeb.Services;
using MaterialDeContrucaoAppWeb.Services.Data;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddNToastNotifyToastr(new ToastrOptions()
                                 {
                                    TimeOut = 10000,
                                    ProgressBar = false,
                                    PositionClass = ToastPositions.TopRight
                                 });

builder.Services.AddTransient<IServiceProduto, ServiceProduto>();
builder.Services.AddDbContext<MatConstDBContext>();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
