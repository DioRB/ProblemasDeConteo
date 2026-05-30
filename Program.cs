using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Problemas_de_Conteo;
using Problemas_de_Conteo.Modules.GridPaths.Services;
using Problemas_de_Conteo.Modules.PasswordCounter.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Servicios para la grilla
builder.Services.AddScoped<GridPathService>();
builder.Services.AddScoped<GridGeneratorService>();
builder.Services.AddScoped<GridDynamicService>();

//Servicios para las contraseñas
builder.Services.AddScoped<PasswordCountService>();
builder.Services.AddScoped<PasswordValidatorService>();

await builder.Build().RunAsync();
