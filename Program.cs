using Microsoft.FeatureManagement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
builder.Configuration.AddEnvironmentVariables();

builder.Configuration.AddAzureAppConfiguration(
    options =>
    {
        options.Connect("Endpoint=https://lean-prog-confugurations.azconfig.io;Id=3ICN;Secret=C6Y6IoizDvo4CSP7hudPS5CbCGueUcUwGP5o4AqfUQOVTwErcaniJQQJ99BDAC1i4TkroYhFAAABAZAC4aOX");
        options.UseFeatureFlags();
    });

builder.Services.AddFeatureManagement();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
