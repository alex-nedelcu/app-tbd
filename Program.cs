using AppTbd.Core.Ports;
using AppTbd.Core.Services;
using AppTbd.Core.Usecases;
using AppTbd.Outbound.Persistence.Adapters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI
builder.Services.AddScoped<IGetTodoItemsUsecase, GetTodoItemsService>();
builder.Services.AddScoped<IReadTodoItemsPort, ReadTodoItemsAdapter>();

var connString = builder.Configuration.GetConnectionString("AppTbdDb");
builder.Services.AddDbContext<AppTbdDbContext>(options => options.UseSqlServer(connString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppTbdDbContext>().Database;
    db.Migrate();
}

app.Run();