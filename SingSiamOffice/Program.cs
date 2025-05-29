using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Diagnostics;
using MudBlazor.Services;
using SingSiamOffice.Authentication;
using SingSiamOffice.Data;
using SingSiamOffice.Manage;
using SingSiamOffice.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();//add
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<UserAccountService>();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<SingSiamOffice.Services.ReadNatID_Service>();
builder.Services.AddScoped<SingSiamOffice.Manage.EventLog>();
builder.Services.AddScoped<SingSiamOffice.Manage.UserManagement>();
builder.Services.AddScoped<SingSiamOffice.Manage.Managements>();
builder.Services.AddScoped<SingSiamOffice.Manage.PromiseManagement>();
builder.Services.AddScoped<SingSiamOffice.Manage.GlobalData>();
builder.Services.AddScoped<SingSiamOffice.Manage.CalculatePaymentPeriod>();
builder.Services.AddScoped<SingSiamOffice.Manage.Collateral1>();
builder.Services.AddScoped<SingSiamOffice.Manage.Collateral2>();
builder.Services.AddScoped<SingSiamOffice.Manage.Collateral3>();
builder.Services.AddScoped<SingSiamOffice.Helpers.NumberToText>();
builder.Services.AddScoped<SingSiamOffice.Helpers.calamount>();

builder.Services.AddDbContext<SingSiamOffice.Models.SingsiamdbContext>();
builder.Services.AddDbContext<SingSiamOffice.Models.SingSiamOld._01singsiamContext>();
builder.Services.AddDbContext<SingSiamOffice.Models.SingSiamOld2._02singsiamContext>();
builder.Services.AddScoped<UserLoginService>();
builder.Services.AddScoped<SingSiamOffice.Manage.BranchService>();
builder.Services.AddHttpClient();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7157") });

}
else
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://141.11.33.219:8000/") });
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "text/plain";

            var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
            var exception = exceptionHandlerPathFeature?.Error;

            // Log error ?????? ?????????????, ?????????????????, ?????????????? service
            Console.Error.WriteLine($"Unhandled exception: {exception?.Message}");

            await context.Response.WriteAsync("An unexpected server error occurred.");
        });
    });

    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//app.UseCookiePolicy();
//app.UseAuthentication();
//app.MapControllers();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapBlazorHub();
    endpoints.MapDefaultControllerRoute();//add
    endpoints.MapFallbackToPage("/_Host");
});

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

app.Run();


