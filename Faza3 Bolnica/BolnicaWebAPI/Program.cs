using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors(policy =>
{
    policy.AddPolicy("CORS", options =>
    {
        options.AllowAnyHeader()
               .AllowAnyMethod()
               .WithOrigins("http://127.0.0.1:7055",
                            "https://127.0.0.1:7055",
                            "http://localhost:7055",
                            "https://localhost:7055",
                            "http://127.0.0.1:5268",
                            "https://127.0.0.1:5268",
                            "http://localhost:5268",
                            "https://localhost:5268",
                            "http://127.0.0.1:1458",
                            "https://127.0.0.1:1458",
                            "http://localhost:1458",
                            "https://localhost:1458");
    });
});

//ovo sam dodala
builder.Services.AddMvc().AddJsonOptions(p =>
{
    p.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddControllers();
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

app.UseCors("CORS");

app.UseAuthorization();

app.MapControllers();

app.Run();