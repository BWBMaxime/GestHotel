using GestHotel.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuration de la connexion à la base de données SQL Server
var connectionString = "DefaultConnection"; // Remplacez par votre chaîne de connexion
builder.Services.AddDbContext<HotelDbContext>(options =>
    options.UseSqlServer(connectionString));

// Ajout des services MVC
builder.Services.AddControllers();

// Configuration de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
