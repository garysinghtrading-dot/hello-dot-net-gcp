
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/hello", () => "<title>Hello World </title> <h1>Hello World from Azure!</h1>");

app.MapRazorPages();

app.Run();
