using Microsoft.AspNetCore.ResponseCompression;
using Winter_2023_CMP_1005_Blazor_RTC.Server.Hubs;
using Winter_2023_CMP_1005_Blazor_RTC.Server.Services.CounterService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSignalR();

builder.Services.AddSingleton<ICounterService, CounterService>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapHub<CounterHub>("/hubs/counter");

app.MapFallbackToFile("index.html");

app.Run();
