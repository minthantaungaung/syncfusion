using Flo3BlazorDev.Components;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSyncfusionBlazor();

var app = builder.Build();
//var license = builder.Configuration["SyncFusionLicenseKey"]!;
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk4NDI1M0AzMjM0MmUzMDJlMzBjdndoU0FQeEtOb3NqbTRtMzIrZW1CWVpTbXZYRWxlUTdCSFhWcE1hK3VvPQ==\r\n");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
