using Microsoft.EntityFrameworkCore;
using WebProgrammingProject.Data; // Uygun namespace'i eklediðinizden emin olun

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL baðlantýsýný DbContext'e ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Uygulama yapýlandýrmasýný buraya ekleyin

app.Run();
