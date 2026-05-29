using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Problemas_de_Conteo;
using Problemas_de_Conteo.Modules.GridPaths.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Servicios para la grilla
builder.Services.AddScoped<GridPathService>();
builder.Services.AddScoped<GridGeneratorService>();
builder.Services.AddScoped<GridDynamicService>();



await builder.Build().RunAsync();
