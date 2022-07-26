using System.Security.AccessControl;
using System;
using System.Collections.Immutable;
using System.Net;
using vsc.Application;
using vsc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
{
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
}
