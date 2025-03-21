using Microsoft.EntityFrameworkCore;
using ref_app_backend.Data;
using ref_app_backend.Models;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();
string connection = Environment.GetEnvironmentVariable("SQLite_SRC");
builder.Services.AddDbContext<RefDbContext>(options =>
    options.UseSqlite(connection));

builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var serviceScope = app.Services.CreateScope())
{
    var _context = serviceScope.ServiceProvider.GetRequiredService<RefDbContext>();
}

app.MapPost("add-ref", (ReferenceDTO dto, RefDbContext _context) =>
{
    _context.References.Add(new Reference(dto));
    _context.SaveChanges();
});

app.MapGet("all-ref", (RefDbContext _context) =>
{
    return _context.References.ToList();
});

app.UseHttpsRedirection();

app.Run();