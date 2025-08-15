using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Registrar servicios
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(); // Swagger

var app = builder.Build();

// 2️⃣ Configurar middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers(); // Mapear controladores

app.Run();

