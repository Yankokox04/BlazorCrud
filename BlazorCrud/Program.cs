using BlazorCrud;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//var hch = new HttpClientHandler();
//hch.ServerCertificateCustomValidationCallback = (message, cert, chain, erros) => true;

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton(new HttpClient() {

    BaseAddress = new Uri("https://localhost:7238")
});

await builder.Build().RunAsync();
