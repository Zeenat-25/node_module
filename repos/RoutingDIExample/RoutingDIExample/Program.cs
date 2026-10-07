using RoutingDIExample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<StudentService>();

var app = builder.Build();

app.MapControllers();

app.Run();