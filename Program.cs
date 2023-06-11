using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PermitToWorkSystem.Data;
using PermitToWorkSystem.Data.IServices;
using PermitToWorkSystem.Data.Service;
using PermitToWorkSystem.Utility;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
});
//builder.Services.AddScoped<IPermitToWorkService, PermitToWorkService>();
//builder.Services.AddScoped<IEmailService, EmailService>();
//builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
//builder.Services.Configure<EmailConfiguration>(builder.Configuration.GetSection("EmailConfiguration")); // Register EmailConfiguration
//builder.Services.AddScoped<IPermitToWorkService, PermitToWorkService>();
//builder.Services.AddScoped<IEmailService, EmailService>();
//builder.Services.Configure<EmailConfiguration>(builder.Configuration.GetSection("EmailConfiguration"));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
});
builder.Services.AddScoped<IPermitToWorkService, PermitToWorkService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ISiteCheckerService, SiteCheckerService>();
builder.Services.Configure<EmailConfiguration>(builder.Configuration.GetSection("EmailConfiguration"));
// Add the following line to resolve the EmailConfiguration dependency for EmailService
builder.Services.AddScoped(provider =>
    provider.GetRequiredService<IOptions<EmailConfiguration>>().Value);

var app = builder.Build();
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
