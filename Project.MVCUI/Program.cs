using Project.BLL.Service_Injections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentityServices();
builder.Services.AddDbContextService();
builder.Services.AddRepManServices();

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

// Area Route

app.MapAreaControllerRoute(
    name: "MyAreaSuperAdmin",
    areaName: "SuperAdmin",
    pattern: "SuperAdmin/{controller=Admin}/{action=Index}/{id?}");

// Default Route

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Reset Password Route

app.MapControllerRoute(
    name: "",
    pattern: "{controller=Home}/{action=ResetPassword}/{id?}/{token?}");

app.Run();
