using Microsoft.EntityFrameworkCore;
using PruebaTecnica;

var builder = WebApplication.CreateBuilder(args);

// Definir la política de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("UsuarioOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Permitir solicitudes desde Angular
              .AllowAnyMethod()  // Permitir cualquier método (GET, POST, PUT, DELETE, etc.)
              .AllowAnyHeader(); // Permitir cualquier encabezado
    });
});

// Configurar la base de datos
builder.Services.AddDbContext<ApplicationDBContext>(opciones =>
    opciones.UseSqlServer("name=DefoultConexion"));

// Agregar controladores y Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilitar Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Habilitar CORS antes de la autorización
app.UseCors("UsuarioOrigins");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
