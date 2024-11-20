using Microsoft.EntityFrameworkCore;
using WebApiCalculadora.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar el contexto al contenedor de servicios
builder.Services.AddDbContext<C�lculosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CalculadoraDB")));

// Agregar los controladores al contenedor de servicios
builder.Services.AddControllers();

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilitar Swagger y el endpoint de Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseStaticFiles(); //archivos est�ticos
app.UseAuthorization();
app.MapControllers(); // Habilitar los controladores
app.Run();


