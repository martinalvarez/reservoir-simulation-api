using Reservoir.Service;
using Reservoir.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

/*
// 1. Definir la política de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173") // La URL de tu Vite/React
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
*/

/*
// 1. Agregar el servicio de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin() // Permitir cualquier origen (para desarrollo)
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
*/

builder.Services.AddCors(options =>
{
    options.AddPolicy("ProductionPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:5174") // Solo tu app de React
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});


builder.Services.AddScoped<IReservoirService, ReservoirService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*
// 2. Habilitar CORS (DEBE ir antes de UseAuthorization)
app.UseCors("AllowReactApp");
*/
/*
// 2. Habilitar el middleware de CORS (IMPORTANTE: Debe ir antes de MapControllers)
app.UseCors("AllowAll");
*/
// ...
app.UseCors("ProductionPolicy");


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();