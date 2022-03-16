using IdentityServer4;
using IdentityServer4.Models;
using Notes.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureIdentityServer();

var app = builder.Build();

app.UseIdentityServer();

app.MapGet("/", () => "Hello World!");

app.Run();
