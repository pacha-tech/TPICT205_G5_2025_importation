using correction_205.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using correction_205.Models;
using correction_205.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(10, 4, 32)))); // Remplacez par votre version




// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<EtudiantService>(); // Votre service pour les produits
builder.Services.AddScoped<EnseignantService>();
builder.Services.AddScoped<Auth_etudiant_Service>();
builder.Services.AddScoped<Auth_enseignant_Service>();
builder.Services.AddScoped<Creation_PVService>();
builder.Services.AddScoped<Modifier_PVService>();
builder.Services.AddScoped<Supprimer_PVService>();
builder.Services.AddScoped<Consulter_PVService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
