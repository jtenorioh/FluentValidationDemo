using DarthSeldon.API.FluentValidation.Demo.Business;
using DarthSeldon.API.FluentValidation.Demo.Records;
using DarthSeldon.API.FluentValidation.Demo.Validators;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add validators

builder.Services.AddScoped<IValidator<Product>, ProductValidator>();

//add business

builder.Services.AddScoped<ProductLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();