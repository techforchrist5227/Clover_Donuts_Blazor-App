using Clover_Donuts_FE.Server.DataBase;
using Clover_Donuts_FE.Server.Repositories;
using Clover_Donuts_FE.Server.Repositories.Contracts;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication();
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder
            .WithOrigins("https://localhost:7218, http://localhost:7218") // Replace with your allowed origins
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



builder.Services.AddDbContext<CloverDonutsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CDConnectionString"));
}
);

builder.Services.AddTransient<IProductRepository,ProductRepository>();

var app = builder.Build();

app.UseCors(policy => policy.WithOrigins("https://localhost:7218", "http://localhost:7218").AllowAnyMethod().WithHeaders(HeaderNames.ContentType));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();
   
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
