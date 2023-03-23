using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MV.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddIdentityConfiguration();
builder.Services.AddMvcConfiguration(builder.Configuration);
builder.Services.RegisterServices();

 
var app = builder.Build();

app.UseMvcConfiguration();
app.Run();