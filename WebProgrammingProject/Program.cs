using Microsoft.EntityFrameworkCore;
using WebProgrammingProject.Data; // Uygun namespace'i ekledi�inizden emin olun

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL ba�lant�s�n� DbContext'e ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Uygulama yap�land�rmas�n� buraya ekleyin

app.Run();
