using CQRSmediatr.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddMediatR(cfg =>
    {
        cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
    })
    .AddScoped<IUserRepository, UserRepository>()
    .AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
