using EletroMultiAPI.Data;
using EletroMultiAPI.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var myAllowSpecificOrigins = "_var myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
var connectionString = (builder.Configuration.GetConnectionString("EletromultiConnection"));
builder.Services.AddDbContext<EletroMultiContext>(opts => opts.UseMySql
(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddCors(opts =>
{
    opts.AddPolicy(name: myAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyOrigin()
        .AllowAnyHeader();
    });
});

builder.Services.
    AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson
    (opts=>opts.SerializerSettings.ReferenceLoopHandling=ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
